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
using System.Threading;

namespace DatabaseTeamProject
{
    public partial class employeeIDedit : Form
    {
        public manage empideditmng;

        dba a = new dba();

        public employeeIDedit(manage _empideditmng)
        {
            InitializeComponent();

            this.empideditmng = _empideditmng;
        }

        // 수정하기 버튼 클릭
        private void Editsure_Click(object sender, EventArgs e)
        {
            if(newid.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dup.Enabled)
            {
                MessageBox.Show("아이디 중복 확인을 해주세요.", "중복 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = dup;
                return;
            }

            if (!Regex.IsMatch(newid.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(newid.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newid.Clear();
                this.ActiveControl = newid;
                return;
            }

            if (newid.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = newid;
                newid.Clear();
                return;
            }

           
            if (MessageBox.Show("정말 수정하시겠습니까?" + '\n' + "해당 아이디와 관련된 정보들도 모두 수정됩니다.", "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string emp_update = "update employee set "
                                    + "id = '" + newid.Text.ToString().Trim() + "'"
                                    + "where id = '" + empideditmng.login_main.LoginID + "'";

                empideditmng.login_main.LoginID = newid.Text.ToString().Trim();

                MySqlCommand cmd = new MySqlCommand(emp_update, a.Connection());

                cmd.ExecuteNonQuery();

                empideditmng.Text = "종합 예약 시스템   안녕하세요! " + newid.Text.ToString().Trim() + "님";

                MessageBox.Show("아이디 수정이 완료되었습니다.", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                using (Loading ld = new Loading(WaitData))
                {
                    ld.ShowDialog(this);
                }
            }
        }

        private void WaitData()
        {
            for (int i = 0; i <= 250; i++)
                Thread.Sleep(5);
        }

        // 중복 확인 버튼 클릭
        private void dup_Click(object sender, EventArgs e)
        {
            if (newid.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = newid;
                return;
            }

            if (newid.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = newid;
                return;
            }

            if (!Regex.IsMatch(newid.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(newid.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newid.Clear();
                this.ActiveControl = newid;
                return;
            }

            try
            {
                // 의사 아이디랑 중복인지 검사
                string docidselect = "select * from doctor where id = '" + newid.Text.ToString().Trim() + "'";

                MySqlCommand docidselect_cmd = new MySqlCommand(docidselect, a.Connection());

                MySqlDataReader docidselect_cmd_dr = docidselect_cmd.ExecuteReader();

                if (docidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 의사의 아이디입니다." + '\n' + "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newid.Clear();
                    docidselect_cmd_dr.Close();
                    this.ActiveControl = newid;
                    return;
                }
                docidselect_cmd_dr.Close();


                // 환자 아이디랑 중복되는지 검사
                string patidselect = "select * from patient where id = '" + newid.Text.ToString().Trim() + "'";

                MySqlCommand patidselect_cmd = new MySqlCommand(patidselect, a.Connection());

                MySqlDataReader patidselect_cmd_dr = patidselect_cmd.ExecuteReader();

                if (patidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 환자의 아이디입니다." + '\n' + "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newid.Clear();
                    patidselect_cmd_dr.Close();
                    this.ActiveControl = newid;
                    return;
                }
                patidselect_cmd_dr.Close();

                string dup_sql = "select id from employee where id = '" + newid.Text.ToString().Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(dup_sql, a.Connection());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("중복된 아이디 입니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    newid.Clear();
                }
                else
                {
                    MessageBox.Show("사용 가능합니다.", "사용 가능한 아이디", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newid.ReadOnly = true;
                    dup.Enabled = false;
                }

                reader.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.ToString());
            }
        }

        // 지우기 버튼
        private void alldelete_Click(object sender, EventArgs e)
        {
            newid.Clear();
            newid.ReadOnly = false;
            dup.Enabled = true;
            this.ActiveControl = newid;
        }
    }
}
