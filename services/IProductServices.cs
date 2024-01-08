using store.Entities;

namespace store.services;

public interface IProductServices
{
    public List<Product> GetAll();

}