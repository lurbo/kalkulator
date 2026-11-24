namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stevka = "";
        double steviloEna;
        double steviloDva;
        char operacija;
        double rezultat = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            stevka += "1";
            textBox1.Text = stevka;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stevka += "2";
            textBox1.Text = stevka;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stevka += "4";
            textBox1.Text = stevka;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stevka += "7";
            textBox1.Text = stevka;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            stevka += "8";
            textBox1.Text = stevka;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            stevka += "0";
            textBox1.Text = stevka;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            stevka += "9";
            textBox1.Text = stevka;

        }


        private void button6_Click(object sender, EventArgs e)
        {
            stevka += "6";
            textBox1.Text = stevka;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            stevka += "5";
            textBox1.Text = stevka;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            stevka += "3";
            textBox1.Text = stevka;
        }

        private void buttonSestevanje_Click(object sender, EventArgs e)
        {
            try
            {
                steviloEna = Convert.ToDouble(stevka);
                stevka = "";
                operacija = '+';
            }
            catch
            {

            }
        }

        private void buttonOdstevanje_Click(object sender, EventArgs e)
        {
            try { 
            steviloEna = Convert.ToDouble(stevka);
            stevka = "";
            operacija = '-';
            }

            catch
            {}
        }

        private void buttonDeljenje_Click(object sender, EventArgs e)
        {
            try { 
            steviloEna = Convert.ToDouble(stevka);
            stevka = "";
            operacija = '/';

             }

            catch
            {}
        }

        private void buttonMnozenje_Click(object sender, EventArgs e)
        {
            steviloEna = Convert.ToDouble(stevka);
            stevka = "";
            operacija = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonIzracun_Click(object sender, EventArgs e)
        {
            steviloDva = Convert.ToDouble(stevka);

            switch (operacija)
            {
                case '+':
                    rezultat = steviloEna + steviloDva;
                    break;
                case '-':
                    rezultat = steviloEna - steviloDva;
                    break;
                case '/':
                    if (steviloDva == 0)
                    {
                        MessageBox.Show("Deljenje z niè ni mogoèe!");
                        return;
                    }
                    rezultat = steviloEna / steviloDva;

                    break;
                case '*':
                    rezultat = steviloEna * steviloDva;
                    break;
            }
            string rez = Convert.ToString(rezultat);
            textBox1.Text = rez;
            stevka = rez;
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                stevka = stevka.Remove(stevka.Length - 1);
                textBox1.Text = stevka;
            }
            catch
            {

            }
        }
    }
}