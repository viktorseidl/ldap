namespace LDAP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.DN = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.connectbtn = new System.Windows.Forms.Button();
            this.searchfield = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LDAP Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LDAP Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passwort";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(108, 12);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(181, 20);
            this.server.TabIndex = 4;
            this.server.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(108, 38);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(181, 20);
            this.port.TabIndex = 5;
            this.port.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DN
            // 
            this.DN.Location = new System.Drawing.Point(108, 64);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(181, 20);
            this.DN.TabIndex = 6;
            this.DN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(108, 90);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(181, 20);
            this.pass.TabIndex = 7;
            this.pass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // connectbtn
            // 
            this.connectbtn.BackColor = System.Drawing.Color.Red;
            this.connectbtn.Location = new System.Drawing.Point(295, 12);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(493, 23);
            this.connectbtn.TabIndex = 8;
            this.connectbtn.Text = "DISCONNECTED";
            this.connectbtn.UseVisualStyleBackColor = false;
            this.connectbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchfield
            // 
            this.searchfield.Location = new System.Drawing.Point(24, 136);
            this.searchfield.Name = "searchfield";
            this.searchfield.Size = new System.Drawing.Size(381, 20);
            this.searchfield.TabIndex = 9;
            this.searchfield.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(411, 136);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(126, 23);
            this.searchbtn.TabIndex = 10;
            this.searchbtn.Text = "Suche";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchfield);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.DN);
            this.Controls.Add(this.port);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox DN;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox searchfield;
        private System.Windows.Forms.Button searchbtn;
    }
}

