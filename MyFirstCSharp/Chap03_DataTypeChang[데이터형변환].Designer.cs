namespace MyFirstCSharp
{
    partial class Chap03_DataTypeChang
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
            this.btnChangStoI = new System.Windows.Forms.Button();
            this.btnChangeStoI = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangStoI
            // 
            this.btnChangStoI.Location = new System.Drawing.Point(37, 40);
            this.btnChangStoI.Name = "btnChangStoI";
            this.btnChangStoI.Size = new System.Drawing.Size(108, 75);
            this.btnChangStoI.TabIndex = 0;
            this.btnChangStoI.Text = "숫자 -> 문자";
            this.btnChangStoI.UseVisualStyleBackColor = true;
            this.btnChangStoI.Click += new System.EventHandler(this.btnChangStoI_Click);
            // 
            // btnChangeStoI
            // 
            this.btnChangeStoI.Location = new System.Drawing.Point(151, 40);
            this.btnChangeStoI.Name = "btnChangeStoI";
            this.btnChangeStoI.Size = new System.Drawing.Size(108, 75);
            this.btnChangeStoI.TabIndex = 1;
            this.btnChangeStoI.Text = "문자->숫자";
            this.btnChangeStoI.UseVisualStyleBackColor = true;
            this.btnChangeStoI.Click += new System.EventHandler(this.btnChangeStoI_Click);
            // 
            // btnNull
            // 
            this.btnNull.Location = new System.Drawing.Point(37, 121);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(108, 75);
            this.btnNull.TabIndex = 0;
            this.btnNull.Text = "NULL 변환 처리";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(151, 121);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(108, 75);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "문자 숫자 합";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "사용법";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chap03_DataTypeChang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnChangeStoI);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnChangStoI);
            this.Name = "Chap03_DataTypeChang";
            this.Text = "데이터 형변환";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangStoI;
        private Button btnChangeStoI;
        private Button btnNull;
        private Button btnSum;
        private Button button1;
    }
}