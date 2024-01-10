using System.Data;
using BOL;
using MySql.Data.MySqlClient;

namespace DAL.DisConnected;

public class MySqlDBManager
{
    public MySqlDBManager() { }
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

                }
            }


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



    }









    // public Product GetById(int id)
    // {
    //     Product prod = new Product();
    //     bool status = false;
    //     //Insert disconnected code to be written
    //     List<Product> employees = new List<Product>();
    //     MySqlConnection con = new MySqlConnection();
    //     con.ConnectionString = @"server=localhost; port=3306; user=root; password=password; database=transflower";
    //     MySqlCommand cmd = new MySqlCommand();
    //     cmd.Connection = con;
    //     cmd.CommandText = "SELECT * from employees";
    //     try
    //     {
    //         DataSet ds = new DataSet();
    //         MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    //         MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
    //         da.Fill(ds);
    //         DataTable dtProducts = ds.Tables[0];
    //         DataRowCollection rows = dtProducts.Rows;
    //         DataRow[] foundRows = dtProducts.Select("Id =" + id); //*******
    //         Console.WriteLine("Found " + foundRows.Length);
    //         DataRow theRow = foundRows[0];
    //         Console.WriteLine(theRow["id"].ToString() + " " + theRow["firstName"].ToString());
    //         prod.Id = int.Parse(theRow["id"].ToString());
    //         prod.FirstName = theRow["firstName"].ToString();
    //         prod.LastName = theRow["lastName"].ToString();
    //         prod.Address = theRow["email"].ToString();
    //         prod.Email = theRow["email"].ToString();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     return prod;
    // }
    // public bool Insert(Product prod)
    // {
    //     bool status = false;
    //     //Insert disconnected code to be written
    //     List<Product> employees = new List<Product>();
    //     MySqlConnection con = new MySqlConnection();
    //     con.ConnectionString = @"server=localhost; port=3306; user=root; password=password; database=transflower";
    //     MySqlCommand cmd = new MySqlCommand();
    //     cmd.Connection = con;
    //     cmd.CommandText = "SELECT * from employees";
    //     try
    //     {
    //         DataSet ds = new DataSet();
    //         MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    //         MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
    //         da.Fill(ds);
    //         DataTable dtProducts = ds.Tables[0];
    //         DataRowCollection rows = dtProducts.Rows;
    //         DataRow row = dtProducts.NewRow();
    //         row["firstName"] = prod.FirstName;
    //         row["lastName"] = prod.LastName;
    //         row["email"] = prod.Email;
    //         row["address"] = prod.Address;
    //         rows.Add(row);
    //         da.Update(ds);
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     return status;
    // }

    // public bool Update(Product prod)
    // {
    //     bool status = false;
    //     //Insert disconnected code to be written
    //     return status;
    // }
    // public bool Delete(Product prod)
    // {
    //     bool status = false;
    //     //Insert disconnected code to be written
    //     List<Product> employees = new List<Product>();
    //     MySqlConnection con = new MySqlConnection();
    //     con.ConnectionString = @"server=localhost; port=3306; user=root; password=password; database=transflower";
    //     MySqlCommand cmd = new MySqlCommand();
    //     cmd.Connection = con;
    //     cmd.CommandText = "SELECT * from employees";
    //     try
    //     {
    //         DataSet ds = new DataSet();
    //         MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    //         MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
    //         da.Fill(ds);
    //         DataTable dtProducts = ds.Tables[0];
    //         DataRowCollection rows = dtProducts.Rows;
    //         DataRow[] foundRows = dtProducts.Select("Id =" + prod.Id); //*******
    //         Console.WriteLine("Found " + foundRows.Length);
    //         DataRow theRow = foundRows[0];
    //         Console.WriteLine(theRow["id"].ToString() + " " + theRow["firstName"].ToString());
    //         //rows.Remove(theRow);
    //         rows.RemoveAt(2);
    //         da.Update(ds);
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     return status;
    // }

}