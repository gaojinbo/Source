
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EastCarmen.Entity;


namespace EastCarmen.IDao
{
	public partial interface IDBSession
	{

		
		IPersonRepository PersonRepository{get;}
		
		IStudentRepository StudentRepository{get;}
	
	}
	
}