using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Convert;

namespace L2MAtkCalcRemastered
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly decimal factor = 31.47M;

        private decimal CalculateMAtk(decimal OwnAttack, decimal weaponAttack)
        {
            return OwnAttack + weaponAttack * factor;
        }

        private decimal ConvertOwnAttack()
        {
            decimal result;

            try
            {
                result = ToDecimal(OwnMAttack.Text);
                if (result == 0)
                {
                    MessageBox.Show("I don't think you attack is so low, try inserting it again :)", "Warning");
                }
                return result;
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"Field {nameof(OwnMAttack)} cannot be empty and can only contain numbers!", "Error!");
                return 0;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Have you really become a god among races?", "Error - unexpectedly high value");
                return 0;
            }
            catch(Exception)
            {
                MessageBox.Show(@"Unexpected exception! Please report that issue on github: ", "Error!");
                
            }
        }

        private string ConvertToSendableForm(decimal sentValue)
        {
            string result = sentValue.ToString();
            return result;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            decimal weaponAttack = 293;
            ApoCasterResult.Text = ConvertToSendableForm(CalculateMAtk(ConvertOwnAttack(), weaponAttack));
        }
    }
}
