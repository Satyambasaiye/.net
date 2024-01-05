namespace store.services;
public interface IauthServices
{
    public void addUserDetail(string name, string email, string pass);
    public string authenticateUser(string name, string pass);

}