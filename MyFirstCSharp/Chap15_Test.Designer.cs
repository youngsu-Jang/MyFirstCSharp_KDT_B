namespace MyFirstCSharp
{
    partial class Chap15_Test
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
            this.btnJudgge = new System.Windows.Forms.Button();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMultiE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBtnClickCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJudgge
            // 
            this.btnJudgge.Location = new System.Drawing.Point(293, 54);
            this.btnJudgge.Name = "btnJudgge";
            this.btnJudgge.Size = new System.Drawing.Size(131, 28);
            this.btnJudgge.TabIndex = 0;
            this.btnJudgge.Text = "2,5 공배수여부 판단";
            this.btnJudgge.UseVisualStyleBackColor = true;
            this.btnJudgge.Click += new System.EventHandler(this.btnJudgge_Click);
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(168, 59);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(108, 23);
            this.txtInputValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "입력 받을 값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "8의 배수일 경우 값과의 곱";
            // 
            // txtMultiE
            // 
            this.txtMultiE.Location = new System.Drawing.Point(168, 110);
            this.txtMultiE.Name = "txtMultiE";
            this.txtMultiE.Size = new System.Drawing.Size(108, 23);
            this.txtMultiE.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // txtBtnClickCount
            // 
            this.txtBtnClickCount.Location = new System.Drawing.Point(168, 158);
            this.txtBtnClickCount.Name = "txtBtnClickCount";
            this.txtBtnClickCount.Size = new System.Drawing.Size(108, 23);
            this.txtBtnClickCount.TabIndex = 6;
            // 
            // Chap15_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 219);
            this.Controls.Add(this.txtBtnClickCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMultiE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputValue);
            this.Controls.Add(this.btnJudgge);
            this.Name = "Chap15_Test";
            this.Text = "분기문 테스트_공배수 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnJudgge;
        private TextBox txtInputValue;
        private Label label1;
        private Label label2;
        private TextBox txtMultiE;
        private Label label3;
        private TextBox txtBtnClickCount;
    }
}