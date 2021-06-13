
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.sucursal = new System.Windows.Forms.Label();
            this.pizza = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.ComboSucursales = new System.Windows.Forms.ComboBox();
            this.precio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescipcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1Pizza = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dormidos Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administracion";
            // 
            // sucursal
            // 
            this.sucursal.AutoSize = true;
            this.sucursal.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursal.Location = new System.Drawing.Point(21, 120);
            this.sucursal.Name = "sucursal";
            this.sucursal.Size = new System.Drawing.Size(129, 36);
            this.sucursal.TabIndex = 2;
            this.sucursal.Text = "Sucursal";
            // 
            // pizza
            // 
            this.pizza.AutoSize = true;
            this.pizza.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizza.Location = new System.Drawing.Point(21, 177);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(87, 35);
            this.pizza.TabIndex = 3;
            this.pizza.Text = "Pizza:";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(21, 293);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(174, 36);
            this.descripcion.TabIndex = 4;
            this.descripcion.Text = "Descripcion";
            // 
            // ComboSucursales
            // 
            this.ComboSucursales.FormattingEnabled = true;
            this.ComboSucursales.Items.AddRange(new object[] {
            "Guatemala",
            "Jalapa",
            "Progreso"});
            this.ComboSucursales.Location = new System.Drawing.Point(156, 135);
            this.ComboSucursales.Name = "ComboSucursales";
            this.ComboSucursales.Size = new System.Drawing.Size(121, 21);
            this.ComboSucursales.TabIndex = 5;
            this.ComboSucursales.SelectedIndexChanged += new System.EventHandler(this.Sucursales_SelectedIndexChanged);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(489, 150);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(95, 35);
            this.precio.TabIndex = 6;
            this.precio.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.FormattingEnabled = true;
            this.txtprecio.Items.AddRange(new object[] {
            "Q.25.00",
            "Q.50.00",
            "Q.100.00"});
            this.txtprecio.Location = new System.Drawing.Point(590, 164);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(121, 21);
            this.txtprecio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de la pizza";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(291, 247);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(199, 21);
            this.txtnombre.TabIndex = 9;
            // 
            // txtdescipcion
            // 
            this.txtdescipcion.Location = new System.Drawing.Point(27, 342);
            this.txtdescipcion.Multiline = true;
            this.txtdescipcion.Name = "txtdescipcion";
            this.txtdescipcion.Size = new System.Drawing.Size(463, 48);
            this.txtdescipcion.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1Pizza
            // 
            this.dataGridView1Pizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Pizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.Description,
            this.Valor});
            this.dataGridView1Pizza.Location = new System.Drawing.Point(27, 420);
            this.dataGridView1Pizza.Name = "dataGridView1Pizza";
            this.dataGridView1Pizza.Size = new System.Drawing.Size(793, 117);
            this.dataGridView1Pizza.TabIndex = 12;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Precio";
            this.Valor.Name = "Valor";
            this.Valor.Width = 200;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(686, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Agregar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.images1;
            this.pictureBox2.Location = new System.Drawing.Point(725, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 549);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1Pizza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdescipcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.ComboSucursales);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.pizza);
            this.Controls.Add(this.sucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Pizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sucursal;
        private System.Windows.Forms.Label pizza;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.ComboBox ComboSucursales;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.ComboBox txtprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescipcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}