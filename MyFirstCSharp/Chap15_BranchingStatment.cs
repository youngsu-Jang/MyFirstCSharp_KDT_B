using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap15_BranchingStatment : Form
    {
        // 분기문 
        // 프로그램 흐름의 조건에따라 여러갈래로 나누는 흐름제어.
        // 비교연산자 로는 ==, !=, <=, >=, < , > , && , ||

        public Chap15_BranchingStatment()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            // 텍스트박스에 입력한 값이 없을경우. 
            // "아무 값도 없습니다." 메세지 표현
            // 입력 값이 있을경우 해당 값을 메세지로 표현.

            // 1. 텍스트 박스에 입력한 값 변수에 대입. 
            string sTxtValue = txtInput.Text;

            // 기본적인 분기문 원형. 
            if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다.");
            }
            else
            {
                MessageBox.Show(sTxtValue);
            }
        }

        private void btnInIf_Click(object sender, EventArgs e)
        {
            /* 만약에 입력한 값이 1 일때는 "분기문 1 실행" 메세지 
             * 2 일때는 "분기문 2 실행" 메세지 
             * 3 일때는 "분기문 3 실행" 메세지 
             * 값이 없을 경우에는 "아무값도 없습니다." 메세지
             * 1,2,3 이 모두 아닐경우 는 "적절한 분기문이 없습니다." 메세지
             */

            string sTxtValue = txtInput.Text;
            // 분기문 안에 사용되는 분기문 
            if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다.");
            }
            else
            {
                if (sTxtValue == "1")
                {
                    MessageBox.Show("1 번 분기문 실행.");
                }



                if (sTxtValue == "2")
                {
                    MessageBox.Show("2 번 분기문 실행.");
                } 


                if (sTxtValue == "3")
                {
                    MessageBox.Show("3 번 분기문 실행.");
                }
                else
                {
                    MessageBox.Show("적절한분기문이 없습니다.");
                }

                // 마지막의 else 는 3번 분기문의 예외 일 경우 결과로직. 
                // 1 을 입력 했을 경우 
                // 1번 분기문 입니다. 라는 메세지를 표현하는 IF 문 적용
                // 3번이 아니기때문에 Else 구문 적용 
            }
        }

        private void btnElseIf_Click(object sender, EventArgs e)
        {
            // else if 
            // if 문과 다음 if 문을 하나의 흐름으로 만들어준다.
            string sTxtValue = txtInput.Text;

            if (sTxtValue == "")
            {
                MessageBox.Show("아무 값도 없습니다.");
            }    
            else if (sTxtValue == "1")
            {
                MessageBox.Show("분기문 실행");
            }
            else if (sTxtValue == "2")
            {
                MessageBox.Show("분기문 실행");
            }
            else if (sTxtValue == "3")
            {
                MessageBox.Show("3번 분기문 실행");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
        }

        private void btnAndIf_Click(object sender, EventArgs e)
        {
            // AND IF 문 ( && 로 표기 하며 '그리고' 의 역할)
            string sTxtValue = txtInput.Text;

            if (sTxtValue != "1" && sTxtValue == "2" && sTxtValue != "3")
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }
            else if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다.");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }

            // && 연산자는 왼쪽과 오른쪽에 모두 참 일 경우에만 True 로 간주한다. 
        }

        private void btnOrIf_Click(object sender, EventArgs e)
        {
            // Or If 문
            string sTxtValue = txtInput.Text;
            if (sTxtValue == "1" || sTxtValue == "2" || sTxtValue == "3")
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }
            else if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다.");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
            // || (세로줄, 버티컬바) 연산자는 왼쪽과 오른쪽이 어느 하나라도 참 일경우 True
            
        }

        private void btnBoolIf_Click(object sender, EventArgs e)
        {
            // Bool 데이터 변수에 데이터가 담긴 내용으로 비교하는 로직.
            string sTxtValue = txtInput.Text;
            bool bFalg = false; 

            // 첫번째 분기 흐름.
            if (sTxtValue == "1" || sTxtValue == "2" || sTxtValue == "3" )
            {
                bFalg = true;
            }
            else if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다.");
                return;
            }

            // 두번째 분기 흐름.
            if (bFalg)
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }
            else if (sTxtValue != "")
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
            



        }

        private void btnP_MFalg_Click(object sender, EventArgs e)
        {
            int iTxtValue = 0;
            bool bFlaG = false;
            bFlaG = int_.TryParse(txtInput.Text, out iTxtValue);
            if (!bFlaG)
            {
                MessageBox.Show("음수 양수 판단을 할 수 없습니다.");
                return;
            }

            // 음수 양수 로직 처리.
            if (iTxtValue < 0)
            {
                MessageBox.Show("음수 입니다.");
            }

            else if (iTxtValue > 0)
            {
                MessageBox.Show("양수 입니다.");
            } 
            else 
            {
                MessageBox.Show("0 값을 입력하였습니다.");
            }

        }

        private void btnH_JTest_Click(object sender, EventArgs e)
        {
            // 홀/짝 찾기 
            int iTxtValue = 0;
            bool bFlaG = false;
            bFlaG = int_.TryParse(txtInput.Text, out iTxtValue);
            if (!bFlaG)
            {
                MessageBox.Show("숫자로 바꿀수 없는 값입니다.");
                return;
            }


            // 홀 짝 구분 로직.
            if (iTxtValue % 2 == 0)
            {
                MessageBox.Show("짝수입니다.");
            }
            else
            {
                MessageBox.Show("홀수입니다.");
            }
        }

        private void btnTernaryOperator_Click(object sender, EventArgs e)
        {
            // 삼항 연산자. 
            // 피연산자의 개수가 3개인 조건부 연산자. 
            // if - else 구문을 한줄로 간단하게 표현 할 수 있기 때문에 인라인 if (In-Line IF) 
            // 문이라고도 한다. 

            int iTxtValue = 0;
            bool bFlaG = false;
            bFlaG = int_.TryParse(txtInput.Text, out iTxtValue);
            if (!bFlaG)
            {
                MessageBox.Show("숫자로 바꿀수 없는 값입니다.");
                return;
            }

            string sResult = string.Empty; // string sResult = "";

            MessageBox.Show((iTxtValue % 2 == 0) ? "짝수입니다." : "홀수입니다.");
            

        }
    }
}
