﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.MainForm.TeacherPage;

namespace GUI
{
    public partial class MainFormQuiz : Form
    {
        private AccountResponse account;
        public MainFormQuiz(AccountResponse _account)
        {
            account = _account;
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            guna2CustomGradientPanel1.Controls.Clear();
            Control uc = new TeacherPage(account);
            uc.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Add(uc);
        }

        private void MainFormQuizApp_Load(object sender, EventArgs e)
        {

        }

        private void MainFormQuizApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}