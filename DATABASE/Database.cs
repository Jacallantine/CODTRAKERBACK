using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;


using API.MODELS;
using API.CONTROLLERS;

namespace API.DATABASE{
public class Database{
    private string cs;

    public Database()
    {
         cs = "server=ol5tz0yvwp930510.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;database=l44mtoa1n4wh6y74;user=uzf11anultxdooek;password=zpnhnut70jwyrbgw;port=3306;";
    }


 public async Task<object> ValidateLogin(string sql, List<MySqlParameter> parms)
        {
            using var connection = new MySqlConnection(cs);
            await connection.OpenAsync();
            using var command = new MySqlCommand(sql, connection);


            if (parms != null)
            {
                command.Parameters.AddRange(parms.ToArray());
            }
            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new
                {
                    UserName = reader.GetString(0)
                };
            }
            return null;
        }


}
}