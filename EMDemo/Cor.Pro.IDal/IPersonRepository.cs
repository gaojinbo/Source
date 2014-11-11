using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.Model;

namespace Cor.Pro.IDal
{
    //Person类数据访问层几口
    //此处可用T4生成
    //继承IBaseRepository基仓储接口 
    public partial interface IPersonRepository : IBaseRepository<Person>
    {
    }
}
