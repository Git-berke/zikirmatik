using System.Media;
using variables_and_data_type.Properties;

namespace variables_and_data_type
{
    public partial class Form1 : Form
    {
        SoundPlayer splayer = new SoundPlayer(Resources.buttonsound);




        private int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            number++;
            label1.Text = number.ToString() + "ELHAMDULILLAH";
            splayer.Play();

        }
    }
}
