
namespace AdvanceShop.Views
{
    partial class RelParCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelParCaixa));
            this.btnVisualizar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdCaixas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsuarioCaixa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDataCaixa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDataFechamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPesquisar = new DevExpress.XtraEditors.SearchControl();
            this.lblPesquisarGrid = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Appearance.Options.UseFont = true;
            this.btnVisualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.ImageOptions.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(429, 305);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(111, 36);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(528, 230);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdCaixas,
            this.gridColumnUsuarioCaixa,
            this.gridColumnDataCaixa,
            this.gridColumnDataFechamento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnIdCaixas
            // 
            this.gridColumnIdCaixas.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnIdCaixas.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnIdCaixas.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnIdCaixas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnIdCaixas.Caption = "Caixa";
            this.gridColumnIdCaixas.FieldName = "idcaixas";
            this.gridColumnIdCaixas.Name = "gridColumnIdCaixas";
            this.gridColumnIdCaixas.Visible = true;
            this.gridColumnIdCaixas.VisibleIndex = 0;
            this.gridColumnIdCaixas.Width = 85;
            // 
            // gridColumnUsuarioCaixa
            // 
            this.gridColumnUsuarioCaixa.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnUsuarioCaixa.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnUsuarioCaixa.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnUsuarioCaixa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnUsuarioCaixa.Caption = "Usuário Caixa";
            this.gridColumnUsuarioCaixa.FieldName = "usuariocadastro";
            this.gridColumnUsuarioCaixa.Name = "gridColumnUsuarioCaixa";
            this.gridColumnUsuarioCaixa.Visible = true;
            this.gridColumnUsuarioCaixa.VisibleIndex = 1;
            this.gridColumnUsuarioCaixa.Width = 223;
            // 
            // gridColumnDataCaixa
            // 
            this.gridColumnDataCaixa.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnDataCaixa.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnDataCaixa.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDataCaixa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDataCaixa.Caption = "Data Caixa";
            this.gridColumnDataCaixa.DisplayFormat.FormatString = "g";
            this.gridColumnDataCaixa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDataCaixa.FieldName = "datahoracadastro";
            this.gridColumnDataCaixa.Name = "gridColumnDataCaixa";
            this.gridColumnDataCaixa.Visible = true;
            this.gridColumnDataCaixa.VisibleIndex = 2;
            this.gridColumnDataCaixa.Width = 181;
            // 
            // gridColumnDataFechamento
            // 
            this.gridColumnDataFechamento.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnDataFechamento.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnDataFechamento.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDataFechamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDataFechamento.Caption = "Data Fechamento";
            this.gridColumnDataFechamento.DisplayFormat.FormatString = "g";
            this.gridColumnDataFechamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDataFechamento.FieldName = "datahorafechamento";
            this.gridColumnDataFechamento.Name = "gridColumnDataFechamento";
            this.gridColumnDataFechamento.Visible = true;
            this.gridColumnDataFechamento.VisibleIndex = 3;
            this.gridColumnDataFechamento.Width = 196;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Client = this.gridControl1;
            this.txtPesquisar.Location = new System.Drawing.Point(12, 37);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Properties.Appearance.Options.UseFont = true;
            this.txtPesquisar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtPesquisar.Properties.Client = this.gridControl1;
            this.txtPesquisar.Size = new System.Drawing.Size(528, 26);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lblPesquisarGrid
            // 
            this.lblPesquisarGrid.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisarGrid.Appearance.Options.UseFont = true;
            this.lblPesquisarGrid.Location = new System.Drawing.Point(12, 12);
            this.lblPesquisarGrid.Name = "lblPesquisarGrid";
            this.lblPesquisarGrid.Size = new System.Drawing.Size(129, 19);
            this.lblPesquisarGrid.TabIndex = 11;
            this.lblPesquisarGrid.Text = "Pesquisar no grid:";
            // 
            // RelParCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.lblPesquisarGrid);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnVisualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "RelParCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RelParCaixa_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RelParCaixa_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVisualizar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchControl txtPesquisar;
        private DevExpress.XtraEditors.LabelControl lblPesquisarGrid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdCaixas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUsuarioCaixa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataCaixa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataFechamento;
    }
}