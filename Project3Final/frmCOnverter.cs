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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    /// <summary>
    /// Partial forms class to handle form events
    /// </summary>
    public partial class frmConverter : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public frmConverter()
        {
            InitializeComponent();
            this.Text = AssemblyTitle;
            lblConvertedText.Text = String.Format("Integer Value in Base {0}", nudBase.Value);
        }

        /// <summary>
        /// Retreives the title from the assemble file
        /// </summary>
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Converts User specified decimal value to user specified base number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertFromDecimal_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDecimal.Text))
            {
                int toConvert = Int32.Parse(txtDecimal.Text);
                int targetBase = (int)nudBase.Value;
                int digits = (int)nudResultPlaces.Value;

                txtConverted.Text = BaseConverter.FromDecimal(toConvert, targetBase, digits);
                lblArrow.Text = "---->";
                
            }
        }

        /// <summary>
        /// Event for close button that closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (!String.IsNullOrEmpty(txtConverted.Text))
            {
                
                Regex wordPattern = new Regex(@"[A-Z]");
                if (wordPattern.IsMatch(txtConverted.Text) && nudBase.Value < 10) // Don't allow the user to input letters for bases less than 11 
                {
                    MessageBox.Show("A base less than 11 cannot contain Letters.", "Error");
                    return;
                }
                txtDecimal.Text = BaseConverter.ToDecimal(txtConverted.Text, (int)nudBase.Value).ToString();

                lblArrow.Text = "<----";
            }
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
            //If the base is less than 10 only allow characters that are less than the base to be entered. If the base is 10 or greater allow 0-9 to be entered
            if ((e.KeyChar >= '0' && e.KeyChar <= ((nudBase.Value < 10) ? char.Parse((nudBase.Value - 1).ToString()) : '9')) || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Value changed event for nudBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudBase_ValueChanged(object sender, EventArgs e)
        {
            lblConvertedText.Text = String.Format("Integer Value in Base {0}", nudBase.Value);
        }

        /// <summary>
        /// Method displays goodbye message to user upon closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you for using the Base Conversion Program.", "Goodbye");
        }

    }
}
