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
    public partial class WeekForm : UserControl
    {
        public WeekForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView_week.Items.Clear();

            // 데이터베이스에서 1주일 메뉴와 관련된 값을 추출 
            List<string> MenuList = MyDB.WeekMenu(1);

            // List 객체의 전체 데이터를 순회
            foreach (string emt in MenuList)
            {
                // 가져온 데이터를 토큰링
                string[] token = emt.Split('#');

                ListViewItem item1 = new ListViewItem(token[0].Trim()); // MENU
                item1.SubItems.Add(token[1].Trim()); // PHONE
                item1.SubItems.Add(token[2].Trim()); // STORE
                item1.SubItems.Add(token[3].Trim()); // AVERAGE SCORE
                item1.SubItems.Add(token[4].Trim()); // ADDRESS
                // 리스트 뷰의 하위 항목으로 추가
                listView_week.Items.Add(item1);
            }
        }
    }
}
