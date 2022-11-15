using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap08_Test : Form
    {
        string sTitle; 
        public Chap08_Test()
        {
            InitializeComponent();
            sTitle = label1.Text;
        }

        private void btnNameChang_Click(object sender, EventArgs e)
        {
            // 한줄로 표현하는 로직을 구현 해 보세요.
            label1.Text = label1.Text.Replace("OOO", "동상현");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // S/W 위치 찾기
            int iIndex = label1.Text.IndexOf("S/W");
            MessageBox.Show(iIndex.ToString());

            // 한줄로 표현 해 보세요.
            MessageBox.Show(Convert.ToString(label1.Text.IndexOf("S/W")));
        }

        private void btnInsertKDT_Click(object sender, EventArgs e)
        {
            label1.Text = $"-KDT-{label1.Text}-KDT-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // SMARTFACTORY 만 소문자로 변경

            // 1. 처리할 문자열 (타이틀)
            string sTitle = label1.Text;

            // 2. 변경해야 할 문자 ? 
            string sValue = "SMARTFACTORY";
            
            // 3. SMARTFACTORY 문구가 있는 위치(주소) 찾기.
            int iIndex = sTitle.IndexOf(sValue);

            // 4. 라벨 타이틀 에서 SMARTFACTORY 문구를 삭제.
            string sResult = sTitle.Remove(iIndex, sValue.Length);

            // 5. 대문자를 소문자로 변경.
            sValue = sValue.ToLower();

            // 6. 소문자 삽입 후 Text 표현. 
            label1.Text = sResult.Insert(iIndex, sValue);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 모든 공백 없애기.
            label1.Text = label1.Text.Replace(" ", "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 문자열 되돌리기.
            label1.Text = sTitle;
        }
    }
}
