using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap03_DataTypeChang : Form
    {
        public Chap03_DataTypeChang()
        {
            InitializeComponent();
            this.Text = "데이터 형변환";
        }



        private void btnChangStoI_Click(object sender, EventArgs e)
        {
            // 숫자 를 문자로 형변환 하는로직 실습. 
            // btnChangStoI.Text = "문자 형변환 실행";

            // 변환 될 대상 숫자 형식 변수 생성.
            // 대입하는 값 = 리터럴.
            int iValue1 = 10;
            int ivalue2 = 20;
            double dValue1 = 10.1;
            double dValue2 = 20.1;

            // 변경되는 문자가 담기는 변수 생성
            string sValue1;
            string sValue2;

            // 1. .ToString() 메서드를 호출하여 변환.
            sValue1 = iValue1.ToString();


            #region [ 변수를 사용하여 변환 로직을 한번만 실행 ]
            // .ToString() 한번만 호출한 결과 값을 변수(sValue2)에 대입후 변수를 하위 
            // 로직에서 재사용 함으로서 .ToString() 호출해야 하는 로직을 줄일수 있다. 
            // sValue2 에 dValue2 를 형변환하여 대입해 보세요.
            sValue2 = dValue2.ToString();

            // 메세지 박스로 변경된 데이터 확인.
            MessageBox.Show(sValue2); 

            sValue1 = sValue2;

            MessageBox.Show(sValue1);
            #endregion




            #region [변환 로직을 두번 실행하여 결과값 표현 리소스 낭비의 예제]
            // 메세지박스를 호출 하되 dValue2(실수) 를 곧바로 표현하는 
            // 로직을 한줄로 구현해 보세요.
            string sValue5 = dValue1.ToString();
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);



            #endregion


            // 2. Convert.ToString() 으로 변환.
            sValue1 = Convert.ToString(iValue1);
            MessageBox.Show(sValue1);

            // 예제) 문자열의 합. 
            MessageBox.Show(sValue2 + sValue1);
        }

        private void btnChangeStoI_Click(object sender, EventArgs e)
        {
            // 문자를 숫자로 변경한다. 

            // 숫자로 바꿀 문자열 변수 생성.
            string sValue1 = "안녕하세요";
            string sValue2 = "10";
            string sValue3 = "10.1";


            // 1. .Parse() 기능으로 변환.

            //int iValue1 = int.Parse(sValue1);  // 오류발생.
            int ivalue2 = int.Parse(sValue2);  //오류 발생하지않음
          
            //int ivalue3 = int.Parse(sValue3);    // Double 형식을 int 형 변환 오류 
            
            //int ivalue4 = double.Parse(sValue3); // Double 형변환 성공하였으나 int 에 담지 못함 오류
            double dValue1 = double.Parse(sValue3);

            // 2. Convert.To***() 로 변경
            int iValue5 = Convert.ToInt32(sValue2);
            double dValue2 = Convert.ToDouble(sValue3);

            //int iValue6 = Convert.ToInt32(sValue3); 

            // Parse() 와 Convert.To***() 를사용하여
            // 문자를 숫자로 변환할때
            // 문법상으로는 오류가 없으나.
            // 프로그램 실행 시 시트템 오류가 발생하므로
            // 숫자로 변환 할 수있는 문자인지 체크(검증)하는 
            // 로직이 필요.

            // 3. 정수/소수 로 변환할 수 있는 문자열인지 
            // 검증하는 기능 .TryParse();


            // "안녕하세요" 문자열을 int 형으로 변환시
            // 변환할수 없는 문자 이므로 iResult 에 0 값을 반환
            // 시스템 오류를 발생 하지 않는다

            int iResult; // 문자가 변환된 정수 값을 받을 변수.
            bool bTorF;  // 정상적으로 변환하였는지 여부를 확인할수있는 변수

            bTorF = int.TryParse(sValue2,out iResult);
            MessageBox.Show(Convert.ToString(iResult));

            sValue1 = "0";
            bTorF = int.TryParse(sValue1, out iResult);
            MessageBox.Show(Convert.ToString(iResult));

            // TryParse() 는 변환의 결과값(int) 과 
            // 성공 또는 실패 의 값 (Bool)
            // 을 동시에 반환하여 
            // 반환 값이 0 이라도 성공/실패 에 의한 
            // 결과 인지 검증 할 수 있다. 



            // "10" 이라는 문자를 정수에 담아서 표현하므로
            // 정상적인값 10 을 확인 할 수 있다. 
            int iResult2;
            int.TryParse(sValue2, out iResult2);
            MessageBox.Show(Convert.ToString(iResult2));

            // "10.1" 이라는 문자 를 소수 형 데이터 타입
            // 에 검증후 대입.
            double dResult1;
            double.TryParse(sValue3, out dResult1);
            MessageBox.Show(Convert.ToString(dResult1));


            
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            // 여러 줄 주석 처리. /*      */
            /*
              - Convert.ToString() 구문은 변수의 값이 null 
                일 경우 빈값으로 반환하는 예외 로직이 
                포함 되어 있다. 
              - .ToString() 보다는 Convert.ToString()
                으로 형변환 하는것을 권장.

              - NULL
                . 데이터의 용량(메모리) 자체가 주어지지 않은
                  이름만 가지고 있는 변수가 생성. 
                . "" 는 빈공백의 데이터가 있는 상태를 말한다.
                . * 숫자형 데이터 는 NULL 값을 가질수 없다.
                  경우에 따라서는 데이터 타입에 ? 키워드를 추가하여
                  NULL 로 처리 할수 있다.
             */

            int? iValue = null;
            string? sValue = null;

            MessageBox.Show(Convert.ToString(sValue));
            MessageBox.Show(sValue.ToString());
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            // 정수 를 + 연산자로 처리할 경우.
            int iValue6 = 10;
            int iValue7 = 20;
            MessageBox.Show(Convert.ToString(iValue6 + iValue7));

            int iValue8 = iValue6 + iValue7;
            MessageBox.Show(Convert.ToString(iValue8));  // 30 이 표현

            // 문자 를 + 연산자로 처리 할 경우.
            string sValue7 = "100";
            string sValue8 = " 입니다.";
            string sVlaue9 = sValue7 + sValue8;
            MessageBox.Show(sVlaue9); // 100 입니다.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parse 를 사용하는 경우.
            
            string Sult  = "1000456454asdasdqwd";
            string Sugar = "1000456454";

            // 3 
            bool SpaComp;

            int SugarPer;
            SpaComp = int.TryParse(Sult, out SugarPer);
            MessageBox.Show(SugarPer.ToString());
        }
    }
}
 