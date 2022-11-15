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
    public partial class Chap06_StringFind : Form
    {
        string sTitleOri;

        public Chap06_StringFind()
        {
            InitializeComponent();

            sTitleOri = lblTitle.Text;
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Index Of - 문자열 내에서 찾고자 하는 지정된 문자
            //            또는 문자열의 위치 Index 찾기.

            // 1. 타이틀 내용 변수에 담기. 
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자열 변수에 담기
            string sValue = txtIndexOf.Text;


            // 3. 사용자가 지정한 문자 위치 찾기.
            int iIndex; // 사용자 지정 문자 위치 변수
            iIndex = sTitle.IndexOf(sValue);

            MessageBox.Show(Convert.ToString(iIndex));
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // Last Index Of : 문자열의 뒤에서 찾아
            //                 몇번째 인덱스(주소)에 있는지 리턴.


            // 1. 타이틀 변수 생성 및 데이터 담기.
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자. 
            string sValue = txtLastIndexOf.Text;

            // 3. 인덱스 찾아서 변수에 담기.
            int iResult = sTitle.LastIndexOf(sValue);

            MessageBox.Show(Convert.ToString(iResult));
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            // StratWith : 해당 문자열로 시작하는지 판단.
            //             성공 : True , 실패 : False

            // 1. 타이틀 내용 변수에 담기.
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자 변수에 담기.
            string sValue = txtStartWith.Text;

            // 3. 판단 결과 반환하기.
            bool bFlag = sTitle.StartsWith(sValue);

            MessageBox.Show(Convert.ToString(bFlag));

        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            // EndWith : 문자열이 지정한 문자로 끝나는지 판단한다. 
            // 1. 타이틀 내용 변수에 담기.
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자 변수에 담기.
            string sValue = txtEndWith.Text;

            // 3. 판단 결과 반환하기.
            bool bFlag = sTitle.EndsWith(sValue);

            MessageBox.Show(Convert.ToString(bFlag));
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            // Contains() : 지정한 문자열을 포함하고
            //              있는지 결과를 반환한다.

            // 1. 타이틀 라벨에 있는 문자열 을 문자 변수에 등록
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자.
            string sValue = txtContains.Text;



            // 3. 문자열을 포함하고 있는지 판단. 
            // 3-1 . 변수(참/거짓) 를 만들고 결과값을 담는 유형
            bool bContains; // 판단 결과를 받을 bool 변수.
            bContains = sTitle.Contains(sValue);
            MessageBox.Show(Convert.ToString(bContains)); // 결과값 표현
            // bContains 결과값에 따른
            // 후속 로직을 작성 할 수 있다.
            bContains = !bContains;

            // 3-2 .변수를 만들면서 결과값을 담는 방법
            bool bContains2 = sTitle.Contains(sValue);
            MessageBox.Show(Convert.ToString(bContains2));
            // bContains2 의 결과값에 따른
            // 후속 로직을 작성 할 수 있다. 
            bContains2 = !bContains2;

            // 3-3 변수에 담지 않고 결과값을 표현
            MessageBox.Show(Convert.ToString(sTitle.Contains(sValue)));
            // 결과값에 따른
            // 후속 로직을 작성 할 수 있다. 
            bool bContains3 = !sTitle.Contains(sValue);
        }

        private void btnChang_Click(object sender, EventArgs e)
        {
            // Replace : 문자열 변환하기.

            // 1. 문자열 변환할 대상이 있는 문자열 
            string sTitle = lblTitle.Text;

            // 2. 변환 을 해야할 문자열.
            string sObj = txtReplace1.Text;

            // 3. 변환 시킬 문자열
            string sValue = txtReplace2.Text;

            // 라벨에 변경된 내용 표시하기.
            //lblTitle.Text = sTitle.Replace(sObj, sValue);

            string sValue2 = sTitle.Replace(sObj, sValue);
            lblTitle.Text = sValue2;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // 라벨 타이틀 의 문구를 원본데이터로 변경 한다. 

            // 1. 원본 데이터가 보관 되어야 하는 시점은 ? 
            // 클래스가 시작되는 시점 (생성자)
            // string sValueOri (변수데이터 입력 함)

            // 2. 원본 데이터로 복구 해야 하는 시점은 ? 
            lblTitle.Text = sTitleOri;

            // 3. 원본 데이터를 복구 하기 위하여 응용해야 하는 개념은 ? 
            // 함수(메서드) 가 관리하는 변수이냐 ? 
            // 클래스가 관리하는 변수이냐 에 따라서 달라짐
            // 클래스가 관리하는 변수 로 지정 할 경우 
            // 클래스가 종료 될때까지 남아있으므로 
            // 크래스의 하위 속성 인 메서드 에서 공용으로 사용 할 수 있다. 

        }
    }
}
