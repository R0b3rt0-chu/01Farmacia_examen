namespace Farmacia
{
    partial class FrmPrincipal
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
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotesYVencimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empeladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyecciónDeDemandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.ventasToolStripMenuItem1,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarMedicamentosToolStripMenuItem,
            this.lotesYVencimToolStripMenuItem,
            this.empeladosToolStripMenuItem,
            this.lotesToolStripMenuItem,
            this.recetasToolStripMenuItem});
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.medicamentosToolStripMenuItem.Text = "Administración";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // administrarMedicamentosToolStripMenuItem
            // 
            this.administrarMedicamentosToolStripMenuItem.Name = "administrarMedicamentosToolStripMenuItem";
            this.administrarMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administrarMedicamentosToolStripMenuItem.Text = "Medicamentos";
            this.administrarMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.administrarMedicamentosToolStripMenuItem_Click);
            // 
            // lotesYVencimToolStripMenuItem
            // 
            this.lotesYVencimToolStripMenuItem.Name = "lotesYVencimToolStripMenuItem";
            this.lotesYVencimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lotesYVencimToolStripMenuItem.Text = "Sucursales";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProveedoresToolStripMenuItem,
            this.registrarComprasToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.proveedoresToolStripMenuItem.Text = "Inventario";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeProveedoresToolStripMenuItem.Text = "Ver Inventario";
            // 
            // registrarComprasToolStripMenuItem
            // 
            this.registrarComprasToolStripMenuItem.Name = "registrarComprasToolStripMenuItem";
            this.registrarComprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarComprasToolStripMenuItem.Text = "Gestionar Lotes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoDeVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ventasToolStripMenuItem.Text = "Compras";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            this.puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            this.puntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntoDeVentaToolStripMenuItem.Text = "Registrar Compra";
            // 
            // empeladosToolStripMenuItem
            // 
            this.empeladosToolStripMenuItem.Name = "empeladosToolStripMenuItem";
            this.empeladosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empeladosToolStripMenuItem.Text = "Empelados";
            // 
            // lotesToolStripMenuItem
            // 
            this.lotesToolStripMenuItem.Name = "lotesToolStripMenuItem";
            this.lotesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lotesToolStripMenuItem.Text = "Lotes";
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de Ventas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorDíaToolStripMenuItem,
            this.comprasPorProveedorToolStripMenuItem,
            this.proyecciónDeDemandaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventasPorDíaToolStripMenuItem
            // 
            this.ventasPorDíaToolStripMenuItem.Name = "ventasPorDíaToolStripMenuItem";
            this.ventasPorDíaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ventasPorDíaToolStripMenuItem.Text = "Ventas por día";
            // 
            // comprasPorProveedorToolStripMenuItem
            // 
            this.comprasPorProveedorToolStripMenuItem.Name = "comprasPorProveedorToolStripMenuItem";
            this.comprasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.comprasPorProveedorToolStripMenuItem.Text = "Compras por proveedor";
            // 
            // proyecciónDeDemandaToolStripMenuItem
            // 
            this.proyecciónDeDemandaToolStripMenuItem.Name = "proyecciónDeDemandaToolStripMenuItem";
            this.proyecciónDeDemandaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.proyecciónDeDemandaToolStripMenuItem.Text = "Proyección de demanda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "Nueva Ventana";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox2.Text = "Registrar Compra Rápida";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox3.Text = "Actualizar Stock";
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 428);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(800, 22);
            this.statusStripPrincipal.TabIndex = 4;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel2.Text = "Sucursal";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel3.Text = "Fecha";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel4.Text = "Hora";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel5.Text = "Estado";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Gestión de Farmacia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotesYVencimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empeladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyecciónDeDemandaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}