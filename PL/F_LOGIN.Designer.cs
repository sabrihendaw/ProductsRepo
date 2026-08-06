namespace products.PL
{
    partial class F_LOGIN
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
            this.B_CLOSE = new System.Windows.Forms.Button();
            this.B_LOGIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T_ID = new System.Windows.Forms.TextBox();
            this.T_PWD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_CLOSE
            // 
            this.B_CLOSE.Location = new System.Drawing.Point(280, 142);
            this.B_CLOSE.Name = "B_CLOSE";
            this.B_CLOSE.Size = new System.Drawing.Size(134, 41);
            this.B_CLOSE.TabIndex = 0;
            this.B_CLOSE.Text = "خروج";
            this.B_CLOSE.UseVisualStyleBackColor = true;
            this.B_CLOSE.Click += new System.EventHandler(this.B_CLOSE_Click);
            // 
            // B_LOGIN
            // 
            this.B_LOGIN.Location = new System.Drawing.Point(80, 142);
            this.B_LOGIN.Name = "B_LOGIN";
            this.B_LOGIN.Size = new System.Drawing.Size(115, 41);
            this.B_LOGIN.TabIndex = 1;
            this.B_LOGIN.Text = "دخول";
            this.B_LOGIN.UseVisualStyleBackColor = true;
            this.B_LOGIN.Click += new System.EventHandler(this.B_LOGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور";
            // 
            // T_ID
            // 
            this.T_ID.Location = new System.Drawing.Point(160, 35);
            this.T_ID.Name = "T_ID";
            this.T_ID.Size = new System.Drawing.Size(229, 20);
            this.T_ID.TabIndex = 4;
            // 
            // T_PWD
            // 
            this.T_PWD.Location = new System.Drawing.Point(160, 79);
            this.T_PWD.Name = "T_PWD";
            this.T_PWD.Size = new System.Drawing.Size(232, 20);
            this.T_PWD.TabIndex = 5;
            // 
            // F_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 195);
            this.Controls.Add(this.T_PWD);
            this.Controls.Add(this.T_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_LOGIN);
            this.Controls.Add(this.B_CLOSE);
            this.Name = "F_LOGIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_CLOSE;
        private System.Windows.Forms.Button B_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_ID;
        private System.Windows.Forms.TextBox T_PWD;
    }
}