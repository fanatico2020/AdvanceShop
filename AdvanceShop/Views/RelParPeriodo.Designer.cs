
namespace AdvanceShop.Views
{
    partial class RelParPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelParPeriodo));
            this.lblSaldoInicial = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodoInicial = new DevExpress.XtraScheduler.DateNavigator();
            this.txtPeriodoFinal = new DevExpress.XtraScheduler.DateNavigator();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnVisualizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoInicial.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoFinal.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicial.Appearance.Options.UseFont = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(12, 12);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(107, 19);
            this.lblSaldoInicial.TabIndex = 2;
            this.lblSaldoInicial.Text = "Período Inicial:";
            // 
            // txtPeriodoInicial
            // 
            this.txtPeriodoInicial.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtPeriodoInicial.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.txtPeriodoInicial.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPeriodoInicial.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.txtPeriodoInicial.Location = new System.Drawing.Point(12, 37);
            this.txtPeriodoInicial.Name = "txtPeriodoInicial";
            this.txtPeriodoInicial.Size = new System.Drawing.Size(241, 250);
            this.txtPeriodoInicial.TabIndex = 3;
            // 
            // txtPeriodoFinal
            // 
            this.txtPeriodoFinal.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtPeriodoFinal.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.txtPeriodoFinal.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPeriodoFinal.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.txtPeriodoFinal.Location = new System.Drawing.Point(296, 37);
            this.txtPeriodoFinal.Name = "txtPeriodoFinal";
            this.txtPeriodoFinal.Size = new System.Drawing.Size(241, 250);
            this.txtPeriodoFinal.TabIndex = 4;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(259, -9);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(31, 296);
            this.separatorControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(296, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Período Final:";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Appearance.Options.UseFont = true;
            this.btnVisualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.ImageOptions.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(426, 293);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(111, 36);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // RelParPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 343);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.txtPeriodoFinal);
            this.Controls.Add(this.txtPeriodoInicial);
            this.Controls.Add(this.lblSaldoInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "RelParPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RelParPeriodo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RelParPeriodo_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoInicial.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoFinal.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSaldoInicial;
        private DevExpress.XtraScheduler.DateNavigator txtPeriodoInicial;
        private DevExpress.XtraScheduler.DateNavigator txtPeriodoFinal;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnVisualizar;
    }
}