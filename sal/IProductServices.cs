using BOL;
using DAL;

namespace SAL;


public interface IProductServices
{
    public bool DeleteById(int id);
    public List<Product> GetAll();
        public Product GetById(int id);

}