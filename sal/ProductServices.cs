using BOL;
using DAL;
using DAL.Connected;
using DAL.DisConnected;

namespace SAL;
public class ProductServices : IProductServices
{
    MySqlDBManager rep = new MySqlDBManager();
    Connected connected=new Connected();


    public bool DeleteById(int id)
    {
        return connected.DeleteById(id);
       
    }

    public List<Product> GetAll()
    {
        return rep.GetAll();
    }
    public Product GetById(int id)
    {
        return rep.getById(id);
    }
}