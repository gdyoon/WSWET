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
    public partial class MiniBrowser : Form
    {
        string link = string.Empty;

        // 생성자를 통해 받아온 링크 값을 토대로
        public MiniBrowser(string link)
        {
            InitializeComponent();
            this.link = link;
        }


        private void MiniBrowser_Load(object sender, EventArgs e)
        {
            // 웹브라우저 컴포넌트 객체의 Navigate 메서드에 첫번째 파라미터로 링크 값을 넣어 브라우저를 띄움.
            this.webBrowser1.Navigate(link);
        }
    }
}
