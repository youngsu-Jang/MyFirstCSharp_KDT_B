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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCatch2 = new System.Windows.Forms.Button();
            this.btnCatch1 = new System.Windows.Forms.Button();
            this.btnArrayArg = new System.Windows.Forms.Button();
            this.btnArrayReturn = new System.Windows.Forms.Button();
            this.btnCalssMCall = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOverLoding = new System.Windows.Forms.Button();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.btnGenericMethod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCatch2);
            this.groupBox1.Controls.Add(this.btnCatch1);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "술래잡기";
            // 
            // btnCatch2
            // 
            this.btnCatch2.Location = new System.Drawing.Point(194, 19);
            this.btnCatch2.Name = "btnCatch2";
            this.btnCatch2.Size = new System.Drawing.Size(160, 39);
            this.btnCatch2.TabIndex = 1;
            this.btnCatch2.UseVisualStyleBackColor = true;
            this.btnCatch2.Click += new System.EventHandler(this.btnCatch2_Click);
            // 
            // btnCatch1
            // 
            this.btnCatch1.Location = new System.Drawing.Point(6, 19);
            this.btnCatch1.Name = "btnCatch1";
            this.btnCatch1.Size = new System.Drawing.Size(170, 39);
            this.btnCatch1.TabIndex = 0;
            this.btnCatch1.Text = "나 잡아 봐라~~";
            this.btnCatch1.UseVisualStyleBackColor = true;
            this.btnCatch1.Click += new System.EventHandler(this.btnCatch1_Click);
            // 
            // btnArrayArg
            // 
            this.btnArrayArg.Location = new System.Drawing.Point(12, 287);
            this.btnArrayArg.Name = "btnArrayArg";
            this.btnArrayArg.Size = new System.Drawing.Size(115, 58);
            this.btnArrayArg.TabIndex = 9;
            this.btnArrayArg.Text = "Array Argument";
            this.btnArrayArg.UseVisualStyleBackColor = true;
            this.btnArrayArg.Click += new System.EventHandler(this.btnArrayArg_Click);
            // 
            // btnArrayReturn
            // 
            this.btnArrayReturn.Location = new System.Drawing.Point(133, 287);
            this.btnArrayReturn.Name = "btnArrayReturn";
            this.btnArrayReturn.Size = new System.Drawing.Size(115, 58);
            this.btnArrayReturn.TabIndex = 10;
            this.btnArrayReturn.Text = "Array Return";
            this.btnArrayReturn.UseVisualStyleBackColor = true;
            this.btnArrayReturn.Click += new System.EventHandler(this.btnArrayReturn_Click);
            // 
            // btnCalssMCall
            // 
            this.btnCalssMCall.Location = new System.Drawing.Point(254, 287);
            this.btnCalssMCall.Name = "btnCalssMCall";
            this.btnCalssMCall.Size = new System.Drawing.Size(115, 58);
            this.btnCalssMCall.TabIndex = 11;
            this.btnCalssMCall.Text = "Class Method Call";
            this.btnCalssMCall.UseVisualStyleBackColor = true;
            this.btnCalssMCall.Click += new System.EventHandler(this.btnCalssMCall_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(12, 360);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(79, 58);
            this.btnRef.TabIndex = 12;
            this.btnRef.Text = "ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(97, 360);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(79, 58);
            this.btnOut.TabIndex = 13;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(182, 360);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(79, 58);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOverLoding
            // 
            this.btnOverLoding.Location = new System.Drawing.Point(12, 424);
            this.btnOverLoding.Name = "btnOverLoding";
            this.btnOverLoding.Size = new System.Drawing.Size(79, 58);
            this.btnOverLoding.TabIndex = 15;
            this.btnOverLoding.Text = "OverLoding";
            this.btnOverLoding.UseVisualStyleBackColor = true;
            this.btnOverLoding.Click += new System.EventHandler(this.btnOverLoding_Click);
            // 
            // btnTryParse
            // 
            this.btnTryParse.Location = new System.Drawing.Point(12, 488);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(79, 58);
            this.btnTryParse.TabIndex = 16;
            this.btnTryParse.Text = "TryParse";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // btnGenericMethod
            // 
            this.btnGenericMethod.Location = new System.Drawing.Point(97, 424);
            this.btnGenericMethod.Name = "btnGenericMethod";
            this.btnGenericMethod.Size = new System.Drawing.Size(79, 58);
            this.btnGenericMethod.TabIndex = 17;
            this.btnGenericMethod.Text = "Generic Method";
            this.btnGenericMethod.UseVisualStyleBackColor = true;
            this.btnGenericMethod.Click += new System.EventHandler(this.btnGenericMethod_Click);
            // 
            // Chap14_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 581);
            this.Controls.Add(this.btnGenericMethod);
            this.Controls.Add(this.btnTryParse);
            this.Controls.Add(this.btnOverLoding);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnCalssMCall);
            this.Controls.Add(this.btnArrayReturn);
            this.Controls.Add(this.btnArrayArg);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Button btnCatch2;
        private Button btnCatch1;
        private Button btnArrayArg;
        private Button btnArrayReturn;
        private Button btnCalssMCall;
        private Button btnRef;
        private Button btnOut;
        private Button btnIn;
        private Button btnOverLoding;
        private Button btnTryParse;
        private Button btnGenericMethod;
    }
}