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

        private Controller controller = Controller.Get();

        private bool isValidBool;

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
            HideErrorLabel();
            ResetCategoryComboboxControl();
            ResetTransactorControls();
            ResetErrorLabel();

        }

        #region Transactor Tab


        #region Buttons

        private void AddTransactorButton_Click(object sender, EventArgs e)
        {
            ShowCategoryComboBoxControl();
            ShowCancelTransactorButton();
        }


        private void EditTransactorButton_Click(object sender, EventArgs e)
        {

        }


        private void RemoveTransactorButton_Click(object sender, EventArgs e)
        {

        }


        private void SaveTransactorButton_Click(object sender, EventArgs e)
        {
            isValidBool = true;

            string category = categoryComboBox.SelectedIndex.ToString();
            string primaryName = ValidatePrimaryName();
            string secondaryName = ValidateSecondaryName();
            string phoneNumber = ValidatePhoneNumber();
            string street = ValidateStreet();
            string city = ValidateCity();
            string region = ValidateRegion();
            string postalCode = ValidatePostalCode();

            if (isValidBool)
            {
                transactorListBox.Items.Add(controller.SaveTransactor(category, primaryName, secondaryName, phoneNumber, street, city, region, postalCode));
            }
        }


        /// <summary>
        /// Cancel current transactor tab action and hide/reset all fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelTransactorButton_Click(object sender, EventArgs e)
        {
            HideTransactorControls();
            HideCategoryComboBoxControl();
            HideCancelTransactorButton();
            HideErrorLabel();
            ResetTransactorControls();
            ResetCategoryComboboxControl();
            ResetErrorLabel();
        }


        #endregion Buttons


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
        /// Shows general controls in Transactor Tab.
        /// </summary>
        private void ShowTransactorControls()
        {
            primaryNameLabel.Visible = true;
            primaryNameTextBox.Visible = true;
            secondaryNameLabel.Visible = true;
            secondaryNameTextBox.Visible = true;
            phoneLabel1.Visible = true;
            phoneLabel2.Visible = true;
            phoneLabel3.Visible = true;
            phoneTextBox1.Visible = true;
            phoneTextBox2.Visible = true;
            phoneTextBox3.Visible = true;
            addressLabel.Visible = true;
            streetTextBox.Visible = true;
            cityLabel.Visible = true;
            cityTextBox.Visible = true;
            regionLabel.Visible = true;
            regionComboBox.Visible = true;
            postalCodeLabel.Visible = true;
            postalCodeTextBox.Visible = true;
            saveTransactorButton.Visible = true;
        }


        /// <summary>
        /// Hides general controls in Transactor Tab.
        /// </summary>
        private void HideTransactorControls()
        {
            primaryNameLabel.Visible = false;
            primaryNameTextBox.Visible = false;
            secondaryNameLabel.Visible = false;
            secondaryNameTextBox.Visible = false;
            phoneLabel1.Visible = false;
            phoneLabel2.Visible = false;
            phoneLabel3.Visible = false;
            phoneTextBox1.Visible = false;
            phoneTextBox2.Visible = false;
            phoneTextBox3.Visible = false;
            addressLabel.Visible = false;
            streetTextBox.Visible = false;
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


        /// <summary>
        /// Hides cancel button in transactor tab.
        /// </summary>
        private void HideCancelTransactorButton()
        {
            cancelTransactorButton.Visible = false;
        }


        /// <summary>
        /// Shows error label in transactor tab.
        /// </summary>
        private void ShowErrorLabel()
        {
            errorLabel.Visible = true;
        }


        /// <summary>
        /// Hides error label in transactor tab.
        /// </summary>
        private void HideErrorLabel()
        {
            errorLabel.Visible = false;
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
        /// Resets general Transactor Tab back to default text values.
        /// </summary>
        private void ResetTransactorControls()
        {
            primaryNameTextBox.Clear();
            secondaryNameTextBox.Clear();
            phoneTextBox1.Clear();
            phoneTextBox2.Clear();
            phoneTextBox3.Clear();
            streetTextBox.Clear();
            cityTextBox.Clear();
            regionComboBox.SelectedIndex = 0;
            postalCodeTextBox.Clear();
        }


        /// <summary>
        /// Resets errorLabel.
        /// </summary>
        private void ResetErrorLabel()
        {
            errorLabel.Text = "Errors:" + Environment.NewLine;
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
                primaryNameLabel.Text = "First Name:";
                secondaryNameLabel.Text = "Last Name";
                ShowTransactorControls();
            }

            if (categoryComboBox.SelectedIndex == 2)
            {
                primaryNameLabel.Text = "Primary Business Name:";
                secondaryNameLabel.Text = "Secondary Business Name (Optional):";
                ShowTransactorControls();
            }
        }


        #region Validation

        /// <summary>
        /// Validate Primary Name.
        /// </summary>
        private string ValidatePrimaryName()
        {
            string primaryName = primaryNameTextBox.Text.Trim();

            if (primaryName.Length == 0)
            {
                // Is not of proper length.
                isValidBool = false;
                if (categoryComboBox.SelectedIndex == 1)
                {
                    errorLabel.Text += "Invalid First Name" + Environment.NewLine;
                }
                else if (categoryComboBox.SelectedIndex == 2)
                {
                    errorLabel.Text += "Invalid Primary Name" + Environment.NewLine;
                }
                ShowErrorLabel();
            }

            return primaryName;
        }

        /// <summary>
        /// Validate Secondary Name.
        /// </summary>
        private string ValidateSecondaryName()
        {
            string secondaryName = secondaryNameTextBox.Text.Trim();

            // Field is optional is category "business" is selected.
            if (categoryComboBox.SelectedIndex != 2)
            {
                if (secondaryName.Length == 0)
                {
                    // Is not of proper length.
                    isValidBool = false;
                    errorLabel.Text += "Invalid Last Name" + Environment.NewLine;
                    ShowErrorLabel();
                }
            }

            return secondaryName;
        }


        /// <summary>
        /// Validate Phone Number.
        /// </summary>
        private string ValidatePhoneNumber()
        {
            string phoneNumber = (phoneTextBox1.Text.Trim() + phoneTextBox2.Text.Trim() + phoneTextBox3.Text.Trim());

            try
            {
                long.Parse(phoneNumber);
                if (phoneNumber.Length != 10)
                {
                    // Is not of proper length.
                    isValidBool = false;
                    errorLabel.Text += "Invalid Phone Number" + Environment.NewLine;
                    ShowErrorLabel();
                }
            }
            catch
            {
                // Is not of type long.
                isValidBool = false;
                errorLabel.Text += "Invalid Phone Number" + Environment.NewLine;
                ShowErrorLabel();
            }

            return phoneNumber;
        }


        /// <summary>
        /// Validate Street.
        /// </summary>
        private string ValidateStreet()
        {
            string street = streetTextBox.Text.Trim();

            if (street.Length == 0)
            {
                // Is not of proper length.
                isValidBool = false;
                errorLabel.Text += "Invalid Street" + Environment.NewLine;
                ShowErrorLabel();
            }

            return street;
        }


        /// <summary>
        /// Validate City.
        /// </summary>
        private string ValidateCity()
        {
            string city = cityTextBox.Text.Trim();

            if (city.Length == 0)
            {
                // Is not of proper length.
                isValidBool = false;
                errorLabel.Text += "Invalid City" + Environment.NewLine;
                ShowErrorLabel();
            }

            return city;
        }


        /// <summary>
        /// Validate Region.
        /// </summary>
        private string ValidateRegion()
        {
            if (regionComboBox.SelectedIndex == 0)
            {
                // Is not valid selection.
                isValidBool = false;
                errorLabel.Text += "Invalid Region" + Environment.NewLine;
                ShowErrorLabel();
            }

            return regionComboBox.SelectedIndex.ToString();
        }


        /// <summary>
        /// Validate PostalCode.
        /// </summary>
        private string ValidatePostalCode()
        {
            string postalCode = postalCodeTextBox.Text.Trim();

            try
            {
                Int32.Parse(postalCode);
                if ((postalCode.Length < 3 || postalCode.Length > 10))
                {
                    // Is not of proper length.
                    isValidBool = false;
                    errorLabel.Text += "Invalid Zip" + Environment.NewLine;
                    ShowErrorLabel();
                }
            }
            catch
            {
                // Is not of type int.
                isValidBool = false;
                errorLabel.Text += "Invalid Zip" + Environment.NewLine;
                ShowErrorLabel();
            }
            

            return postalCode;
        }

        #endregion Validation


        private void UpdateTransactorListBox(Entity[] entityArray)
        {
            for (int index = 0; entityArray[index] != null; index++)
            {
                transactorListBox.Items.Add(entityArray[index].ToString());
            }
        }

        #endregion Transactor Tab

    }
}
