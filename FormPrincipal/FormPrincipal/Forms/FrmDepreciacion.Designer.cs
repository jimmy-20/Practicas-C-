
namespace FormPrincipal.Forms
{
    partial class FrmDepreciacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMetodoDepreciacion = new System.Windows.Forms.ComboBox();
            this.dgvDepreciacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo de depreciacion:";
            // 
            // cmbMetodoDepreciacion
            // 
            this.cmbMetodoDepreciacion.FormattingEnabled = true;
            this.cmbMetodoDepreciacion.Location = new System.Drawing.Point(272, 28);
            this.cmbMetodoDepreciacion.Name = "cmbMetodoDepreciacion";
            this.cmbMetodoDepreciacion.Size = new System.Drawing.Size(705, 28);
            this.cmbMetodoDepreciacion.TabIndex = 1;
            this.cmbMetodoDepreciacion.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoDepreciacion_SelectedIndexChanged);
            // 
            // dgvDepreciacion
            // 
            this.dgvDepreciacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepreciacion.Location = new System.Drawing.Point(17, 69);
            this.dgvDepreciacion.Name = "dgvDepreciacion";
            this.dgvDepreciacion.RowHeadersWidth = 62;
            this.dgvDepreciacion.RowTemplate.Height = 28;
            this.dgvDepreciacion.Size = new System.Drawing.Size(960, 432);
            this.dgvDepreciacion.TabIndex = 2;
            // 
            // FrmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 513);
            this.Controls.Add(this.dgvDepreciacion);
            this.Controls.Add(this.cmbMetodoDepreciacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmDepreciacion";
            this.Text = "FrmDepreciacion";
            this.Load += new System.EventHandler(this.FrmDepreciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMetodoDepreciacion;
        private System.Windows.Forms.DataGridView dgvDepreciacion;
    }
}