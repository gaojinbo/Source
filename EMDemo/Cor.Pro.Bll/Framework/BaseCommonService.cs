using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.IDal;
using Cor.Pro.Dal;

namespace Cor.Pro.Bll.Framework
{
    public abstract class BaseCommonService
    {
        public IDbSession _dbSession = DbSessionFactory.GetCurrentDbSession();
    }
}
