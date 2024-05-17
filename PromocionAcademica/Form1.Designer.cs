namespace PromocionAcademica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarMásInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionToolStripMenuItem,
            this.misionToolStripMenuItem,
            this.cargoAcademicoToolStripMenuItem,
            this.solicitarMásInformacionToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.profesoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.visionToolStripMenuItem.Text = "Vision";
            this.visionToolStripMenuItem.Click += new System.EventHandler(this.visionToolStripMenuItem_Click);
            // 
            // misionToolStripMenuItem
            // 
            this.misionToolStripMenuItem.Name = "misionToolStripMenuItem";
            this.misionToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.misionToolStripMenuItem.Text = "Mision";
            this.misionToolStripMenuItem.Click += new System.EventHandler(this.misionToolStripMenuItem_Click);
            // 
            // cargoAcademicoToolStripMenuItem
            // 
            this.cargoAcademicoToolStripMenuItem.Name = "cargoAcademicoToolStripMenuItem";
            this.cargoAcademicoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.cargoAcademicoToolStripMenuItem.Text = "Carga Academico";
            this.cargoAcademicoToolStripMenuItem.Click += new System.EventHandler(this.cargoAcademicoToolStripMenuItem_Click);
            // 
            // solicitarMásInformacionToolStripMenuItem
            // 
            this.solicitarMásInformacionToolStripMenuItem.Name = "solicitarMásInformacionToolStripMenuItem";
            this.solicitarMásInformacionToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.solicitarMásInformacionToolStripMenuItem.Text = "Solicitar Más informacion";
            this.solicitarMásInformacionToolStripMenuItem.Click += new System.EventHandler(this.solicitarMásInformacionToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PromocionAcademica.Properties.Resources.logouadeo79;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Promocion Academica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoAcademicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarMásInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

