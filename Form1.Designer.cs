namespace Even_Academ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            cadastrarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            cadastrarEventoToolStripMenuItem = new ToolStripMenuItem();
            inscreverEstudanteToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1118, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { cadastrarUsuarioToolStripMenuItem, cadastrarEventoToolStripMenuItem, inscreverEstudanteToolStripMenuItem, listarToolStripMenuItem, listarToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1118, 33);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            cadastrarUsuarioToolStripMenuItem.Size = new Size(168, 29);
            cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuario";
            cadastrarUsuarioToolStripMenuItem.Click += cadastrarUsuarioToolStripMenuItem_Click;
            // 
            // cadastrarEventoToolStripMenuItem
            // 
            cadastrarEventoToolStripMenuItem.Name = "cadastrarEventoToolStripMenuItem";
            cadastrarEventoToolStripMenuItem.Size = new Size(162, 29);
            cadastrarEventoToolStripMenuItem.Text = "Cadastrar Evento";
            cadastrarEventoToolStripMenuItem.Click += cadastrarEventoToolStripMenuItem_Click;
            // 
            // inscreverEstudanteToolStripMenuItem
            // 
            inscreverEstudanteToolStripMenuItem.Name = "inscreverEstudanteToolStripMenuItem";
            inscreverEstudanteToolStripMenuItem.Size = new Size(181, 29);
            inscreverEstudanteToolStripMenuItem.Text = "Inscrever Estudante";
            inscreverEstudanteToolStripMenuItem.Click += inscreverEstudanteToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(141, 29);
            listarToolStripMenuItem.Text = " Listar eventos";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(235, 29);
            listarToolStripMenuItem1.Text = "Listar estudantes inscritos ";
            listarToolStripMenuItem1.Click += listarToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 507);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private ToolStripMenuItem cadastrarEventoToolStripMenuItem;
        private ToolStripMenuItem inscreverEstudanteToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
    }
}
