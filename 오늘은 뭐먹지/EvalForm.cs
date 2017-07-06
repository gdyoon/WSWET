using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 오늘은_뭐먹지
{
    public partial class EvalForm : UserControl
    {
        private int score = 0;
        private int id = 0;
        string str = string.Empty;

        public EvalForm()
        {
            InitializeComponent();
        }

        private void btn_evalOK_Click(object sender, EventArgs e)
        {
            try
            {
                // 메뉴의 아이디를 바탕으로 점수를 추가한다.
                MyDB.AddScore(id, score);

                MessageBox.Show("평가반영됨");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 리스트 뷰의 하위 항목 아이템들을 모두 제거
            listView_eval.Items.Clear();

            // 데이터 베이스에서 전체 메뉴를 선택한다.
            List<string> MenuList = MyDB.SelectAllMenu();

            // 전체 데이터를 반복문 처리
            foreach (string emt in MenuList)
            {
                // 가져온 데이터를 토큰링 함.
                string[] token = emt.Split('#');

                // 리스트뷰의 하위 항목의 아이템에 각각 컬럼에 담는다.
                ListViewItem item1 = new ListViewItem(token[0].Trim()); // 1번째 컬럼 
                item1.SubItems.Add(token[1].Trim());                    // 2번째 컬럼
                item1.SubItems.Add(token[2].Trim());                    // 3번째 컬럼
                item1.SubItems.Add(token[3].Trim());                    // 4번째 컬럼
                item1.SubItems.Add(token[4].Trim());                    // 5번째 컬럼
                item1.SubItems.Add(token[5].Trim());                    // 6번째 컬럼
                item1.SubItems.Add(token[6].Trim());                    // 7번째 컬럼
                listView_eval.Items.Add(item1);                         // 리스트뷰의 하나의 아이템으로 추가
            }
        }
        #region 라디오 버튼 클릭 이벤트
        // 5점 눌렀을 때
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            score = 5;
        }

        // 4점을 눌렀을 때
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            score = 4;
        }

        // 3점을 눌렀을 때
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            score = 3;
        }

        // 2점을 눌렀을 때
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            score = 2;
        }

        // 1점을 눌렀을 때
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            score = 1;
        }
        #endregion 

        private void listView_eval_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 마우스의 좌표 값 X, Y를 토대로 어떤 아이템이 선택되었는지 식별
            ListViewItem selection = listView_eval.GetItemAt(e.X, e.Y);

            // 식별된 아이템의 1번째 컬럼 값을 추출 즉, 아이디 값을 추출
            str = selection.SubItems[0].Text;
            id = Convert.ToInt32(str);
        }
    }
}
