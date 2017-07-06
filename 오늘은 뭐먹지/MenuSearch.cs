using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 오늘은_뭐먹지
{
    public partial class MenuSearch : Form
    {
        public string Lv_link = string.Empty;
        public string Lv_title = string.Empty;
        public string Lv_add = string.Empty;
        public string Lv_phone = string.Empty;

        public MenuSearch()
        {
            InitializeComponent();
        }

        // 메뉴 검색 버튼 클릭과 연결된 이벤트 핸들러
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                // 검색 결과 리스트 뷰 하위 항목 아이템 전체 삭제
                this.listView_search.Items.Clear();

                // XmlDocument 객체를 생성
                XmlDocument xdoc = new XmlDocument();

                // 검색창에 입력한 값을 가져옴
                string value = textBox_search.Text;

                // 네이버 Seach API와 연동된 네이버 데이터베이스에 해당 URL 과 검색 값을 보냄
                string query = string.Format("http://openapi.naver.com/search?key=7cc9b23fc633af83efe2b6155dfa8e55&query={0}&target=local&start=1&display=30 ", value);
                //  Xml 문서로 변형된 결과 값을 가져옴
                xdoc.Load(query);

                // rss 태그 단일 노드를 선택
                XmlNode rn = xdoc.SelectSingleNode("rss");
                // 그 밑에 channel 태그 단일 노드를 선택
                XmlNode cn = rn.SelectSingleNode("channel");
                // item 에 연결된 다중 노드 값의 리스트를 반환
                XmlNodeList xnl = cn.SelectNodes("item"); // 개별 검색 결과 얻기

                // 검색 결과들을 받기 위한 XmlNode 객체들
                XmlNode tnode; // title ( 검색 결과 )
                XmlNode Lnode; // link ( 링크 )
                XmlNode phnode; // phone ( 전화번호 )
                XmlNode addnode; // address ( 일반주소 )
                XmlNode roadnode; // roadAddress ( 도로명 주소 )

                ListViewItem item1;

                // 전체 item 다중 노드 값을 탐색
                foreach (XmlNode item_node in xnl)
                {
                    // SelectSingleNode 안에 들어간 파라미터의 키는 네이버 Seach API에서 정의한 약속된 값임. 자세한 사항은 Seach API 참조.
                    tnode = item_node.SelectSingleNode("title");            // title과 연결된 노드 값을 추출
                    Lnode = item_node.SelectSingleNode("link");             // link과 연결된 노드 값을 추출
                    phnode = item_node.SelectSingleNode("telephone");        // telephone과 연결된 노드 값을 추출
                    addnode = item_node.SelectSingleNode("address");         // address과 연결된 노드 값을 추출
                    roadnode = item_node.SelectSingleNode("roadAddress");    // roadAddress과 연결된 노드 값을 추출


                    // 해당 노드들의 InnerText 속성을 통하여 텍스트 값을 추출하여 하위 아이템에 서브 아이템 항목을 추가
                    item1 = new ListViewItem(tnode.InnerText);
                    item1.SubItems.Add(Lnode.InnerText);
                    item1.SubItems.Add(phnode.InnerText);
                    item1.SubItems.Add(addnode.InnerText);
                    item1.SubItems.Add(roadnode.InnerText);
                    // 리스트뷰의 하위 항목 아이템으로 추가
                    listView_search.Items.Add(item1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        // 자세히 보기 버튼 클릭과 연결된 이벤트 핸들러 
        private void btn_connectWeb_Click(object sender, EventArgs e)
        {
            // 클린한 항목의 주소 링크를 가져옴
            string link = Lv_link;
            // 링크를통하여 브라우저를 맵핑
            MiniBrowser mb = new MiniBrowser(link);
            // 브라우저를 띄움
            mb.Show();
        }

        private void listView_search_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 마우스의 좌표 값 X, Y를 토대로 어떤 아이템이 선택되었는지 식별
            ListViewItem selection = listView_search.GetItemAt(e.X, e.Y);
            // 식별된 포인터 위치의 리스트 뷰의 하위 항목에서 값을들 추출
            Lv_title = selection.SubItems[0].Text;
            Lv_link = selection.SubItems[1].Text;
            Lv_phone = selection.SubItems[2].Text;
            Lv_add = selection.SubItems[3].Text;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // OK 이벤트를 반환하고 종료
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // CANCEL 이벤트를 반환하고 종료
            DialogResult = DialogResult.Cancel;
        }
    }
}
