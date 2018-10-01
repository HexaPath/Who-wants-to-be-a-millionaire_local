namespace WhoWantsToBeAMillionaire_form1
{
    partial class Form1
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(145, 136);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUsername.Size = new System.Drawing.Size(498, 32);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Ime";
            this.textBoxUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUsername_MouseClick);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(145, 195);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPassword.Size = new System.Drawing.Size(501, 32);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Geslo";
            this.textBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPassword_MouseClick);
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.Location = new System.Drawing.Point(145, 258);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(163, 51);
            this.btnSup.TabIndex = 6;
            this.btnSup.Text = "Sing Up";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(314, 258);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(163, 51);
            this.btnSin.TabIndex = 7;
            this.btnSin.Text = "Sign In";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.Red;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.Location = new System.Drawing.Point(483, 258);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(163, 51);
            this.btnext.TabIndex = 8;
            this.btnext.Text = "Exit";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(156, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Who wants to be a Millionaire";
            // 
            // btnlead
            // 
            this.btnlead.BackColor = System.Drawing.Color.Yellow;
            this.btnlead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlead.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlead.ForeColor = System.Drawing.Color.Black;
            this.btnlead.Location = new System.Drawing.Point(176, 315);
            this.btnlead.Name = "btnlead";
            this.btnlead.Size = new System.Drawing.Size(444, 31);
            this.btnlead.TabIndex = 10;
            this.btnlead.Text = "Leaderboard";
            this.btnlead.UseVisualStyleBackColor = false;
            this.btnlead.Click += new System.EventHandler(this.btnlead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(801, 446);
            this.Controls.Add(this.btnlead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Who wants to be a Millionaire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlead;
    }
}

