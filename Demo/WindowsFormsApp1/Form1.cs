﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IAuthorService _authorService;
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void dgwAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
