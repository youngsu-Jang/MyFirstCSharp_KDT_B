namespace MyFirstCSharp
{
    partial class Chap14_Method
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
            this.txtTtile = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.btnArg_Par = new System.Windows.Forms.Button();
            this.btnVoidReturn = new System.Windows.Forms.Button();
            this.btnStringReturn = new System.Windows.Forms.Button();
            this.btnIntReturn = new System.Windows.Forms.Button();
            this.btnDefaultReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTtile
            // 
            this.txtTtile.Location = new System.Drawing.Point(12, 12);
            this.txtTtile.Name = "txtTtile";
            this.txtTtile.Size = new System.Drawing.Size(192, 23);
            this.txtTtile.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(12, 79);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(79, 58);
            this.btnMethodCall.TabIndex = 2;
            this.btnMethodCall.Text = "함수 호출";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // btnArg_Par
            // 
            this.btnArg_Par.Location = new System.Drawing.Point(97, 79);
            this.btnArg_Par.Name = "btnArg_Par";
            this.btnArg_Par.Size = new System.Drawing.Size(79, 58);
            this.btnArg_Par.TabIndex = 3;
            this.btnArg_Par.Text = "인수 인자";
            this.btnArg_Par.UseVisualStyleBackColor = true;
            this.btnArg_Par.Click += new System.EventHandler(this.btnArg_Par_Click);
            // 
            // btnVoidReturn
            // 
            this.btnVoidReturn.Location = new System.Drawing.Point(12, 143);
            this.btnVoidReturn.Name = "btnVoidReturn";
            this.btnVoidReturn.Size = new System.Drawing.Size(79, 58);
            this.btnVoidReturn.TabIndex = 4;
            this.btnVoidReturn.Text = "Void Return";
            this.btnVoidReturn.UseVisualStyleBackColor = true;
            this.btnVoidReturn.Click += new System.EventHandler(this.btnVoidReturn_Click);
            // 
            // btnStringReturn
            // 
            this.btnStringReturn.Location = new System.Drawing.Point(97, 143);
            this.btnStringReturn.Name = "btnStringReturn";
            this.btnStringReturn.Size = new System.Drawing.Size(79, 58);
            this.btnStringReturn.TabIndex = 5;
            this.btnStringReturn.Text = "String Return";
            this.btnStringReturn.UseVisualStyleBackColor = true;
            this.btnStringReturn.Click += new System.EventHandler(this.btnStringReturn_Click);
            // 
            // btnIntReturn
            // 
            this.btnIntReturn.Location = new System.Drawing.Point(182, 143);
            this.btnIntReturn.Name = "btnIntReturn";
            this.btnIntReturn.Size = new System.Drawing.Size(79, 58);
            this.btnIntReturn.TabIndex = 6;
            this.btnIntReturn.Text = "Int Return";
            this.btnIntReturn.UseVisualStyleBackColor = true;
            this.btnIntReturn.Click += new System.EventHandler(this.btnIntReturn_Click);
            // 
            // btnDefaultReturn
            // 
            this.btnDefaultReturn.Location = new System.Drawing.Point(267, 143);
            this.btnDefaultReturn.Name = "btnDefaultReturn";
            this.btnDefaultReturn.Size = new System.Drawing.Size(115, 58);
            this.btnDefaultReturn.TabIndex = 7;
            this.btnDefaultReturn.Text = "Default Return";
            this.btnDefaultReturn.UseVisualStyleBackColor = true;
            this.btnDefaultReturn.Click += new System.EventHandler(this.btnDefaultReturn_Click);
            // 
            // Chap14_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 478);
            this.Controls.Add(this.btnDefaultReturn);
            this.Controls.Add(this.btnIntReturn);
            this.Controls.Add(this.btnStringReturn);
            this.Controls.Add(this.btnVoidReturn);
            this.Controls.Add(this.btnArg_Par);
            this.Controls.Add(this.btnMethodCall);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTtile);
            this.Name = "Chap14_Method";
            this.Text = "메서드를 공부합니다.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTtile;
        private Label lblTitle;
        private Button btnMethodCall;
        private Button btnArg_Par;
        private Button btnVoidReturn;
        private Button btnStringReturn;
        private Button btnIntReturn;
        private Button btnDefaultReturn;
    }
}