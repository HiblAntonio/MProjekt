namespace PForms
{
    partial class Home
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOdDatuma = new System.Windows.Forms.DateTimePicker();
            this.dtpDoDatuma = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnSearchIme = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(188, 372);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(174, 59);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijavi se u sustav";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Traži zaposlenike u tablici";
            // 
            // dtpOdDatuma
            // 
            this.dtpOdDatuma.Location = new System.Drawing.Point(764, 214);
            this.dtpOdDatuma.Name = "dtpOdDatuma";
            this.dtpOdDatuma.Size = new System.Drawing.Size(138, 20);
            this.dtpOdDatuma.TabIndex = 8;
            // 
            // dtpDoDatuma
            // 
            this.dtpDoDatuma.Location = new System.Drawing.Point(764, 275);
            this.dtpDoDatuma.Name = "dtpDoDatuma";
            this.dtpDoDatuma.Size = new System.Drawing.Size(138, 20);
            this.dtpDoDatuma.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Od datuma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Do datuma";
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(774, 327);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(106, 29);
            this.btnSeach.TabIndex = 12;
            this.btnSeach.Text = "Pretraži";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 341);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(389, 372);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(174, 59);
            this.btnOdjava.TabIndex = 14;
            this.btnOdjava.Text = "Odjavi se iz sustava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnSearchIme
            // 
            this.btnSearchIme.Location = new System.Drawing.Point(774, 77);
            this.btnSearchIme.Name = "btnSearchIme";
            this.btnSearchIme.Size = new System.Drawing.Size(106, 29);
            this.btnSearchIme.TabIndex = 15;
            this.btnSearchIme.Text = "Pretraži";
            this.btnSearchIme.UseVisualStyleBackColor = true;
            this.btnSearchIme.Click += new System.EventHandler(this.btnSearchIme_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mario Širić",
            "Ivana Pothorski",
            "Monika Damjanov",
            "Loneta Plečko",
            "Mario Salaji",
            "Ivan Čeliković"});
            this.comboBox1.Location = new System.Drawing.Point(764, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 443);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearchIme);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDoDatuma);
            this.Controls.Add(this.dtpOdDatuma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrijava);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOdDatuma;
        private System.Windows.Forms.DateTimePicker dtpDoDatuma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnSearchIme;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

