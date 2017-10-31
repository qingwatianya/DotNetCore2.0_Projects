using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameWork_WindowsService_HangFire
{
  public  class Test
    {
        public static void Fork()
        {
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            MySql.Data.MySqlClient.MySqlConnection ff = new MySql.Data.MySqlClient.MySqlConnection(tmpConnection);
            string tmpSql = string.Format("UPDATE Module_Description SET Module_URL='111{0}';", DateTime.Now.ToString());
            ff.Execute(tmpSql);


        }
    }
}
