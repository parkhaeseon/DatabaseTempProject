using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace DatabaseTeamProject
{
    public partial class patRank : Form
    {
        public manage pRmng;

        dba a = new dba();

        public patRank(manage _pRmng)
        {
            InitializeComponent();

            this.pRmng = _pRmng;
        }

        
        private void patRank_Load(object sender, EventArgs e)
        {
            try
            {
                string drop_view_if_exists = "drop view if exists patRank";
                MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
                drop_view_if_exists_cmd.ExecuteNonQuery();


                string create_view = "create view patRank as " +
                    "select a.name, b.patientid, count(b.patientid) 'cnt' from patient a " +
                    "inner join reservation b " +
                    "on a.id = b.patientid " +
                    "group by b.patientid " +
                    "order by cnt desc";

                MySqlCommand create_view_cmd = new MySqlCommand(create_view, a.Connection());
                create_view_cmd.ExecuteNonQuery();


                string innerjoinsub = "select a.id, a.name, " +
                    "ifnull((select cnt from patRank where patientid = a.id), 0) 'cnt' from patient a " +
                    "order by cnt desc";

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(innerjoinsub, a.Connection());

                DataSet ds = new DataSet();

                mysqldataadapter.Fill(ds);

                DataGridViewTextBoxColumn makeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn3 = new DataGridViewTextBoxColumn();

                makeColumn.DataPropertyName = "id";
                makeColumn.HeaderText = "환자 아이디";
                patientRankGridView.Columns.Add(makeColumn);

                makeColumn2.DataPropertyName = "name";
                makeColumn2.HeaderText = "환자 이름";
                patientRankGridView.Columns.Add(makeColumn2);

                makeColumn3.DataPropertyName = "cnt";
                makeColumn3.HeaderText = "지금까지 병원 예약 횟수";
                patientRankGridView.Columns.Add(makeColumn3);

                patientRankGridView.AllowUserToAddRows = false;
                patientRankGridView.AllowUserToDeleteRows = false;
                patientRankGridView.ReadOnly = true;

                patientRankGridView.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void patRank_FormClosed(object sender, FormClosedEventArgs e)
        {
            string drop_view_if_exists = "drop view if exists patRank";
            MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
            drop_view_if_exists_cmd.ExecuteNonQuery();
        }

        private void patientRankGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string NumberingText = (e.RowIndex + 1).ToString();

                // 글자 사이즈 구하기.
                SizeF stringSize = e.Graphics.MeasureString(NumberingText, Font);

                // 글자에 맞춰 좌표계산. 
                PointF StringPoint = new PointF
                (
                    Convert.ToSingle(patientRankGridView.RowHeadersWidth - 3 - stringSize.Width),
                    Convert.ToSingle(e.RowBounds.Y) + patientRankGridView[0, e.RowIndex].ContentBounds.Height * 0.3f
                );

                // 문자열 그리기.
                e.Graphics.DrawString
                (
                    NumberingText,
                    Font,
                    Brushes.Black,
                    StringPoint.X,
                    StringPoint.Y
                );
            }
        }
    }
}
