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
    public partial class Chap15_Test : Form
    {
        int ibtnClickCount = 0;// 버튼을 클릭한 카운트 담을 변수. 클래스 필드멤버.

        public Chap15_Test()
        {
            InitializeComponent();
        }

        private void btnJudgge_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭한 총 횟수 표현. 
            ++ibtnClickCount;
            txtBtnClickCount.Text = ibtnClickCount.ToString();


            // 1. 숫자 변경 가능한 문자 입력 여부 판단. (TryParse)
            string sVlue = txtInputValue.Text; // 숫자로 변경 할 문자
            int iResult  = 0;                  // 숫자가 변경된 값 변순
            bool bTF     = false;              // 숫자 변경 가능 여부 변수


            // 로직을 실행 할 조건 이 참일 경우 에 풀어낸 코딩. 
            // 아래 코딩은 if 분기문 안에 또다른 조건 이 참일 경우에만 
            // 실행되는 로직을 구현한 코딩 이므로 비 효율적.
            //bTF = int.TryParse(sVlue, out iResult);
            //if (bTF == true)
            //{
            //    // 1 이상이고, 100 이하
            //    if (iResult >= 1 || iResult <= 100)
            //    {

            //        // 2,5 공배수 \
            //        // 8배수
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("숫자로 변경 할 수 없는 값을 입력하였습니다.");
            //    return;
            //}

            // 로직 상 걸러내고 시작해야 하는 필수 체크 사항을
            // 먼저 검출하고 로직을 구현!

            // 1. 입력한 문자가 숫자로 바뀔수 있는 문자인지.
            bTF = int.TryParse(sVlue, out iResult);
            if (bTF == false)
            {
                MessageBox.Show("숫자로 변경 할 수 없는 값을 입력하였습니다.");
                return;
            }

            // 2. 입력 받은 값이 1부터 100 사이의 수인지.
            if (iResult < 1 || iResult > 100)
            {
                MessageBox.Show("1 부터 100 사이의 수를 입력하세요. ");
                return;
            }

            // 정상적인 로직 구현. 
            // 3. 2 와 5의 공배수 인지 판단. 

            if (iResult % 2 == 0 && iResult % 5 == 0)
            {
                MessageBox.Show("2 와 5 의 공배수 입니다.");
            }
            else
            {
                MessageBox.Show("2 와 5 의 공배수  가 아닙니다.");
            }

            // 8의 배수인지 확인하는 메서드를 호출. 
            FindE(iResult);
        }

        // 8의 배수인지 확인하는 메서드 . 
        void FindE(int iValue)
        {
            if (iValue % 8 == 0)
            {
                txtMultiE.Text = Convert.ToString(iValue * 8);
            }
            else
            {
                txtMultiE.Text = "";
            }
        }
    }
}
