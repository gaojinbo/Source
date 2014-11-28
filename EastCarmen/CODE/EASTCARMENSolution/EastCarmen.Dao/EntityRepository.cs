using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EastCarmen.Entity;
using EastCarmen.IDao;
using EastCarmen.Dao;


namespace EastCarmen.Dao
{
	
	public partial class PersonRepository :BaseRepository<Person>,IPersonRepository
	{         
		
	}
		
	public partial class StudentRepository :BaseRepository<Student>,IStudentRepository
	{         
		
	}
	}