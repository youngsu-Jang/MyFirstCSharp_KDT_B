using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap14_Method : Form
    {
        // 메서드 (함수) 와 리턴(반환하는 결과) 값 
        // 데이터를 주는값 : 인수, 아규먼트.
        // 데이터를 받는값 : 인자, 매개변수,  파라매터.
        // 아!수주 받자매 파
        // Return : 메서드에서 처리한 어떠한 결과를 메서드를 호출한 부분으로 넘겨주는 기능.
        //          메서드를 종료하라는 의미가 아니고 
        //          여기까지만 하고 반환값을 호출한곳으로 돌려준다. 
        // ref , Out , In : 매개변수, 한정자. 


        string asValue111;
        public Chap14_Method()
        {
            InitializeComponent(); 
        }

        #region < 기본 메서드 호출 >


        private void btnMethodCall_Click(object sender, EventArgs e)
        {
            ShowMessage(); 
        }

        void ShowMessage()
        {
            MessageBox.Show("안녕하세요");
            txtTtile.Text = "안녕하세요";
            lblTitle.Text = "안녕하세요"; 
        }
        #endregion

        #region < 인수와 인자 값을 통한 함수의 호출 >
        void btnArg_Par_Click(object sender, EventArgs e)
        {
           //  인수 값을 전달 하고 전달된 값을 인자로 처리하는 메서드 유형.

            int iValue = 234234;

            // sValue 라는 변수의 값을 인수값으로 던져준다.
            ShowMessage2(iValue); // sMessage = sValue;
        }

        
        void ShowMessage2(int iMessage )
        {
            MessageBox.Show(Convert.ToString(iMessage));
            //txtTitle.Text = Convert.ToString(iMessage);
            lblTitle.Text = Convert.ToString(iMessage);
        }

        #endregion

        #region < 아무 값을 반환하지 않는 리턴 >
        private void btnVoidReturn_Click(object sender, EventArgs e)
        {
            ShowMessage3("버튼 3번째 입니다");
        }

        private void ShowMessage3(string sMessage)
        {
            MessageBox.Show(sMessage);
            txtTtile.Text = sMessage;
            return; // 함수(메서드) 의 종료 구문 처럼 보이지만 반환할 값이 없는 상태로
                    // 호출한 곳으로 결과값을 보내주는 구문.
                    //  - 아무런 결과값을 가지지 않고 호출한 곳으로 돌아가라
            lblTitle.Text = sMessage;

        }



        #endregion

        #region < String 값을 반환하는 리턴 >

        private void btnStringReturn_Click(object sender, EventArgs e)
        {
            string sResult = ShowMessage4("안녕하세요.");
            MessageBox.Show(sResult);
        }
        


        private string ShowMessage4(string sMessage) 
        {
            MessageBox.Show(sMessage);
            return "성공";
        }
        #endregion

        #region < Int 값을 반환하는 리턴 > 

        private void btnIntReturn_Click(object sender, EventArgs e)
        {
            int iValue1 = 15;
            int iValue2 = 25;

            int iResult = IntSum(iValue2, iValue1);
            MessageBox.Show(Convert.ToString(iResult));

          

        }

        int IntSum(int iValue1, int iValue2)
        {
            // iValue1 = 25;
            // *************************************
            // 인수와 인자 의 변수 이름이 같다고 하더라도
            // 주고 받는 위치에 따라 값이 대입 된다.
            return iValue1 + iValue2;
        }
        #endregion

        #region < 인자가 기본값을 가지는 함수의 결과를 반환하는 리턴 메서드 (선택적 인수) > 
        private void btnDefaultReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(IntSum2(10,20)));
        }

        private int IntSum2(int iValue1, int ivalue2 = 20, int iValue3 = 40)
        {
            // 인자 int ivalue2 에 20을 기본값으로 대입한 메서드 인경우
            // IntSum2 을 호출 하는 부분에는 ivalue2 이 들어갈 인수값을 등록하지 않아도 된다. 
            return iValue1 + ivalue2 + iValue3;

            // 인자값에 기본값을 설정 할 경우 
            // 중간 에 있는 인자에 만 기본값을 설정 할 수 없다. 
            // 마지막 인자는 반드시 기본값 설정하는 인자여야만 한다. 
        }
        #endregion

        #region < 클래스를 인수로 전달 하는 경우, 간단한 게임 >
        private void btnCatch1_Click(object sender, EventArgs e)
        {
            CatchGameMethod(btnCatch1,btnCatch2);
        }
        private void btnCatch2_Click(object sender, EventArgs e)
        {
            CatchGameMethod(btnCatch2, btnCatch1);
        }
        private void CatchGameMethod(Button btn_Catch1, Button btn_Catch2)
        {
            btn_Catch1.Text = "";
            btn_Catch2.Text = "나 잡아 봐라~";
        }
        #endregion

        #region < 인수를 배열로 전달하는 경우 > 

        private void btnArrayArg_Click(object sender, EventArgs e)
        {
            string[] ArrayString = { "안녕하세요.", "반갑습니다.", "C#프로그래밍" };
            ShowMessage6(ArrayString);
        }

        private void ShowMessage6(string[] sArrayString)
        {
            MessageBox.Show(sArrayString[0]);
            txtTtile.Text = sArrayString[1];
            lblTitle.Text = sArrayString[2];
        }
        #endregion


        #region < 배열을 리턴 하는 경우 > 
        private void btnArrayReturn_Click(object sender, EventArgs e)
        {
            // 1. 배열 인자 생성. 
            int[] iArray = { 10, 20 };
            // 2. 메소드 호출.
            iArray = IntSum3(iArray);
            MessageBox.Show($"[0] : {iArray[0]} , [1] : {iArray[1]} ");
        }

        private int[] IntSum3(int[] iArray)
        {
            // 배열 인수를 일정한 값과 합하는 메서드.
            int[] iSumInt = { 5, 10 };
            iSumInt[0] = iSumInt[0] + iArray[0];
            iSumInt[1] += iArray[1];
            return iSumInt; 
        }
        #endregion

        #region < 다른 클래스의 함수 호출 >
        private void btnCalssMCall_Click(object sender, EventArgs e)
        {
            // New_Class 를 객체화(인스턴스)
            New_Class newClass = new New_Class();
            //MessageBox.Show(newClass.IntSum(40).ToString());

            New_Class.IntSum2(10, 20);
        }
        #endregion


        #region < Ref 인자 반환(값 참조), Read/Write > 
        private void btnRef_Click(object sender, EventArgs e)
        {
            int iA_Value    = 13;
            int iA_ValueRef = 20;

            // 13, 20, 20, 13 , 13, 13
            MessageBox.Show($"인수     iA_Value    의 값은 : {iA_Value}");     // 1 번째
            MessageBox.Show($"Ref 인수 iA_ValueRef 의 값은 : {iA_ValueRef}");  // 2 번째

            RefMethod(iA_Value, ref iA_ValueRef);

            MessageBox.Show($"iA_Value    의 값은 : {iA_Value}");      // 5 번째
            MessageBox.Show($"iA_ValueRef 의 값은 : {iA_ValueRef}");   // 6 번째
        }

        private void RefMethod(int iP_Value, ref int iP_ValueRef)
        {
            MessageBox.Show($"Ref 인자 iP_ValueRef 의 값은 : {iP_ValueRef}");  // 3 번째
            iP_ValueRef = iP_Value;
            iP_Value    = 10;
            MessageBox.Show($"Ref 인자 iP_ValueRef 의 값은 : {iP_ValueRef}");  // 4 번째
        }

        #endregion
    }

    class New_Class
    {
        // 수를 더하는 New_Class Method
        public int IntSum(int iValue1, int iValue2 = 20)
        {
            return iValue1 + iValue2;
        }


        // 모든 클래스에서 사용할 수 있는
        // 메모리에 상주(정적) 머물러 있는 
        // 정수 결과 반환 타입의 
        // IntSum2 라는 메서드를 만들고
        // 인자 값으로는 int 형 데이터타입을 두개 받는 메서드.
        public static int IntSum2(int iValue, int iValue2)
        {

            return iValue + iValue2;
        }
    }

}
