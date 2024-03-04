namespace jurnal3
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 6;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            textInput.Text = textInput.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void angka4_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 4;
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void angka3_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 3;
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 5;
        }

        private void angka7_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 7;
        }

        private void angka8_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 8;
        }

        private void jumlah_Click(object sender, EventArgs e)
        {
            a = Int32.Parse(textInput.Text);
            textInput.Text = "";
        }

        private void angka0_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 0;
        }

        private void samaDengan_Click(object sender, EventArgs e)
        {
            b = Int32.Parse(textInput.Text);
            int hasil = a + b;
            textInput.Text = hasil.ToString();


        }

        private void angka9_Click(object sender, EventArgs e)
        {
            textInput.Text = textInput.Text + 9;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
        }
    }
}
