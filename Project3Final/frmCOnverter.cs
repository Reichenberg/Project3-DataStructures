//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Project 3
//	File Name:		frmConverter.cs
//	Description:    Handles conversion of various bases
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Chance Reichenberg, reichenberg@etsu.edu, Department of Computing, East Tennessee State University
//	Created:	    Friday, April 3, 2015
//	Copyright:		Chance Reichenberg, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    /// <summary>
    /// Partial forms class to handle form events
    /// </summary>
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Converts User specified decimal value to user specified base number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertFromDecimal_Click(object sender, EventArgs e)
        {
            int toConvert = Int32.Parse(txtDecimal.Text);
            int targetBase = (int)nudBase.Value;

            txtConverted.Text = BaseConverter.FromDecimal(toConvert, targetBase);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Converts user specified base number to base 10 decimal value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertToDecimal_Click(object sender, EventArgs e)
        {
            txtDecimal.Text = BaseConverter.ToDecimal(txtConverted.Text, (int)nudBase.Value).ToString();
        }

        /// <summary>
        /// Prevents User from inputing incorrect data into the decimal text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Prevents user from entering incorrect data into the converted text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtConverted_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
