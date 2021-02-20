using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmApplication.Models
{
	public interface IRepo<T>
	{
		void Add(T emp);
		bool Remove(int empId);
		T GetById(int empid);

		IEnumerable<T> GetAll();
	}
}