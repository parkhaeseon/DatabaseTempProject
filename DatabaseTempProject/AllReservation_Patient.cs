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
    public partial class AllReservation_Patient : Form
    {
        public manage ARP_mng;

        dba a = new dba();


        public AllReservation_Patient(manage _ARP_mng)
        {
            InitializeComponent();

            this.ARP_mng = _ARP_mng;
        }

        private void Allreservation_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();

                string selection_day_reservation = "select a.id 'id', a.rrn 'rrn', a.name 'name', b.starttime 'time', d.name 'dept', e.id 'empId', e.name 'empName' from patient a " +
                    "inner join reservation b on a.id = b.patientid " +
                    "inner join doctor c on b.doctorid = c.id " +
                    "inner join dept d on c.deptcode = d.code " +
                    "inner join employee e on e.id = b.empid " +
                    "order by b.starttime";

                MySqlDataAdapter allres_adp = new MySqlDataAdapter(selection_day_reservation, a.Connection());

                DataSet ds = new DataSet();

                allres_adp.Fill(ds);

                List<DataGridViewTextBoxColumn> makeColumn = new List<DataGridViewTextBoxColumn>();

                for (int i = 0; i < 7; i++)
                    makeColumn.Add(new DataGridViewTextBoxColumn());

                string[] cols = { "id", "rrn", "name", "time", "dept", "empId", "empName" };
                string[] kocols = { "환자 아이디", "환자 주민등록번호", "환자 이름", "예약 시간", "진료과", "예약한 행정직원 ID", "예약한 행정직원 이름" };

                for (int i = 0; i < 7; i++)
                {
                    makeColumn[i].DataPropertyName = cols[i].ToString().Trim();
                    makeColumn[i].HeaderText = kocols[i].ToString().Trim();
                    dataGridView3.Columns.Add(makeColumn[i]);
                }

                dataGridView3.AllowUserToAddRows = false;
                dataGridView3.AllowUserToDeleteRows = false;
                dataGridView3.ReadOnly = true;

                dataGridView3.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        string Week(DateTime dt)
        {
            string s = "";

            switch(dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    s = "월요일";
                    break;

                case DayOfWeek.Tuesday:
                    s = "화요일";
                    break;

                case DayOfWeek.Wednesday:
                    s = "수요일";
                    break;

                case DayOfWeek.Thursday:
                    s = "목요일";
                    break;

                case DayOfWeek.Friday:
                    s = "금요일";
                    break;

                case DayOfWeek.Saturday:
                    s = "토요일";
                    break;

                case DayOfWeek.Sunday:
                    s = "일요일";
                    break;
            }

            return s;
        }

        private void DayReservationButton_Click(object sender, EventArgs e)
        {
            string y = monthCalendar2.SelectionStart.Year.ToString();
            string m = monthCalendar2.SelectionStart.Month.ToString();
            string d = monthCalendar2.SelectionStart.Day.ToString();

            string ymd = y + "-" + m + "-" + d;

            string Day = Week(Convert.ToDateTime(ymd));

            if (MessageBox.Show("선택하신 날짜로 예약 현황을 보시겠습니까?" + 
                '\n' + y + "년 " + m + "월 " + d + "일 " + Day, "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();

                string selection_day_reservation = "select a.id 'id', a.rrn 'rrn', a.name 'name', b.starttime 'time', d.name 'dept', e.id 'empId', e.name 'empName' from patient a " +
                    "inner join reservation b on a.id = b.patientid " +
                    "inner join doctor c on b.doctorid = c.id " +
                    "inner join dept d on c.deptcode = d.code " +
                    "inner join employee e on e.id = b.empid " +
                    "where b.starttime between '" + ymd + " 00:00:00' and '" + ymd + " 23:59:59'" +
                    "order by b.starttime";

                MySqlDataAdapter allres_adp = new MySqlDataAdapter(selection_day_reservation, a.Connection());

                DataSet ds = new DataSet();

                allres_adp.Fill(ds);

                List<DataGridViewTextBoxColumn> makeColumn = new List<DataGridViewTextBoxColumn>();

                for (int i = 0; i < 7; i++)
                    makeColumn.Add(new DataGridViewTextBoxColumn());

                string[] cols = { "id", "rrn", "name", "time", "dept", "empId", "empName" };
                string[] kocols = { "환자 아이디", "환자 주민등록번호", "환자 이름", "예약 시간", "진료과", "예약한 행정직원 ID", "예약한 행정직원 이름" };

                for (int i = 0; i < 7; i++)
                {
                    makeColumn[i].DataPropertyName = cols[i].ToString().Trim();
                    makeColumn[i].HeaderText = kocols[i].ToString().Trim();
                    dataGridView3.Columns.Add(makeColumn[i]);
                }

                dataGridView3.AllowUserToAddRows = false;
                dataGridView3.AllowUserToDeleteRows = false;
                dataGridView3.ReadOnly = true;

                dataGridView3.DataSource = ds.Tables[0];
            }
        }
    }
}
