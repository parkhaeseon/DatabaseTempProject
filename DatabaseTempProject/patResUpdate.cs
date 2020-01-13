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
    public partial class patResUpdate : Form
    {
        public patientUpdateReservation patUR;

        private string Hour = "", Minute = "";
        private string originalTime = "";
        private string Name = "";

        dba a = new dba();

        private bool SelectionCell = false;


        public patResUpdate(patientUpdateReservation _patUR)
        {
            InitializeComponent();
            this.patUR = _patUR;

            string[] p = { "09", "10", "11", "12", "13", "14", "15", "16", "17" };
            timeHour.Items.AddRange(p);
            timeHour.SelectedIndex = 0;

            string[] m = { "00", "20", "40" };
            timeMinute.Items.AddRange(m);
            timeMinute.SelectedIndex = 0;
        }

        private bool Week(DateTime dt)
        {
            bool ret = false;

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    ret = true;
                    break;
                default:
                    ret = false;
                    break;
            }

            return ret;
        }

        // 처음 열릴 때
        private void patResUpdate_Load(object sender, EventArgs e)
        {
            originalTime = "";
            Name = "";

            try
            {
                existRes.DataSource = null;
                existRes.Rows.Clear();
                existRes.Refresh();

                string select_patient_sql = "select a.id, a.rrn, a.name, b.starttime from patient a " +
                    "inner join reservation b on a.id = b.patientid" +
                    " where a.id = '" + patUR.pId.Text.ToString().Trim() + "'";

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(select_patient_sql, a.Connection());

                DataSet ds = new DataSet();

                mysqldataadapter.Fill(ds);

                DataGridViewTextBoxColumn makeColumn1 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn4 = new DataGridViewTextBoxColumn();

                makeColumn1.DataPropertyName = "id";
                makeColumn1.HeaderText = "환자 아이디";
                existRes.Columns.Add(makeColumn1);

                makeColumn2.DataPropertyName = "rrn";
                makeColumn2.HeaderText = "환자 주민등록번호";
                existRes.Columns.Add(makeColumn2);

                makeColumn3.DataPropertyName = "name";
                makeColumn3.HeaderText = "환자 이름";
                existRes.Columns.Add(makeColumn3);

                makeColumn4.DataPropertyName = "starttime";
                makeColumn4.HeaderText = "기존 예약 시간";
                existRes.Columns.Add(makeColumn4);

                existRes.AllowUserToAddRows = false;
                existRes.AllowUserToDeleteRows = false;
                existRes.ReadOnly = true;

                existRes.DataSource = ds.Tables[0];

                existRes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                existRes.ClearSelection();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        // 위의 날짜로 수정하기 버튼 클릭
        private void ResUpdateButton_Click(object sender, EventArgs e)
        {
            string y = monthCalendar2.SelectionStart.Year.ToString();
            string m = monthCalendar2.SelectionStart.Month.ToString();
            string d = monthCalendar2.SelectionStart.Day.ToString();

            if (m.Length == 1) m = "0" + m;
            if (d.Length == 1) d = "0" + d;

            string ymd = y + "-" + m + "-" + d;

            if (Week(Convert.ToDateTime(ymd)))
            {
                MessageBox.Show("선택하신 날짜는 토, 일요일입니다.", "예약 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string holidays_select = "select pholidays from publicholidays where pholidays ='" + ymd + "'";

                MySqlCommand res_select = new MySqlCommand(holidays_select, a.Connection());

                MySqlDataReader reader_select = res_select.ExecuteReader();

                if (reader_select.HasRows)
                {
                    MessageBox.Show("해당 날짜는 공휴일입니다.", "예약 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader_select.Close();
                    return;
                }

                reader_select.Close();

                string reservationTime = ymd + " " + Hour + ":" + Minute + ":" + "00"; // 달력으로 선택한 새로운 예약 시간


                if (MessageBox.Show("선택하신 날짜와 시간으로 예약하시겠습니까?" + '\n' + "전 예약 시간 : " + originalTime + '\n' + "후 예약 시간  : "
                    + reservationTime, "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(!SelectionCell)
                    {
                        MessageBox.Show("왼 쪽에서 변경할 예약 시간을 선택해주세요.", "수정 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    string alreadyPat = "select * from reservation where patientid = '" + patUR.pId.Text.ToString().Trim()
                + "' and starttime = '" + reservationTime + "'";

                    MySqlCommand alRes = new MySqlCommand(alreadyPat, a.Connection());

                    MySqlDataReader Search = alRes.ExecuteReader();

                    if (Search.HasRows)
                    {            
                        while(Search.Read())
                        {
                            MessageBox.Show("이미 해당 시간에 " + Name + "님의 예약 내역이 있습니다.", "해당 시간 예약 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Search.Close();
                            existRes.ClearSelection();
                            SelectionCell = false;
                            return;
                        }
                    }

                    Search.Close();

                    string update_sql = "update reservation set starttime = '" + reservationTime + "', empid =  '" + patUR.pUR_mng.login_main.LoginID + "' where patientid = '" + patUR.pId.Text.ToString().Trim() + "' and starttime = '" + originalTime + "'";

                    MySqlCommand res_update_sql = new MySqlCommand(update_sql, a.Connection());

                    res_update_sql.ExecuteNonQuery();

                    existRes.DataSource = null;
                    existRes.Rows.Clear();
                    existRes.Refresh();

                    string select_patient_sql = "select a.id, a.rrn, a.name, b.starttime from patient a " +
                        "inner join reservation b on a.id = b.patientid" +
                        " where a.id = '" + patUR.pId.Text.ToString().Trim() + "'";

                    MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(select_patient_sql, a.Connection());

                    DataSet ds = new DataSet();

                    mysqldataadapter.Fill(ds);

                    DataGridViewTextBoxColumn makeColumn1 = new DataGridViewTextBoxColumn();
                    DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();
                    DataGridViewTextBoxColumn makeColumn3 = new DataGridViewTextBoxColumn();
                    DataGridViewTextBoxColumn makeColumn4 = new DataGridViewTextBoxColumn();

                    makeColumn1.DataPropertyName = "id";
                    makeColumn1.HeaderText = "환자 아이디";
                    existRes.Columns.Add(makeColumn1);

                    makeColumn2.DataPropertyName = "rrn";
                    makeColumn2.HeaderText = "환자 주민등록번호";
                    existRes.Columns.Add(makeColumn2);

                    makeColumn3.DataPropertyName = "name";
                    makeColumn3.HeaderText = "환자 이름";
                    existRes.Columns.Add(makeColumn3);

                    makeColumn4.DataPropertyName = "starttime";
                    makeColumn4.HeaderText = "기존 예약 시간";
                    existRes.Columns.Add(makeColumn4);

                    existRes.AllowUserToAddRows = false;
                    existRes.AllowUserToDeleteRows = false;
                    existRes.ReadOnly = true;

                    existRes.DataSource = ds.Tables[0];

                    existRes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    existRes.ClearSelection();

                    SelectionCell = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void timeHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hour = timeHour.SelectedItem.ToString();

        }

        private void existRes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DateTime myDate = Convert.ToDateTime(existRes.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());

            originalTime = myDate.ToString("yyyy-MM-dd HH:mm:ss");

            SelectionCell = true;

            Name = existRes.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
        }

        private void timeMinute_SelectedIndexChanged(object sender, EventArgs e)
        {
            Minute = timeMinute.SelectedItem.ToString();
        }
    }
}