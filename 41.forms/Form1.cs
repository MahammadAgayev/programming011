namespace _41.forms
{
    public partial class Form1 : Form
    {
        private int _count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (lblHelloWorld.Visible)
            {
                lblHelloWorld.Visible = false;
                return;
            }

            lblHelloWorld.Visible = true;

            if (_count == 3)
            {
                lblHelloWorld.ForeColor = Color.Green;
            }

            _count++;
        }

        private void btnThanos_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(0, 1_000_000);

            if(num % 2 == 0)
            {
                lblTextOfFortune.ForeColor = Color.Red;
                lblTextOfFortune.Text = "You died";
                lblTextOfFortune.Visible = true;
            } 
            else
            {

                lblTextOfFortune.ForeColor = Color.Green;
                lblTextOfFortune.Text = "You will live";
                lblTextOfFortune.Visible = true;
            }
        }
    }
}
