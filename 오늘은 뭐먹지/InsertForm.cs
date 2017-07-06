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
    public partial class InsertForm : UserControl
    {
        public InsertForm()
        {
            InitializeComponent();
            comboBox_category.SelectedIndex = 0;
        }

        private void button_dlgInsertOK_Click(object sender, EventArgs e)
        {
            // 메뉴 추가에 사용될 변수 목록
            string menu = string.Empty;
            string phone = string.Empty;
            string store = string.Empty;
            string add = string.Empty;
            int price;
            string category = string.Empty;

            try
            {
                // 대화상자에서 OK를 반환했을 경우

                // 텍스트 박스 컴포넌트의 Text 속성으로 입력된 스트링 값을 받아옴.
                menu = textBox_menu.Text;
                phone = textBox_phone.Text;
                store = textBox_store.Text;
                add = textBox_add.Text;
                price = Convert.ToInt32(textBox_price.Text);
                category = comboBox_category.SelectedItem.ToString();


                // MyDB 클래스에 정의된 정적 함수 InsertMenu 호출하여 처리 된 행 수 반환 ( 정상 값 : 1)
                if (MyDB.InsertMenu(menu, phone, store, add, price, category))
                {
                    MessageBox.Show("추가되었습니다");
                }
                else
                {
                    MessageBox.Show("추가에 실패하였습니다.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "에러");
            }
        }

        private void button_dlgInsertCANCEL_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // 메뉴 추가를 위한 검색 대화 상자 생성 및 띄우기
            MenuSearch dlg_search = new MenuSearch();
            DialogResult dr = dlg_search.ShowDialog();


            // OK 이벤트가 반환 되었을 때
            if (dr == DialogResult.OK)
            {
                // 검색 대화 상자에서 가져온 식당명, 전화번호, 주소 변수 값을 가져옴
                textBox_phone.Text = dlg_search.Lv_phone;
                textBox_store.Text = dlg_search.Lv_title;
                textBox_add.Text = dlg_search.Lv_add;
            }
            else
            {
                MessageBox.Show("선택된 것이 없습니다.");
            }
        }
    }
}
