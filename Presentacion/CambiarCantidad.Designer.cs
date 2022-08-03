namespace Presentacion
{
	partial class CambiarCantidad
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
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblArticulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// nudCantidad
			// 
			this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.nudCantidad.Location = new System.Drawing.Point(50, 63);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(174, 22);
			this.nudCantidad.TabIndex = 1;
			this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(30, 108);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 25);
			this.button1.TabIndex = 3;
			this.button1.Text = "Ingresar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(169, 108);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 25);
			this.button2.TabIndex = 4;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(47, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cantidad";
			// 
			// lblArticulo
			// 
			this.lblArticulo.AutoSize = true;
			this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lblArticulo.Location = new System.Drawing.Point(136, 44);
			this.lblArticulo.Name = "lblArticulo";
			this.lblArticulo.Size = new System.Drawing.Size(88, 16);
			this.lblArticulo.TabIndex = 6;
			this.lblArticulo.Text = "ssssssssss";
			this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CambiarCantidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 182);
			this.Controls.Add(this.lblArticulo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nudCantidad);
			this.Name = "CambiarCantidad";
			this.Text = "CambiarCantidad";
			this.Load += new System.EventHandler(this.CambiarCantidad_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblArticulo;
	}
}