﻿
namespace AFIT_Cooperative.Dashboard
{
    partial class FundWallet
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            this.panel1 = new Wisej.Web.Panel();
            this.nudYear = new Wisej.Web.NumericUpDown();
            this.nudMonth = new Wisej.Web.NumericUpDown();
            this.panel2 = new Wisej.Web.Panel();
            this.nudAmount = new Wisej.Web.NumericUpDown();
            this.txtCVV = new Wisej.Web.TextBox();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.txtCarcNumber = new Wisej.Web.MaskedTextBox();
            this.btnPay = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudYear);
            this.panel1.Controls.Add(this.nudMonth);
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel1.Location = new System.Drawing.Point(46, 258);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(240, 76);
            this.panel1.TabIndex = 27;
            this.panel1.TabStop = true;
            this.panel1.Text = "Expiration Date";
            // 
            // nudYear
            // 
            this.nudYear.AutoSize = false;
            this.nudYear.CssStyle = "border-radius: 3px";
            this.nudYear.Location = new System.Drawing.Point(98, 3);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(139, 42);
            this.nudYear.TabIndex = 1;
            this.nudYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // nudMonth
            // 
            this.nudMonth.AutoSize = false;
            this.nudMonth.CssStyle = "border-radius: 3px";
            this.nudMonth.Location = new System.Drawing.Point(5, 3);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(87, 42);
            this.nudMonth.TabIndex = 0;
            this.nudMonth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudAmount);
            this.panel2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel2.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel2.Location = new System.Drawing.Point(46, 102);
            this.panel2.Name = "panel2";
            this.panel2.ShowCloseButton = false;
            this.panel2.ShowHeader = true;
            this.panel2.Size = new System.Drawing.Size(337, 76);
            this.panel2.TabIndex = 29;
            this.panel2.TabStop = true;
            this.panel2.Text = "Amount (NGN)";
            // 
            // nudAmount
            // 
            this.nudAmount.AutoSize = false;
            this.nudAmount.CssStyle = "border-radius: 3px";
            this.nudAmount.Location = new System.Drawing.Point(5, 3);
            this.nudAmount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(325, 42);
            this.nudAmount.TabIndex = 0;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // txtCVV
            // 
            this.txtCVV.CssStyle = "border-radius: 3px";
            this.txtCVV.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCVV.LabelText = "CVV/CVC";
            this.txtCVV.Location = new System.Drawing.Point(289, 263);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Padding = new Wisej.Web.Padding(12);
            this.txtCVV.Size = new System.Drawing.Size(85, 68);
            this.txtCVV.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/meanpath.svg";
            this.pictureBox1.Location = new System.Drawing.Point(179, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            // 
            // txtCarcNumber
            // 
            this.txtCarcNumber.CssStyle = "border-radius: 3px";
            this.txtCarcNumber.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarcNumber.LabelText = "Card Number";
            this.txtCarcNumber.Location = new System.Drawing.Point(51, 184);
            this.txtCarcNumber.Mask = "0000 0000 0000 0000 000";
            this.txtCarcNumber.Name = "txtCarcNumber";
            this.txtCarcNumber.Padding = new Wisej.Web.Padding(12);
            this.txtCarcNumber.PromptChar = ' ';
            this.txtCarcNumber.Size = new System.Drawing.Size(325, 68);
            this.txtCarcNumber.TabIndex = 32;
            this.txtCarcNumber.TextMaskFormat = Wisej.Web.MaskFormat.ExcludePromptAndLiterals;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/credit-card.svg";
            componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
            this.txtCarcNumber.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnPay.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnPay.Location = new System.Drawing.Point(46, 359);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(330, 42);
            this.btnPay.TabIndex = 31;
            this.btnPay.Text = "Pay NGN 0";
            this.btnPay.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // FundWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCarcNumber);
            this.Controls.Add(this.btnPay);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.IconSource = "resource.wx/Wisej.Ext.FontAwesome/lock.svg";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FundWallet";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Fund Wallet";
            this.Load += new System.EventHandler(this.FundWallet_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.NumericUpDown nudYear;
        private Wisej.Web.NumericUpDown nudMonth;
        private Wisej.Web.Panel panel2;
        public Wisej.Web.NumericUpDown nudAmount;
        private Wisej.Web.TextBox txtCVV;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.MaskedTextBox txtCarcNumber;
        private Wisej.Web.Button btnPay;
    }
}