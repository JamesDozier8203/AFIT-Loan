﻿using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Drawing;
using System.Linq;
using Wisej.Web;

namespace AFIT_Cooperative.Dashboard
{
    public partial class Index : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        Member currentMember;
        Account account;

        public Index(Member member)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentMember = member;
        }

        private void Index_Appear(object sender, EventArgs e)
        {
            LoadPayHistory();
        }

        public void LoadPayHistory()
        {
            account = _context.Accounts.SingleOrDefault((a) => a.Member.Id == currentMember.Id);
            lblWallet.Text = account.Wallet.ToString("N###,##0.00");

            btnStatusIndicator.Visible = false;
            lblLoanAmount.Text = "N0.00";
            lblLoanBalance.Text = "N0.00";
            Loan currentLoan = account.Loan;
            if (currentLoan != null)
            {
                btnStatusIndicator.Visible = true;
                lblLoanAmount.Text = currentLoan.AmountPayable.ToString("N###,##0.00");
                btnStatusIndicator.Text = currentLoan.Status == 0 ? "Pending" : 
                    currentLoan.Status == 1 ? "Active" : "Declined";

                if (currentLoan.Status == 1)
                {
                    lblLoanBalance.Text = currentLoan.Balance.ToString("N###,##0.00");
                    btnStatusIndicator.ForeColor = Color.Green;
                    btnStatusIndicator.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/dot-circle-o.svg";
                }
                else
                {
                    lblLoanBalance.Text = "N0.00";
                    btnStatusIndicator.ForeColor = Color.Goldenrod;
                    btnStatusIndicator.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/ban.svg";
                    if (currentLoan.Status < 0)
                    {
                        btnStatusIndicator.ForeColor = Color.Red;
                        btnStatusIndicator.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/times-circle-o.svg";
                    }
                }
            }

            var hList = _context.PaymentHistories.Where((h) => h.Member.Id == currentMember.Id).ToList();

            var histories = hList.Select((h) =>
                new PaymentHistoryDisplay
                {
                    Id = h.Id,
                    Fullname = h.Member.Fullname,
                    Amount = h.Amount.ToString("###,##0.00"),
                    Date = h.PaidAt.ToString("ddd dd MMMM, yyyy")
                }).ToList();

            dataGridView1.DataSource = histories;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Fullname"].Visible = false;
            dataGridView1.Columns["Amount"].Width = 200;
            dataGridView1.Columns["Date"].Width = 200;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if(account.Loan == null || account.Loan.Status < 1)
            {
                MessageBox.Show("No active loan");
                return;
            }
            PayLoan payLoan = new PayLoan(account);
            payLoan.ShowDialog();
            LoadPayHistory();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (account.Loan != null && account.Loan.Status != -1)
            {
                if(account.Loan.Status == 1)
                    MessageBox.Show("You have an active loan");
                if (account.Loan.Status == 0)
                    MessageBox.Show("Your loan request is still pending");
                return;
            }
            ApplyLoan applyLoan = new ApplyLoan(account);
            applyLoan.ShowDialog();
            LoadPayHistory();
        }
    }
}
