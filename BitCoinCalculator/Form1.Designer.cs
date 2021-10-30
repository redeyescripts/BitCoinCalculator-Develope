
using System;

namespace BitCoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.currency2 = new System.Windows.Forms.ComboBox();
            this.RatesBtn = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bITCOINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOGECOINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculated = new System.Windows.Forms.TextBox();
            this.currencyshow = new System.Windows.Forms.TextBox();
            this.nupp1 = new System.Windows.Forms.Button();
            this.result2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyMenu.Location = new System.Drawing.Point(55, 205);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(137, 28);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select Currency";
            this.currencyMenu.SelectedIndexChanged += new System.EventHandler(this.currencyMenu_SelectedIndexChanged);
            // 
            // currency2
            // 
            this.currency2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency2.FormattingEnabled = true;
            this.currency2.Items.AddRange(new object[] {
            "EURO",
            "US"});
            this.currency2.Location = new System.Drawing.Point(608, 205);
            this.currency2.Name = "currency2";
            this.currency2.Size = new System.Drawing.Size(137, 28);
            this.currency2.TabIndex = 8;
            this.currency2.Text = "Select Currency";
            // 
            // RatesBtn
            // 
            this.RatesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RatesBtn.ForeColor = System.Drawing.Color.White;
            this.RatesBtn.Location = new System.Drawing.Point(82, 147);
            this.RatesBtn.Name = "RatesBtn";
            this.RatesBtn.Size = new System.Drawing.Size(75, 23);
            this.RatesBtn.TabIndex = 1;
            this.RatesBtn.Text = "Rates";
            this.RatesBtn.UseVisualStyleBackColor = false;
            this.RatesBtn.Click += new System.EventHandler(this.RatesBtn_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.BackColor = System.Drawing.Color.Aqua;
            this.amountOfBtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOfBtc.Location = new System.Drawing.Point(46, 256);
            this.amountOfBtc.Multiline = true;
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.Size = new System.Drawing.Size(153, 38);
            this.amountOfBtc.TabIndex = 2;
            this.amountOfBtc.Text = "Amount ";
            this.amountOfBtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountOfBtc.UseWaitCursor = true;
            this.amountOfBtc.TextChanged += new System.EventHandler(this.amountOfDoge_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(100, 368);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(37, 13);
            this.result.TabIndex = 3;
            this.result.Text = "Result";
            this.result.Visible = false;
            // 
            // result1
            // 
            this.result1.BackColor = System.Drawing.Color.Blue;
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.ForeColor = System.Drawing.Color.Red;
            this.result1.Location = new System.Drawing.Point(46, 316);
            this.result1.Multiline = true;
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(153, 39);
            this.result1.TabIndex = 4;
            this.result1.Text = "Results";
            this.result1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result1.Visible = false;
            this.result1.TextChanged += new System.EventHandler(this.result1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bITCOINToolStripMenuItem,
            this.dOGECOINToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "MENU";
            // 
            // bITCOINToolStripMenuItem
            // 
            this.bITCOINToolStripMenuItem.Name = "bITCOINToolStripMenuItem";
            this.bITCOINToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bITCOINToolStripMenuItem.Text = "BITCOIN";
            // 
            // dOGECOINToolStripMenuItem
            // 
            this.dOGECOINToolStripMenuItem.Name = "dOGECOINToolStripMenuItem";
            this.dOGECOINToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dOGECOINToolStripMenuItem.Text = "DOGECOIN";
            // 
            // Calculated
            // 
            this.Calculated.BackColor = System.Drawing.Color.Blue;
            this.Calculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculated.ForeColor = System.Drawing.Color.Red;
            this.Calculated.Location = new System.Drawing.Point(598, 316);
            this.Calculated.Multiline = true;
            this.Calculated.Name = "Calculated";
            this.Calculated.Size = new System.Drawing.Size(153, 39);
            this.Calculated.TabIndex = 6;
            this.Calculated.Text = "Results";
            this.Calculated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Calculated.Visible = false;
            this.Calculated.TextChanged += new System.EventHandler(this.tulemus_TextChanged);
            // 
            // currencyshow
            // 
            this.currencyshow.BackColor = System.Drawing.Color.Aqua;
            this.currencyshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyshow.Location = new System.Drawing.Point(598, 256);
            this.currencyshow.Multiline = true;
            this.currencyshow.Name = "currencyshow";
            this.currencyshow.Size = new System.Drawing.Size(153, 38);
            this.currencyshow.TabIndex = 7;
            this.currencyshow.Text = "Amount";
            this.currencyshow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nupp1
            // 
            this.nupp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nupp1.ForeColor = System.Drawing.Color.White;
            this.nupp1.Location = new System.Drawing.Point(637, 147);
            this.nupp1.Name = "nupp1";
            this.nupp1.Size = new System.Drawing.Size(75, 23);
            this.nupp1.TabIndex = 9;
            this.nupp1.Text = "Rates";
            this.nupp1.UseVisualStyleBackColor = false;
            this.nupp1.Click += new System.EventHandler(this.currency2_Click);
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Location = new System.Drawing.Point(656, 368);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(37, 13);
            this.result2.TabIndex = 10;
            this.result2.Text = "Result";
            this.result2.Click += new System.EventHandler(this.result2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 72);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(640, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 72);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.nupp1);
            this.Controls.Add(this.currency2);
            this.Controls.Add(this.currencyshow);
            this.Controls.Add(this.Calculated);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.RatesBtn);
            this.Controls.Add(this.currencyMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BitCoinCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void currency2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button RatesBtn;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bITCOINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOGECOINToolStripMenuItem;
        private System.Windows.Forms.TextBox Calculated;
        private System.Windows.Forms.TextBox currencyshow;
        private System.Windows.Forms.Button nupp1;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.ComboBox currency2;
    }
}

