namespace LDAP
{
    partial class LDAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDAP));
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
            this.Datentabelle = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.Datentabelle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.server, "server");
            this.server.Name = "server";
            this.server.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.port, "port");
            this.port.Name = "port";
            this.port.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DN
            // 
            this.DN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.DN, "DN");
            this.DN.Name = "DN";
            this.DN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.pass, "pass");
            this.pass.Name = "pass";
            this.pass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // connectbtn
            // 
            this.connectbtn.BackColor = System.Drawing.Color.Red;
            this.connectbtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.connectbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.connectbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.connectbtn, "connectbtn");
            this.connectbtn.ForeColor = System.Drawing.Color.Black;
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchfield
            // 
            this.searchfield.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.searchfield, "searchfield");
            this.searchfield.Name = "searchfield";
            this.searchfield.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // searchbtn
            // 
            resources.ApplyResources(this.searchbtn, "searchbtn");
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Datentabelle
            // 
            this.Datentabelle.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Datentabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Datentabelle, "Datentabelle");
            this.Datentabelle.Name = "Datentabelle";
            this.Datentabelle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            // 
            // LDAP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Datentabelle);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LDAP";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.Datentabelle)).EndInit();
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
        private System.Windows.Forms.DataGridView Datentabelle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TreeView treeView1;
    }
}

