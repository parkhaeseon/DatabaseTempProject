using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace DatabaseTeamProject
{
    public class dba
    {
        // 반환할 MySqlConnection
        protected MySqlConnection conn;

        // 데이터베이스를 연결하고, 실행(Open)한다.
        public dba()
        {
            conn = new MySqlConnection("server = localhost; " +
                "user = root;" +
                " password = 000000; " +
                "database = databaseteamproject; " +
                "Charset = utf8");
            if (!conn.Ping()) conn.Open();
        }

        // 연결한 데이터베이스를 닫는다.
        public void Close()
        {
            conn.Close();
        }

        // sql문을 사용하기 위해 쓰일 MySqlConnection을 반환한다.
        public MySqlConnection Connection()
        {
            return conn;
        }
    }
}
