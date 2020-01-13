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
    public partial class patientUpdateReservation : Form
    {
        public manage pUR_mng;
        public patResUpdate realpRU;

        dba a = new dba();


        public patientUpdateReservation(manage _pUR_mng)
        {
            InitializeComponent();

            this.pUR_mng = _pUR_mng;

            this.ActiveControl = pId;
        }

        // 해당 환자가 있는지 검색
        private void Entersure_Click(object sender, EventArgs e)
        {        
            if (pId.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = pId;
                return;
            }

            if (!Regex.IsMatch(pId.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(pId.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pId.Clear();
                this.ActiveControl = pId;
                return;
            }

            if (pId.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = pId;
                pId.Clear();
                return;
            }

            try
            {
                string search_patient = "select id from patient where id = '" + pId.Text.ToString().Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(search_patient, a.Connection());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();

                    realpRU = new patResUpdate(this);
                    realpRU.ShowDialog();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("등록되어 있지 않은 환자입니다.", "미등록 환자", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pId.Clear();
                    this.ActiveControl = pId;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
