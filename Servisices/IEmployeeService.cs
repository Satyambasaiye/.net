using HRAPP.entities;

namespace HRAPP.Services;

public interface IEmployeeService
{
    public List<Employee> GetAll();
}