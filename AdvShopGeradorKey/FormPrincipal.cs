using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvShopGeradorKey
{
    public partial class FormPrincipal : Form
    {
        string palavraChave = "masterkey@";
        int contadorclick = 0;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            txtPalavraChave.Text = CreateMD5Hash(palavraChave);
            txtVencimento.Text = Convert.ToString(DateTime.Now.AddMonths(1));
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            DateTime dataLimite = DateTime.Now.AddMonths(1);
            DateTime dataVencimento = Convert.ToDateTime(txtVencimento.Text);
            int comparacaoT = DateTime.Compare(dataVencimento,dataLimite);
            
            if (comparacaoT < 0)
            {
                if (txtPalavraChave.Text != string.Empty && txtPalavraChave.Text.Length > 6)
                {
                    txtCriptografada.Text = Criptografar(palavraChave + txtVencimento.Text);
                }
            }
            else
            {
                MessageBox.Show("Opa a data de vencimento escolhida ta além do limite permitir!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCriptografada.Text = string.Empty;
                txtDescriptografada.Text = "**************************************";
            }
            
        }
        private string Criptografar(string valor)
        {
            string chaveCripto;
            Byte[] cript = System.Text.ASCIIEncoding.ASCII.GetBytes(valor);
            chaveCripto = Convert.ToBase64String(cript);
            return chaveCripto;


        }

        private string Descriptografar(string valor)
        {
            string chaveCripto;
            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = System.Text.ASCIIEncoding.ASCII.GetString(cript);
            return chaveCripto;

        }

        private void txtCriptografada_TextChanged(object sender, EventArgs e)
        {
            if (txtCriptografada.Text != string.Empty)
            {
                txtDescriptografada.Text = Descriptografar(txtCriptografada.Text);
            }
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                btnGerar.PerformClick();
            }
        }
        private string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void txtDescriptografada_Click(object sender, EventArgs e)
        {
            contadorclick++;
            if(contadorclick == 12)
            {
                txtDescriptografada.UseSystemPasswordChar = false;
            }
        }
    }
}
