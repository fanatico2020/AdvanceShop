using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Shared.Library
{
    public static class ExportarExcel
    {
        public static void Grid(GridView gridView)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salvar como (Excel).xlsx";
            sfd.Filter = "Excel(.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
            {
                gridView.ExportToXlsx($"{sfd.FileName}.xlsx");
            }
        }
    }
}
