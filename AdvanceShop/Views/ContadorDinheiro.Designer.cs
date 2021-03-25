namespace AdvanceShop.Views
{
    partial class ContadorDinheiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContadorDinheiro));
            this.gridControlContadorDinheiro = new DevExpress.XtraGrid.GridControl();
            this.gridViewContadorDinheiro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCedulaMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnZerarContador = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContadorDinheiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContadorDinheiro)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlContadorDinheiro
            // 
            this.gridControlContadorDinheiro.Location = new System.Drawing.Point(12, 12);
            this.gridControlContadorDinheiro.MainView = this.gridViewContadorDinheiro;
            this.gridControlContadorDinheiro.Name = "gridControlContadorDinheiro";
            this.gridControlContadorDinheiro.Size = new System.Drawing.Size(481, 357);
            this.gridControlContadorDinheiro.TabIndex = 0;
            this.gridControlContadorDinheiro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContadorDinheiro});
            // 
            // gridViewContadorDinheiro
            // 
            this.gridViewContadorDinheiro.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridViewContadorDinheiro.Appearance.FooterPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gridViewContadorDinheiro.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewContadorDinheiro.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewContadorDinheiro.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridViewContadorDinheiro.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewContadorDinheiro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCedulaMoeda,
            this.gridColumnQuantidade,
            this.gridColumnTotal});
            this.gridViewContadorDinheiro.GridControl = this.gridControlContadorDinheiro;
            this.gridViewContadorDinheiro.Name = "gridViewContadorDinheiro";
            this.gridViewContadorDinheiro.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewContadorDinheiro.OptionsCustomization.AllowGroup = false;
            this.gridViewContadorDinheiro.OptionsView.ShowFooter = true;
            this.gridViewContadorDinheiro.OptionsView.ShowGroupPanel = false;
            this.gridViewContadorDinheiro.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // gridColumnCedulaMoeda
            // 
            this.gridColumnCedulaMoeda.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnCedulaMoeda.AppearanceCell.Options.UseFont = true;
            this.gridColumnCedulaMoeda.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCedulaMoeda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnCedulaMoeda.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnCedulaMoeda.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnCedulaMoeda.AppearanceHeader.Options.UseFont = true;
            this.gridColumnCedulaMoeda.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnCedulaMoeda.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCedulaMoeda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCedulaMoeda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnCedulaMoeda.Caption = "Cédula / Moeda";
            this.gridColumnCedulaMoeda.FieldName = "Descricao";
            this.gridColumnCedulaMoeda.Name = "gridColumnCedulaMoeda";
            this.gridColumnCedulaMoeda.OptionsColumn.AllowEdit = false;
            this.gridColumnCedulaMoeda.Visible = true;
            this.gridColumnCedulaMoeda.VisibleIndex = 0;
            this.gridColumnCedulaMoeda.Width = 238;
            // 
            // gridColumnQuantidade
            // 
            this.gridColumnQuantidade.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnQuantidade.AppearanceCell.Options.UseFont = true;
            this.gridColumnQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidade.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnQuantidade.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnQuantidade.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnQuantidade.AppearanceHeader.Options.UseFont = true;
            this.gridColumnQuantidade.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnQuantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnQuantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidade.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnQuantidade.Caption = "Quantidade";
            this.gridColumnQuantidade.FieldName = "Quantidade";
            this.gridColumnQuantidade.Name = "gridColumnQuantidade";
            this.gridColumnQuantidade.Visible = true;
            this.gridColumnQuantidade.VisibleIndex = 1;
            this.gridColumnQuantidade.Width = 157;
            // 
            // gridColumnTotal
            // 
            this.gridColumnTotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridColumnTotal.AppearanceCell.Options.UseFont = true;
            this.gridColumnTotal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumnTotal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnTotal.AppearanceHeader.Options.UseFont = true;
            this.gridColumnTotal.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnTotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnTotal.Caption = "Total";
            this.gridColumnTotal.DisplayFormat.FormatString = "c";
            this.gridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnTotal.FieldName = "Total";
            this.gridColumnTotal.Name = "gridColumnTotal";
            this.gridColumnTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "Total = {0:c}")});
            this.gridColumnTotal.UnboundExpression = "[Descricao] * [Quantidade]";
            this.gridColumnTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnTotal.Visible = true;
            this.gridColumnTotal.VisibleIndex = 2;
            this.gridColumnTotal.Width = 290;
            // 
            // btnZerarContador
            // 
            this.btnZerarContador.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZerarContador.ImageOptions.Image")));
            this.btnZerarContador.Location = new System.Drawing.Point(350, 375);
            this.btnZerarContador.Name = "btnZerarContador";
            this.btnZerarContador.Size = new System.Drawing.Size(143, 29);
            this.btnZerarContador.TabIndex = 6;
            this.btnZerarContador.Text = "Zerar Contador (F2)";
            this.btnZerarContador.Click += new System.EventHandler(this.btnZerarContador_Click);
            // 
            // ContadorDinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 414);
            this.Controls.Add(this.btnZerarContador);
            this.Controls.Add(this.gridControlContadorDinheiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ContadorDinheiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Dinheiro";
            this.Load += new System.EventHandler(this.ContadorDinheiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContadorDinheiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContadorDinheiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlContadorDinheiro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContadorDinheiro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCedulaMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotal;
        private DevExpress.XtraEditors.SimpleButton btnZerarContador;
    }
}