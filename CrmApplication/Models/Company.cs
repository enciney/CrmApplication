using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmApplication.Models
{
	public class Company
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string Fax { get; set; }
		public string ContactName { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string Email { get; set; }
	}
}