namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, cua, cub, zeta;
            for (i = 1; i <= 50; i++)
            {
                cua = i * i;
                cub = i * i * i;
                zeta = cua + cub;
                listBox1.Items.Add(i);
                listBox2.Items.Add(cua);
                listBox3.Items.Add(cub);
                listBox4.Items.Add(zeta);
            }
        }
    }
}