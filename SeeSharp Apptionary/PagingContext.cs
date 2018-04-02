using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SeeSharp_Apptionary
{
    public class PagingContext: DbContext
    {
        public PagingContext(): base()
        {

        }
        public DbSet <Page> Pages { get; set; }

    }
}
