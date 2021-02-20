using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmApplication.Models
{
	public class VisitInfo
	{
		public int CompanyId { get; set; }
		public DateTime PlannigVisitDate { get; set; }
		public string CompanyAddress { get; set; }
		public DateTime ActualVisitDate { get; set; }
		public int EmployeeId { get; set; }
		public string Comment { get; set; }

	}
}