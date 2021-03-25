
namespace AdvanceShop.Views
{
    partial class TrocaDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocaDevolucao));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtObservacaoNfe = new DevExpress.XtraEditors.TextEdit();
            this.cbxInformarObsNfe = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grbxFormaDevolucao = new DevExpress.XtraEditors.RadioGroup();
            this.gridControlItensDevolucao = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridViewItensDevolucao = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.lblObs = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoNfe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxInformarObsNfe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbxFormaDevolucao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensDevolucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewItensDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtObservacaoNfe);
            this.panelControl1.Controls.Add(this.cbxInformarObsNfe);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.grbxFormaDevolucao);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(716, 186);
            this.panelControl1.TabIndex = 0;
            // 
            // txtObservacaoNfe
            // 
            this.txtObservacaoNfe.Location = new System.Drawing.Point(5, 118);
            this.txtObservacaoNfe.Name = "txtObservacaoNfe";
            this.txtObservacaoNfe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoNfe.Properties.Appearance.Options.UseFont = true;
            this.txtObservacaoNfe.Size = new System.Drawing.Size(706, 26);
            this.txtObservacaoNfe.TabIndex = 2;
            // 
            // cbxInformarObsNfe
            // 
            this.cbxInformarObsNfe.Location = new System.Drawing.Point(5, 89);
            this.cbxInformarObsNfe.Name = "cbxInformarObsNfe";
            this.cbxInformarObsNfe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInformarObsNfe.Properties.Appearance.Options.UseFont = true;
            this.cbxInformarObsNfe.Properties.Caption = "Informar observação na NF-e";
            this.cbxInformarObsNfe.Size = new System.Drawing.Size(247, 23);
            this.cbxInformarObsNfe.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Forma de devolução:";
            // 
            // grbxFormaDevolucao
            // 
            this.grbxFormaDevolucao.Location = new System.Drawing.Point(5, 30);
            this.grbxFormaDevolucao.Name = "grbxFormaDevolucao";
            this.grbxFormaDevolucao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Crédito para compras futuras"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Devolver valor pago")});
            this.grbxFormaDevolucao.Size = new System.Drawing.Size(706, 53);
            this.grbxFormaDevolucao.TabIndex = 0;
            // 
            // gridControlItensDevolucao
            // 
            this.gridControlItensDevolucao.Location = new System.Drawing.Point(12, 204);
            this.gridControlItensDevolucao.MainView = this.advBandedGridViewItensDevolucao;
            this.gridControlItensDevolucao.Name = "gridControlItensDevolucao";
            this.gridControlItensDevolucao.Size = new System.Drawing.Size(716, 234);
            this.gridControlItensDevolucao.TabIndex = 1;
            this.gridControlItensDevolucao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridViewItensDevolucao});
            // 
            // advBandedGridViewItensDevolucao
            // 
            this.advBandedGridViewItensDevolucao.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridViewItensDevolucao.GridControl = this.gridControlItensDevolucao;
            this.advBandedGridViewItensDevolucao.Name = "advBandedGridViewItensDevolucao";
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Selecione os itens que deseja devolver";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 340;
            // 
            // lblObs
            // 
            this.lblObs.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Appearance.Options.UseFont = true;
            this.lblObs.Location = new System.Drawing.Point(12, 447);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(552, 19);
            this.lblObs.TabIndex = 3;
            this.lblObs.Text = "Obs: para efetuar uma troca, basta fazer a devolução depois uma nova venda!";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(630, 444);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar (F2)";
            // 
            // TrocaDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 481);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.gridControlItensDevolucao);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TrocaDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca / Devolução";
            this.Load += new System.EventHandler(this.TrocaDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoNfe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxInformarObsNfe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbxFormaDevolucao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensDevolucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewItensDevolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.RadioGroup grbxFormaDevolucao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit cbxInformarObsNfe;
        private DevExpress.XtraGrid.GridControl gridControlItensDevolucao;
        private DevExpress.XtraEditors.TextEdit txtObservacaoNfe;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridViewItensDevolucao;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.LabelControl lblObs;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}