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
    public partial class MainForm : Form
    {
        UserControl currentForm;



        public MainForm()
        {
            InitializeComponent();
        }

        private void ActivateForm()
        {
            panel_main.Controls.Clear();
            panel_main.Controls.Add(currentForm);
        }

        private void dB연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 데이터베이스와 연결된 연결 문자열
                string connectionString = "Server=49.142.209.156;"
                                  + "Database=store;"
                                  + "Uid=root;"
                                  + "Pwd=1234;";

                // MyDB 클래스에 연결 문자열을 통하여 내부적으로 Open()  메서드 호출, 연결 시도
                MyDB.ConnectDB(connectionString);
                
                // 연결이 성공하면 연결 버튼을 비활성화 한다.
                if (MyDB.Scon.State == ConnectionState.Open)
                {
                    MessageBox.Show("MySQL DB 연결 성공");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
         
            }

        }

        private void dB해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyDB.DisconnectDB();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 메뉴추가ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentForm = new InsertForm();
            ActivateForm();
        }

        private void 메뉴평가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new EvalForm();
            ActivateForm();
        }

        private void 오늘의메뉴추천ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 데이터 베이스에서 1주일 식단에 관련된 쿼리를 추출하여 MenuList 변수에 음.
                List<string> MenuList = MyDB.WeekMenu();

                // foreach 구문,  리스트의 끝까지 돈다.
                foreach (string emt in MenuList)
                {
                    // 받아온 MenuList 엘리먼트를 토큰링
                    string[] token = emt.Split('#');

                    string menu = token[0].Trim();  //메뉴
                    string phone = token[1].Trim(); // 전화번호
                    string store = token[2].Trim(); // 식당명
                    string score = token[3].Trim(); // 평점
                    string addr = token[4].Trim();  // 주소

                    // 추출된 엘리먼트의 데이터를 하나의 변수에 담아 메세지 박스로 띄움.
                    string temp = string.Format("메뉴 : {0}\n\n전번:{1}\n\n식당명:{2}\n\n평점:{3}\n\n주소:{4}", menu, phone, store, score, addr);
                    MessageBox.Show(temp, "당첨되었습니다");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 주일식단추천ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentForm = new WeekForm();
            ActivateForm();
        }

        private void 식당위치보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 지도보기를 위한 대화 상자(모달) 객체 생성 및 띄우기
            MenuMap dlg_map = new MenuMap();
            DialogResult dr = dlg_map.ShowDialog();
        }

        private void 개발자정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevInfo dev_info = new DevInfo();
            DialogResult dr = dev_info.ShowDialog();
        }
    }
}
