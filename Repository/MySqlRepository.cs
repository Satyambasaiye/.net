namespace store.Repository;
using store.Entities;
using MySql.Data.MySqlClient;
public class MySqlRepository
{
    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select * from product";
        try
        {
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string? name = reader["name"].ToString();
                int quantity = int.Parse(reader["quantity"].ToString());
                string details = reader["details"].ToString();
                Product p = new Product(id, name, quantity, details);
                products.Add(p);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {
            con.Close();
        }
        return products;

    }
}