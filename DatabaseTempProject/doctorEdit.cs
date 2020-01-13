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
    public partial class doctorEdit : Form
    {
        public manage dE_mng;

        public docEditForm deForm;

        dba a = new dba();

        public doctorEdit(manage _dE_mng)
        {
            InitializeComponent();

            this.dE_mng = _dE_mng;
        }

        // 해당 의사 정보 수정하기 버튼 클릭
        private void docedit_Click(object sender, EventArgs e)
        {
            if (docId.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = docId;
                return;
            }

            if (!Regex.IsMatch(docId.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(docId.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                docId.Clear();
                this.ActiveControl = docId;
                return;
            }

            if (docId.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = docId;
                docId.Clear();
                return;
            }

            try
            {
                string docidselect = "select * from doctor where id = '" + docId.Text.ToString().Trim() + "'";

                MySqlCommand docidselect_cmd = new MySqlCommand(docidselect, a.Connection());

                MySqlDataReader docidselect_cmd_dr = docidselect_cmd.ExecuteReader();

                if (!docidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("등록되어 있지 않은 의사 아이디입니다.", "해당 아이디에 맞는 의사 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    docId.Clear();
                    docidselect_cmd_dr.Close();
                    this.ActiveControl = docId;
                    return;
                }

                docidselect_cmd_dr.Close();

                deForm = new docEditForm(this);
                deForm.ShowDialog();

                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
