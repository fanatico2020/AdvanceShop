
namespace AdvanceShop.Views
{
    partial class BackupRestauracaoDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRestauracaoDB));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtbpBackup = new DevExpress.XtraTab.XtraTabPage();
            this.panelControlProgresso = new DevExpress.XtraEditors.PanelControl();
            this.lblProgressoBackup = new DevExpress.XtraEditors.LabelControl();
            this.cbxFecharSistema = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancelarBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.pgbProgressoBackup = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblProgressoBkp = new DevExpress.XtraEditors.LabelControl();
            this.panelControlCaminho = new DevExpress.XtraEditors.PanelControl();
            this.btnProcurarCaminho = new DevExpress.XtraEditors.SimpleButton();
            this.txtCaminhoBackup = new DevExpress.XtraEditors.TextEdit();
            this.lblCaminho = new DevExpress.XtraEditors.LabelControl();
            this.xtbpRestaurar = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblProgressoRestaurar = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelarRestaurar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestaurar = new DevExpress.XtraEditors.SimpleButton();
            this.pgbProgressoRestaurar = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnProcurarArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.txtCaminhoArquivoRestaurar = new DevExpress.XtraEditors.TextEdit();
            this.lblArquivo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtbpBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlProgresso)).BeginInit();
            this.panelControlProgresso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFecharSistema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgressoBackup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCaminho)).BeginInit();
            this.panelControlCaminho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoBackup.Properties)).BeginInit();
            this.xtbpRestaurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgressoRestaurar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivoRestaurar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtbpBackup;
            this.xtraTabControl1.Size = new System.Drawing.Size(612, 298);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbpBackup,
            this.xtbpRestaurar});
            // 
            // xtbpBackup
            // 
            this.xtbpBackup.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtbpBackup.Appearance.Header.Options.UseFont = true;
            this.xtbpBackup.Controls.Add(this.panelControlProgresso);
            this.xtbpBackup.Controls.Add(this.panelControlCaminho);
            this.xtbpBackup.Name = "xtbpBackup";
            this.xtbpBackup.Size = new System.Drawing.Size(610, 267);
            this.xtbpBackup.Text = "Backup";
            // 
            // panelControlProgresso
            // 
            this.panelControlProgresso.Controls.Add(this.lblProgressoBackup);
            this.panelControlProgresso.Controls.Add(this.cbxFecharSistema);
            this.panelControlProgresso.Controls.Add(this.btnCancelarBackup);
            this.panelControlProgresso.Controls.Add(this.btnBackup);
            this.panelControlProgresso.Controls.Add(this.pgbProgressoBackup);
            this.panelControlProgresso.Controls.Add(this.lblProgressoBkp);
            this.panelControlProgresso.Location = new System.Drawing.Point(3, 119);
            this.panelControlProgresso.Name = "panelControlProgresso";
            this.panelControlProgresso.Size = new System.Drawing.Size(602, 118);
            this.panelControlProgresso.TabIndex = 1;
            // 
            // lblProgressoBackup
            // 
            this.lblProgressoBackup.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressoBackup.Appearance.Options.UseFont = true;
            this.lblProgressoBackup.Appearance.Options.UseTextOptions = true;
            this.lblProgressoBackup.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblProgressoBackup.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProgressoBackup.Location = new System.Drawing.Point(87, 5);
            this.lblProgressoBackup.Name = "lblProgressoBackup";
            this.lblProgressoBackup.Size = new System.Drawing.Size(507, 19);
            this.lblProgressoBackup.TabIndex = 10;
            this.lblProgressoBackup.Text = "%";
            // 
            // cbxFecharSistema
            // 
            this.cbxFecharSistema.Location = new System.Drawing.Point(5, 75);
            this.cbxFecharSistema.Name = "cbxFecharSistema";
            this.cbxFecharSistema.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFecharSistema.Properties.Appearance.Options.UseFont = true;
            this.cbxFecharSistema.Properties.Caption = "Fechar sistema ao terminar progresso";
            this.cbxFecharSistema.Size = new System.Drawing.Size(296, 23);
            this.cbxFecharSistema.TabIndex = 3;
            // 
            // btnCancelarBackup
            // 
            this.btnCancelarBackup.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBackup.Appearance.Options.UseFont = true;
            this.btnCancelarBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBackup.ImageOptions.Image")));
            this.btnCancelarBackup.Location = new System.Drawing.Point(347, 65);
            this.btnCancelarBackup.Name = "btnCancelarBackup";
            this.btnCancelarBackup.Size = new System.Drawing.Size(111, 43);
            this.btnCancelarBackup.TabIndex = 4;
            this.btnCancelarBackup.Text = "Cancelar";
            this.btnCancelarBackup.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Appearance.Options.UseFont = true;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.Location = new System.Drawing.Point(464, 65);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(130, 43);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup (F2)";
            this.btnBackup.Click += new System.EventHandler(this.btnGerarBackup_Click);
            // 
            // pgbProgressoBackup
            // 
            this.pgbProgressoBackup.Location = new System.Drawing.Point(5, 30);
            this.pgbProgressoBackup.Name = "pgbProgressoBackup";
            this.pgbProgressoBackup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgbProgressoBackup.Properties.Step = 1;
            this.pgbProgressoBackup.Size = new System.Drawing.Size(589, 29);
            this.pgbProgressoBackup.TabIndex = 0;
            // 
            // lblProgressoBkp
            // 
            this.lblProgressoBkp.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressoBkp.Appearance.Options.UseFont = true;
            this.lblProgressoBkp.Location = new System.Drawing.Point(5, 5);
            this.lblProgressoBkp.Name = "lblProgressoBkp";
            this.lblProgressoBkp.Size = new System.Drawing.Size(76, 19);
            this.lblProgressoBkp.TabIndex = 6;
            this.lblProgressoBkp.Text = "Progresso:";
            // 
            // panelControlCaminho
            // 
            this.panelControlCaminho.Controls.Add(this.btnProcurarCaminho);
            this.panelControlCaminho.Controls.Add(this.txtCaminhoBackup);
            this.panelControlCaminho.Controls.Add(this.lblCaminho);
            this.panelControlCaminho.Location = new System.Drawing.Point(3, 3);
            this.panelControlCaminho.Name = "panelControlCaminho";
            this.panelControlCaminho.Size = new System.Drawing.Size(602, 110);
            this.panelControlCaminho.TabIndex = 0;
            // 
            // btnProcurarCaminho
            // 
            this.btnProcurarCaminho.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarCaminho.Appearance.Options.UseFont = true;
            this.btnProcurarCaminho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarCaminho.ImageOptions.Image")));
            this.btnProcurarCaminho.Location = new System.Drawing.Point(483, 62);
            this.btnProcurarCaminho.Name = "btnProcurarCaminho";
            this.btnProcurarCaminho.Size = new System.Drawing.Size(111, 43);
            this.btnProcurarCaminho.TabIndex = 2;
            this.btnProcurarCaminho.Text = "Procurar";
            this.btnProcurarCaminho.Click += new System.EventHandler(this.btnProcurarCaminho_Click);
            // 
            // txtCaminhoBackup
            // 
            this.txtCaminhoBackup.Location = new System.Drawing.Point(5, 30);
            this.txtCaminhoBackup.Name = "txtCaminhoBackup";
            this.txtCaminhoBackup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoBackup.Properties.Appearance.Options.UseFont = true;
            this.txtCaminhoBackup.Properties.MaxLength = 60;
            this.txtCaminhoBackup.Size = new System.Drawing.Size(589, 26);
            this.txtCaminhoBackup.TabIndex = 1;
            // 
            // lblCaminho
            // 
            this.lblCaminho.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminho.Appearance.Options.UseFont = true;
            this.lblCaminho.Location = new System.Drawing.Point(5, 5);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(69, 19);
            this.lblCaminho.TabIndex = 3;
            this.lblCaminho.Text = "Caminho:";
            // 
            // xtbpRestaurar
            // 
            this.xtbpRestaurar.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtbpRestaurar.Appearance.Header.Options.UseFont = true;
            this.xtbpRestaurar.Controls.Add(this.panelControl2);
            this.xtbpRestaurar.Controls.Add(this.panelControl1);
            this.xtbpRestaurar.Name = "xtbpRestaurar";
            this.xtbpRestaurar.Size = new System.Drawing.Size(610, 267);
            this.xtbpRestaurar.Text = "Restaurar";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblProgressoRestaurar);
            this.panelControl2.Controls.Add(this.btnCancelarRestaurar);
            this.panelControl2.Controls.Add(this.btnRestaurar);
            this.panelControl2.Controls.Add(this.pgbProgressoRestaurar);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(3, 119);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(602, 118);
            this.panelControl2.TabIndex = 2;
            // 
            // lblProgressoRestaurar
            // 
            this.lblProgressoRestaurar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressoRestaurar.Appearance.Options.UseFont = true;
            this.lblProgressoRestaurar.Appearance.Options.UseTextOptions = true;
            this.lblProgressoRestaurar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblProgressoRestaurar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProgressoRestaurar.Location = new System.Drawing.Point(87, 5);
            this.lblProgressoRestaurar.Name = "lblProgressoRestaurar";
            this.lblProgressoRestaurar.Size = new System.Drawing.Size(507, 19);
            this.lblProgressoRestaurar.TabIndex = 10;
            this.lblProgressoRestaurar.Text = "%";
            // 
            // btnCancelarRestaurar
            // 
            this.btnCancelarRestaurar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRestaurar.Appearance.Options.UseFont = true;
            this.btnCancelarRestaurar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarRestaurar.ImageOptions.Image")));
            this.btnCancelarRestaurar.Location = new System.Drawing.Point(333, 65);
            this.btnCancelarRestaurar.Name = "btnCancelarRestaurar";
            this.btnCancelarRestaurar.Size = new System.Drawing.Size(111, 43);
            this.btnCancelarRestaurar.TabIndex = 3;
            this.btnCancelarRestaurar.Text = "Cancelar";
            this.btnCancelarRestaurar.Click += new System.EventHandler(this.btnCancelarRestaurar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Appearance.Options.UseFont = true;
            this.btnRestaurar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.ImageOptions.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(450, 65);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(144, 43);
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.Text = "Restaurar (F3)";
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pgbProgressoRestaurar
            // 
            this.pgbProgressoRestaurar.Location = new System.Drawing.Point(5, 30);
            this.pgbProgressoRestaurar.Name = "pgbProgressoRestaurar";
            this.pgbProgressoRestaurar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgbProgressoRestaurar.Properties.Step = 1;
            this.pgbProgressoRestaurar.Size = new System.Drawing.Size(589, 29);
            this.pgbProgressoRestaurar.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Progresso:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnProcurarArquivo);
            this.panelControl1.Controls.Add(this.txtCaminhoArquivoRestaurar);
            this.panelControl1.Controls.Add(this.lblArquivo);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(602, 110);
            this.panelControl1.TabIndex = 1;
            // 
            // btnProcurarArquivo
            // 
            this.btnProcurarArquivo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarArquivo.Appearance.Options.UseFont = true;
            this.btnProcurarArquivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarArquivo.ImageOptions.Image")));
            this.btnProcurarArquivo.Location = new System.Drawing.Point(483, 62);
            this.btnProcurarArquivo.Name = "btnProcurarArquivo";
            this.btnProcurarArquivo.Size = new System.Drawing.Size(111, 43);
            this.btnProcurarArquivo.TabIndex = 2;
            this.btnProcurarArquivo.Text = "Procurar";
            this.btnProcurarArquivo.Click += new System.EventHandler(this.btnProcurarArquivo_Click);
            // 
            // txtCaminhoArquivoRestaurar
            // 
            this.txtCaminhoArquivoRestaurar.Location = new System.Drawing.Point(5, 30);
            this.txtCaminhoArquivoRestaurar.Name = "txtCaminhoArquivoRestaurar";
            this.txtCaminhoArquivoRestaurar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivoRestaurar.Properties.Appearance.Options.UseFont = true;
            this.txtCaminhoArquivoRestaurar.Properties.MaxLength = 60;
            this.txtCaminhoArquivoRestaurar.Size = new System.Drawing.Size(589, 26);
            this.txtCaminhoArquivoRestaurar.TabIndex = 1;
            // 
            // lblArquivo
            // 
            this.lblArquivo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivo.Appearance.Options.UseFont = true;
            this.lblArquivo.Location = new System.Drawing.Point(5, 5);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(62, 19);
            this.lblArquivo.TabIndex = 3;
            this.lblArquivo.Text = "Arquivo:";
            // 
            // BackupRestauracaoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 328);
            this.Controls.Add(this.xtraTabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BackupRestauracaoDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Dados";
            this.Load += new System.EventHandler(this.BackupRestauracaoDB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackupRestauracaoDB_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BackupRestauracaoDB_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtbpBackup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlProgresso)).EndInit();
            this.panelControlProgresso.ResumeLayout(false);
            this.panelControlProgresso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFecharSistema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgressoBackup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCaminho)).EndInit();
            this.panelControlCaminho.ResumeLayout(false);
            this.panelControlCaminho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoBackup.Properties)).EndInit();
            this.xtbpRestaurar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgressoRestaurar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivoRestaurar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtbpBackup;
        private DevExpress.XtraTab.XtraTabPage xtbpRestaurar;
        private DevExpress.XtraEditors.PanelControl panelControlCaminho;
        private DevExpress.XtraEditors.LabelControl lblCaminho;
        private DevExpress.XtraEditors.TextEdit txtCaminhoBackup;
        private DevExpress.XtraEditors.SimpleButton btnProcurarCaminho;
        private DevExpress.XtraEditors.PanelControl panelControlProgresso;
        private DevExpress.XtraEditors.ProgressBarControl pgbProgressoBackup;
        private DevExpress.XtraEditors.LabelControl lblProgressoBkp;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.SimpleButton btnCancelarBackup;
        private DevExpress.XtraEditors.CheckEdit cbxFecharSistema;
        private DevExpress.XtraEditors.LabelControl lblProgressoBackup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnProcurarArquivo;
        private DevExpress.XtraEditors.TextEdit txtCaminhoArquivoRestaurar;
        private DevExpress.XtraEditors.LabelControl lblArquivo;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblProgressoRestaurar;
        private DevExpress.XtraEditors.SimpleButton btnCancelarRestaurar;
        private DevExpress.XtraEditors.SimpleButton btnRestaurar;
        private DevExpress.XtraEditors.ProgressBarControl pgbProgressoRestaurar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}