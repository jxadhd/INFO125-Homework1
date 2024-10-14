using System;
using System.Windows.Forms;

// Simple order form for food parcel delivery
namespace jcr168_Homework1
{
    // Intialises WinForm
    public partial class Hungry : Form
    {
        // Price constants
        const float PRICE_FOR_TWO = 15f;
        const float PRICE_FOR_FOUR = 20f;
        const float PRICE_FOR_SIX = 30f;
        // Price multiplier constants
        const float MULTIPLIER_BRONZE = 1.1f;
        const float MULTIPLIER_SILVER = 1.05f;
        const float MULTIPLIER_GOLD = 1.0f;
        // Discount constants
        const float DISCOUNT_TWO_TYPE = 0.03f;
        const float DISCOUNT_THREE_TYPE = 0.05f;
        // Tax constant
        const float TAX_AMOUNT = 0.08f;

        public Hungry()
        {
            InitializeComponent();
        }

        private void checkTwo_CheckedChanged(object sender, EventArgs e)
        {
            numericTwo.Enabled = checkTwo.Checked;
            if (!checkTwo.Checked)
            {
                numericTwo.Value = 0;

            }

        }

        private void checkFour_CheckedChanged(object sender, EventArgs e)
        {
            numericFour.Enabled = checkFour.Checked;
            if (!checkFour.Checked)
            {
                numericFour.Value = 0;
            }
        }

        private void checkSix_CheckedChanged(object sender, EventArgs e)
        {
            numericSix.Enabled = checkSix.Checked;
            if (!checkSix.Checked)
            {
                numericSix.Value = 0;
            }
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Change to say "Recalculate"
            buttonCalculate.Text = "Recalculate";

            // Error string
            string errorMessage0Checked = "Invalid Input - Please select 1 or more of all checked meal types!";

            // Declare variables to hold quantities as int
            int twoQuant = int.Parse(numericTwo.Text);
            int fourQuant = int.Parse(numericFour.Text);
            int sixQuant = int.Parse(numericSix.Text);

            // Calculate total quantity for later use
            int totalQuant = twoQuant + fourQuant + sixQuant;

            // Subtotal initial math logic
            float subTotal = (twoQuant * PRICE_FOR_TWO + fourQuant * PRICE_FOR_FOUR + sixQuant * PRICE_FOR_SIX);

            // Count up number of types customer is ordering and store in totalType
            // Input validation against totalType = 0 for each meal type
            int totalType = 0;
            // Was initially using an errorMessage0Checked as input validation, however now we simply fix on behalf of the user :)
            // string errorMessage0Checked = "Can't select a meal type and order 0!";
            if (checkTwo.Checked == true)
            {
                if (twoQuant == 0)
                {
                    MessageBox.Show(errorMessage0Checked);
                    checkTwo.Checked = false;
                   // numericTwo.Enabled = false;
                }
                else
                {
                    totalType += 1;
                }

            }

            if (checkFour.Checked == true)
            {
                if (fourQuant == 0)
                {
                    MessageBox.Show(errorMessage0Checked);
                    checkFour.Checked = false;

                   // numericFour.Enabled = false;
                }
                else
                {
                    totalType += 1;
                }

            }

            if (checkSix.Checked == true)
            {
                if (sixQuant == 0)
                {
                    MessageBox.Show(errorMessage0Checked);
                    checkSix.Checked = false;
                   // numericSix.Enabled = false;
                }
                else
                {
                    totalType += 1;
                }

            }

            // Input validation to ensure at least one meal type is selected
            if (totalType == 0 | totalQuant == 0)
            {
                MessageBox.Show("You must select at least one meal!");
            }

            // Calculate the price and discount through if statements
            // Input validation for 0 is not necessary here (it was already checked)
            // I considered leaving it in for assessment purposes, however opted to take the more efficient option
            // For assessment purposes, to validate against 0 here we would simply adjust the if condition:
            // if (totalQuant > 10 | totalQuant <= 0){...}
            if (totalQuant > 10)
            {
                MessageBox.Show("Order quantity must be between 1 and 10!");
            }
            else if (totalQuant > 0)
            {
                if (!radioBronze.Checked && !radioSilver.Checked && !radioGold.Checked)
                {
                    MessageBox.Show("You must select a subscription type!");
                }
                else
                {
                    float multiplier = 1.0f;
                    switch (true)
                    {
                        case bool _ when radioBronze.Checked:
                            multiplier = MULTIPLIER_BRONZE;
                            break;
                        case bool _ when radioSilver.Checked:
                            multiplier = MULTIPLIER_SILVER;
                            break;
                        case bool _ when radioGold.Checked:
                            multiplier = MULTIPLIER_GOLD;
                            break;
                    }
                    // Run calculations
                    CalculateTotal(subTotal, multiplier, totalType);
                }
            }
        }

