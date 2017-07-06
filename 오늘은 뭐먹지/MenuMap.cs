using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 오늘은_뭐먹지
{
    public partial class MenuMap : Form
    {
        public MenuMap()
        {
            InitializeComponent();
        }

        private void btn_zoomIn_Click(object sender, EventArgs e)
        {
            // HTML 문서 객체를 찾아와
            HtmlDocument doc = webBrowser1.Document;
            // zoomIn 속성을 건드려 지도를 확대 시킴.
            doc.InvokeScript("zoomIn");
        }

        private void btn_zoomOut_Click(object sender, EventArgs e)
        {
            // HTML 문서 객체를 찾아와
            HtmlDocument doc = webBrowser1.Document;
            // zoomIn 속성을 건드려 지도를 축소 시킴.
            doc.InvokeScript("zoomOut");
        }

        private void btn_updatemap_Click(object sender, EventArgs e)
        {
            // 리스트 뷰 하위 항목 아이템 모두 제거
            listView_map.Items.Clear();

            try
            {
                // 데이터 베이스에서 전체 식당 메뉴를 가져온다.
                List<string> MenuList = MyDB.SelectAllMenu();

                // 반환된 전체 값을 반복
                foreach (string emt in MenuList)
                {
                    // 가져온 요소를 토큰링 해줌
                    string[] token = emt.Split('#');

                    // 리스트뷰의 하위 항목의 아이템에 각각 컬럼에 담는다.
                    ListViewItem item1 = new ListViewItem(token[0].Trim());
                    item1.SubItems.Add(token[1].Trim());                    // 2번째 컬럼
                    item1.SubItems.Add(token[2].Trim());                    // 3번째 컬럼
                    item1.SubItems.Add(token[3].Trim());                    // 4번째 컬럼
                    item1.SubItems.Add(token[4].Trim());                    // 5번째 컬럼
                    item1.SubItems.Add(token[5].Trim());                    // 6번째 컬럼
                    item1.SubItems.Add(token[6].Trim());                    // 7번째 컬럼
                    listView_map.Items.Add(item1);                          // 리스트 뷰의 하나의 하위항목 아이템으로 추가
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void MenuMap_Load(object sender, EventArgs e)
        {
            // Noname3.html 라는 문서를 url을 가져옴
            string url = Environment.CurrentDirectory + "\\Noname3.html";
            // 해당 문서로 로딩
            this.webBrowser1.Navigate(url);
        }

        private void listView_map_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                // 클릭한 마우스의 좌표 값 X, Y를 토대로 어떤 아이템이 선택되었는지 식별
                ListViewItem selection = listView_map.GetItemAt(e.X, e.Y);

                // 빈 문자열로 초기화 하여 에러를 방지함.
                string strX = string.Empty;
                string strY = string.Empty;
                string name = string.Empty;

                // 식별된 아이템의컬럼 값을 추출 즉, 좌표 값 X, Y 값을 추출
                strX = selection.SubItems[5].Text;
                strY = selection.SubItems[6].Text;

                // 식당명과 메뉴 명을 하나의 문자열에 포맷하여 담는다.
                name = string.Format(selection.SubItems[1].Text.Trim() + " , " + selection.SubItems[3].Text.Trim());

                // HTML 문서와 연결 시킬 object 객체 생성
                object[] objArray1 = new object[2];
                object[] objArray2 = new object[3];

                // 좌표 값을 소수 값으로 파싱하여 담음.
                objArray1[0] = float.Parse(strX);
                objArray1[1] = float.Parse(strY);

                // 식당명과, 메뉴명이 담긴 하나의 변수로 초기화 하고 좌표 값을 담는다.
                objArray2[0] = name;
                objArray2[1] = float.Parse(strX);
                objArray2[2] = float.Parse(strY);

                // 웹브라우저 객체의 Document를 doc 객체에 저장
                HtmlDocument doc = webBrowser1.Document;


                // HTML 문서에서 MoveToMap 과 InfoWindow 속성을 찾아 식당명, 메뉴명, 좌표 값이 담긴 object 객체를 찾아 동적으로 변형
                doc.InvokeScript("MoveToMap", objArray1);
                doc.InvokeScript("InfoWindow", objArray2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void cb_satelite_CheckedChanged(object sender, EventArgs e)
        {
            // 해당 속성이 체크 되었으면
            if (cb_satelite.CheckState.ToString() == "Checked")
            {
                // HTML 문서 객체를 찾아와
                HtmlDocument doc = webBrowser1.Document;
                // 위성지도로 변경
                doc.InvokeScript("HybridMap");
            }
            else
            {
                // HTML 문서 객체를 찾아와
                HtmlDocument doc = webBrowser1.Document;
                // 일반지도로 변경
                doc.InvokeScript("RoadMap");
            }
        }
    }
}
