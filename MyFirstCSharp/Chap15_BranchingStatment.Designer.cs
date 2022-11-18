namespace MyFirstCSharp
{
    partial class Chap15_BranchingStatment
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
            this.btnIF = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInIf = new System.Windows.Forms.Button();
            this.btnElseIf = new System.Windows.Forms.Button();
            this.btnAndIf = new System.Windows.Forms.Button();
            this.btnOrIf = new System.Windows.Forms.Button();
            this.btnBoolIf = new System.Windows.Forms.Button();
            this.btnP_MFalg = new System.Windows.Forms.Button();
            this.btnH_JTest = new System.Windows.Forms.Button();
            this.btnTernaryOperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 55);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(72, 65);
            this.btnIF.TabIndex = 0;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnInIf
            // 
            this.btnInIf.Location = new System.Drawing.Point(90, 55);
            this.btnInIf.Name = "btnInIf";
            this.btnInIf.Size = new System.Drawing.Size(72, 65);
            this.btnInIf.TabIndex = 2;
            this.btnInIf.Text = "In IF";
            this.btnInIf.UseVisualStyleBackColor = true;
            this.btnInIf.Click += new System.EventHandler(this.btnInIf_Click);
            // 
            // btnElseIf
            // 
            this.btnElseIf.Location = new System.Drawing.Point(168, 55);
            this.btnElseIf.Name = "btnElseIf";
            this.btnElseIf.Size = new System.Drawing.Size(72, 65);
            this.btnElseIf.TabIndex = 3;
            this.btnElseIf.Text = "ElseIF";
            this.btnElseIf.UseVisualStyleBackColor = true;
            this.btnElseIf.Click += new System.EventHandler(this.btnElseIf_Click);
            // 
            // btnAndIf
            // 
            this.btnAndIf.Location = new System.Drawing.Point(12, 126);
            this.btnAndIf.Name = "btnAndIf";
            this.btnAndIf.Size = new System.Drawing.Size(72, 65);
            this.btnAndIf.TabIndex = 4;
            this.btnAndIf.Text = "And IF";
            this.btnAndIf.UseVisualStyleBackColor = true;
            this.btnAndIf.Click += new System.EventHandler(this.btnAndIf_Click);
            // 
            // btnOrIf
            // 
            this.btnOrIf.Location = new System.Drawing.Point(90, 126);
            this.btnOrIf.Name = "btnOrIf";
            this.btnOrIf.Size = new System.Drawing.Size(72, 65);
            this.btnOrIf.TabIndex = 5;
            this.btnOrIf.Text = "OR IF";
            this.btnOrIf.UseVisualStyleBackColor = true;
            this.btnOrIf.Click += new System.EventHandler(this.btnOrIf_Click);
            // 
            // btnBoolIf
            // 
            this.btnBoolIf.Location = new System.Drawing.Point(168, 126);
            this.btnBoolIf.Name = "btnBoolIf";
            this.btnBoolIf.Size = new System.Drawing.Size(72, 65);
            this.btnBoolIf.TabIndex = 6;
            this.btnBoolIf.Text = "Bool IF";
            this.btnBoolIf.UseVisualStyleBackColor = true;
            this.btnBoolIf.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // btnP_MFalg
            // 
            this.btnP_MFalg.Location = new System.Drawing.Point(12, 197);
            this.btnP_MFalg.Name = "btnP_MFalg";
            this.btnP_MFalg.Size = new System.Drawing.Size(72, 65);
            this.btnP_MFalg.TabIndex = 7;
            this.btnP_MFalg.Text = "음수/양수 Test";
            this.btnP_MFalg.UseVisualStyleBackColor = true;
            this.btnP_MFalg.Click += new System.EventHandler(this.btnP_MFalg_Click);
            // 
            // btnH_JTest
            // 
            this.btnH_JTest.Location = new System.Drawing.Point(90, 197);
            this.btnH_JTest.Name = "btnH_JTest";
            this.btnH_JTest.Size = new System.Drawing.Size(72, 65);
            this.btnH_JTest.TabIndex = 8;
            this.btnH_JTest.Text = "홀수/짝수 Test";
            this.btnH_JTest.UseVisualStyleBackColor = true;
            this.btnH_JTest.Click += new System.EventHandler(this.btnH_JTest_Click);
            // 
            // btnTernaryOperator
            // 
            this.btnTernaryOperator.Location = new System.Drawing.Point(168, 197);
            this.btnTernaryOperator.Name = "btnTernaryOperator";
            this.btnTernaryOperator.Size = new System.Drawing.Size(72, 65);
            this.btnTernaryOperator.TabIndex = 9;
            this.btnTernaryOperator.Text = "삼항연산자";
            this.btnTernaryOperator.UseVisualStyleBackColor = true;
            this.btnTernaryOperator.Click += new System.EventHandler(this.btnTernaryOperator_Click);
            // 
            // Chap15_BranchingStatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 286);
            this.Controls.Add(this.btnTernaryOperator);
            this.Controls.Add(this.btnH_JTest);
            this.Controls.Add(this.btnP_MFalg);
            this.Controls.Add(this.btnBoolIf);
            this.Controls.Add(this.btnOrIf);
            this.Controls.Add(this.btnAndIf);
            this.Controls.Add(this.btnElseIf);
            this.Controls.Add(this.btnInIf);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnIF);
            this.Name = "Chap15_BranchingStatment";
            this.Text = "분기문";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIF;
        private TextBox txtInput;
        private Button btnInIf;
        private Button btnElseIf;
        private Button btnAndIf;
        private Button btnOrIf;
        private Button btnBoolIf;
        private Button btnP_MFalg;
        private Button btnH_JTest;
        private Button btnTernaryOperator;
    }
}