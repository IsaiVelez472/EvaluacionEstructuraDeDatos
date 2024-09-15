namespace Evaluacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProducto = new TextBox();
            txtValorUnitario = new TextBox();
            txtCantidadVendida = new TextBox();
            cmbProductos = new ComboBox();
            btnAgregarProducto = new Button();
            btnQuitarProducto = new Button();
            btnAgregarVenta = new Button();
            dgProductos = new DataGridView();
            btnProductoMasVendido = new Button();
            btnProductoMenosIngresos = new Button();
            txtProductoMasVendido = new TextBox();
            txtProductoMenosIngresos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 69);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 101);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 128);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad vendida";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(135, 32);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(410, 23);
            txtProducto.TabIndex = 4;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(287, 61);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(100, 23);
            txtValorUnitario.TabIndex = 5;
            txtValorUnitario.TextChanged += txtValorUnitario_TextChanged;
            // 
            // txtCantidadVendida
            // 
            txtCantidadVendida.Location = new Point(300, 125);
            txtCantidadVendida.Name = "txtCantidadVendida";
            txtCantidadVendida.Size = new Size(71, 23);
            txtCantidadVendida.TabIndex = 6;
            txtCantidadVendida.TextChanged += txtCantidadVendida_TextChanged;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(223, 93);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(219, 23);
            cmbProductos.TabIndex = 7;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(622, 31);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(149, 23);
            btnAgregarProducto.TabIndex = 8;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.Location = new Point(657, 101);
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.Size = new Size(75, 23);
            btnQuitarProducto.TabIndex = 9;
            btnQuitarProducto.Text = "Quitar";
            btnQuitarProducto.UseVisualStyleBackColor = true;
            btnQuitarProducto.Click += btnQuitarProducto_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(640, 130);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(104, 23);
            btnAgregarVenta.TabIndex = 10;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(156, 185);
            dgProductos.Name = "dgProductos";
            dgProductos.Size = new Size(422, 150);
            dgProductos.TabIndex = 11;
            // 
            // btnProductoMasVendido
            // 
            btnProductoMasVendido.Location = new Point(46, 367);
            btnProductoMasVendido.Name = "btnProductoMasVendido";
            btnProductoMasVendido.Size = new Size(164, 23);
            btnProductoMasVendido.TabIndex = 12;
            btnProductoMasVendido.Text = "Producto Más Vendido";
            btnProductoMasVendido.UseVisualStyleBackColor = true;
            btnProductoMasVendido.Click += btnProductoMasVendido_Click;
            // 
            // btnProductoMenosIngresos
            // 
            btnProductoMenosIngresos.Location = new Point(49, 399);
            btnProductoMenosIngresos.Name = "btnProductoMenosIngresos";
            btnProductoMenosIngresos.Size = new Size(161, 23);
            btnProductoMenosIngresos.TabIndex = 13;
            btnProductoMenosIngresos.Text = "Producto Menos Ingresos";
            btnProductoMenosIngresos.UseVisualStyleBackColor = true;
            btnProductoMenosIngresos.Click += btnProductoMenosIngresos_Click;
            // 
            // txtProductoMasVendido
            // 
            txtProductoMasVendido.Enabled = false;
            txtProductoMasVendido.Location = new Point(223, 367);
            txtProductoMasVendido.Name = "txtProductoMasVendido";
            txtProductoMasVendido.Size = new Size(355, 23);
            txtProductoMasVendido.TabIndex = 14;
            // 
            // txtProductoMenosIngresos
            // 
            txtProductoMenosIngresos.Enabled = false;
            txtProductoMenosIngresos.Location = new Point(223, 400);
            txtProductoMenosIngresos.Name = "txtProductoMenosIngresos";
            txtProductoMenosIngresos.Size = new Size(355, 23);
            txtProductoMenosIngresos.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProductoMenosIngresos);
            Controls.Add(txtProductoMasVendido);
            Controls.Add(btnProductoMenosIngresos);
            Controls.Add(btnProductoMasVendido);
            Controls.Add(dgProductos);
            Controls.Add(btnAgregarVenta);
            Controls.Add(btnQuitarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(cmbProductos);
            Controls.Add(txtCantidadVendida);
            Controls.Add(txtValorUnitario);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProducto;
        private TextBox txtValorUnitario;
        private TextBox txtCantidadVendida;
        private ComboBox cmbProductos;
        private Button btnAgregarProducto;
        private Button btnQuitarProducto;
        private Button btnAgregarVenta;
        private DataGridView dgProductos;
        private Button btnProductoMasVendido;
        private Button btnProductoMenosIngresos;
        private TextBox txtProductoMasVendido;
        private TextBox txtProductoMenosIngresos;
    }
}
