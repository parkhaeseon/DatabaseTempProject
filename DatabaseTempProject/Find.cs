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
    public partial class FindIDPW : Form
    {
        public login login_main;

        dba a = new dba();


        public FindIDPW(login _main)
        {
            InitializeComponent();

            this.login_main = _main;
        }

        private void findclick_Click(object sender, EventArgs e)
        {
            string sid = fid.Text.ToString().Trim();
            string srrn = frrn.Text.ToString().Trim();

            if ( sid == "" || srrn == "")
            {
                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(srrn.Trim(), @"^\d{13}$"))
            {
                MessageBox.Show("주민등록번호 형식이 올바르지 않습니다.", "주민등록번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frrn.Clear();
                this.ActiveControl = frrn;
                return;
            }

            if (!Regex.IsMatch(fid.Text.ToString().Trim(), @"[가-힣]{2,5}"))
            {
                MessageBox.Show("이름에 오류가 있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fid.Clear();
                this.ActiveControl = fid;
                return;
            }

            if (Regex.IsMatch(fid.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("이름에 문자가 포함되어있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fid.Clear();
                this.ActiveControl = fid;
                return;
            }

            try
            {
                string find_select = "select id, pw from employee where name = '" + sid + "' and rrn = '" + srrn + "'";

                MySqlCommand f_select = new MySqlCommand(find_select, a.Connection());
 
                MySqlDataReader reader_find = f_select.ExecuteReader();

                if (reader_find.HasRows && reader_find != null)
                {
                    while(reader_find.Read())
                    {
                        MessageBox.Show("아이디 : " + reader_find["id"].ToString() + "\n비밀번호 : " + reader_find["pw"].ToString(), "기억바랍니다.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("이름과 주민등록번호를 동시에 만족하는 회원이 없습니다.", "이름과 주민등록번호에 해당하는 회원 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
