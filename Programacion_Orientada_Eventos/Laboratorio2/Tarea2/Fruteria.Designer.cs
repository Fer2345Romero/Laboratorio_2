namespace Programacion_Orientada_Eventos.Laboratorio2.Tarea2
{
    partial class Fruteria
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
            this.labelCantidadDisponible = new System.Windows.Forms.Label();
            this.buttonNuevaVenta = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.listBoxFrutas = new System.Windows.Forms.ListBox();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgregarFrutaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCantidadDisponible
            // 
            this.labelCantidadDisponible.AutoSize = true;
            this.labelCantidadDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadDisponible.Location = new System.Drawing.Point(193, 120);
            this.labelCantidadDisponible.Name = "labelCantidadDisponible";
            this.labelCantidadDisponible.Size = new System.Drawing.Size(149, 16);
            this.labelCantidadDisponible.TabIndex = 0;
            this.labelCantidadDisponible.Text = "Cantidad disponible";
            // 
            // buttonNuevaVenta
            // 
            this.buttonNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaVenta.Location = new System.Drawing.Point(196, 227);
            this.buttonNuevaVenta.Name = "buttonNuevaVenta";
            this.buttonNuevaVenta.Size = new System.Drawing.Size(139, 27);
            this.buttonNuevaVenta.TabIndex = 1;
            this.buttonNuevaVenta.Text = "Nueva venta";
            this.buttonNuevaVenta.UseVisualStyleBackColor = true;
            this.buttonNuevaVenta.Click += new System.EventHandler(this.buttonNuevaVenta_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(193, 158);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(53, 16);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // listBoxFrutas
            // 
            this.listBoxFrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFrutas.FormattingEnabled = true;
            this.listBoxFrutas.ItemHeight = 16;
            this.listBoxFrutas.Location = new System.Drawing.Point(21, 120);
            this.listBoxFrutas.Name = "listBoxFrutas";
            this.listBoxFrutas.Size = new System.Drawing.Size(150, 116);
            this.listBoxFrutas.TabIndex = 3;
            this.listBoxFrutas.SelectedIndexChanged += new System.EventHandler(this.listBoxFrutas_SelectedIndexChanged);
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Items.AddRange(new object[] {
            "Mario",
            "Rosario"});
            this.comboBoxClientes.Location = new System.Drawing.Point(21, 59);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(150, 21);
            this.comboBoxClientes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // AgregarFrutaButton
            // 
            this.AgregarFrutaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarFrutaButton.Location = new System.Drawing.Point(196, 183);
            this.AgregarFrutaButton.Name = "AgregarFrutaButton";
            this.AgregarFrutaButton.Size = new System.Drawing.Size(139, 27);
            this.AgregarFrutaButton.TabIndex = 7;
            this.AgregarFrutaButton.Text = "Agregar Fruta";
            this.AgregarFrutaButton.UseVisualStyleBackColor = true;
            // 
            // Fruteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 312);
            this.Controls.Add(this.AgregarFrutaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.listBoxFrutas);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.buttonNuevaVenta);
            this.Controls.Add(this.labelCantidadDisponible);
            this.Name = "Fruteria";
            this.Text = "Fruteria";
            this.Load += new System.EventHandler(this.Fruteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCantidadDisponible;
        private System.Windows.Forms.Button buttonNuevaVenta;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.ListBox listBoxFrutas;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarFrutaButton;
    }
}