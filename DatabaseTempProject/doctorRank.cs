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
    public partial class doctorRank : Form
    {
        public manage doctorRank_mng;

        dba a = new dba();

        public doctorRank(manage _doctorRank_mng)
        {
            InitializeComponent();

            this.doctorRank_mng = _doctorRank_mng;
        }

        // 열릴 때
        private void doctorRank_Load(object sender, EventArgs e)
        {
            try
            {
                string drop_view_if_exists = "drop view if exists doctorRank";
                MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
                drop_view_if_exists_cmd.ExecuteNonQuery();


                string create_view = "create view doctorRank as " +
                    "select b.rrn 'rrn', b.name 'name', count(*) 'docResCount' from reservation a " +
                    "inner join doctor b " +
                    "on a.doctorid = b.id " +
                    "group by a.doctorid " +
                    "order by docResCount desc";
                MySqlCommand create_view_cmd = new MySqlCommand(create_view, a.Connection());
                create_view_cmd.ExecuteNonQuery();


                string innerjoinsub = "select a.id, a.name, ifnull((select docResCount from doctorRank where Name = a.name), 0) 'totalCount' from doctor a order by totalCount desc";

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(innerjoinsub, a.Connection());

                DataSet ds = new DataSet();

                mysqldataadapter.Fill(ds);

                DataGridViewTextBoxColumn makeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn3 = new DataGridViewTextBoxColumn();

                makeColumn.DataPropertyName = "id";
                makeColumn.HeaderText = "의사 아이디";
                doctorRankGridView.Columns.Add(makeColumn);

                makeColumn2.DataPropertyName = "name";
                makeColumn2.HeaderText = "의사 이름";
                doctorRankGridView.Columns.Add(makeColumn2);

                makeColumn3.DataPropertyName = "totalCount";
                makeColumn3.HeaderText = "지금까지 예약된 수";
                doctorRankGridView.Columns.Add(makeColumn3);

                doctorRankGridView.AllowUserToAddRows = false;
                doctorRankGridView.AllowUserToDeleteRows = false;
                doctorRankGridView.ReadOnly = true;

                doctorRankGridView.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        // 닫힐 때
        private void doctorRank_FormClosed(object sender, FormClosedEventArgs e)
        {
            string drop_view_if_exists = "drop view if exists doctorRank";
            MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
            drop_view_if_exists_cmd.ExecuteNonQuery();
        }

        private void doctorRankGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string NumberingText = (e.RowIndex + 1).ToString();

                // 글자 사이즈 구하기.
                SizeF stringSize = e.Graphics.MeasureString(NumberingText, Font);

                // 글자에 맞춰 좌표계산. 
                PointF StringPoint = new PointF
                (
                    Convert.ToSingle(doctorRankGridView.RowHeadersWidth - 3 - stringSize.Width),
                    Convert.ToSingle(e.RowBounds.Y) + doctorRankGridView[0, e.RowIndex].ContentBounds.Height * 0.3f
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
