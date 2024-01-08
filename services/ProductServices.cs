using store.Entities;
using store.Repository;

namespace store.services;
public class ProductServices : IProductServices
{
    MySqlRepository rep = new MySqlRepository();
    public List<Product> GetAll()
    {
        return rep.GetAll();
    }
}