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
    /*
     Static 한정자 
        - 프로그램 전체에서 유기적으로 관리해야 하는 값이 발생할 경우
          객체의 생성 없이 클래스 내의 필드값 을 직접적으로 관리 할 수 있음.
          클래스에 머물러 있는 필드나 메서드 라는 의미에서 정적필드, 정적메서드
          라고도 불림.
        - 최초 초기화(최초로 값이 대입 또는 호출, 메서드가 실행될때 ) 
          메모리에 등록되어 프로그램이 종료 될때까지 메모리에 상주한다. 
          불필요하게 사용할 경우 메모리 효율을 떨어트릴수 있으므로 사용상 고려 가 필요
     
     Const 상수 (변하지 않는값)
        - 최초 값 대입후 추가로 값을 대입 시 오류가 발생하여 
          여러 개발자가 동시에 작업을 할 경우 또는 코딩의 길이가
          길어져서 변수에 대한 정의 가 모호해 질 경우 
          데이터가 변질 될 수 있는 오류를 방지 할 수 있다. 


    */

    public partial class Chap13_Static_Const : Form
    {
        public Chap13_Static_Const()
        {
            InitializeComponent();

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // 단일 필드 값 호출 후 변경
            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "반갑습니다.";

        } 
        private void btnNicetoMeetYou_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "화이팅";
        }

        private void btnFighting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Static_Class.sValue); 
        }

        private void btnStaticOrInstance_Click(object sender, EventArgs e)
        {
            // 복수 필드의 Static 형식 또는 Instance 형식.

            // 1. Static 형이 아닌 일반 필드(인스턴스 필드)
            //    클래스를 객체화 하여 호출 하되 로직 종료 시 소멸된다.
            
            // 클래스를 객체화 하여 인스턴스 필드에 "반갑습니다" 값 입력
            StaticOrInstance_Class SOI_C = new StaticOrInstance_Class();
            SOI_C.sInstance_Value = "반갑습니다.";

            // 정적 필드 에 바로 "반값습니다." 갑 입력.
            StaticOrInstance_Class.sStatic_Value = "반갑습니다.";

        }

        private void btnStaticOrInstance_Call_Click(object sender, EventArgs e)
        {
            // StaticOrInstance_Class 에 있는 필드 값 을 표현
            
            // 인스턴스 필드 값 표현.
            StaticOrInstance_Class COI_C = new StaticOrInstance_Class();
            MessageBox.Show(COI_C.sInstance_Value);

            // 정적 필드 값 표현.
            MessageBox.Show(StaticOrInstance_Class.sStatic_Value);

        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            // 상수 바뀌지 않는 값 Const

            // 1. Const_Class 객체 생성.
            Const_Class Const_C = new Const_Class();

            // 2. 객체를 만들어 접근을 할 수 없다.
            // Const_C.sConst_Value
            //    . Const(상수) 는 Static 형식을 가지고 있다. 

            // 3. 상수에 데이터를 대입시 오류가 발생
            //Const_Class.sConst_Value = "값을바꿔보자";

            // 4. 확인
            MessageBox.Show(Const_Class.sConst_Value);
        }
    }

    class Static_Class
    {
        // 단일 필드 만 Static 으로 한정하는 클래스.
        public static string sValue = "안녕하세요";
    }

    class StaticOrInstance_Class
    {
        public string sInstance_Value = "안녕하세요"; // 인스턴스 필드
        public static string sStatic_Value = "안녕하세요"; // 정적 필드.

    }

    class Const_Class
    {
        // 상수 생성.
        public const string sConst_Value = "상수값";
    }

}
