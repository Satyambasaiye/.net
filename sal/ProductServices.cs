using BOL;
using DAL;

namespace SAL;
public class ProductServices : IProductServices
{
    MySqlRepository rep = new MySqlRepository();
    public List<Product> GetAll()
    {
        return rep.GetAll();
    }
}