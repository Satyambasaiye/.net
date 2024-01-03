using System.Security.Cryptography;

namespace HRAPP.entities;

[Serializable]
public class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public double basicSalary { get; set; }
    public double da { get; set; }
    public double tax { get; set; }
    public double pf { get; set; }
    public double computeSal()
    {
        return basicSalary + (da * 22) - (tax + pf);
    }
    public override string ToString()
    {
        return "id" + this.id + " name:" + this.name + " total salary:" + this.computeSal();
    }


}