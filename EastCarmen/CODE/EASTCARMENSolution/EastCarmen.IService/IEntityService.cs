
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EastCarmen.Entity;


namespace EastCarmen.IService
{
		
		public partial interface IPersonService :IBaseService<Person>
		{         
		
		}
		
		public partial interface IStudentService :IBaseService<Student>
		{         
		
		}
	}