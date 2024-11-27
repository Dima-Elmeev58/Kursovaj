namespace Приложение_курсового
{
    public partial class Form1 : Form
    {
        public object TextBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(SortTextBox1);
            this.Controls.Add(SortButton1);
            this.Controls.Add(textBoxInput);
            this.Controls.Add(button2);

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MassgeBox1_Click(object sender, EventArgs e)
        {

        }
        private void SortTextBox1_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
