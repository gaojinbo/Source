using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EastCarmen.Entity;


namespace EastCarmen.IDao
{
	
	public partial interface IPersonRepository :IBaseRepository<Person>
	{         
		
	}
		
	public partial interface IStudentRepository :IBaseRepository<Student>
	{         
		
	}
	}