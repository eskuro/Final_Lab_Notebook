namespace Principal
{
	partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.comprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.rubrosToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.creToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // creToolStripMenuItem
            // 
            this.creToolStripMenuItem.Name = "creToolStripMenuItem";
            this.creToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.creToolStripMenuItem.Text = "Nuevo Articulo";
            this.creToolStripMenuItem.Click += new System.EventHandler(this.creToolStripMenuItem_Click);
            // 
            // rubrosToolStripMenuItem
            // 
            this.rubrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem1,
            this.nuevoRubroToolStripMenuItem});
            this.rubrosToolStripMenuItem.Name = "rubrosToolStripMenuItem";
            this.rubrosToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.rubrosToolStripMenuItem.Text = "Rubros";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(220, 34);
            this.consultaToolStripMenuItem1.Text = "Consulta ";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // nuevoRubroToolStripMenuItem
            // 
            this.nuevoRubroToolStripMenuItem.Name = "nuevoRubroToolStripMenuItem";
            this.nuevoRubroToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.nuevoRubroToolStripMenuItem.Text = "Nuevo Rubro";
            this.nuevoRubroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRubroToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarVentaToolStripMenuItem,
            this.comprobantesToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // generarVentaToolStripMenuItem
            // 
            this.generarVentaToolStripMenuItem.Name = "generarVentaToolStripMenuItem";
            this.generarVentaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.generarVentaToolStripMenuItem.Text = "Generar Venta";
            this.generarVentaToolStripMenuItem.Click += new System.EventHandler(this.generarVentaToolStripMenuItem_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(0, 42);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(796, 646);
            this.panelContenedor.TabIndex = 1;
            // 
            // comprobantesToolStripMenuItem
            // 
            this.comprobantesToolStripMenuItem.Name = "comprobantesToolStripMenuItem";
            this.comprobantesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.comprobantesToolStripMenuItem.Text = "Comprobantes";
            this.comprobantesToolStripMenuItem.Click += new System.EventHandler(this.comprobantesToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 689);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem creToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rubrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem nuevoRubroToolStripMenuItem;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobantesToolStripMenuItem;
    }
}