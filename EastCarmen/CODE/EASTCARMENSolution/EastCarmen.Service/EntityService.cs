
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EastCarmen.Entity;
using EastCarmen.IService;


namespace EastCarmen.Service
{
		
		public partial class PersonService :BaseService<Person>,IPersonService
		{         
			public override void SetCurrentRepository()
			{
				CurrentRepository = _dbSession.PersonRepository;
			} 
		}
		
		public partial class StudentService :BaseService<Student>,IStudentService
		{         
			public override void SetCurrentRepository()
			{
				CurrentRepository = _dbSession.StudentRepository;
			} 
		}
	}