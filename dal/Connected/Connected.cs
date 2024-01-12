using System.Data;
using System.Data.Common;
using BOL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
namespace DAL.Connected;

public class Connected{
    public Connected(){}
    public bool DeleteById(int id){
    MySqlConnection con=new MySqlConnection();
    con.ConnectionString=@"server=localhost; port=3306;user=root;password=root123; database=dotnet";
    MySqlCommand cmd=new MySqlCommand();
    cmd.Connection=con;
    cmd.CommandText="delete from product where id="+id;
    con.Open();
    if(cmd.ExecuteNonQuery()>0){
        return true;
    }return false;


    }
}

