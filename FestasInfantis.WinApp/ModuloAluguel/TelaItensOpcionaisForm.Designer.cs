namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaItensOpcionaisForm
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
            groupBoxItensAdicionais = new GroupBox();
            listAdicionais = new CheckedListBox();
            btnSalvar = new Button();
            groupBoxItensAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxItensAdicionais
            // 
            groupBoxItensAdicionais.Controls.Add(listAdicionais);
            groupBoxItensAdicionais.Dock = DockStyle.Top;
            groupBoxItensAdicionais.Location = new Point(0, 0);
            groupBoxItensAdicionais.Name = "groupBoxItensAdicionais";
            groupBoxItensAdicionais.Size = new Size(495, 398);
            groupBoxItensAdicionais.TabIndex = 0;
            groupBoxItensAdicionais.TabStop = false;
            groupBoxItensAdicionais.Text = "Itens Disponíveis";
            // 
            // listAdicionais
            // 
            listAdicionais.Dock = DockStyle.Fill;
            listAdicionais.FormattingEnabled = true;
            listAdicionais.Location = new Point(3, 23);
            listAdicionais.Name = "listAdicionais";
            listAdicionais.Size = new Size(489, 372);
            listAdicionais.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(375, 414);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 48);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // TelaItensOpcionaisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 483);
            Controls.Add(btnSalvar);
            Controls.Add(groupBoxItensAdicionais);
            Name = "TelaItensOpcionaisForm";
            Text = "TelaItensOpcionaisForm";
            groupBoxItensAdicionais.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxItensAdicionais;
        private CheckedListBox listAdicionais;
        private Button btnSalvar;
    }
}