using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvShopInstall
{
    public partial class FormPrincipal : Form
    {
        bool accTermoContrato,instalarLocal;
        int index;
        List<Panel> listaPanel = new List<Panel>();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            listaPanel.Add(panel1);
            listaPanel.Add(panel2);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (index < listaPanel.Count - 1) listaPanel[++index].BringToFront();
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            if (index > 0) listaPanel[--index].BringToFront();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbtAceitaLicenca_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAceitaLicenca.Checked)
            {
                btnSeguinte.Enabled = true;
            }
        }

        private void rbtNaoAceitaLicenca_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNaoAceitaLicenca.Checked)
            {
                MessageBox.Show("Se você não aceita então pode clica em cancelar a instalação!");
            }
        }

        private void txtPastaDestino_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPastaDestino.Text))
            {
                panelTipoInstall.Enabled = true;
            }
            else
            {
                panelTipoInstall.Enabled = false;
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPastaDestino.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