        private void CalculateTotal(float subTotal, float multiplier, int totalType)
        {
            // float memberPrice = subTotal * multiplier;
            float discountAmount = 0f;

            if (totalType == 3)
            {
                discountAmount = subTotal * DISCOUNT_THREE_TYPE;
            }
            else if (totalType == 2)
            {
                discountAmount = subTotal * DISCOUNT_TWO_TYPE;
            }

            subTotal -= discountAmount;

            float total = subTotal * multiplier;
            float gstAmount = total * TAX_AMOUNT;

            // Tally up our grand total!
            total += gstAmount;

            textDiscount.Text = discountAmount.ToString("C");
            textGST.Text = gstAmount.ToString("C");
            textTotal.Text = total.ToString("C");

            // Reset totalType for the next calculation
            // This is mostly to catch an exception, it already seems to work fine without this step
            totalType = 0;

            // Activate place order button
            buttonOrder.Enabled = true;

            // Show success label
            labelCalcConfirm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        // User clicks "Exit"
        {
            this.Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        // User clicks "Place my order!"
        {
            // Parse textDiscount.Text and use to decide on which discountConfirmString
            string discountConfirmString = "";
            if (float.Parse(textDiscount.Text, System.Globalization.NumberStyles.Currency) > 0)
            {
                discountConfirmString = $"\nBy ordering multiple varieties, you saved: {textDiscount.Text}\n";
            }
            else
            {
                discountConfirmString = "";
            }

            // Show a confirmation message
            MessageBox.Show($"Order placed successfully. Thanks for your business!\n" +
                                discountConfirmString +
                                $"\nTax amount: {textGST.Text}\n" +
                                $"Order total: {textTotal.Text}");

            // Ask if the user would like to return to the order screen or exit
            string MessageBoxContent = "Chur! Do you want to place another order?";

            DialogResult askuser = MessageBox.Show(MessageBoxContent, "", MessageBoxButtons.YesNo);
            if (askuser == DialogResult.No)
            {
                Application.Exit();
            }

            ValueReset();
        }

        private void ValueReset()
        {
            // Clear the inputs
            numericTwo.Value = 0;
            numericFour.Value = 0;
            numericSix.Value = 0;
            checkTwo.Checked = false;
            checkFour.Checked = false;
            checkSix.Checked = false;
            radioBronze.Checked = false;
            radioSilver.Checked = false;
            radioGold.Checked = false;
            textDiscount.Text = "";
            textGST.Text = "";
            textTotal.Text = "";

            // Hide calculation success label
            labelCalcConfirm.Hide();

            // Deactivate "Place my order!" button
            buttonOrder.Enabled = false;

            // Reset "Calculate" button
            buttonCalculate.Text = "Calculate";

            // Focus to "Calculate" button
            buttonCalculate.Focus();
        }

        private void medalPicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good job, you found an easter egg!");
        }

        private void pictureAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright Josh Cross 2024\n" +
                "All rights reserved.\n" +
                "\nThank you for using my first ever .NET software :)\n" +
                "\nI truly enjoyed (and gained a lot from) this assessment, thank you UC and the INFO125 team!", "Josh Cross is goated");
        }
    }
}