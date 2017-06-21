using AutoMapper;
using CineMark.Response;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using model = CineMark.models;
namespace CineMark.Payment
{

    [AutomapServiceBehavior]
    public class Repository : Contract
    {

        protected readonly Entities Context;
        protected const int quantity = 1; 

        public Repository(Entities Context)
        {
            this.Context = Context;
        }


        public Json store(string programming_id, string client, string quantity, String element)
        {
            int id = int.Parse(programming_id);

            String[]elements = element.Split('-'); ;
            
            programming programming = this.Context.programming.First(x => x.id == id);
            int q = int.Parse(quantity);

            // Todo: Validate quotas

            using (var transaction = Context.Database.BeginTransaction())
            {

                payments pay = this.Context.payments.Add(new payments() {
                    programming_id = programming.id,
                    price = programming.movies.price,
                    client = client,
                    headquarter_id = 1,
                    quantity = q,
                    creator_by = 1
                });

                Boolean isSuccess = this.Context.SaveChanges() > 0;
                
                if (isSuccess)
                {
                    List<products> products = this.Context.products.Where(x => elements.Contains(x.id.ToString())).ToList();
                    
                    products.ForEach(x =>
                    {
                        pay.payment_detail.Add(new payment_detail()
                        {
                            price = x.price,
                            product_id = x.id,
                            quantity = Repository.quantity
                        });
                    });

                    isSuccess = this.Context.SaveChanges() > 0;
                }
                

                if (! isSuccess || ! this.updateOccupiedProperty(programming, q))
                {
                    transaction.Rollback();
                    return new Json() {
                        success = false,
                        message = "Error registering"
                    };
                }


                transaction.Commit();

                return new Json()
                {
                    success = true,
                    message = String.Format("was registered for {0}", client)
                };

            }

        }



        public List<model.Payment> all()
        {
            List<payments> payments = this.Context.payments.ToList();
            return Mapper.Map<List<payments>, List<model.Payment>>(payments);
        }


        public model.Payment find(String id)
        {
            int key = int.Parse(id);
            return Mapper.Map<payments, model.Payment>(this.Context.payments.First(x => x.id == key));
        }



        protected Boolean updateOccupiedProperty(programming programming, int quantity)
        {
            int occupied = int.Parse(programming.occupied.ToString());

            programming.occupied = (short)(occupied + quantity);

            this.Context.Entry(programming).State = EntityState.Modified;

            return this.Context.SaveChanges() > 0;
        }

    }
}
