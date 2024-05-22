using System.Xml.Linq;

namespace badanideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtBB.Text); 
            double hight = Convert.ToDouble(txtTB.Text);
            double result = 0.0;
            string result2 = "";
            hight = hight / 100;
            
            if (rbKg.Checked)
            {

                result = weight / (hight * hight);
            }

            else if (rbPon.Checked)
            {
                weight = weight / 2.205;
                result = weight / (hight * hight);
            }

            if (result < 18.5)
            {
                result2 = "Kekurangan Berat Badan";
            }
            else if (result < 24.9)
            {
                result2 = "Id eal";
            }
            else if (result < 30)
            {
                result2 = "Berlebihan Berat Badan";
            }
            else if (result < 34.9)
            {
                result2 = "Obesitas I";
            }
            else if (result < 40)
            {
                result2 = "Obesitas II";
            }

            txtHasil.Text = "Hai "+ textBox2.Text! +" BMI kamu adalah : " + result.ToString("#.#") + "\r\n" + "Kategori" + result2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBB.Text = "";
            txtTB.Text = "";
            txtHasil.Text = "";

            rbKg.Checked = false;
            rbPon.Checked = false;
        }
    }
}