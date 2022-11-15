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
    partial class Chap05_StringChang : System.Windows.Forms.Form
    {
        string sTitle;

        public Chap05_StringChang()
        {
            // 생성자
            // 클래스 가 제일처음 진입할때(시작할때)
            // 반드시 수행해야 하는 코드
            InitializeComponent();
            sTitle = lblTitle.Text; 
        }

        private void btnChang_Click(object sender, EventArgs e)
        {
            // 타이틀 문자열 임의 변경
            lblTitle.Text = " wefiiwef  ldkasdf  가가가";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // 원본 라벨 문자열 되돌리기
            lblTitle.Text = sTitle;
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // 원본 데이터 의 모든 문자 중 대문자를 소문자로 변경
            txtLower.Text = sTitle.ToLower();
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            // 원본 데이터 의 모든 문자 중 소문자를 대문자로 변경
            txtUpper.Text = sTitle.ToUpper();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 지정한 위치에 입력한 문자를 삽입하기. 
            string sSting = txtstring.Text;                 // 삽입할 문자열.
            int iIndex    = Convert.ToInt32(txtIndex.Text); // 문자열을 삽입할 위치

            // parse , tryparse 를 이용하여 txtIndex 형변환 해보세요.
            txtInsert.Text = sTitle.Insert(iIndex, sSting);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 지정한 위치로 부터 지정한 개수의 문자를 삭제

            // 삭제를 시작할 위치.
            int iStartIndex = Convert.ToInt32(txtIndexS.Text);

            // 삭제 할 문자의 개수
            int iCount = Convert.ToInt32(txtStringCount.Text);

            // 삭제 후 문자열 표시
            txtRemove.Text = sTitle.Remove(iStartIndex, iCount);
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 앞, 뒤 공백을 삭제. 
            txtTrim.Text = sTitle.Trim();
        }

        private void btnStartTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 앞 공백만 지움.
            txtStartTrim.Text = sTitle.TrimStart();
        }

        private void btnEndTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 뒷 공백만 지움.
            txtEndTrim.Text = sTitle.TrimEnd();
        }
    } 
}
