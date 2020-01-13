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
    public partial class depRank : Form
    {
        public manage dR_mng;

        dba a = new dba();

        public depRank(manage _dR_mng)
        {
            InitializeComponent();

            this.dR_mng = _dR_mng;
        }

        private void depRank_Load(object sender, EventArgs e)
        {
            try
            {
                string drop_view_if_exists = "drop view if exists deptRank";
                MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
                drop_view_if_exists_cmd.ExecuteNonQuery();

                string create_view = "create view deptRank as " +
                    "select c.name 'deptName', count(*) 'deptCount' from reservation a " +
                    "inner join doctor b on a.doctorid = b.id " +
                    "inner join dept c on b.deptcode = c.code group by c.code";
                MySqlCommand create_view_cmd = new MySqlCommand(create_view, a.Connection());
                create_view_cmd.ExecuteNonQuery();


                string innerjoinsub = "select a.name, ifnull((select deptCount from deptRank where deptName = a.name), 0) 'totalCount' from dept a order by totalCount desc";

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(innerjoinsub, a.Connection());

                DataSet ds = new DataSet();

                mysqldataadapter.Fill(ds);

                DataGridViewTextBoxColumn makeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();

                makeColumn.DataPropertyName = "name";
                makeColumn.HeaderText = "진료과";
                deptRankGridView.Columns.Add(makeColumn);

                makeColumn2.DataPropertyName = "totalCount";
                makeColumn2.HeaderText = "지금까지 예약된 수";
                deptRankGridView.Columns.Add(makeColumn2);

                deptRankGridView.AllowUserToAddRows = false;
                deptRankGridView.AllowUserToDeleteRows = false;
                deptRankGridView.ReadOnly = true;

                deptRankGridView.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void depRank_FormClosed(object sender, FormClosedEventArgs e)
        {
            string drop_view_if_exists = "drop view if exists deptRank";
            MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
            drop_view_if_exists_cmd.ExecuteNonQuery();
        }

        private void deptRankGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string NumberingText = (e.RowIndex + 1).ToString();

                // 글자 사이즈 구하기.
                SizeF stringSize = e.Graphics.MeasureString(NumberingText, Font);

                // 글자에 맞춰 좌표계산. 
                PointF StringPoint = new PointF
                (
                    Convert.ToSingle(deptRankGridView.RowHeadersWidth - 3 - stringSize.Width),
                    Convert.ToSingle(e.RowBounds.Y) + deptRankGridView[0, e.RowIndex].ContentBounds.Height * 0.3f
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
