namespace MyFirstCSharp
{
    partial class Chap08_Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnNameChang = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInsertKDT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "안녕하세요 2022 스마트팩토리 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 SMARTFACTORY 교육이 되었으면 합니다" +
    ".\r\n";
            // 
            // btnNameChang
            // 
            this.btnNameChang.Location = new System.Drawing.Point(41, 108);
            this.btnNameChang.Name = "btnNameChang";
            this.btnNameChang.Size = new System.Drawing.Size(151, 53);
            this.btnNameChang.TabIndex = 1;
            this.btnNameChang.Text = "OOO -> 본인이름 변경";
            this.btnNameChang.UseVisualStyleBackColor = true;
            this.btnNameChang.Click += new System.EventHandler(this.btnNameChang_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "S/W 위치 찾기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInsertKDT
            // 
            this.btnInsertKDT.Location = new System.Drawing.Point(318, 108);
            this.btnInsertKDT.Name = "btnInsertKDT";
            this.btnInsertKDT.Size = new System.Drawing.Size(114, 53);
            this.btnInsertKDT.TabIndex = 3;
            this.btnInsertKDT.Text = "앞, 뒤 -KDT- 입력";
            this.btnInsertKDT.UseVisualStyleBackColor = true;
            this.btnInsertKDT.Click += new System.EventHandler(this.btnInsertKDT_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "SMARTFACTORY 소문자로 변경";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "모든 공백 없애기";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(447, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 53);
            this.button6.TabIndex = 6;
            this.button6.Text = "원본 타이틀 되돌리기";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Chap08_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 280);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInsertKDT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNameChang);
            this.Controls.Add(this.label1);
            this.Name = "Chap08_Test";
            this.Text = "문자열 다루기 Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnNameChang;
        private Button button2;
        private Button btnInsertKDT;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}