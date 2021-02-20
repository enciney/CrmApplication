using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmApplication.Models
{
	public class EmployeeRepo : IEmployeeRepo
	{

		public EmployeeRepo()
		{

		}

		IEnumerable<Employee> InMemoryEmployee = new Employee[] {
			new Employee() { Name = "Test", Surname = "Test", Id = 0, Email= "test@test.com", Password = "123", UserName= "test1" },
			new Employee() { Name = "Test2", Surname = "Test2", Id = 1, Email= "test2@test.com", Password = "123", UserName= "test2" },
			new Employee() { Name = "Test3", Surname = "Test3", Id = 2, Email= "test3@test.com", Password = "123", UserName= "test3" },
		};

		public void Add(Employee emp)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employee> GetAll()
		{
			return InMemoryEmployee;
		}

		public Employee GetById(int empid)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int empId)
		{
			throw new NotImplementedException();
		}
	}
}