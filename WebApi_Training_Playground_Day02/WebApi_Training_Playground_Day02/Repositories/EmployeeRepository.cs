using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Training_Playground_Day02.Models;

namespace WebApi_Training_Playground_Day02.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly WebApiTrainingDbContext _context;

		public EmployeeRepository(WebApiTrainingDbContext context)
		{
			this._context = context;
		}

		public IEnumerable<Employee> GetEmployees()
		{
			return this._context.Employees.ToList();
		}

		public Employee GetEmployee(int employeeId)
		{
			throw new NotImplementedException();
		}

		public Employee AddEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public Employee UpdateEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public void DeleteEmployee(int employeeId)
		{
			throw new NotImplementedException();
		}
	}
}
