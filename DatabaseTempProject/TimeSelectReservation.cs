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
    public partial class TimeSelectReservation : Form
    {
        public patientReservation pR_TSR;

        private string Hour = "", Minute = "";

        dba a = new dba();

        public TimeSelectReservation(patientReservation _pR_TSR)
        {
            InitializeComponent();

            this.pR_TSR = _pR_TSR;

            string[] p = {"09", "10", "11", "12", "13", "14", "15", "16", "17"};
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

        private void DateSelect_Click(object sender, EventArgs e)
        {
            string y = monthCalendar1.SelectionStart.Year.ToString();
            string m = monthCalendar1.SelectionStart.Month.ToString();
            string d = monthCalendar1.SelectionStart.Day.ToString();

            string ymd = y + "-" + m + "-" + d;

            if(Week(Convert.ToDateTime(ymd)))
            {
                MessageBox.Show("선택하신 날짜는 토, 일요일입니다.", "예약 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            if (MessageBox.Show("선택하신 날짜와 시간으로 예약하시겠습니까?", "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pR_TSR.TimeSelect.Enabled = false;

                string reservationTime = ymd + " " + Hour + ":" + Minute + ":" + "00";

                pR_TSR.timeReser.Text = reservationTime;

                this.Close();
            }
        }

        private void timeHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hour = timeHour.SelectedItem.ToString();
        }

        private void timeMinute_SelectedIndexChanged(object sender, EventArgs e)
        {
            Minute = timeMinute.SelectedItem.ToString();
        }
    }
}
