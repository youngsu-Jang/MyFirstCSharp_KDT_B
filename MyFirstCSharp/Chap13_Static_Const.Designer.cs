namespace MyFirstCSharp
{
    partial class Chap13_Static_Const
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
            this.btnHello = new System.Windows.Forms.Button();
            this.btnNicetoMeetYou = new System.Windows.Forms.Button();
            this.btnFighting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(33, 34);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(110, 46);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "안녕하세요";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnNicetoMeetYou
            // 
            this.btnNicetoMeetYou.Location = new System.Drawing.Point(149, 34);
            this.btnNicetoMeetYou.Name = "btnNicetoMeetYou";
            this.btnNicetoMeetYou.Size = new System.Drawing.Size(110, 46);
            this.btnNicetoMeetYou.TabIndex = 1;
            this.btnNicetoMeetYou.Text = "반갑습니다.";
            this.btnNicetoMeetYou.UseVisualStyleBackColor = true;
            this.btnNicetoMeetYou.Click += new System.EventHandler(this.btnNicetoMeetYou_Click);
            // 
            // btnFighting
            // 
            this.btnFighting.Location = new System.Drawing.Point(265, 34);
            this.btnFighting.Name = "btnFighting";
            this.btnFighting.Size = new System.Drawing.Size(110, 46);
            this.btnFighting.TabIndex = 2;
            this.btnFighting.Text = "화이팅";
            this.btnFighting.UseVisualStyleBackColor = true;
            this.btnFighting.Click += new System.EventHandler(this.btnFighting_Click);
            // 
            // Chap13_Static_Const
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 121);
            this.Controls.Add(this.btnFighting);
            this.Controls.Add(this.btnNicetoMeetYou);
            this.Controls.Add(this.btnHello);
            this.Name = "Chap13_Static_Const";
            this.Text = "Static 한정자와 변수";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHello;
        private Button btnNicetoMeetYou;
        private Button btnFighting;
    }
}