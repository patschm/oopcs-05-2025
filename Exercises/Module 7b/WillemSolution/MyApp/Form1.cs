namespace MyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += ModTitle;
        }

        private void ModTitle(object? sender, EventArgs e)
        {
            this.Text = "Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button)!.BackColor = Color.Red;
        }
    }
}