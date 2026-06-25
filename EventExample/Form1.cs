namespace EventExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var data = sender as Label;

            //data.Visible = false;
            data.ForeColor = Color.Aquamarine;
            data.BackColor = Color.RebeccaPurple;

            Console.WriteLine("Clicked Salamlar Button");
        }
    }
}
