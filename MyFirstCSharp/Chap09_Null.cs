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
    public partial class Chap09_Null : Form
    {
        /*
          - Null ? 
            . 데이터의 용량(메모리) 자체가 주어지지 않는 값. 
            . 값이 존재 하지 않는다 
            . "" 아무것도 없는 값(데이터) 가 존재한다. 
            . ex) 모델하우스에서 건축되지 않은 아파트 호수 를 계약한경우.

          - 기본적으로 숫자형 변수에는 Null 을 대입 할수 없다. 
            . ? 를 사용하여 Null 을 임시로 대입할수 있으나 
              로직 구현시 오류가 날수 있으니 주의.
        */
        public Chap09_Null()
        {
            InitializeComponent();
        }

        private void btnHasValue_Click(object sender, EventArgs e)
        {
            // 숫자형 데이터의 값이 Null 인지 판단하는 방법.

            // 1. 숫자형 데이터 타입에 Null 을 허용 하는 방법. 
            // 데이터 타입 뒤에 ? 를 삽입하여 임시적으로 Null 을 허용 
            // 할수 있도록 변경가능. 
            int? iValue = null;
            string? sValue = null;

            MessageBox.Show(Convert.ToString(iValue.HasValue)); //False

            iValue = 1;

            MessageBox.Show(Convert.ToString(iValue.HasValue)); //True

            // 문자형 데이터 타입 (sValue) 는 
            // 기본적으로 Null 을 허용하는 데이터 타입이므로 
            // HasValue 기능이 존재할 필요가없다. 
        }

        private void btnNullFlag_Click(object sender, EventArgs e)
        {
            // Null 병합 연산자 '??' 
            // 데이터 타입의 유형이 Null 인지 판단하는 용법.

            int? iValue = null;

            // 1. iValue 의값이 Null 인지 판단.

            // iValue 의 값이 Null 일 경우 -1 을 반환하여 표현.
            MessageBox.Show(Convert.ToString(iValue ?? -1));

            // iValue 에 10 이라는 수를 대입할 경우 10 이 표현.
            iValue = 10;
            MessageBox.Show(Convert.ToString(iValue ?? 0));

            // 2. string 데이터타입에 Null 값 여부 판단. 
            string sValue = null;
            MessageBox.Show(sValue ?? "입력한 값이 Null 입니다.");

            sValue = "안녕하세요";
            MessageBox.Show(sValue ?? "입력한 값이 Null 입니다.");
        }
    }
}
