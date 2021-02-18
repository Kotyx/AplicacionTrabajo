
namespace AplicacionTrabajo
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
            this.userControl12 = new BibliotecaTrabajo.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(0, -1);
            this.userControl12.Name = "userControl12";
            this.userControl12.propiedadNumero = 0;
            this.userControl12.Size = new System.Drawing.Size(800, 450);
            this.userControl12.TabIndex = 0;
            this.userControl12.Load += new System.EventHandler(this.userControl12_Load);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver veces jugadas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(793, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl12);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BibliotecaTrabajo.UserControl1 userControl11;
        private BibliotecaTrabajo.UserControl1 userControl12;
        private System.Windows.Forms.Button button1;
    }
}

