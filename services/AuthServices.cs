using store.Repository;

namespace store.services;

public class AuthService : IauthServices
{
    Register reg = new Register();
    public void addUserDetail(string name, string email, string pass)
    {

        reg.serialize(name, email, pass);

    }
    public string authenticateUser(string name, string pass)
    {
        // reg.authenticateUser(name,pass);
        return "hello";
    }


}