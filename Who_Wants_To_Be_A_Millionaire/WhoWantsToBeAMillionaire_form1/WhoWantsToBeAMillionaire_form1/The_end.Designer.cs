namespace WhoWantsToBeAMillionaire_form1
{
    partial class The_end
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnrepeat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlead = new System.Windows.Forms.Button();
            this.btnchangeuser = new System.Windows.Forms.Button();
            this.btnctpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(739, 391);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(228, 58);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnrepeat
            // 
            this.btnrepeat.BackColor = System.Drawing.Color.Lime;
            this.btnrepeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrepeat.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepeat.ForeColor = System.Drawing.Color.Black;
            this.btnrepeat.Location = new System.Drawing.Point(509, 391);
            this.btnrepeat.Name = "btnrepeat";
            this.btnrepeat.Size = new System.Drawing.Size(224, 58);
            this.btnrepeat.TabIndex = 10;
            this.btnrepeat.Text = "Play again";
            this.btnrepeat.UseVisualStyleBackColor = false;
            this.btnrepeat.Click += new System.EventHandler(this.btnrepeat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(432, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "name";
            // 
            // btnlead
            // 
            this.btnlead.BackColor = System.Drawing.Color.Yellow;
            this.btnlead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlead.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlead.ForeColor = System.Drawing.Color.Black;
            this.btnlead.Location = new System.Drawing.Point(211, 391);
            this.btnlead.Name = "btnlead";
            this.btnlead.Size = new System.Drawing.Size(292, 58);
            this.btnlead.TabIndex = 6;
            this.btnlead.Text = "Leaderboard";
            this.btnlead.UseVisualStyleBackColor = false;
            this.btnlead.Click += new System.EventHandler(this.btnlead_Click);
            // 
            // btnchangeuser
            // 
            this.btnchangeuser.BackColor = System.Drawing.Color.Blue;
            this.btnchangeuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchangeuser.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangeuser.ForeColor = System.Drawing.Color.Black;
            this.btnchangeuser.Location = new System.Drawing.Point(605, 455);
            this.btnchangeuser.Name = "btnchangeuser";
            this.btnchangeuser.Size = new System.Drawing.Size(292, 58);
            this.btnchangeuser.TabIndex = 12;
            this.btnchangeuser.Text = "Change User";
            this.btnchangeuser.UseVisualStyleBackColor = false;
            this.btnchangeuser.Click += new System.EventHandler(this.btnchangeuser_Click);
            // 
            // btnctpc
            // 
            this.btnctpc.BackColor = System.Drawing.Color.Teal;
            this.btnctpc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnctpc.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctpc.ForeColor = System.Drawing.Color.Black;
            this.btnctpc.Location = new System.Drawing.Point(307, 455);
            this.btnctpc.Name = "btnctpc";
            this.btnctpc.Size = new System.Drawing.Size(292, 58);
            this.btnctpc.TabIndex = 13;
            this.btnctpc.Text = "Change Topic";
            this.btnctpc.UseVisualStyleBackColor = false;
            this.btnctpc.Click += new System.EventHandler(this.btnctpc_Click);
            // 
            // The_end
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1214, 657);
            this.Controls.Add(this.btnctpc);
            this.Controls.Add(this.btnchangeuser);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnrepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlead);
            this.Name = "The_end";
            this.Text = "The_end";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.The_end_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnrepeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlead;
        private System.Windows.Forms.Button btnchangeuser;
        private System.Windows.Forms.Button btnctpc;
    }
}