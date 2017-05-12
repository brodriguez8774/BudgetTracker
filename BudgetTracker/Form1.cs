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
            new ComboItem(0, ""),
            new ComboItem(1, "Individual"),
            new ComboItem(2, "Business"),
        };

        private ComboItem[] regionArray = new ComboItem[] {
            new ComboItem(0, ""),
            new ComboItem(1, "AL"),
            new ComboItem(2, "AK"),
            new ComboItem(3, "AZ"),
            new ComboItem(4, "AR"),
            new ComboItem(5, "CA"),
            new ComboItem(6, "CO"),
            new ComboItem(7, "CT"),
            new ComboItem(8, "DE"),
            new ComboItem(9, "FL"),
            new ComboItem(10, "GA"),
            new ComboItem(11, "HI"),
            new ComboItem(12, "ID"),
            new ComboItem(13, "IL"),
            new ComboItem(14, "IN"),
            new ComboItem(15, "IA"),
            new ComboItem(16, "KS"),
            new ComboItem(17, "KY"),
            new ComboItem(18, "LA"),
            new ComboItem(19, "ME"),
            new ComboItem(20, "MD"),
            new ComboItem(21, "MA"),
            new ComboItem(22, "MI"),
            new ComboItem(23, "MN"),
            new ComboItem(24, "MS"),
            new ComboItem(25, "MO"),
            new ComboItem(26, "MT"),
            new ComboItem(27, "NE"),
            new ComboItem(28, "NV"),
            new ComboItem(29, "NH"),
            new ComboItem(30, "NJ"),
            new ComboItem(31, "NM"),
            new ComboItem(32, "NY"),
            new ComboItem(33, "NC"),
            new ComboItem(34, "ND"),
            new ComboItem(35, "OH"),
            new ComboItem(36, "OK"),
            new ComboItem(37, "OR"),
            new ComboItem(38, "PA"),
            new ComboItem(39, "RI"),
            new ComboItem(40, "SC"),
            new ComboItem(41, "SD"),
            new ComboItem(42, "TN"),
            new ComboItem(43, "TX"),
            new ComboItem(44, "UT"),
            new ComboItem(45, "VT"),
            new ComboItem(46, "VA"),
            new ComboItem(47, "WA"),
            new ComboItem(48, "WV"),
            new ComboItem(49, "WI"),
            new ComboItem(50, "WY"),
        };

        #endregion Variables

        public Form1()
        {
            InitializeComponent();

            // Populate fields of Transactor Tab.
            categoryComboBox.Items.AddRange(categoryArray);
            regionComboBox.Items.AddRange(regionArray);
            categoryComboBox.SelectedIndex = 0;
            regionComboBox.SelectedIndex = 0;

            // Set defaults of Transactor Tab.
            HideCategoryComboBoxControl();
            HideTransactorControls();
            HideCancelTransactorButton();
            ResetCategoryComboboxControl();
            ResetTransactorControls();
        }

        #region Transactor Tab

        private void addTransactorButton_Click(object sender, EventArgs e)
        {
            ShowCategoryComboBoxControl();
            ShowCancelTransactorButton();
        }


        private void editTransactorButton_Click(object sender, EventArgs e)
        {

        }


        private void removeTransactorButton_Click(object sender, EventArgs e)
        {

        }


        #region Show/Hide Methods

        /// <summary>
        /// Show categoryComboBox.
        /// </summary>
        private void ShowCategoryComboBoxControl()
        {
            categoryLabel.Visible = true;
            categoryComboBox.Visible = true;
        }


        /// <summary>
        /// Hide categoryComboBox.
        /// </summary>
        private void HideCategoryComboBoxControl()
        {
            categoryLabel.Visible = false;
            categoryComboBox.Visible = false;
        }


        /// <summary>
        /// Shows controls in Transactor Tab.
        /// </summary>
        private void ShowTransactorControls()
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
            addressLabel.Visible = true;
            addressTextBox.Visible = true;
            cityLabel.Visible = true;
            cityTextBox.Visible = true;
            regionLabel.Visible = true;
            regionComboBox.Visible = true;
            postalCodeLabel.Visible = true;
            postalCodeTextBox.Visible = true;
            saveTransactorButton.Visible = true;
        }


        /// <summary>
        /// Hides controls in Transactor Tab.
        /// </summary>
        private void HideTransactorControls()
        {
            firstNameLabel.Visible = false;
            firstNameTextBox.Visible = false;
            lastNameLabel.Visible = false;
            lastNameTextBox.Visible = false;
            phoneLabel1.Visible = false;
            phoneLabel2.Visible = false;
            phoneLabel3.Visible = false;
            phoneTextBox1.Visible = false;
            phoneTextBox2.Visible = false;
            phoneTextBox3.Visible = false;
            addressLabel.Visible = false;
            addressTextBox.Visible = false;
            cityLabel.Visible = false;
            cityTextBox.Visible = false;
            regionLabel.Visible = false;
            regionComboBox.Visible = false;
            postalCodeLabel.Visible = false;
            postalCodeTextBox.Visible = false;
            saveTransactorButton.Visible = false;
        }


        /// <summary>
        /// Shows cancel button in transactor tab.
        /// </summary>
        private void ShowCancelTransactorButton()
        {
            cancelTransactorButton.Visible = true;
        }


        private void HideCancelTransactorButton()
        {
            cancelTransactorButton.Visible = false;
        }


        #endregion Show/Hide Methods



        #region Reset Methods

        /// <summary>
        /// Reset categoryComboBox.
        /// </summary>
        private void ResetCategoryComboboxControl()
        {
            categoryComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// Resets Transactor Tab back to default text values.
        /// </summary>
        private void ResetTransactorControls()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneTextBox1.Clear();
            phoneTextBox2.Clear();
            phoneTextBox3.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            regionComboBox.SelectedIndex = 0;
            postalCodeTextBox.Clear();
        }

        #endregion Reset Methods


        /// <summary>
        /// Populate transactor form fields based on categoryComboBox index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex == 0)
            {
                HideTransactorControls();
                ResetTransactorControls();
            }

            if (categoryComboBox.SelectedIndex == 1)
            {
                firstNameLabel.Text = "First Name:";
                lastNameLabel.Text = "Last Name";
                ShowTransactorControls();
            }

            if (categoryComboBox.SelectedIndex == 2)
            {
                firstNameLabel.Text = "Primary Business Name:";
                lastNameLabel.Text = "Secondary Business Name (Optional):";
                ShowTransactorControls();
            }
        }


        private void saveTransactorButton_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Cancel current transactor tab action and hide/reset all fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelTransactorButton_Click(object sender, EventArgs e)
        {
            HideTransactorControls();
            HideCategoryComboBoxControl();
            HideCancelTransactorButton();
            ResetTransactorControls();
            ResetCategoryComboboxControl();
        }

        #endregion Transactor Tab

    }
}
