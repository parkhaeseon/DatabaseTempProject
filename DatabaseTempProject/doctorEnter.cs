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
    public partial class doctorEnter : Form
    {
        public manage doctorMng;
        public doctorEnterAddress dEA;

        private string docGender, docHome = "", docDept;
        private Dictionary<string, string> dic;

        dba a = new dba();

        public doctorEnter(manage _doctorMng)
        {
            InitializeComponent();

            this.doctorMng = _doctorMng;

            // 성별 세팅
            string[] s = { "남", "여" };
            doctorGender.Items.AddRange(s);
            doctorGender.SelectedIndex = 0;

            // 지역번호 세팅
            string[] p = {"02", "051", "053", "032", "062", "042", "052", "044", "031", "033",
            "043", "041", "063", "061", "054", "055", "064"};
            doctorHome.Items.AddRange(p);
            doctorHome.SelectedIndex = 0;

            // 진료과 세팅
            string[] d = { "외과", "내과", "산부인과", "안과", "소아과", "피부과", "이비인후과", "가정의학과"};

            doctorDept.Items.AddRange(d);
            doctorDept.SelectedIndex = 0;

            dic = new Dictionary<string, string>();

            dic.Add("외과", "01");
            dic.Add("내과", "02");
            dic.Add("산부인과", "03");
            dic.Add("안과", "04");
            dic.Add("소아과", "05");
            dic.Add("피부과", "06");
            dic.Add("이비인후과", "07");
            dic.Add("가정의학과", "08");
        }

        // 중복확인 버튼 클릭
        private void dup_Click(object sender, EventArgs e)
        {
            if (doctorId.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = doctorId;
                return;
            }

            if (!Regex.IsMatch(doctorId.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(doctorId.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorId.Clear();
                this.ActiveControl = doctorId;
                return;
            }

            if (doctorId.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = doctorId;
                doctorId.Clear();
                return;
            }

            try
            {
                // 환자 아이디랑 중복되는지 검사
                string patidselect = "select * from patient where id = '" + doctorId.Text.ToString().Trim() + "'";

                MySqlCommand patidselect_cmd = new MySqlCommand(patidselect, a.Connection());

                MySqlDataReader patidselect_cmd_dr = patidselect_cmd.ExecuteReader();

                if (patidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 환자의 아이디입니다." + '\n' +  "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doctorId.Clear();
                    patidselect_cmd_dr.Close();
                    this.ActiveControl = doctorId;
                    return;
                }
                patidselect_cmd_dr.Close();

                // 행정직원 아이디랑 중복인지 검사
                string empidselect = "select * from employee where id = '" + doctorId.Text.ToString().Trim() + "'";

                MySqlCommand empidselect_cmd = new MySqlCommand(empidselect, a.Connection());

                MySqlDataReader empidselect_cmd_dr = empidselect_cmd.ExecuteReader();

                if (empidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 행정직원의 아이디입니다." + '\n' + "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doctorId.Clear();
                    empidselect_cmd_dr.Close();
                    this.ActiveControl = doctorId;
                    return;
                }
                empidselect_cmd_dr.Close();
                
                // 의사 아이디랑 중복인지 검사
                string docidselect = "select * from doctor where id = '" + doctorId.Text.ToString().Trim() + "'";

                MySqlCommand docidselect_cmd = new MySqlCommand(docidselect, a.Connection());

                MySqlDataReader docidselect_cmd_dr = docidselect_cmd.ExecuteReader();

                if (docidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 의사의 아이디입니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doctorId.Clear();
                    docidselect_cmd_dr.Close();
                    this.ActiveControl = doctorId;
                    return;
                }

                MessageBox.Show("사용 가능합니다.", "사용 가능한 아이디", MessageBoxButtons.OK, MessageBoxIcon.Information);

                docidselect_cmd_dr.Close();

                doctorId.ReadOnly = true;

                dup.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        // 직접 입력 버튼 클릭
        private void selfinput_Click(object sender, EventArgs e)
        {
            doctorAddress.ReadOnly = false;
            doctorAddress.Clear();
            this.ActiveControl = doctorAddress;
        }

        private void saddr_Click(object sender, EventArgs e)
        {
            dEA = new doctorEnterAddress(this);

            dEA.ShowDialog();
        }

        private void doctorGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            docGender = doctorGender.SelectedItem.ToString();
        }

        private void doctorHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            docHome = doctorHome.SelectedItem.ToString();
        }

        private void doctorDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            docDept = doctorDept.SelectedItem.ToString().Trim();
        }

        // 재작성 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            doctorId.Clear();
            doctorId.ReadOnly = false;
            this.ActiveControl = doctorId;
            dup.Enabled = true;
        }

        private void alldelete_Click(object sender, EventArgs e)
        {
            doctorId.Clear();
            doctorId.ReadOnly = false;
            doctorRrn.Clear();
            doctorRrn.ReadOnly = false;
            doctorName.Clear();
            doctorAddress.Clear();
            doctorAddress.ReadOnly = false;
            doctorAddress2.Clear();
            doctorPhone.Clear();
            doctorHome2.Clear();

            dup.Enabled = true;

            this.ActiveControl = doctorId;
        }

        // 등록하기 버튼 클릭
        private void Entersure_Click(object sender, EventArgs e)
        {
            if(doctorId.Text.ToString().Trim() == "" || doctorRrn.Text.ToString().Trim() == "" || doctorName.Text.ToString().Trim() == "" || doctorAddress.Text.ToString().Trim() == "" || 
                doctorAddress2.Text.ToString().Trim() == "" || doctorPhone.Text.ToString().Trim() == "" || doctorHome2.Text.ToString().Trim() == "")
            {

                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!Regex.IsMatch(doctorId.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(doctorId.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorId.Clear();
                this.ActiveControl = doctorId;
                return;
            }

            if (doctorId.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorId.Clear();
                this.ActiveControl = doctorId;
                return;
            }

            if (!doctorId.ReadOnly)
            {
                MessageBox.Show("아이디 중복 확인을 해주세요.", "아이디 중복 확인 필수", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = dup;
                return;
            }

            if (!Regex.IsMatch(doctorName.Text.ToString().Trim(), @"[가-힣]{2,5}"))
            {
                MessageBox.Show("이름에 오류가 있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorName.Clear();
                this.ActiveControl = doctorName;
                return;
            }

            if (Regex.IsMatch(doctorName.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("이름에 문자가 포함되어있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorName.Clear();
                this.ActiveControl = doctorName;
                return;
            }

            if(doctorName.Text.ToString().Trim().Length > 5)
            {
                MessageBox.Show("이름이 너무 깁니다. 한글 5자 이하로 입력하세요.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorName.Clear();
                this.ActiveControl = doctorName;
                return;
            }

            if (Regex.IsMatch(doctorHome2.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("집 전화번호에 문자가 포함되어있습니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorHome2.Clear();
                this.ActiveControl = doctorHome2;
                return;
            }

            if (Regex.IsMatch(doctorHome2.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("집 전화번호에 문자가 포함되어있습니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorHome2.Clear();
                this.ActiveControl = doctorHome2;
                return;
            }

            if (doctorHome2.Text.ToString().Trim().Length > 10)
            {
                MessageBox.Show("집 뒷 전화번호가 너무 깁니다." + '\n' + "숫자 10개 이하만 가능합니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorHome2.Clear();
                this.ActiveControl = doctorHome2;
                return;
            }

            if (Regex.IsMatch(doctorPhone.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("핸드폰 번호에 문자가 포함되어있습니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorPhone.Clear();
                this.ActiveControl = doctorPhone;
                return;
            }

            if (!Regex.IsMatch(doctorPhone.Text.ToString().Trim(), @"^\d{11}$"))
            {
                MessageBox.Show("핸드폰 번호는 숫자로 총 11자리입니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorPhone.Clear();
                this.ActiveControl = doctorPhone;
                return;
            }

            if (!Regex.IsMatch(doctorRrn.Text.ToString().Trim(), @"^\d{13}$"))
            {
                MessageBox.Show("주민등록번호 형식이 올바르지 않습니다.", "주민등록번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doctorRrn.Clear();
                this.ActiveControl = doctorRrn;
                return;
            }

            try
            {
                string s = doctorRrn.Text.ToString().Trim();

                if (s[6] == '1')
                {
                    if (docGender == "여")
                    {
                        MessageBox.Show("주민등록번호와 성별 중 잘못된 부분이 있습니다.", "주민등록번호와 성별 중 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (s[6] == '2')
                {
                    if (docGender == "남")
                    {
                        MessageBox.Show("주민등록번호와 성별 중 잘못된 부분이 있습니다.", "주민등록번호와 성별 중 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 환자 주민등록번호 검사
                string patselect = "select * from patient where rrn = '" + doctorRrn.Text.ToString().Trim() + "'";

                MySqlCommand patcmd = new MySqlCommand(patselect, a.Connection());

                MySqlDataReader patrd = patcmd.ExecuteReader();

                if (patrd.HasRows)
                {
                    MessageBox.Show("이미 가입된 환자의 주민등록번호입니다.", "가입 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doctorRrn.Clear();
                    patrd.Close();
                    this.ActiveControl = doctorRrn;
                    return;
                }
                patrd.Close();


                // 행정직원 주민등록번호 검사
                string rrn_select = "select * from employee where rrn = '" + doctorRrn.Text.ToString().Trim() + "'";

                MySqlCommand res_select = new MySqlCommand(rrn_select, a.Connection());

                MySqlDataReader reader_select = res_select.ExecuteReader();

                if (reader_select.HasRows)
                {
                    MessageBox.Show("이미 가입된 행정직원 주민등록번호입니다.", "가입 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doctorRrn.Clear();
                    this.ActiveControl = doctorRrn;
                    reader_select.Close();
                    return;
                }

                reader_select.Close();

                // 의사 주민등록번호 검사
                string docrrnselect = "select * from doctor where rrn = '" + doctorRrn.Text.ToString().Trim() + "'";

                MySqlCommand docrrnselect_cmd = new MySqlCommand(docrrnselect, a.Connection());

                MySqlDataReader docrrnselect_cmd_dr = docrrnselect_cmd.ExecuteReader();

                if (docrrnselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 의사의 주민등록번호입니다.", "이미 가입된 주민등록번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doctorRrn.Clear();
                    docrrnselect_cmd_dr.Close();
                    this.ActiveControl = doctorRrn;
                    return;
                }
                docrrnselect_cmd_dr.Close();

                if(doctorHome2.Text.ToString().Trim().Length < 5)
                {
                    MessageBox.Show("전화번호 뒷 자리가 너무 짧습니다.", "전화번호 뒷 자리 짧음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = doctorHome2;
                    return;
                }

                string get = doctorHome2.Text.ToString().Trim().Substring(0, docHome.Length);

                if (get == docHome)
                {
                    MessageBox.Show("전화번호 뒷 자리에 지역 번호가 포함되어있습니다.", "전화번호 뒷 자리에 지역 번호 포함", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = doctorHome2;
                    return;
                }

                docHome += doctorHome2.Text.ToString().Trim();
                docDept = dic[docDept];

                string insertSQL = "insert into doctor values('"
                    + doctorId.Text.ToString().Trim() + "', '"
                    + doctorRrn.Text.ToString().Trim() + "', '"
                    + doctorName.Text.ToString().Trim() + "', '"
                    + docGender + "', '"
                    + doctorAddress.Text.ToString().Trim() + " " + doctorAddress2.Text.ToString().Trim() + "', '"
                    + doctorPhone.Text.ToString().Trim() + "', '"
                    + docHome + "', '"
                    + docDept + "')";

                MySqlCommand cmd = new MySqlCommand(insertSQL, a.Connection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("의사 등록이 완료되었습니다.", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Close();
            }
            catch (Exception Test)
            {
                docHome = doctorHome.SelectedItem.ToString();
                MessageBox.Show(Test.ToString());
            }
        }
    }
}
