using HRAPP.entities;
using HRAPP.Repositories;

namespace HRAPP.Services;

public class EmployeeService : IEmployeeService
{
    public List<Employee> GetAll()
    {
        List<Employee> employees = new List<Employee>();
        RepositoryManager mgr = new RepositoryManager();
        string filename = "emp.json";
        employees.Add(new Employee { id = 1, name = "satyam", basicSalary = 2000, pf = 200, da = 300, tax = 400 });
        employees = mgr.DeSerialize(filename);
        return employees;
    }
    public void Insert(Employee emp)
    {
        
    }



}
