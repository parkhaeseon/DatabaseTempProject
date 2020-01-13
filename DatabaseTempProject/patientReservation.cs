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
    public partial class patientReservation : Form
    {
        public manage pRmng;
        public findPatientReservation fPR;
        public TimeSelectReservation TSR;
        public possibleDoctorSelect pDS;

        dba a = new dba();


        public patientReservation(manage _pRmng)
        {
            InitializeComponent();

            this.pRmng = _pRmng;
        }

        // 환자 조회 버튼 클릭
        private void patientSelect_Click(object sender, EventArgs e)
        {
            if(patientNameReservation.Text.ToString().Trim() == "")
            {
                MessageBox.Show("이름이 빈 칸입니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.ActiveControl = patientNameReservation;

                return;
            }

            string patSearch = "select * from patient where name = '" + patientNameReservation.Text.ToString().Trim() + "'";

            MySqlCommand patSearch_cmd = new MySqlCommand(patSearch, a.Connection());

            MySqlDataReader patSearch_cmd_reader = patSearch_cmd.ExecuteReader();

            if (!patSearch_cmd_reader.HasRows)
            {
                MessageBox.Show("등록되지 않은 환자입니다.", "해당 정보에 해당하는 환자 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patSearch_cmd_reader.Close();
                return;
            }

            patientNameReservation.ReadOnly = true;

            patSearch_cmd_reader.Close();

            fPR = new findPatientReservation(this);

            fPR.ShowDialog();
        }

        // 날짜 및 시간 버튼 클릭
        private void TimeSelect_Click(object sender, EventArgs e)
        {
            TSR = new TimeSelectReservation(this);

            TSR.ShowDialog();
        }

        // 예약하기 버튼 클릭
        private void goReservation_Click(object sender, EventArgs e)
        {
            if(patientNameReservation.Text.ToString().Trim() == "" || patientIdReservation.Text.ToString().Trim() == "" || 
                timeReser.Text.ToString().Trim() == "" || doctorNameReservation.Text.ToString().Trim() == "" || 
                doctorIdReservation.Text.ToString().Trim() == "")
            {

                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            string nowtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int result = DateTime.Compare(Convert.ToDateTime(timeReser.Text.ToString().Trim()), Convert.ToDateTime(nowtime));

            if(result <= 0)
            {
                MessageBox.Show("과거의 시간을 예약할 수 없습니다.", "해당 시간(과거) 예약 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string patient_reservation_already = "select patientid, starttime from reservation where patientid = '" + patientIdReservation.Text.ToString().Trim()
                + "' and starttime = '" + timeReser.Text.ToString().Trim() + "'";

                MySqlCommand already_reservation = new MySqlCommand(patient_reservation_already, a.Connection());

                MySqlDataReader reader_select_already = already_reservation.ExecuteReader();

                if (reader_select_already.HasRows)
                {
                    MessageBox.Show("이미 해당 시간에 " + patientNameReservation.Text.ToString().Trim() + "님의 예약 내역이 있습니다.", "해당 시간 예약 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader_select_already.Close();
                    return;
                }

                reader_select_already.Close();

                string insertSQL = "insert into reservation values('" + patientIdReservation.Text.ToString().Trim() + "', '"
                    + timeReser.Text.ToString().Trim() + "', '"
                    + doctorIdReservation.Text.ToString().Trim() + "', '"
                    + pRmng.login_main.LoginID + "')";

                MySqlCommand cmd = new MySqlCommand(insertSQL, a.Connection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("해당 환자의 진료 예약이 완료되었습니다.", "진료 예약 완료", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }        
        }

        // 지우기 버튼 클릭
        private void alldelete_Click(object sender, EventArgs e)
        {
            patientNameReservation.Clear();
            patientNameReservation.ReadOnly = false;
            patientIdReservation.Clear();
            timeReser.Clear();
            doctorNameReservation.Clear();
            doctorIdReservation.Clear();
            TimeSelect.Enabled = true;
            this.ActiveControl = patientNameReservation;
        }

        // 진료 가능 의사 조회
        private void possibleDoctor_Click(object sender, EventArgs e)
        {
            if(timeReser.Text.ToString().Trim() == "")
            {
                MessageBox.Show("진료 예약 시간을 먼저 설정하세요.", "진료 예약 시간부터 먼저 선택", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            pDS = new possibleDoctorSelect(this);

            pDS.getTime = timeReser.Text.ToString().Trim();

            pDS.ShowDialog();
        }

        private void reSelect_Click(object sender, EventArgs e)
        {
            TimeSelect.Enabled = true;
            timeReser.Clear();
            doctorNameReservation.Clear();
            doctorIdReservation.Clear();
        }

        // 다시 검색 버튼 클릭
        private void res_pat_Click(object sender, EventArgs e)
        {
            patientNameReservation.Clear();
            patientNameReservation.ReadOnly = false;
            patientIdReservation.Clear();
            this.ActiveControl = patientNameReservation;
        }
    }
}
