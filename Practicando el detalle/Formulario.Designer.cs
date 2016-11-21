namespace Practicando_el_detalle
{
    partial class Formulario
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
            this.FacturaIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArticuloscomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.Agragarbutton = new System.Windows.Forms.Button();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FacturaId";
            // 
            // FacturaIdtextBox
            // 
            this.FacturaIdtextBox.Location = new System.Drawing.Point(83, 29);
            this.FacturaIdtextBox.Name = "FacturaIdtextBox";
            this.FacturaIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.FacturaIdtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.Location = new System.Drawing.Point(83, 67);
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientetextBox.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(437, 43);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(97, 40);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(236, 303);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(97, 40);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(28, 303);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(97, 40);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatosdataGridView);
            this.groupBox1.Controls.Add(this.Agragarbutton);
            this.groupBox1.Controls.Add(this.CantidadtextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ArticuloscomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(28, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Articulos";
            // 
            // ArticuloscomboBox
            // 
            this.ArticuloscomboBox.FormattingEnabled = true;
            this.ArticuloscomboBox.Items.AddRange(new object[] {
            "Manzana ",
            "Uva",
            "Melon",
            "Piña",
            "Coco",
            "Naranja",
            "Guayaba"});
            this.ArticuloscomboBox.Location = new System.Drawing.Point(67, 24);
            this.ArticuloscomboBox.Name = "ArticuloscomboBox";
            this.ArticuloscomboBox.Size = new System.Drawing.Size(121, 21);
            this.ArticuloscomboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(260, 24);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(126, 20);
            this.CantidadtextBox.TabIndex = 3;
            // 
            // Agragarbutton
            // 
            this.Agragarbutton.Location = new System.Drawing.Point(409, 12);
            this.Agragarbutton.Name = "Agragarbutton";
            this.Agragarbutton.Size = new System.Drawing.Size(97, 37);
            this.Agragarbutton.TabIndex = 4;
            this.Agragarbutton.Text = "Agregar";
            this.Agragarbutton.UseVisualStyleBackColor = true;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Location = new System.Drawing.Point(6, 51);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.Size = new System.Drawing.Size(500, 119);
            this.DatosdataGridView.TabIndex = 5;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ClientetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FacturaIdtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FacturaIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientetextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.Button Agragarbutton;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ArticuloscomboBox;
        private System.Windows.Forms.Label label3;
    }
}