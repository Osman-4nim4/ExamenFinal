
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1Admin = new System.Windows.Forms.Button();
            this.button2Orden = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Armenian", 36F);
            this.label1.Location = new System.Drawing.Point(205, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dormido´s Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1Admin
            // 
            this.button1Admin.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1Admin.Font = new System.Drawing.Font("Noto Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Admin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1Admin.Location = new System.Drawing.Point(246, 174);
            this.button1Admin.Name = "button1Admin";
            this.button1Admin.Size = new System.Drawing.Size(364, 75);
            this.button1Admin.TabIndex = 2;
            this.button1Admin.Text = "ADMINISTRACION";
            this.button1Admin.UseVisualStyleBackColor = false;
            this.button1Admin.Click += new System.EventHandler(this.button1Admin_Click);
            // 
            // button2Orden
            // 
            this.button2Orden.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2Orden.Font = new System.Drawing.Font("Noto Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Orden.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2Orden.Location = new System.Drawing.Point(330, 255);
            this.button2Orden.Name = "button2Orden";
            this.button2Orden.Size = new System.Drawing.Size(200, 76);
            this.button2Orden.TabIndex = 3;
            this.button2Orden.Text = "Ordenes";
            this.button2Orden.UseVisualStyleBackColor = false;
            this.button2Orden.Click += new System.EventHandler(this.button2Orden_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Captura_de_pantalla_2021_06_13_111656;
            this.pictureBox3.Location = new System.Drawing.Point(450, 411);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(381, 50);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.images1;
            this.pictureBox2.Location = new System.Drawing.Point(-37, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._02_FONDO_FRANJA_AZUL_01;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2Orden);
            this.Controls.Add(this.button1Admin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Admin;
        private System.Windows.Forms.Button button2Orden;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

