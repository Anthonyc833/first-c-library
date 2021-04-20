using System;

namespace Game_library
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Arrayview = new System.Windows.Forms.Button();
            this.Savepre = new System.Windows.Forms.Button();
            this.hc = new System.Windows.Forms.TextBox();
            this.HardCopy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUMID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.textboxgame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Arrayview);
            this.groupBox1.Controls.Add(this.Savepre);
            this.groupBox1.Controls.Add(this.hc);
            this.groupBox1.Controls.Add(this.HardCopy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NUMID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxConsole);
            this.groupBox1.Controls.Add(this.textboxgame);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Adding";
            // 
            // Arrayview
            // 
            this.Arrayview.Location = new System.Drawing.Point(154, 168);
            this.Arrayview.Name = "Arrayview";
            this.Arrayview.Size = new System.Drawing.Size(75, 23);
            this.Arrayview.TabIndex = 9;
            this.Arrayview.Text = "array view";
            this.Arrayview.UseVisualStyleBackColor = true;
            this.Arrayview.Click += new System.EventHandler(this.arrayveiwing);
            // 
            // Savepre
            // 
            this.Savepre.Location = new System.Drawing.Point(24, 168);
            this.Savepre.Name = "Savepre";
            this.Savepre.Size = new System.Drawing.Size(75, 23);
            this.Savepre.TabIndex = 8;
            this.Savepre.Text = "Save";
            this.Savepre.UseVisualStyleBackColor = true;
            this.Savepre.Click += new System.EventHandler(this.savinggamelibrary);
            // 
            // hc
            // 
            this.hc.Location = new System.Drawing.Point(81, 126);
            this.hc.Name = "hc";
            this.hc.Size = new System.Drawing.Size(63, 20);
            this.hc.TabIndex = 7;
            // 
            // HardCopy
            // 
            this.HardCopy.AutoSize = true;
            this.HardCopy.Location = new System.Drawing.Point(21, 126);
            this.HardCopy.Name = "HardCopy";
            this.HardCopy.Size = new System.Drawing.Size(54, 13);
            this.HardCopy.TabIndex = 6;
            this.HardCopy.Text = "HardCopy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NUMID";
            // 
            // NUMID
            // 
            this.NUMID.Location = new System.Drawing.Point(72, 19);
            this.NUMID.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUMID.Name = "NUMID";
            this.NUMID.Size = new System.Drawing.Size(63, 20);
            this.NUMID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Console";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(72, 88);
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(146, 20);
            this.textBoxConsole.TabIndex = 2;
            // 
            // textboxgame
            // 
            this.textboxgame.Location = new System.Drawing.Point(72, 50);
            this.textboxgame.Name = "textboxgame";
            this.textboxgame.Size = new System.Drawing.Size(316, 20);
            this.textboxgame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 242);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Game library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMID)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxgame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUMID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.TextBox hc;
        private System.Windows.Forms.Label HardCopy;
        private System.Windows.Forms.Button Savepre;
        private System.Windows.Forms.Button Arrayview;
    }
}

