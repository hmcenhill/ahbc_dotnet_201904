using SomethingCool.Models;

namespace SomethingCool.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly EmployeeContext _context;

        public DataRepository(EmployeeContext context)
        {
            _context = context;
        }

        public Employee Get(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Save(int id, Employee employee)
        {
            if (id == employee.Id)
            {
                _context.Update(employee);
                _context.SaveChanges();
            }
        }
    }
}
