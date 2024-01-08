using System.Text.Json;
using System.Text.Json.Serialization;
using store.model;

namespace store.Repository;
public class Register
{


    public void serialize(string name, string email, string pass)
    {
        var options=new JsonSerializerOptions{IncludeFields=true};
        // File.WriteAllText("register_user", js);
        RegisterModel reg=new RegisterModel(name,email,pass);
        var RegisterJson=JsonSerializer.Serialize(reg,options);
        File.AppendAllText("register_user", RegisterJson+Environment.NewLine);
        Console.WriteLine("saved details");
        

    }
    public List<RegisterModel> deSerialize(string username,string pass)
    {
        List<RegisterModel> registerList=new List<RegisterModel>();
        string fn = "register_user";
        string[] lines = File.ReadAllLines(fn);
        
        foreach(string line in lines)
        {
            RegisterModel reg=JsonSerializer.Deserialize<RegisterModel>(line);
            
            registerList.Add(reg);
        }
        Console.WriteLine("in deserialize..........");
        registerList.ForEach(s=>Console.WriteLine(s));

        return registerList;
    }
}