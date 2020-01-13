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
    public partial class patientReservationDelete : Form
    {
        public manage patResEdit;
        public PatientReservationDeleteSearch pRDS;

        dba a = new dba();


        public patientReservationDelete(manage _patResEdit)
        {
            InitializeComponent();

            this.patResEdit = _patResEdit;
        }
        
        // 환자 예약 내역 조회 버튼
        private void patressearch_Click(object sender, EventArgs e)
        {
            if (patIdResDelete.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = patIdResDelete;
                return;
            }

            if (!Regex.IsMatch(patIdResDelete.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(patIdResDelete.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patIdResDelete.Clear();
                this.ActiveControl = patIdResDelete;
                return;
            }

            if (patIdResDelete.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patIdResDelete.Clear();
                this.ActiveControl = patIdResDelete;
                return;
            }

            try
            {
                string SelectIDPW = "select * from patient where id = '" + patIdResDelete.Text.ToString().Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(SelectIDPW, a.Connection());

                MySqlDataReader SelectIDreader = cmd.ExecuteReader();

                if (SelectIDreader.HasRows)
                {
                    SelectIDreader.Close();

                    pRDS = new PatientReservationDeleteSearch(this);
                    pRDS.ShowDialog();
                }
                else
                {
                    SelectIDreader.Close();

                    MessageBox.Show("입력하신 아이디에 해당하는 환자가 없습니다.", "입력한 아이디에 맞는 환자 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patIdResDelete.Clear();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
