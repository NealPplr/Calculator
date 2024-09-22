using System;
using System.Windows.Forms;

namespace Calculate.app
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void lblNumber2_Click(object sender, EventArgs e)
        {
    

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //1. Haal de waarde uit het eerste tekstvak op.
            string number1 = txtNumber1.Text;

            //2. haal de waarde uit het tweede tekstvak op. 
            string number2 = txtNumber2.Text;

            //3. Tel de 2 opgehaalde waardes samen. 
            int result = Convert.ToInt32(number1) + Convert.ToInt32(number2);

            //4. Toon het resultaat in het resultaatvak. 
            //txtResult.Text = convert.tostring(result);
            txtResult.Text = result.ToString();
        }