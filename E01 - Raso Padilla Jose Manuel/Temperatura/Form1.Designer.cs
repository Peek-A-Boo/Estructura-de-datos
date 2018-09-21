namespace Temperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vsbTemperatura = new System.Windows.Forms.VScrollBar();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lblGrados = new System.Windows.Forms.Label();
            this.rbtFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vsbTemperatura
            // 
            this.vsbTemperatura.LargeChange = 1;
            this.vsbTemperatura.Location = new System.Drawing.Point(44, 28);
            this.vsbTemperatura.Maximum = 10000;
            this.vsbTemperatura.Name = "vsbTemperatura";
            this.vsbTemperatura.Size = new System.Drawing.Size(32, 400);
            this.vsbTemperatura.TabIndex = 0;
            this.vsbTemperatura.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbTemperatura_Scroll);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(109, 170);
            this.txtTemperatura.Multiline = true;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.ReadOnly = true;
            this.txtTemperatura.Size = new System.Drawing.Size(134, 38);
            this.txtTemperatura.TabIndex = 2;
            // 
            // lblGrados
            // 
            this.lblGrados.BackColor = System.Drawing.Color.SkyBlue;
            this.lblGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrados.Location = new System.Drawing.Point(104, 233);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(137, 36);
            this.lblGrados.TabIndex = 3;
            this.lblGrados.Text = "Grados";
            // 
            // rbtFahrenheit
            // 
            this.rbtFahrenheit.AutoSize = true;
            this.rbtFahrenheit.Checked = true;
            this.rbtFahrenheit.Location = new System.Drawing.Point(109, 91);
            this.rbtFahrenheit.Name = "rbtFahrenheit";
            this.rbtFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rbtFahrenheit.TabIndex = 4;
            this.rbtFahrenheit.TabStop = true;
            this.rbtFahrenheit.Text = "Fahrenheit";
            this.rbtFahrenheit.UseVisualStyleBackColor = true;
            this.rbtFahrenheit.CheckedChanged += new System.EventHandler(this.rbtFahrenheit_CheckedChanged);
            // 
            // rbCelsius
            // 
            this.rbCelsius.AutoSize = true;
            this.rbCelsius.Location = new System.Drawing.Point(109, 123);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(58, 17);
            this.rbCelsius.TabIndex = 5;
            this.rbCelsius.Text = "Celsius";
            this.rbCelsius.UseVisualStyleBackColor = true;
            this.rbCelsius.CheckedChanged += new System.EventHandler(this.rbCelsius_CheckedChanged);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(261, 170);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(223, 38);
            this.lblTemperatura.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 456);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.rbCelsius);
            this.Controls.Add(this.rbtFahrenheit);
            this.Controls.Add(this.lblGrados);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.vsbTemperatura);
            this.Name = "Form1";
            this.Text = "T03. Raso Padilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vsbTemperatura;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.RadioButton rbtFahrenheit;
        private System.Windows.Forms.RadioButton rbCelsius;
        private System.Windows.Forms.Label lblTemperatura;
    }
}

