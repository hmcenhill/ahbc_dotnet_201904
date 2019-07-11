using SomethingCool.Models;
using System.Collections.Generic;
using System.Linq;

namespace SomethingCool.Data
{
    public class DataRepository
    {
        private readonly Dictionary<int, Employee> _data =
            new Dictionary<int, Employee>
            {
                { 5, new Employee
                    {
                        Id = 5,
                        FirstName = "Jason",
                        LastName = "Robert",
                        Age = 35,
                        Email = "jason@grandcircus.co"
                    }}
            };

        public Employee Get(int id)
        {
            if (_data.TryGetValue(id, out var employee))
            {
                return employee;
            }

            return null;
        }

        public void Add(Employee employee)
        {
            var id = _data.Keys.Max() + 1;
            _data[id] = employee;
        }

        public void Save(int id, Employee employee)
        {
            _data[id] = employee;
        }
    }
}
