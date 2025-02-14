using System;

namespace ficha_73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            
            int textBoxNA;
            int textBoxNB;
            

            try
            {
                textBoxResultado.Text = (int.Parse(textBoxNa.Text) + int.Parse(textBoxNb.Text)).ToString();
            }
            catch(OverflowException ex)
            {
                MessageBox.Show("introduzir letras ou um n�mero demasiado grande");
            }
            catch (Exception ex)
            {
                MessageBox.Show("entrada � inv�lida: " + ex.Message);
            }
            textBoxResultado.Clear();
        }
    }
}
