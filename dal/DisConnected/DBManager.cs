using System.Data;
using System.Data.Common;
using BOL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace DAL.DisConnected;

public class MySqlDBManager
{
    public MySqlDBManager() { }
    public bool DeleteById( int id)
    {
         bool deleted=false;
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=@"server=localhost; port=3306; user=root; password=root123;database=dotnet";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText="select * from Product";
        try{
             DataRow deleteRow=null;
            DataSet ds=new DataSet();
            MySqlDataAdapter da=new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder =new MySqlCommandBuilder(da);
            da.Fill(ds);
            DataTable dtProducts=ds.Tables[0];
            DataRowCollection rows=dtProducts.Rows;
            foreach(DataRow row in rows)
            {
                if(int.Parse(row["id"].ToString())==id)
                {
                deleteRow=row;
                Console.WriteLine("row inside if =:"+deleteRow["name"]);
                    break;
                }
            }
            Console.WriteLine("row =:"+deleteRow["name"]);
             rows.Remove(deleteRow);
            //deleteRow.Delete();
            da.Update(ds);
            
            return deleted;
            
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return deleted;
        }
    }

    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from product";
        try
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);

            da.Fill(ds);
            DataTable dtProducts = ds.Tables[0];
            DataRowCollection rows = dtProducts.Rows;
            foreach (DataRow row in rows)
            {
                int id = int.Parse(row["id"].ToString());
                string? name = row["name"].ToString();
                int quantity = int.Parse(row["quantity"].ToString());
                string? details = row["details"].ToString();

                Product prod = new Product(id, name, quantity, details);
                products.Add(prod);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return products;
    }
    public Product getById(int id)
    {
        DataSet ds = new DataSet();
        Product prod = new Product();
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        con.ConnectionString = @"server=localhost;port=3306;user=root;password=root123;database=dotnet";
        cmd.Connection = con;
        cmd.CommandText = "select * from product where id=" + id;
        try
        {
            DataSet ds2 = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            da.Fill(ds2);
            DataTable dtProducts = ds2.Tables[0];
            DataRowCollection rows = dtProducts.Rows;
            foreach (DataRow row in rows)
            {
                if (int.Parse(row["id"].ToString()) == id)
                {
                    prod.id=int.Parse(row["id"].ToString());
                    prod.name=row["name"].ToString();
                    prod.quantity=int.Parse(row["quantity"].ToString());
                    prod.details=row["details"].ToString();
                }
            }

        }
        catch (Exception e)
        {
            
            Console.WriteLine("exception in dbmanger !!!!"+e.Message);
        }
                    return prod;
    }

  
}