
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
            this.userControl14 = new BibliotecaTrabajo.UserControl1();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControl14
            // 
            this.userControl14.Location = new System.Drawing.Point(-3, -1);
            this.userControl14.Name = "userControl14";
            this.userControl14.propiedadNumero = 0;
            this.userControl14.Size = new System.Drawing.Size(800, 450);
            this.userControl14.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(249, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Veces jugadas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(877, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userControl14);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaTrabajo.UserControl1 userControl11;
        private BibliotecaTrabajo.UserControl1 userControl12;
        private System.Windows.Forms.Button button1;
        private BibliotecaTrabajo.UserControl1 userControl13;
        private BibliotecaTrabajo.UserControl1 userControl14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

