namespace E02___Raso_Padilla_Jose_Manuel
{
    partial class Form1
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnDesplegar = new System.Windows.Forms.Button();
            this.lstClases = new System.Windows.Forms.ListBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.lblNombreClase = new System.Windows.Forms.Label();
            this.lblClases = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(426, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(137, 36);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Clases";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnDesplegar
            // 
            this.btnDesplegar.Location = new System.Drawing.Point(426, 76);
            this.btnDesplegar.Name = "btnDesplegar";
            this.btnDesplegar.Size = new System.Drawing.Size(137, 36);
            this.btnDesplegar.TabIndex = 2;
            this.btnDesplegar.Text = "Desplegar";
            this.btnDesplegar.UseVisualStyleBackColor = true;
            this.btnDesplegar.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // lstClases
            // 
            this.lstClases.FormattingEnabled = true;
            this.lstClases.Location = new System.Drawing.Point(47, 89);
            this.lstClases.Name = "lstClases";
            this.lstClases.Size = new System.Drawing.Size(125, 134);
            this.lstClases.TabIndex = 7;
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(766, 76);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(125, 134);
            this.lstAlumnos.TabIndex = 8;
            // 
            // lblNombreClase
            // 
            this.lblNombreClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClase.Location = new System.Drawing.Point(761, 29);
            this.lblNombreClase.Name = "lblNombreClase";
            this.lblNombreClase.Size = new System.Drawing.Size(128, 30);
            this.lblNombreClase.TabIndex = 9;
            this.lblNombreClase.Text = "wea";
            this.lblNombreClase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClases
            // 
            this.lblClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClases.Location = new System.Drawing.Point(42, 29);
            this.lblClases.Name = "lblClases";
            this.lblClases.Size = new System.Drawing.Size(128, 30);
            this.lblClases.TabIndex = 10;
            this.lblClases.Text = "Clases";
            this.lblClases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E02___Raso_Padilla_Jose_Manuel.Properties.Resources.DS5BR50XUAUNi7p;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 533);
            this.Controls.Add(this.lblClases);
            this.Controls.Add(this.lblNombreClase);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.lstClases);
            this.Controls.Add(this.btnDesplegar);
            this.Controls.Add(this.btnCargar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "E3-1 Mejorando la clase";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnDesplegar;
        private System.Windows.Forms.Label lblNombreClase;
        private System.Windows.Forms.Label lblClases;
        public System.Windows.Forms.ListBox lstClases;
        public System.Windows.Forms.ListBox lstAlumnos;
    }
}

