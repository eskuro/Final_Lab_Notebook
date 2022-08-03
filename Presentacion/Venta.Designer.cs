namespace Presentacion
{
	partial class Venta
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnBorrarItem = new System.Windows.Forms.Button();
            this.btnCambiarCantidad = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(36, 71);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(374, 71);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(148, 26);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(203, 71);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(148, 26);
            this.txtDescripcion.TabIndex = 2;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(616, 72);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(122, 26);
            this.nudCantidad.TabIndex = 3;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(13, 121);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 62;
            this.dgvGrilla.Size = new System.Drawing.Size(928, 432);
            this.dgvGrilla.TabIndex = 4;
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            this.dgvGrilla.DoubleClick += new System.EventHandler(this.dgvGrilla_DoubleClick);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(754, 585);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(148, 26);
            this.txtSubTotal.TabIndex = 5;
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(754, 625);
            this.nudDescuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(122, 26);
            this.nudDescuento.TabIndex = 6;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(754, 668);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Lime;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.Location = new System.Drawing.Point(46, 566);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(108, 92);
            this.btnFacturar.TabIndex = 8;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnBorrarItem
            // 
            this.btnBorrarItem.BackColor = System.Drawing.Color.Red;
            this.btnBorrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrarItem.Location = new System.Drawing.Point(188, 566);
            this.btnBorrarItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrarItem.Name = "btnBorrarItem";
            this.btnBorrarItem.Size = new System.Drawing.Size(108, 92);
            this.btnBorrarItem.TabIndex = 9;
            this.btnBorrarItem.Text = "Borrar";
            this.btnBorrarItem.UseVisualStyleBackColor = false;
            this.btnBorrarItem.Click += new System.EventHandler(this.btnBorrarItem_Click);
            // 
            // btnCambiarCantidad
            // 
            this.btnCambiarCantidad.BackColor = System.Drawing.Color.Yellow;
            this.btnCambiarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarCantidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnCambiarCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCambiarCantidad.Location = new System.Drawing.Point(330, 566);
            this.btnCambiarCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarCantidad.Name = "btnCambiarCantidad";
            this.btnCambiarCantidad.Size = new System.Drawing.Size(108, 92);
            this.btnCambiarCantidad.TabIndex = 10;
            this.btnCambiarCantidad.Text = "Cambiar Cantidad";
            this.btnCambiarCantidad.UseVisualStyleBackColor = false;
            this.btnCambiarCantidad.Click += new System.EventHandler(this.btnCambiarCantidad_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(746, 67);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(199, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(381, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(624, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(663, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "SubTotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(657, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descuento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(692, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 713);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCambiarCantidad);
            this.Controls.Add(this.btnBorrarItem);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximumSize = new System.Drawing.Size(969, 769);
            this.MinimumSize = new System.Drawing.Size(969, 769);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.DataGridView dgvGrilla;
		private System.Windows.Forms.TextBox txtSubTotal;
		private System.Windows.Forms.NumericUpDown nudDescuento;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Button btnFacturar;
		private System.Windows.Forms.Button btnBorrarItem;
		private System.Windows.Forms.Button btnCambiarCantidad;
		private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}