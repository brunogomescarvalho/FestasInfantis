namespace FestasInfantis.WinApp
{
    partial class TelaPrincipalForm
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
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesMenu = new ToolStripMenuItem();
            TematicasToolStripMenuItem = new ToolStripMenuItem();
            alugueisToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnItemTema = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            labelMenu = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            panelTelaPrincipal = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.BurlyWood;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(900, 48);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenu, TematicasToolStripMenuItem, alugueisToolStripMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrosToolStripMenuItem.Image = Properties.Resources.menu_FILL0_wght200_GRAD0_opsz40;
            cadastrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(139, 44);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesMenu
            // 
            clientesMenu.Image = Properties.Resources.person_add_FILL0_wght200_GRAD0_opsz40;
            clientesMenu.ImageScaling = ToolStripItemImageScaling.None;
            clientesMenu.Name = "clientesMenu";
            clientesMenu.Size = new Size(179, 46);
            clientesMenu.Text = "Clientes";
            clientesMenu.Click += ClientesMenu_Click;
            // 
            // TematicasToolStripMenuItem
            // 
            TematicasToolStripMenuItem.Image = Properties.Resources.domino_mask_FILL0_wght200_GRAD0_opsz40;
            TematicasToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            TematicasToolStripMenuItem.Name = "TematicasToolStripMenuItem";
            TematicasToolStripMenuItem.Size = new Size(179, 46);
            TematicasToolStripMenuItem.Text = "Temas";
            TematicasToolStripMenuItem.Click += TematicasToolStripMenuItem_Click;
            // 
            // alugueisToolStripMenuItem
            // 
            alugueisToolStripMenuItem.Image = Properties.Resources.celebration_FILL0_wght200_GRAD0_opsz40;
            alugueisToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            alugueisToolStripMenuItem.Name = "alugueisToolStripMenuItem";
            alugueisToolStripMenuItem.Size = new Size(179, 46);
            alugueisToolStripMenuItem.Text = "Alugueis";
            alugueisToolStripMenuItem.Click += AlugueisToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.AntiqueWhite;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator2, btnItemTema, toolStripSeparator1, labelMenu });
            toolStrip1.Location = new Point(0, 48);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 47);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.add_circle_FILL0_wght200_GRAD0_opsz40;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(44, 44);
            btnAdicionar.Click += BtnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght200_GRAD0_opsz40;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(44, 44);
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght200_GRAD0_opsz40;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(44, 44);
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // btnItemTema
            // 
            btnItemTema.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItemTema.Enabled = false;
            btnItemTema.Image = Properties.Resources.library_add_FILL0_wght200_GRAD0_opsz40;
            btnItemTema.ImageScaling = ToolStripItemImageScaling.None;
            btnItemTema.ImageTransparentColor = Color.Magenta;
            btnItemTema.Name = "btnItemTema";
            btnItemTema.Size = new Size(44, 44);
            btnItemTema.Click += BtnItemTema_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // labelMenu
            // 
            labelMenu.ImageAlign = ContentAlignment.TopCenter;
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(102, 44);
            labelMenu.Text = "Tipo Cadastro";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.AntiqueWhite;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 492);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(900, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(88, 20);
            labelRodape.Text = "Bem-Vindo!";
            // 
            // panelTelaPrincipal
            // 
            panelTelaPrincipal.Dock = DockStyle.Fill;
            panelTelaPrincipal.Location = new Point(0, 95);
            panelTelaPrincipal.Name = "panelTelaPrincipal";
            panelTelaPrincipal.Size = new Size(900, 397);
            panelTelaPrincipal.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(900, 518);
            Controls.Add(panelTelaPrincipal);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festas Infantis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesMenu;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelMenu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private Panel panelTelaPrincipal;
        private ToolStripMenuItem TematicasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnItemTema;
        private ToolStripMenuItem alugueisToolStripMenuItem;
    }
}