
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EastCarmen.Entity;
using EastCarmen.IDao;


namespace EastCarmen.Dao
{
	 public partial class DBSession:IDBSession
	{

		
	  public IPersonRepository PersonRepository{get { return new PersonRepository();}}
		
	  public IStudentRepository StudentRepository{get { return new StudentRepository();}}
	
	}
	
}