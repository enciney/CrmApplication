﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmApplication.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
	}
}