using System.Text.Json;
using System.Text.Json.Serialization;

namespace store.Repository;
public class Register
{


    public void serialize(string name, string email, string pass)
    {
        var obj = new { name = name, email = email, pass = pass };
        var js = JsonSerializer.Serialize(obj);
        // File.WriteAllText("register_user", js);
        File.AppendAllText("register_user", js);
        Console.WriteLine("saved details");

    }
    public string deSerialize(string filename)
    {
        string fn = "register_user";
        String js = File.ReadAllText(fn);
        // JsonSerializer.Deserialize(js,new{name,email,pass}})
        List<string> l = JsonSerializer.Deserialize<List<string>>(js);
        Console.WriteLine(js);
        Console.WriteLine(l);
        l.ForEach(s => Console.WriteLine(s));

        return fn;



    }
}