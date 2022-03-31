namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
            labelOculto.Text = txtName.Text + " se añadio correctamente";
            txtName.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelOculto.Text = "";
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = 0.0;
            double b = 0.0;

            a=Convert.ToDouble(txtA.Text);
            b=Convert.ToDouble(txtB.Text);

            if(rbSuma.Checked == true)    
                r = a + b;
            if (rbResta.Checked == true)
                r = a - b;
            if (rbMultiplicacion.Checked == true)
                r = a * b;
            if (rbDivision.Checked == true)
                r = a / b;

            lblResultado.Text = r.ToString();

        }
    }
}