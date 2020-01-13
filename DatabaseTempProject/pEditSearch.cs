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
    public partial class pEditSearch : Form
    {
        public manage pES_mng;

        public patientEdit patientEd;

        dba a = new dba();

        public pEditSearch(manage _pES_mng)
        {
            InitializeComponent();

            this.pES_mng = _pES_mng;
        }

        // 해당 환자 정보 수정하기 버튼 클릭
        private void docedit_Click(object sender, EventArgs e)
        {
            if (patId.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = patId;
                return;
            }

            if (!Regex.IsMatch(patId.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(patId.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patId.Clear();
                this.ActiveControl = patId;
                return;
            }

            if (patId.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = patId;
                patId.Clear();
                return;
            }

            try
            {
                string docidselect = "select * from patient where id = '" + patId.Text.ToString().Trim() + "'";

                MySqlCommand docidselect_cmd = new MySqlCommand(docidselect, a.Connection());

                MySqlDataReader docidselect_cmd_dr = docidselect_cmd.ExecuteReader();

                if (!docidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("등록되어 있지 않은 환자 아이디입니다.", "해당 아이디에 맞는 환자 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patId.Clear();
                    docidselect_cmd_dr.Close();
                    this.ActiveControl = patId;
                    return;
                }

                docidselect_cmd_dr.Close();

                patientEd = new patientEdit(this);
                patientEd.ShowDialog();

                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
