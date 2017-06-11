using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CineMark
{
    public abstract class BaseRepository
    {
        protected readonly Entities Context;

        public BaseRepository(Entities Context)
        {
            this.Context = Context;
        }
        public BaseRepository()
        {
        }

    }
}