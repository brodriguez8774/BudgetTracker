using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BudgetTracker.DataStructures;
using BudgetTracker.Models;


namespace BudgetTracker
{
    public partial class Form1 : Form
    {
        #region Variables

        private ComboItem[] categoryArray = new ComboItem[] {
            new ComboItem(0, "Person"),
            new ComboItem(1, "Business"),
        };

        private ComboItem[] regionArray = new ComboItem[] {
            new ComboItem(0, "AL"),
            new ComboItem(1, "AK"),
            new ComboItem(2, "AZ"),
            new ComboItem(3, "AR"),
            new ComboItem(4, "CA"),
            new ComboItem(5, "CO"),
            new ComboItem(6, "CT"),
            new ComboItem(7, "DE"),
            new ComboItem(8, "FL"),
            new ComboItem(9, "GA"),
            new ComboItem(10, "HI"),
            new ComboItem(11, "ID"),
            new ComboItem(12, "IL"),
            new ComboItem(13, "IN"),
            new ComboItem(14, "IA"),
            new ComboItem(15, "KS"),
            new ComboItem(16, "KY"),
            new ComboItem(17, "LA"),
            new ComboItem(18, "ME"),
            new ComboItem(19, "MD"),
            new ComboItem(20, "MA"),
            new ComboItem(21, "MI"),
            new ComboItem(22, "MN"),
            new ComboItem(23, "MS"),
            new ComboItem(24, "MO"),
            new ComboItem(25, "MT"),
            new ComboItem(26, "NE"),
            new ComboItem(27, "NV"),
            new ComboItem(28, "NH"),
            new ComboItem(29, "NJ"),
            new ComboItem(30, "NM"),
            new ComboItem(31, "NY"),
            new ComboItem(32, "NC"),
            new ComboItem(33, "ND"),
            new ComboItem(34, "OH"),
            new ComboItem(35, "OK"),
            new ComboItem(36, "OR"),
            new ComboItem(37, "PA"),
            new ComboItem(38, "RI"),
            new ComboItem(39, "SC"),
            new ComboItem(40, "SD"),
            new ComboItem(41, "TN"),
            new ComboItem(42, "TX"),
            new ComboItem(43, "UT"),
            new ComboItem(44, "VT"),
            new ComboItem(45, "VA"),
            new ComboItem(46, "WA"),
            new ComboItem(47, "WV"),
            new ComboItem(48, "WI"),
            new ComboItem(49, "WY"),
        };

        #endregion Variables

        public Form1()
        {
            InitializeComponent();

            categoryComboBox.Items.AddRange(categoryArray);
            regionComboBox.Items.AddRange(regionArray);
        }

        #region Transactor Tab

        private void addTransactorButton_Click(object sender, EventArgs e)
        {

        }

        private void editTransactorButton_Click(object sender, EventArgs e)
        {

        }

        private void removeTransactorButton_Click(object sender, EventArgs e)
        {

        }

        #endregion Transactor Tab


        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstNameLabel.Visible = true;
            firstNameTextBox.Visible = true;
            lastNameLabel.Visible = true;
            lastNameTextBox.Visible = true;
            phoneLabel1.Visible = true;
            phoneLabel2.Visible = true;
            phoneLabel3.Visible = true;
            phoneTextBox1.Visible = true;
            phoneTextBox2.Visible = true;
            phoneTextBox3.Visible = true;
        }
    }
}
