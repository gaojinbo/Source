using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.Model;

namespace Cor.Pro.IBll
{
    //Person类对应业务逻辑层约束
    //基本约束都在IBaseService基仓储约束中
    //此处也可采用T4方式实现
    public partial interface IPersonService : IBaseService<Person>
    {

    }
}
