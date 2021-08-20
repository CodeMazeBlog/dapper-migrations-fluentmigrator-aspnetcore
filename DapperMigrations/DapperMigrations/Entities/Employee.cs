using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMigrations.Entities
{
	public class Employee
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Position { get; set; }
		public Guid CompanyId { get; set; }
	}
}
