using EastCarmen.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EastCarmen.Dao
{
    public partial class EFContextFactory
    {
        public static DbContext GetCurrentContext()
        {
            DbContext dbcontext = CallContext.GetData("DbContext") as DbContext;
            if (dbcontext == null)
            {
                dbcontext = new EastCarmenDBEntities();
                CallContext.SetData("DbContext", dbcontext);
            }

            return dbcontext;
        }
    }
}
