using HRAPP.entities;
using HRAPP.Services;

namespace HRAPP.controllers;
public class EmployeeControllers
{
    IEmployeeService _svc;
    public EmployeeControllers(IEmployeeService svc)
    {
        this._svc = svc;
    }
    public List<Employee> GetAll()
    {
        return this._svc.GetAll();
    }

    
}