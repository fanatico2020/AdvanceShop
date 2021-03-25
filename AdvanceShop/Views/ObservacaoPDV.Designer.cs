namespace AdvanceShop.Views
{
    partial class ObservacaoPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObservacaoPDV));
            this.txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 2);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Properties.Appearance.Options.UseFont = true;
            this.txtObservacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Properties.MaxLength = 25;
            this.txtObservacao.Size = new System.Drawing.Size(411, 146);
            this.txtObservacao.TabIndex = 1;
            this.txtObservacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObservacao_KeyDown);
            this.txtObservacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacao_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(325, 166);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ObservacaoPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 221);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObservacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ObservacaoPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observação";
            this.Load += new System.EventHandler(this.ObservacaoPDV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObservacaoPDV_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObservacaoPDV_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtObservacao;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}