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
    public partial class Chap10_Calss2 : Form
    {
        public Chap10_Calss2()
        {
            InitializeComponent();
        }

        private void btnCalssInstance_Click(object sender, EventArgs e)
        {
            // 클래스의 객체화(인스턴스 화)
            // 클래스 => (객체 = 인스턴스)
            Chap10_Class Chap10 = new Chap10_Class();
            Chap10.sArm = "왼팔";
            MessageBox.Show(Chap10.sArm);

            // Chap10_2 라는 이름으로 Chap10_Class 를 객체화
            Chap10_Class Chap10_2 = new Chap10_Class();
            Chap10_2.sArm = "오른팔";
            MessageBox.Show(Chap10_2.sArm);

        }
    }
}
