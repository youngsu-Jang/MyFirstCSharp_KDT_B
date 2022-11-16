﻿using System;
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
    }

    class Static_Class
    {
        // 단일 필드 만 Static 으로 한정하는 클래스.
        public static string sValue = "안녕하세요";
    }
}
