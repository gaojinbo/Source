using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.IDal;
using Cor.Pro.Dal;
using Cor.Pro.Model;
using Cor.Pro.IBll;

namespace Cor.Pro.Bll
{
    public partial class PersonService : BaseService<Person>, IPersonService
    {
        public override void SetCurrentRepository()
        {
            //_dbSession在BaseService中定义
            //_dbSession为IDbSession类型
            //IDbSession定义为Partial  内部定义了各数据仓储实现属性的约束
            CurrentRepository = _dbSession.PersonRepository;
        }
    }
}
