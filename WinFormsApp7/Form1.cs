namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label4.Visible = false;
            label3.Visible = true;
            label2.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = true;
            label1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label4.Visible = false;
            label3.Visible = true;
            label2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }
    }
}