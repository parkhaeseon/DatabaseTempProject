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
    public partial class myselfinfo : Form
    {
        public manage selfmng;

        dba a = new dba();


        public myselfinfo(manage _selfmng)
        {
            InitializeComponent();

            this.selfmng = _selfmng;

            this.ActiveControl = null;
        }

        private void myselfinfo_Load(object sender, EventArgs e)
        {
            try
            {
                string selfinfoshow = "select * from employee where id = '" + selfmng.login_main.LoginID + "'";

                MySqlCommand selectinfo = new MySqlCommand(selfinfoshow, a.Connection());

                MySqlDataReader reader_find = selectinfo.ExecuteReader();

                if (reader_find.HasRows && reader_find != null)
                {
                    while (reader_find.Read())
                    {
                        selfid.Text = reader_find["id"].ToString();
                        selfname.Text = reader_find["name"].ToString();
                        selfgender.Text = reader_find["gender"].ToString();
                        selfrrn.Text = reader_find["rrn"].ToString();
                        selfhomeaddress.Text = reader_find["homeaddress"].ToString();
                        selfcpn.Text = reader_find["cpn"].ToString();
                        selfhtn.Text = reader_find["htn"].ToString();
                    }
                }

                reader_find.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
