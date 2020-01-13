using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DatabaseTeamProject
{
    public partial class Totalpeople : Form
    {
        public manage totalmng;

        dba a = new dba();


        public Totalpeople(manage _totalmng)
        {
            InitializeComponent();

            this.totalmng = _totalmng;
        }

        // 열릴 때
        private void Totalpeople_Load(object sender, EventArgs e)
        {

            List<TextBox> empdocpat = new List<TextBox>();

            empdocpat.Add(totalemp);
            empdocpat.Add(totaldoctor);
            empdocpat.Add(totalpatient);

            try
            {
                string countPeople = "select count(rrn) 'total' from employee " +
                "union all select count(rrn) 'total' from doctor " +
                "union all select count(rrn) 'total' from patient";

                MySqlCommand doctorDelete_cmd = new MySqlCommand(countPeople, a.Connection());

                MySqlDataReader TotalCount = doctorDelete_cmd.ExecuteReader();

                if (TotalCount.HasRows)
                {
                    int idx = 0;

                    while (TotalCount.Read())
                    {
                        empdocpat[idx++].Text = TotalCount["total"].ToString();
                    }
                }

                TotalCount.Close();

                countPeople = "select sum(total) 'Total' from " +
                    "(" +
                    "select count(rrn) 'total' from employee " +
                    "union all select count(rrn) 'total' from doctor " +
                    "union all select count(rrn) 'total' from patient" +
                    ") " +
                    "as Temp";

                MySqlCommand doctorDelete_cmd2 = new MySqlCommand(countPeople, a.Connection());

                MySqlDataReader TotalCount2 = doctorDelete_cmd2.ExecuteReader();

                if (TotalCount2.HasRows)
                {
                    while (TotalCount2.Read())
                    {
                        totalp.Text = TotalCount2["Total"].ToString();
                    }
                }

                TotalCount2.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }

            
        }
    }
}
