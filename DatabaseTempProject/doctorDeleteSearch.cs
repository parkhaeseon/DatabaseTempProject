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
    public partial class doctorDeleteSearch : Form
    {
        public manage dDS_mng;

        dba a = new dba();

        public doctorDeleteSearch(manage _dDS_mng)
        {
            InitializeComponent();

            this.dDS_mng = _dDS_mng;

            this.ActiveControl = doctorIdDelete;
        }

        // 삭제하기 버튼 클릭
        private void doctorDelete_Button_Click(object sender, EventArgs e)
        {
            if(doctorIdDelete.Text.ToString().Trim() == "")
            {
                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (doctorIdDelete.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = doctorIdDelete;
                return;
            }

            if (!Regex.IsMatch(doctorIdDelete.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(doctorIdDelete.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorIdDelete.Clear();
                this.ActiveControl = doctorIdDelete;
                return;
            }

            if (doctorIdDelete.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorIdDelete.Clear();
                this.ActiveControl = doctorIdDelete;
                return;
            }

            try
            {
                string doctorDelete_sql_select = "select * from doctor where id = '" + doctorIdDelete.Text.ToString().Trim() + "'";

                MySqlCommand doctorDelete_cmd = new MySqlCommand(doctorDelete_sql_select, a.Connection());

                MySqlDataReader doctorDelete_reader = doctorDelete_cmd.ExecuteReader();

                if (!doctorDelete_reader.HasRows)
                {
                    MessageBox.Show("입력하신 아이디에 해당하는 의사가 없습니다.", "입력한 아이디에 맞는 의사 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doctorIdDelete.Clear();
                    doctorDelete_reader.Close();
                    return;
                }

                doctorDelete_reader.Close();

                if (MessageBox.Show("예약 내역에 있는 해당 의사의 모든 정보와 순위 등 같이 삭제됩니다." + '\n' + "정말 삭제하시겠습니까? 되돌리 수 없습니다.", "예 / 아니오 주의하여 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string doctorDelete_sql = "delete from doctor where id = '" + doctorIdDelete.Text.ToString().Trim() + "'";

                    MySqlCommand doctorDelete_cmd_delete = new MySqlCommand(doctorDelete_sql, a.Connection());

                    doctorDelete_cmd_delete.ExecuteNonQuery();

                    MessageBox.Show("해당 의사와 관련된 모든 정보들이 삭제되었습니다.", "해당 의사 정보 삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
