
namespace Presentacion
{
    partial class ComprobanteConsulta
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
            this.dgvComprobantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprobantes
            // 
            this.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobantes.Location = new System.Drawing.Point(3, 69);
            this.dgvComprobantes.Name = "dgvComprobantes";
            this.dgvComprobantes.RowHeadersWidth = 62;
            this.dgvComprobantes.RowTemplate.Height = 28;
            this.dgvComprobantes.Size = new System.Drawing.Size(774, 515);
            this.dgvComprobantes.TabIndex = 0;
            // 
            // ComprobanteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 596);
            this.Controls.Add(this.dgvComprobantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(798, 652);
            this.MinimumSize = new System.Drawing.Size(798, 652);
            this.Name = "ComprobanteConsulta";
            this.Text = "ComprobanteConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprobantes;
    }
}