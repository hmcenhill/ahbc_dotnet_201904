using SomethingCool.Models;

namespace SomethingCool.Data
{
    public interface IDataRepository
    {
        void Add(Employee employee);
        Employee Get(int id);
        void Save(int id, Employee employee);
    }
}