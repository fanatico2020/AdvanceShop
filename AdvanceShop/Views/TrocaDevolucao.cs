using AdvanceShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Views
{
    public partial class TrocaDevolucao : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();

        public TrocaDevolucao(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
        }

        private void TrocaDevolucao_Load(object sender, EventArgs e)
        {

        }
    }
}
