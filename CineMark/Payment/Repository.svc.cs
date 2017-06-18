using CineMark.Response;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using model = CineMark.models;
namespace CineMark.Payment
{
    public class Repository : Contract
    {

        protected readonly Entities Context;

        public Repository(Entities Context)
        {
            this.Context = Context;
        }


        public Json store(string programming_id, string client, string quantity)
        {
            int id = int.Parse(programming_id);

            programming programming = this.Context.programming.First(x => x.id == id);
            int q = int.Parse(quantity);

            // Todo: Validate quotas

            using (var transaction = Context.Database.BeginTransaction())
            {

                this.Context.payments.Add(new payments() {
                    programming_id = programming.id,
                    client = client,
                    headquarter_id = 1,
                    quantity = q,
                    creator_by = 1
                });

                Boolean isSuccess = this.Context.SaveChanges() > 0;
                

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



        protected Boolean updateOccupiedProperty(programming programming, int quantity)
        {
            int occupied = int.Parse(programming.occupied.ToString());

            programming.occupied = (short)(occupied + quantity);

            this.Context.Entry(programming).State = EntityState.Modified;

            return this.Context.SaveChanges() > 0;
        }

    
    }
}
