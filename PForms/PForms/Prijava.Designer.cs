namespace PForms
{
    partial class Prijava
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
            this.dtpUlazak = new System.Windows.Forms.DateTimePicker();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.dtpIzlazak = new System.Windows.Forms.DateTimePicker();
            this.nudTemperatura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpUlazak
            // 
            this.dtpUlazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpUlazak.Location = new System.Drawing.Point(167, 87);
            this.dtpUlazak.Name = "dtpUlazak";
            this.dtpUlazak.Size = new System.Drawing.Size(121, 20);
            this.dtpUlazak.TabIndex = 0;
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Items.AddRange(new object[] {
            "Julia Tarnai Apel",
            "Ivana Pothorski",
            "Filip Žaper",
            "Ivana Marijančević",
            "Monika Damjanov",
            "Loneta Plečko",
            "Mario Salai",
            "Mario Širić"});
            this.cbZaposlenik.Location = new System.Drawing.Point(167, 41);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(121, 21);
            this.cbZaposlenik.TabIndex = 1;
            // 
            // dtpIzlazak
            // 
            this.dtpIzlazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIzlazak.Location = new System.Drawing.Point(167, 132);
            this.dtpIzlazak.Name = "dtpIzlazak";
            this.dtpIzlazak.Size = new System.Drawing.Size(121, 20);
            this.dtpIzlazak.TabIndex = 2;
            // 
            // nudTemperatura
            // 
            this.nudTemperatura.DecimalPlaces = 1;
            this.nudTemperatura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTemperatura.Location = new System.Drawing.Point(168, 181);
            this.nudTemperatura.Name = "nudTemperatura";
            this.nudTemperatura.Size = new System.Drawing.Size(120, 20);
            this.nudTemperatura.TabIndex = 4;
            this.nudTemperatura.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vrijeme ulaska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vrijeme izlaska";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zaposlenik";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(107, 250);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(96, 29);
            this.btnUnesi.TabIndex = 9;
            this.btnUnesi.Text = "Unesi podatke";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 290);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTemperatura);
            this.Controls.Add(this.dtpIzlazak);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.dtpUlazak);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prijava_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpUlazak;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.DateTimePicker dtpIzlazak;
        private System.Windows.Forms.NumericUpDown nudTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnesi;
    }
}