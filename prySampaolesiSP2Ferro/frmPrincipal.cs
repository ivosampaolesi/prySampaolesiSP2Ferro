using System.Diagnostics.CodeAnalysis;

namespace prySampaolesiSP2Ferro
{
    public partial class frmPrincipal : Form
    {
        const int Precio = 5;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        int vDistancia;
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int vResultado = 0;
            vDistancia= Convert.ToInt32(txtKilometros.Text);
            if ((txtDias.Value >= 7)&&(vDistancia >=100))
            {
                vResultado = (vDistancia * Precio);
            }
            else 
            {
                vResultado = (vDistancia * Precio)*2; 
            }
            MessageBox.Show("Precio Total  $" + vResultado);
            txtKilometros.Focus(); 

        }
    }
}
