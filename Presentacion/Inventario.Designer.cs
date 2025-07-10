namespace Presentacion
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDataCompra = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDataDetalleCompra = new System.Windows.Forms.DataGridView();
            this.IdDetalleCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompraa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDataVenta = new System.Windows.Forms.DataGridView();
            this.DgvDataDetalleVenta = new System.Windows.Forms.DataGridView();
            this.IdDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVentaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProductoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVentaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuarioo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuarioo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotaal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDataCompra
            // 
            this.DgvDataCompra.AllowUserToAddRows = false;
            this.DgvDataCompra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvDataCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDataCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btneliminar,
            this.IdCompra,
            this.IdUsuario,
            this.Usuario,
            this.IdProveedor,
            this.Proveedor,
            this.Documento,
            this.MontoTotal});
            this.DgvDataCompra.Location = new System.Drawing.Point(13, 63);
            this.DgvDataCompra.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDataCompra.MultiSelect = false;
            this.DgvDataCompra.Name = "DgvDataCompra";
            this.DgvDataCompra.ReadOnly = true;
            this.DgvDataCompra.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataCompra.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvDataCompra.RowTemplate.Height = 28;
            this.DgvDataCompra.Size = new System.Drawing.Size(776, 276);
            this.DgvDataCompra.TabIndex = 203;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.MinimumWidth = 6;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Visible = false;
            this.btneliminar.Width = 35;
            // 
            // IdCompra
            // 
            this.IdCompra.HeaderText = "IdCompra";
            this.IdCompra.MinimumWidth = 6;
            this.IdCompra.Name = "IdCompra";
            this.IdCompra.ReadOnly = true;
            this.IdCompra.Visible = false;
            this.IdCompra.Width = 150;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 200;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 130;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.MinimumWidth = 6;
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            this.IdProveedor.Width = 125;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "N° Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 125;
            // 
            // DgvDataDetalleCompra
            // 
            this.DgvDataDetalleCompra.AllowUserToAddRows = false;
            this.DgvDataDetalleCompra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvDataDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDataDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleCompra,
            this.IdCompraa,
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.MontoTotall});
            this.DgvDataDetalleCompra.Location = new System.Drawing.Point(13, 398);
            this.DgvDataDetalleCompra.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDataDetalleCompra.MultiSelect = false;
            this.DgvDataDetalleCompra.Name = "DgvDataDetalleCompra";
            this.DgvDataDetalleCompra.ReadOnly = true;
            this.DgvDataDetalleCompra.RowHeadersWidth = 51;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataDetalleCompra.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvDataDetalleCompra.RowTemplate.Height = 28;
            this.DgvDataDetalleCompra.Size = new System.Drawing.Size(776, 244);
            this.DgvDataDetalleCompra.TabIndex = 211;
            // 
            // IdDetalleCompra
            // 
            this.IdDetalleCompra.HeaderText = "IdDetalleCompra";
            this.IdDetalleCompra.MinimumWidth = 6;
            this.IdDetalleCompra.Name = "IdDetalleCompra";
            this.IdDetalleCompra.ReadOnly = true;
            this.IdDetalleCompra.Visible = false;
            this.IdDetalleCompra.Width = 125;
            // 
            // IdCompraa
            // 
            this.IdCompraa.HeaderText = "IdCompraa";
            this.IdCompraa.MinimumWidth = 6;
            this.IdCompraa.Name = "IdCompraa";
            this.IdCompraa.ReadOnly = true;
            this.IdCompraa.Visible = false;
            this.IdCompraa.Width = 125;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // MontoTotall
            // 
            this.MontoTotall.HeaderText = "MontoTotall";
            this.MontoTotall.MinimumWidth = 6;
            this.MontoTotall.Name = "MontoTotall";
            this.MontoTotall.ReadOnly = true;
            this.MontoTotall.Width = 125;
            // 
            // DgvDataVenta
            // 
            this.DgvDataVenta.AllowUserToAddRows = false;
            this.DgvDataVenta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DgvDataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDataVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.IdVenta,
            this.IdUsuarioo,
            this.Usuarioo,
            this.IdCliente,
            this.Cliente,
            this.NumeroDocumento,
            this.DocumentoCliente,
            this.MontoPago,
            this.MontoCambio,
            this.MontoTotaal});
            this.DgvDataVenta.Location = new System.Drawing.Point(809, 63);
            this.DgvDataVenta.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDataVenta.MultiSelect = false;
            this.DgvDataVenta.Name = "DgvDataVenta";
            this.DgvDataVenta.ReadOnly = true;
            this.DgvDataVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataVenta.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvDataVenta.RowTemplate.Height = 28;
            this.DgvDataVenta.Size = new System.Drawing.Size(776, 276);
            this.DgvDataVenta.TabIndex = 212;
            // 
            // DgvDataDetalleVenta
            // 
            this.DgvDataDetalleVenta.AllowUserToAddRows = false;
            this.DgvDataDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvDataDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDataDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleVenta,
            this.IdVentaa,
            this.IdProductoo,
            this.Productoo,
            this.PrecioVentaa,
            this.Cantidadd,
            this.SubTotal});
            this.DgvDataDetalleVenta.Location = new System.Drawing.Point(809, 398);
            this.DgvDataDetalleVenta.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDataDetalleVenta.MultiSelect = false;
            this.DgvDataDetalleVenta.Name = "DgvDataDetalleVenta";
            this.DgvDataDetalleVenta.ReadOnly = true;
            this.DgvDataDetalleVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvDataDetalleVenta.RowTemplate.Height = 28;
            this.DgvDataDetalleVenta.Size = new System.Drawing.Size(776, 244);
            this.DgvDataDetalleVenta.TabIndex = 213;
            // 
            // IdDetalleVenta
            // 
            this.IdDetalleVenta.HeaderText = "IdDetalleVenta";
            this.IdDetalleVenta.MinimumWidth = 6;
            this.IdDetalleVenta.Name = "IdDetalleVenta";
            this.IdDetalleVenta.ReadOnly = true;
            this.IdDetalleVenta.Visible = false;
            this.IdDetalleVenta.Width = 125;
            // 
            // IdVentaa
            // 
            this.IdVentaa.HeaderText = "IdVenta";
            this.IdVentaa.MinimumWidth = 6;
            this.IdVentaa.Name = "IdVentaa";
            this.IdVentaa.ReadOnly = true;
            this.IdVentaa.Visible = false;
            this.IdVentaa.Width = 125;
            // 
            // IdProductoo
            // 
            this.IdProductoo.HeaderText = "IdProducto";
            this.IdProductoo.MinimumWidth = 6;
            this.IdProductoo.Name = "IdProductoo";
            this.IdProductoo.ReadOnly = true;
            this.IdProductoo.Visible = false;
            this.IdProductoo.Width = 125;
            // 
            // Productoo
            // 
            this.Productoo.HeaderText = "Producto";
            this.Productoo.MinimumWidth = 6;
            this.Productoo.Name = "Productoo";
            this.Productoo.ReadOnly = true;
            this.Productoo.Width = 125;
            // 
            // PrecioVentaa
            // 
            this.PrecioVentaa.HeaderText = "Precio Venta";
            this.PrecioVentaa.MinimumWidth = 6;
            this.PrecioVentaa.Name = "PrecioVentaa";
            this.PrecioVentaa.ReadOnly = true;
            this.PrecioVentaa.Width = 125;
            // 
            // Cantidadd
            // 
            this.Cantidadd.HeaderText = "Cantidad";
            this.Cantidadd.MinimumWidth = 6;
            this.Cantidadd.Name = "Cantidadd";
            this.Cantidadd.ReadOnly = true;
            this.Cantidadd.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Visible = false;
            this.dataGridViewButtonColumn1.Width = 35;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "IdVenta";
            this.IdVenta.MinimumWidth = 6;
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Visible = false;
            this.IdVenta.Width = 150;
            // 
            // IdUsuarioo
            // 
            this.IdUsuarioo.HeaderText = "IdUsuarioo";
            this.IdUsuarioo.MinimumWidth = 6;
            this.IdUsuarioo.Name = "IdUsuarioo";
            this.IdUsuarioo.ReadOnly = true;
            this.IdUsuarioo.Visible = false;
            this.IdUsuarioo.Width = 125;
            // 
            // Usuarioo
            // 
            this.Usuarioo.HeaderText = "Usuarioo";
            this.Usuarioo.MinimumWidth = 6;
            this.Usuarioo.Name = "Usuarioo";
            this.Usuarioo.ReadOnly = true;
            this.Usuarioo.Width = 125;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            this.IdCliente.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 125;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.MinimumWidth = 6;
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 125;
            // 
            // DocumentoCliente
            // 
            this.DocumentoCliente.HeaderText = "Documento Cliente";
            this.DocumentoCliente.MinimumWidth = 6;
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            this.DocumentoCliente.Visible = false;
            this.DocumentoCliente.Width = 125;
            // 
            // MontoPago
            // 
            this.MontoPago.HeaderText = "Monto Pago";
            this.MontoPago.MinimumWidth = 6;
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.ReadOnly = true;
            this.MontoPago.Visible = false;
            this.MontoPago.Width = 125;
            // 
            // MontoCambio
            // 
            this.MontoCambio.HeaderText = "Monto Cambio";
            this.MontoCambio.MinimumWidth = 6;
            this.MontoCambio.Name = "MontoCambio";
            this.MontoCambio.ReadOnly = true;
            this.MontoCambio.Visible = false;
            this.MontoCambio.Width = 125;
            // 
            // MontoTotaal
            // 
            this.MontoTotaal.HeaderText = "Monto Total";
            this.MontoTotaal.MinimumWidth = 6;
            this.MontoTotaal.Name = "MontoTotaal";
            this.MontoTotaal.ReadOnly = true;
            this.MontoTotaal.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 214;
            this.label1.Text = "Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 215;
            this.label2.Text = "Detalle Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 216;
            this.label3.Text = "Detalle Ventas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 217;
            this.label4.Text = "Venta";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 687);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvDataDetalleVenta);
            this.Controls.Add(this.DgvDataVenta);
            this.Controls.Add(this.DgvDataDetalleCompra);
            this.Controls.Add(this.DgvDataCompra);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDataCompra;
        private System.Windows.Forms.DataGridView DgvDataDetalleCompra;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompraa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotall;
        private System.Windows.Forms.DataGridView DgvDataVenta;
        private System.Windows.Forms.DataGridView DgvDataDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVentaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVentaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuarioo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotaal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}