using System.Text.Json;
using HRAPP.entities;
namespace HRAPP.Repositories;

public class RepositoryManager
{
    public void Serialize(List<Employee> employees, string filename)
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        var employeesJson = JsonSerializer.Serialize<List<Employee>>(employees, options);
        File.WriteAllText(filename, employeesJson);
    }
    public List<Employee> DeSerialize(string filename)
    {
        string jsonString = File.ReadAllText(filename);
        List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        return jsonEmployees;
    }
}