using Microsoft.VisualBasic;

namespace C_Test
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ExampleFunc() ///The main calculation
        {
            int Input1 = Int32.Parse(InputA.Text);
            int Input2 = Int32.Parse(InputB.Text);
            double ShellCount = (Input1 + Input2);
            double ShotChance = Math.Round((Input2 / ShellCount) * 100,1);
            string PopUpCaption = "Result:";
            string PopUpMessage = "There is a " + ShotChance.ToString() + "% chance for a Live Round";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(PopUpMessage, PopUpCaption, buttons);
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            ///input validation
            if (Char.IsNumber(InputA.Text, 0) & Char.IsNumber(InputB.Text,0))
            {
                ExampleFunc();
            }
            else
            {
                string EpopupMessage = "Please enter a number in BOTH boxes";
                string EpopupCaption = "Error";
                MessageBoxButtons ErrorButtons = MessageBoxButtons.OK;
                MessageBox.Show(EpopupMessage, EpopupCaption, ErrorButtons);
            }
        }
    }
}
