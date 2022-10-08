namespace Oefening3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Dollar = new System.Windows.Forms.TextBox();
            this.tb_Pound = new System.Windows.Forms.TextBox();
            this.tb_Euro = new System.Windows.Forms.TextBox();
            this.tb_Yen = new System.Windows.Forms.TextBox();
            this.tb_rupees = new System.Windows.Forms.TextBox();
            this.tb_Franken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Dollar
            // 
            this.tb_Dollar.Location = new System.Drawing.Point(113, 56);
            this.tb_Dollar.Name = "tb_Dollar";
            this.tb_Dollar.Size = new System.Drawing.Size(100, 23);
            this.tb_Dollar.TabIndex = 0;
            this.tb_Dollar.TextChanged += new System.EventHandler(this.tb_Dollar_TextChanged);
            // 
            // tb_Pound
            // 
            this.tb_Pound.Location = new System.Drawing.Point(113, 85);
            this.tb_Pound.Name = "tb_Pound";
            this.tb_Pound.Size = new System.Drawing.Size(100, 23);
            this.tb_Pound.TabIndex = 1;
            this.tb_Pound.TextChanged += new System.EventHandler(this.tb_Pound_TextChanged);
            // 
            // tb_Euro
            // 
            this.tb_Euro.Location = new System.Drawing.Point(113, 114);
            this.tb_Euro.Name = "tb_Euro";
            this.tb_Euro.Size = new System.Drawing.Size(100, 23);
            this.tb_Euro.TabIndex = 2;
            this.tb_Euro.TextChanged += new System.EventHandler(this.tb_Euro_TextChanged);
            // 
            // tb_Yen
            // 
            this.tb_Yen.Location = new System.Drawing.Point(113, 143);
            this.tb_Yen.Name = "tb_Yen";
            this.tb_Yen.Size = new System.Drawing.Size(100, 23);
            this.tb_Yen.TabIndex = 3;
            this.tb_Yen.TextChanged += new System.EventHandler(this.tb_Yen_TextChanged);
            // 
            // tb_rupees
            // 
            this.tb_rupees.Location = new System.Drawing.Point(113, 172);
            this.tb_rupees.Name = "tb_rupees";
            this.tb_rupees.Size = new System.Drawing.Size(100, 23);
            this.tb_rupees.TabIndex = 4;
            this.tb_rupees.TextChanged += new System.EventHandler(this.tb_rupees_TextChanged);
            // 
            // tb_Franken
            // 
            this.tb_Franken.Location = new System.Drawing.Point(113, 201);
            this.tb_Franken.Name = "tb_Franken";
            this.tb_Franken.Size = new System.Drawing.Size(100, 23);
            this.tb_Franken.TabIndex = 5;
            this.tb_Franken.TextChanged += new System.EventHandler(this.tb_Franken_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "US Dollar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "British Pound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Euro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Indiaase Rupees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Franken";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Franken);
            this.Controls.Add(this.tb_rupees);
            this.Controls.Add(this.tb_Yen);
            this.Controls.Add(this.tb_Euro);
            this.Controls.Add(this.tb_Pound);
            this.Controls.Add(this.tb_Dollar);
            this.Name = "Form1";
            this.Text = "CurrencyConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Dollar;
        private TextBox tb_Pound;
        private TextBox tb_Euro;
        private TextBox tb_Yen;
        private TextBox tb_rupees;
        private TextBox tb_Franken;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}