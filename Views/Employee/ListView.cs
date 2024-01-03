using HRAPP.entities;

namespace HRAPP.Views;
public class ListView:Iview
{
    private List<Employee> _employees;
    public ListView(List<Employee> emp)
    {
        _employees = emp;
    }
    public void render()
    {
        Console.WriteLine("*********employee list*******");
        foreach (Employee emp in _employees)
        {
            Console.WriteLine(emp);
        }
    }
}