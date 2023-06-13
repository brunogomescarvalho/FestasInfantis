namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaDetalhesTemaForm
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
            groupBoxDetalhes = new GroupBox();
            groupBoxTemas = new GroupBox();
            listItens = new ListBox();
            txtTema = new TextBox();
            txtPreco = new TextBox();
            txtNr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOk = new Button();
            groupBoxDetalhes.SuspendLayout();
            groupBoxTemas.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDetalhes
            // 
            groupBoxDetalhes.Controls.Add(groupBoxTemas);
            groupBoxDetalhes.Controls.Add(txtTema);
            groupBoxDetalhes.Controls.Add(txtPreco);
            groupBoxDetalhes.Controls.Add(txtNr);
            groupBoxDetalhes.Controls.Add(label3);
            groupBoxDetalhes.Controls.Add(label2);
            groupBoxDetalhes.Controls.Add(label1);
            groupBoxDetalhes.Location = new Point(22, 40);
            groupBoxDetalhes.Name = "groupBoxDetalhes";
            groupBoxDetalhes.Size = new Size(490, 466);
            groupBoxDetalhes.TabIndex = 0;
            groupBoxDetalhes.TabStop = false;
            groupBoxDetalhes.Text = "Detalhes Tema";
            // 
            // groupBoxTemas
            // 
            groupBoxTemas.Controls.Add(listItens);
            groupBoxTemas.Dock = DockStyle.Bottom;
            groupBoxTemas.Location = new Point(3, 152);
            groupBoxTemas.Name = "groupBoxTemas";
            groupBoxTemas.Size = new Size(484, 311);
            groupBoxTemas.TabIndex = 6;
            groupBoxTemas.TabStop = false;
            groupBoxTemas.Text = "Itens do Temas";
            // 
            // listItens
            // 
            listItens.Dock = DockStyle.Fill;
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 20;
            listItens.Location = new Point(3, 23);
            listItens.Name = "listItens";
            listItens.Size = new Size(478, 285);
            listItens.TabIndex = 0;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(98, 105);
            txtTema.Name = "txtTema";
            txtTema.ReadOnly = true;
            txtTema.Size = new Size(350, 27);
            txtTema.TabIndex = 5;
            txtTema.TabStop = false;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(323, 40);
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = true;
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 4;
            txtPreco.TabStop = false;
            // 
            // txtNr
            // 
            txtNr.Location = new Point(101, 40);
            txtNr.Name = "txtNr";
            txtNr.ReadOnly = true;
            txtNr.Size = new Size(125, 27);
            txtNr.TabIndex = 3;
            txtNr.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 47);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Preço: R$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 108);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Tema:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(412, 526);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 46);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // TelaDetalhesTemaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 598);
            Controls.Add(btnOk);
            Controls.Add(groupBoxDetalhes);
            Name = "TelaDetalhesTemaForm";
            Text = "TelaDetalhesTemaForm";
            groupBoxDetalhes.ResumeLayout(false);
            groupBoxDetalhes.PerformLayout();
            groupBoxTemas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDetalhes;
        private GroupBox groupBoxTemas;
        private ListBox listItens;
        private TextBox txtTema;
        private TextBox txtPreco;
        private TextBox txtNr;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOk;
    }
}