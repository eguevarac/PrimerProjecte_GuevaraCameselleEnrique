namespace PrimerProjecte_GuevaraCameselleEnrique
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peticiónMóduloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosProfesoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosProfesoresToolStripMenuItem
            // 
            this.datosProfesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peticiónMóduloToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.datosProfesoresToolStripMenuItem.Name = "datosProfesoresToolStripMenuItem";
            this.datosProfesoresToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.datosProfesoresToolStripMenuItem.Text = "Datos Profesores";
            this.datosProfesoresToolStripMenuItem.Click += new System.EventHandler(this.datosMaestrosToolStripMenuItem_Click);
            // 
            // peticiónMóduloToolStripMenuItem
            // 
            this.peticiónMóduloToolStripMenuItem.Name = "peticiónMóduloToolStripMenuItem";
            this.peticiónMóduloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.peticiónMóduloToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.peticiónMóduloToolStripMenuItem.Text = "Petición Módulo";
            this.peticiónMóduloToolStripMenuItem.Click += new System.EventHandler(this.peticiónMóduloToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(247, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = global::PrimerProjecte_GuevaraCameselleEnrique.Properties.Resources.salir1;
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peticiónMóduloToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    }
}

