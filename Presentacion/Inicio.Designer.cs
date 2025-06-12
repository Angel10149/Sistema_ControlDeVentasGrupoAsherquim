namespace Presentacion
{
    partial class Inicio
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
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMantenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVerDetalleVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(800, 69);
            this.MenuTitulo.TabIndex = 2;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarios,
            this.MenuMantenedor,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuClientes,
            this.MenuProveedores,
            this.toolStripMenuItem3});
            this.Menu.Location = new System.Drawing.Point(0, 69);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 33);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(99, 29);
            this.MenuUsuarios.Text = "Usuarios";
            // 
            // MenuMantenedor
            // 
            this.MenuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCategoria,
            this.SubMenuProducto});
            this.MenuMantenedor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMantenedor.Name = "MenuMantenedor";
            this.MenuMantenedor.Size = new System.Drawing.Size(130, 29);
            this.MenuMantenedor.Text = "Mantenedor";
            // 
            // SubMenuCategoria
            // 
            this.SubMenuCategoria.Name = "SubMenuCategoria";
            this.SubMenuCategoria.Size = new System.Drawing.Size(224, 30);
            this.SubMenuCategoria.Text = "Categoria";
            // 
            // SubMenuProducto
            // 
            this.SubMenuProducto.Name = "SubMenuProducto";
            this.SubMenuProducto.Size = new System.Drawing.Size(224, 30);
            this.SubMenuProducto.Text = "Producto";
            // 
            // MenuVentas
            // 
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrarVenta,
            this.SubMenuVerDetalleVenta});
            this.MenuVentas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(82, 29);
            this.MenuVentas.Text = "Ventas";
            // 
            // SubMenuRegistrarVenta
            // 
            this.SubMenuRegistrarVenta.Name = "SubMenuRegistrarVenta";
            this.SubMenuRegistrarVenta.Size = new System.Drawing.Size(224, 30);
            this.SubMenuRegistrarVenta.Text = "Registrar";
            // 
            // SubMenuVerDetalleVenta
            // 
            this.SubMenuVerDetalleVenta.Name = "SubMenuVerDetalleVenta";
            this.SubMenuVerDetalleVenta.Size = new System.Drawing.Size(224, 30);
            this.SubMenuVerDetalleVenta.Text = "Ver Detalle";
            // 
            // MenuClientes
            // 
            this.MenuClientes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(93, 29);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuReporteVentas});
            this.MenuProveedores.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(131, 29);
            this.MenuProveedores.Text = "Proveedores";
            // 
            // SubMenuReporteVentas
            // 
            this.SubMenuReporteVentas.Name = "SubMenuReporteVentas";
            this.SubMenuReporteVentas.Size = new System.Drawing.Size(224, 30);
            this.SubMenuReporteVentas.Text = "Reporte Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema Control De Ventas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.Location = new System.Drawing.Point(570, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(455, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario:";
            // 
            // MenuCompras
            // 
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.MenuCompras.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(101, 29);
            this.MenuCompras.Text = "Compras";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 30);
            this.toolStripMenuItem2.Text = "Reporte Ventas";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(99, 29);
            this.toolStripMenuItem3.Text = "Reportes";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 30);
            this.toolStripMenuItem4.Text = "Reporte Ventas";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTitulo);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuMantenedor;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem SubMenuProducto;
        private System.Windows.Forms.ToolStripMenuItem MenuVentas;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVerDetalleVenta;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuProveedores;
        private System.Windows.Forms.ToolStripMenuItem SubMenuReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem MenuCompras;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
    }
}