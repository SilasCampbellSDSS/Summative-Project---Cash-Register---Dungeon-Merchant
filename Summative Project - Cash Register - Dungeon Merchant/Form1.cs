using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.Sleep()
using System.Media; //allows the use of Sound Player

namespace Summative_Project___Cash_Register___Dungeon_Merchant
{
    public partial class dungeonMerchant : Form

    {
        //globalvariables
        double weaponPrice = 1200;
        double armourPrice = 500;
        double potionPrice = 125;
        int weaponAmount = 0;
        int armourAmount = 0; 
        int potionAmount = 0;
        double subtotal = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double totalCost = 0;
        int tendered = 0;
        double change = 0;



        public dungeonMerchant()
        {
            InitializeComponent();
        }

        private void merchantInteract_Click(object sender, EventArgs e)
        {
            
            {

                weaponLabel.Visible = true;
                weaponText.Visible = true;
                armourLabel.Visible = true;
                armourText.Visible = true;
                potionLabel.Visible = true;
                potionText.Visible = true;
                calculateButton.Visible = true;
            }
             
        }

        private void calculateButton_Click(object sender, EventArgs e)
        { try
        {

            weaponAmount = Convert.ToInt32(weaponText.Text);
            armourAmount = Convert.ToInt32(armourText.Text);
            potionAmount = Convert.ToInt32(potionText.Text);

            subtotal = (weaponPrice * weaponAmount) + (armourPrice * armourAmount) + (potionPrice * potionAmount);
            taxAmount = (subtotal * taxRate);
            totalCost = (taxAmount + subtotal);

            subtotalOutput.Text = $"{subtotal.ToString("C")}";
            taxOutput.Text = $"{taxAmount.ToString("C")}";
            totalOutput.Text = $"{totalCost.ToString("C")}";

            subtotalLabel.Visible = true;
            subtotalOutput.Visible = true;
            taxLabel.Visible = true;
            taxOutput.Visible = true;
            totalLabel.Visible = true;
            totalOutput.Visible = true;
            tenderedLabel.Visible = true;
            tenderedText.Visible = true;
            changeButton.Visible = true;
            changeText.Visible = true;
            receiptButton.Visible = true;
            }
            catch
            { 
                threatLabel.Text = "Hey! What are you trying to pull?!?";
                Refresh();
                Thread.Sleep(3000);

                threatLabel.Text = "";

            }
        }
        private void changeButton_Click(object sender, EventArgs e)
        { try
            {
                tendered = Convert.ToInt32(tenderedText.Text);

                change = tendered - totalCost;

                changeText.Text = $"{change.ToString("C")}";
            }
            catch 
            {
                threatLabel.Text = "Hey! What are you trying to pull?!?";

                Refresh();
                Thread.Sleep(3000);

                threatLabel.Text = "" ;
                
                    }
            
            
        }
        private void receiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptPrinter);
            player.Play();
            
            receiptLabel.Visible = true;
            
            receiptLabel.Text += $"\n The dungeon merchant";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n December 19th, 1012";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n\n Number of Weapons: {weaponAmount}";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n Pieces of Armour: {armourAmount}";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n Number of potions: {potionAmount}";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n\n Subtotal: ${subtotal}";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n Tax: ${taxAmount}";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n Total Price: ${totalCost} \n\n";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n\n Tendered: ${tendered}";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n Change: ${change}";

            Refresh();
            Thread.Sleep(800);

            receiptLabel.Text += $"\n\n Good luck on \n your quest \n adventurer!";

            Refresh();
            Thread.Sleep(800);

            threatLabel.Text = "Order again?";
        }

        private void threatLabel_Click(object sender, EventArgs e)
        {
            subtotalLabel.Visible = false;
            subtotalOutput.Visible = false;
            taxLabel.Visible = false;
            taxOutput.Visible = false;
            totalLabel.Visible = false;
            totalOutput.Visible = false;
            tenderedLabel.Visible = false;
            tenderedText.Visible = false;
            changeButton.Visible = false;
            changeText.Visible = false;
            receiptButton.Visible = false;
            receiptLabel.Visible = false;

            receiptLabel.Text = "";
            weaponText.Text = "";
            armourText.Text = "";
            potionText.Text = "";
            tenderedText.Text = "";
            changeText.Text = "";

            weaponAmount = 0;
            armourAmount = 0;
            potionAmount = 0;
            subtotal = 0;
            taxAmount = 0;
            totalCost = 0;
            tendered = 0;
            change = 0;

        }

        
    }
}
