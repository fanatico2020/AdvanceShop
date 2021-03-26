namespace AdvanceShop.Views
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblSenha = new DevExpress.XtraEditors.LabelControl();
            this.lblEsqueceuSuaSenha = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblSiteAdvanceShop = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Appearance.Options.UseFont = true;
            this.btnEntrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEntrar.ImageOptions.SvgImage")));
            this.btnEntrar.Location = new System.Drawing.Point(310, 230);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(98, 29);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 189);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSenha.Properties.ContextImageOptions.Image")));
            this.txtSenha.Properties.NullText = "Entre com sua senha";
            this.txtSenha.Size = new System.Drawing.Size(396, 26);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseDoubleClick);
            this.txtSenha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseMove);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 132);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUsuario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idusuarios", "Código", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuarioacesso", "Usuário Acesso")});
            this.txtUsuario.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtUsuario.Properties.ContextImageOptions.Image")));
            this.txtUsuario.Properties.NullText = "Selecione seu usuário";
            this.txtUsuario.Size = new System.Drawing.Size(396, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.Options.UseFont = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 107);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 19);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Appearance.Options.UseFont = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 164);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 19);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblEsqueceuSuaSenha
            // 
            this.lblEsqueceuSuaSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSuaSenha.Appearance.Options.UseFont = true;
            this.lblEsqueceuSuaSenha.Location = new System.Drawing.Point(12, 235);
            this.lblEsqueceuSuaSenha.Name = "lblEsqueceuSuaSenha";
            this.lblEsqueceuSuaSenha.Size = new System.Drawing.Size(138, 16);
            this.lblEsqueceuSuaSenha.TabIndex = 4;
            this.lblEsqueceuSuaSenha.Text = "Esqueceu sua senha?";
            this.lblEsqueceuSuaSenha.Click += new System.EventHandler(this.lblEsqueceuSuaSenha_Click);
            // 
            // lblSiteAdvanceShop
            // 
            this.lblSiteAdvanceShop.Appearance.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteAdvanceShop.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSiteAdvanceShop.Appearance.Options.UseFont = true;
            this.lblSiteAdvanceShop.Appearance.Options.UseForeColor = true;
            this.lblSiteAdvanceShop.Location = new System.Drawing.Point(72, 12);
            this.lblSiteAdvanceShop.Name = "lblSiteAdvanceShop";
            this.lblSiteAdvanceShop.Size = new System.Drawing.Size(274, 47);
            this.lblSiteAdvanceShop.TabIndex = 5;
            this.lblSiteAdvanceShop.Text = "ADVANCE SHOP";
            this.lblSiteAdvanceShop.Click += new System.EventHandler(this.lblSiteAdvanceShop_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(381, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Bem-Vindo! Entre com seu usuário e senha de acesso!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 279);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblSiteAdvanceShop);
            this.Controls.Add(this.lblEsqueceuSuaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LookUpEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblEsqueceuSuaSenha;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblSiteAdvanceShop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

