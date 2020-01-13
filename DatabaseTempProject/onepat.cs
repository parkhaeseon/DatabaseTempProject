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
    public partial class onepat : Form
    {
        public manage opmng;

        public namepat npatgo;

        dba a = new dba();

        public onepat(manage _opmng)
        {
            InitializeComponent();

            this.opmng = _opmng;
        }

        // 환자 이름 검색
        private void Entersure_Click(object sender, EventArgs e)
        {
            if(patn.Text.ToString().Trim() == "")
            {
                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!Regex.IsMatch(patn.Text.ToString().Trim(), @"[가-힣]{2,5}"))
            {
                MessageBox.Show("이름에 오류가 있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patn.Clear();
                this.ActiveControl = patn;
                return;
            }

            if (Regex.IsMatch(patn.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("이름에 문자가 포함되어있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patn.Clear();
                this.ActiveControl = patn;
                return;
            }

            if (patn.Text.ToString().Trim().Length > 5)
            {
                MessageBox.Show("이름이 너무 깁니다. 한글 5자 이하로 입력하세요.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patn.Clear();
                this.ActiveControl = patn;
                return;
            }

            string ps = "select * from patient where name = '" + patn.Text.ToString().Trim() + "'";

            MySqlCommand pscmd = new MySqlCommand(ps, a.Connection());

            MySqlDataReader psrd = pscmd.ExecuteReader();

            if (!psrd.HasRows)
            {
                MessageBox.Show("등록되지 않은 환자입니다.", "해당 이름을 가진 환자 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                patn.Clear();
                this.ActiveControl = patn;
                psrd.Close();
                return;
            }

            psrd.Close();

            npatgo = new namepat(this);

            npatgo.ShowDialog();
        }
    }
}
