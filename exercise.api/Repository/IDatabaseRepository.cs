using exercise.api.Models;
using System.Linq.Expressions;

namespace exercise.api.Repository
{
    public interface IDatabaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        IEnumerable<T> Include(params Expression<Func<T, object>>[] includes);
        //IEnumerable<Employee> GetEmployees(Employee employee);
        //Employee CreateEmployee(Employee employee);
        //Employee GetAnEmployee(int id);
        //Employee UpdateAnEmployee(int id, Employee employee);
        //Employee DeleteAnEmployee(int id);



        //IEnumerable<Salary> GetSalaries(Employee employee);
        //Salary CreateSalary(Salary salary);
        //Salary GetASalary(int id);
        //Salary UpdateASalary(int id, Salary salary);
        //Salary DeleteASalary(int id);

        //IEnumerable<Department> GetDepartments(Employee employee);
        //Department CreateDepartment(Department department);
        //Department GetADepartment(int id);
        //Department UpdateADepartment(int id, Department department);
        //Department DeleteADepartment(int id);



    }
}
