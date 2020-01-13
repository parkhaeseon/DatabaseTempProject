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
    public partial class docEditForm : Form
    {
        public doctorEdit doctorFormEdit;

        public docaddredit addrdoc;

        dba a = new dba();

        public docEditForm(doctorEdit _doctorFormEdit)
        {
            InitializeComponent();

            this.doctorFormEdit = _doctorFormEdit;

            // 지역번호 세팅
            string[] p = {"02", "051", "053", "032", "062", "042", "052", "044", "031", "033",
            "043", "041", "063", "061", "054", "055", "064"};
            newhomenumber.Items.AddRange(p);
            newhomenumber.SelectedIndex = 0;
        }

        // 수정하기 버튼 클릭
        private void myinforedit_Click(object sender, EventArgs e)
        {
            if ( newAddress.Text.ToString().Trim() == "" || newAddress2.Text.ToString().Trim() == "" ||
                newcellphone.Text.ToString().Trim() == "" || newhomenumber2.Text.ToString().Trim() == "")
            {
                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (Regex.IsMatch(newcellphone.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("핸드폰 번호에 문자가 포함되어있습니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newcellphone.Clear();
                this.ActiveControl = newcellphone;
                return;
            }

            if (!Regex.IsMatch(newcellphone.Text.ToString().Trim(), @"^\d{11}$"))
            {
                MessageBox.Show("핸드폰 번호는 숫자로 총 11자리입니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newcellphone.Clear();
                this.ActiveControl = newcellphone;
                return;
            }

            if (Regex.IsMatch(newhomenumber2.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("집 전화번호에 문자가 포함되어있습니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newhomenumber2.Clear();
                this.ActiveControl = newhomenumber2;
                return;
            }

            if (newhomenumber2.Text.ToString().Trim().Length > 10)
            {
                MessageBox.Show("집 뒷 전화번호가 너무 깁니다." + '\n' + "숫자 10개 이하만 가능합니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newhomenumber2.Clear();
                this.ActiveControl = newhomenumber2;
                return;
            }

            if (newhomenumber2.Text.ToString().Trim().Length < 5)
            {
                MessageBox.Show("전화번호 뒷 자리가 너무 짧습니다.", "전화번호 뒷 자리 짧음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = newhomenumber2;
                return;
            }

            string get = newhomenumber2.Text.ToString().Trim().Substring(0, newhomenumber.Text.ToString().Trim().Length);

            if (get == newhomenumber.Text.ToString().Trim())
            {
                MessageBox.Show("전화번호 뒷 자리에 지역 번호가 포함되어있습니다.", "전화번호 뒷 자리에 지역 번호 포함", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = newhomenumber2;
                return;
            }

            try
            {
                string emp_update = "update doctor set "
                                    + "homeaddress = '" + newAddress.Text.ToString().Trim() + " " + newAddress2.Text.ToString().Trim() + "', "
                                    + "cpn = '" + newcellphone.Text.ToString().Trim() + "', "
                                    + "htn = '" + newhomenumber.Text.ToString().Trim() + newhomenumber2.Text.ToString().Trim() + "' "
                                    + "where id = '" + doctorFormEdit.docId.Text.ToString().Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(emp_update, a.Connection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("의사 개인정보가 수정되었습니다.", "의사 개인정보 수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        // 직접 입력
        private void selfinput_Click(object sender, EventArgs e)
        {
            newAddress.ReadOnly = false;
            newAddress.Clear();
            this.ActiveControl = newAddress;
        }

        // 도로명 주소 검색 클릭
        private void saddr_Click(object sender, EventArgs e)
        {
            addrdoc = new docaddredit(this);
            addrdoc.ShowDialog();
        }
    }
}
