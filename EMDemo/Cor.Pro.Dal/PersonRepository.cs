using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cor.Pro.Model;
using Cor.Pro.IDal;

namespace Cor.Pro.Dal
{
    //Person类数据访问层操作
    public partial class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        //在IDal中IPersonRepository 继承自 IBaseRepository<Person>
        //IBaseRepository<Person>规定了 基仓储操作
        //PersonRepository实现IPersonRepository的部分 都在 BaseRepository<Person> 中
        //可以理解成：BaseRepository<Person>实现了IPersonRepository所有约束
        //PersonRepository起到中间桥梁作用
    }
}
