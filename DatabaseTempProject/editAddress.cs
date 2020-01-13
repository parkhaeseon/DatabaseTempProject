using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Web;

namespace DatabaseTeamProject
{
    public partial class editAddress : Form
    {
        public empedit edit;

        public editAddress(empedit _edit)
        {
            InitializeComponent();
            this.edit = _edit;
        }

        private void roadaddr_Click(object sender, EventArgs e)
        {
            if (searchRoad.Text.ToString().Trim() == "")
            {
                MessageBox.Show("도로명 주소 칸이 비어있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string getA = "";

                HttpWebRequest rq = (HttpWebRequest)WebRequest.Create
                    (
                    "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdService/retrieveNewAdressAreaCdService/getNewAddressListAreaCd"
                     + "?ServiceKey=FKc%2F3GjDA0yhEFPZh34ABLo09qSe3Fra8BXMDToLmocMBCcwWya7S1BPqV0s4Vk5ZR%2F1fGN%2Bx2bDgpuh1CS5Tg%3D%3D"
                     + "&searchSe=road"
                     + "&srchwrd=" + searchRoad.Text.ToString().Trim()
                    );

                rq.Headers = new WebHeaderCollection();
                rq.Headers.Add("Accept-language", "ko");

                bool bOk = false;

                HttpWebResponse rp = (HttpWebResponse)rq.GetResponse();
                XmlTextReader r = new XmlTextReader(rp.GetResponseStream());

                while (r.Read())
                {
                    if (r.NodeType == XmlNodeType.Element)
                    {
                        if (bOk)
                        {
                            if (r.Name == "lnmAdres")
                            {
                                getA = r.ReadString();
                            }
                        }
                        else
                        {
                            if (r.Name == "successYN")
                            {
                                if (r.ReadString() == "Y") bOk = true; // 검색 성공
                            }
                        }
                    }
                }

                r.Close();
                rp.Close();

                if (getA == "")
                {
                    MessageBox.Show("검색된 결과가 없습니다.", "조회 결과 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchRoad.Text = "";
                    this.ActiveControl = searchRoad;
                    return;
                }

                if (MessageBox.Show("아래의 주소를 사용하시겠습니까?" + '\n' + '\n' + getA, "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    edit.newAddress.Text = getA;
                    edit.newAddress.ReadOnly = true;
                    
                    this.Close();
                }
                else
                {
                    searchRoad.Clear();
                    this.ActiveControl = searchRoad;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
