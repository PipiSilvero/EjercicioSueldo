namespace EjercicioSueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Desde aqui el codigo

            double basico, impAnt, impECivil, impHijos, impTotal;
            int aAnt, cantHijos;

            //Capturo los valores
            basico = double.Parse(txtBasico.Text);
            aAnt =  int.Parse(txtAAntig.Text);
            cantHijos  = int.Parse(txtCHijos.Text);

            //Calculos

            impAnt = basico * 0.02 * aAnt;
            if (chkCasado.Checked )
            {
                impECivil = 300;

            }
            else
            {
                impECivil = 0;
            }
            impHijos = cantHijos * 600;
            impTotal = basico + impAnt + impECivil + impHijos;


            //Llevar datos al front
            txtIAnt.Text = impAnt.ToString();
            txtIEC.Text = impECivil.ToString();
            txtIHijos.Text = impHijos.ToString();
            txtTotal.Text = impTotal.ToString();









            //Hasta aqui
        }
    }
}