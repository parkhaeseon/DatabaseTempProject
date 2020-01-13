using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DatabaseTeamProject
{
    public partial class manage : Form
    {
        public login login_main;
        public doctorEnter doctorEn;
        public empedit emped;
        public patientReservation pR;
        public doctorDeleteSearch dDS;
        public AllReservation_Patient ARP;
        public patientEnter pE;
        public employeeIDedit empidedit;
        public patientDelete pD;
        public depRank dR;
        public doctorRank docRank;
        public empRank employeeRank;
        public myselfinfo selfinfo;
        public patientReservationDelete patRes;
        public Totalpeople total_people;
        public doctorinformation docsall;
        public patientinformation piall;
        public patientUpdateReservation pUR;
        public onepat op;
        public mypatients myp;
        public doctorEdit dE;
        public pEditSearch pES;
        public patRank pat_rank;

        public manage(login _main)
        {
            InitializeComponent();
            this.login_main = _main;

            empPhoto.Load("emp.png");

            empPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }    

        // 로그아웃 버튼 클릭
        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 로그아웃 하시겠습니까?", "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                login_main.Show();
            }
        }

        private void 아이디만수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empidedit = new employeeIDedit(this);

            empidedit.ShowDialog();
        }

        private void 새환자등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pE = new patientEnter(this);
            pE.ShowDialog();
        }

        private void 새의사등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorEn = new doctorEnter(this);
            doctorEn.ShowDialog();
        }

        private void 의사정보삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dDS = new doctorDeleteSearch(this);
            dDS.ShowDialog();
        }

        private void 환자진료예약ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pR = new patientReservation(this);
            pR.ShowDialog();
        }

        private void 예약현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARP = new AllReservation_Patient(this);

            ARP.ShowDialog();
        }

        private void 나머지정보수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emped = new empedit(this);
            emped.ShowDialog();
        }

        private void 환자정보삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pD = new patientDelete(this);
            pD.ShowDialog();
        }

        private void postClear_Click(object sender, EventArgs e)
        {
            Post.Clear();
        }

        private void 진료과예약순위ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dR = new depRank(this);

            dR.ShowDialog();
        }
           

        private void 의사예약순위ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docRank = new doctorRank(this);
            docRank.ShowDialog();
        }

        private void 행정직원예약순위ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeRank = new empRank(this);
            employeeRank.ShowDialog();
        }

        // 내 정보 보기 클릭
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selfinfo = new myselfinfo(this);
            selfinfo.ShowDialog();
        }

        private void 예약삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patRes = new patientReservationDelete(this);
            patRes.ShowDialog();
        }

        // 총 인원 클릭
        private void Total_Click(object sender, EventArgs e)
        {
            total_people = new Totalpeople(this);
            total_people.ShowDialog();
        }


        // 환자 목록 클릭
        private void seepatient_Click(object sender, EventArgs e)
        {
            piall = new patientinformation(this);
            piall.ShowDialog();
        }

        // 의사 목록 클릭
        private void seedoctors_Click(object sender, EventArgs e)
        {
            docsall = new doctorinformation(this);
            docsall.ShowDialog();
        }
   
        private void 예약수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pUR = new patientUpdateReservation(this);

            pUR.ShowDialog();
        }

        private void 내가예약한환자들목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            myp = new mypatients(this);
            myp.ShowDialog();
        }

        // 특정 환자 예약 검색
        private void 특정환자예약내역검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = new onepat(this);
            op.ShowDialog();
        }

        // 의사 정보 수정
        private void doctorEdit_Click(object sender, EventArgs e)
        {
            dE = new doctorEdit(this);

            dE.ShowDialog();
        }

        // 환자 정보 수정
        private void patientEdit_Click(object sender, EventArgs e)
        {
            pES = new pEditSearch(this);

            pES.ShowDialog();

        }

        // 환자 예약 횟수
        private void patientRank_Click(object sender, EventArgs e)
        {
            pat_rank = new patRank(this);
            pat_rank.ShowDialog();
        }
    }
}
