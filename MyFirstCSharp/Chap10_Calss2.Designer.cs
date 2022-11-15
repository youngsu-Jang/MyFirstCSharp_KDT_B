namespace MyFirstCSharp
{
    partial class Chap10_Calss2
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
            this.btnCalssInstance = new System.Windows.Forms.Button();
            this.btnCalssInstance2 = new System.Windows.Forms.Button();
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalssInstance
            // 
            this.btnCalssInstance.Location = new System.Drawing.Point(12, 59);
            this.btnCalssInstance.Name = "btnCalssInstance";
            this.btnCalssInstance.Size = new System.Drawing.Size(174, 50);
            this.btnCalssInstance.TabIndex = 0;
            this.btnCalssInstance.Text = "클래스 객체 생성 및 호출";
            this.btnCalssInstance.UseVisualStyleBackColor = true;
            this.btnCalssInstance.Click += new System.EventHandler(this.btnCalssInstance_Click);
            // 
            // btnCalssInstance2
            // 
            this.btnCalssInstance2.Location = new System.Drawing.Point(194, 59);
            this.btnCalssInstance2.Name = "btnCalssInstance2";
            this.btnCalssInstance2.Size = new System.Drawing.Size(154, 50);
            this.btnCalssInstance2.TabIndex = 1;
            this.btnCalssInstance2.Text = "클래스 생성 및 호출2";
            this.btnCalssInstance2.UseVisualStyleBackColor = true;
            this.btnCalssInstance2.Click += new System.EventHandler(this.btnCalssInstance2_Click);
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(12, 115);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(174, 50);
            this.btnMethodCall.TabIndex = 2;
            this.btnMethodCall.Text = "다른 클래스 메서드 호출하기";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // Chap10_Calss2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 240);
            this.Controls.Add(this.btnMethodCall);
            this.Controls.Add(this.btnCalssInstance2);
            this.Controls.Add(this.btnCalssInstance);
            this.Name = "Chap10_Calss2";
            this.Text = "클래스";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCalssInstance;
        private Button btnCalssInstance2;
        private Button btnMethodCall;
    }
}