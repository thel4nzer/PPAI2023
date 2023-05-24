namespace PPAI_2023
{
    partial class Encuestas
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultarEncuesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(320, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar Encuesta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEncuesta
            // 
            this.btnConsultarEncuesta.Location = new System.Drawing.Point(320, 214);
            this.btnConsultarEncuesta.Name = "btnConsultarEncuesta";
            this.btnConsultarEncuesta.Size = new System.Drawing.Size(187, 23);
            this.btnConsultarEncuesta.TabIndex = 1;
            this.btnConsultarEncuesta.Text = "Consultar Encuesta";
            this.btnConsultarEncuesta.UseVisualStyleBackColor = true;
            this.btnConsultarEncuesta.Click += new System.EventHandler(this.btnConsultarEncuesta_Click);
            // 
            // Encuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultarEncuesta);
            this.Controls.Add(this.button1);
            this.Name = "Encuestas";
            this.Text = "Encuestas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsultarEncuesta;
    }
}