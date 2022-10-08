namespace Oefening2
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
            this.cb_koe = new System.Windows.Forms.CheckBox();
            this.cb_slang = new System.Windows.Forms.CheckBox();
            this.cb_varken = new System.Windows.Forms.CheckBox();
            this.b_sound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_koe
            // 
            this.cb_koe.AutoSize = true;
            this.cb_koe.Location = new System.Drawing.Point(108, 100);
            this.cb_koe.Name = "cb_koe";
            this.cb_koe.Size = new System.Drawing.Size(46, 19);
            this.cb_koe.TabIndex = 0;
            this.cb_koe.Text = "Koe";
            this.cb_koe.UseVisualStyleBackColor = true;
            // 
            // cb_slang
            // 
            this.cb_slang.AutoSize = true;
            this.cb_slang.Location = new System.Drawing.Point(108, 136);
            this.cb_slang.Name = "cb_slang";
            this.cb_slang.Size = new System.Drawing.Size(55, 19);
            this.cb_slang.TabIndex = 1;
            this.cb_slang.Text = "Slang";
            this.cb_slang.UseVisualStyleBackColor = true;
            // 
            // cb_varken
            // 
            this.cb_varken.AutoSize = true;
            this.cb_varken.Location = new System.Drawing.Point(108, 175);
            this.cb_varken.Name = "cb_varken";
            this.cb_varken.Size = new System.Drawing.Size(61, 19);
            this.cb_varken.TabIndex = 2;
            this.cb_varken.Text = "Varken";
            this.cb_varken.UseVisualStyleBackColor = true;
            // 
            // b_sound
            // 
            this.b_sound.Location = new System.Drawing.Point(108, 210);
            this.b_sound.Name = "b_sound";
            this.b_sound.Size = new System.Drawing.Size(75, 23);
            this.b_sound.TabIndex = 3;
            this.b_sound.Text = "Laat horen!";
            this.b_sound.UseVisualStyleBackColor = true;
            this.b_sound.Click += new System.EventHandler(this.b_sound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_sound);
            this.Controls.Add(this.cb_varken);
            this.Controls.Add(this.cb_slang);
            this.Controls.Add(this.cb_koe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cb_koe;
        private CheckBox cb_slang;
        private CheckBox cb_varken;
        private Button b_sound;
    }
}