namespace store.model;
public class RegisterModel{
    public string name{get;set;}
    public string emai{get;set;}

    public string  pass{get;set;}
    public RegisterModel(){
        
    }
    public RegisterModel(string name,string email,string pass)
    {
        this.name=name;
        this.emai=email;
        
        this.pass=pass;
    }
    
    public override string ToString()
    {
        return name+" "+emai;
    }
}