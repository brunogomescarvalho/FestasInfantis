namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaItemTemaForm
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
            groupBox1 = new GroupBox();
            numericValor = new NumericUpDown();
            btnExcluir = new Button();
            btnInserir = new Button();
            listBoxItensTema = new ListBox();
            label4 = new Label();
            txtNomeItem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTema = new TextBox();
            txtId = new TextBox();
            labelNome = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericValor).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericValor);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(listBoxItensTema);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNomeItem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTema);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelNome);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(453, 313);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Itens";
            // 
            // numericValor
            // 
            numericValor.DecimalPlaces = 2;
            numericValor.Location = new Point(93, 117);
            numericValor.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericValor.Name = "numericValor";
            numericValor.Size = new Size(111, 23);
            numericValor.TabIndex = 21;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(6, 206);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 46);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(6, 154);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 46);
            btnInserir.TabIndex = 18;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += BtnInserir_Click;
            // 
            // listBoxItensTema
            // 
            listBoxItensTema.FormattingEnabled = true;
            listBoxItensTema.ItemHeight = 15;
            listBoxItensTema.Location = new Point(93, 154);
            listBoxItensTema.Name = "listBoxItensTema";
            listBoxItensTema.Size = new Size(331, 139);
            listBoxItensTema.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 117);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 16;
            label4.Text = "Valor:";
            // 
            // txtNomeItem
            // 
            txtNomeItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeItem.Location = new Point(93, 85);
            txtNomeItem.Margin = new Padding(3, 2, 3, 2);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(331, 25);
            txtNomeItem.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 88);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 11;
            label2.Text = "Item:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 9;
            label1.Text = "Número:";
            // 
            // txtTema
            // 
            txtTema.Enabled = false;
            txtTema.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTema.Location = new Point(93, 56);
            txtTema.Margin = new Padding(3, 2, 3, 2);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(331, 25);
            txtTema.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(94, 28);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = SystemColors.ButtonFace;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(26, 56);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 19);
            labelNome.TabIndex = 10;
            labelNome.Text = "Tema:";
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(309, 344);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(390, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaItemTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 391);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemTemaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Itens do Tema";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericValor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnInserir;
        private ListBox listBoxItensTema;
        private Label label4;
        private TextBox txtNomeItem;
        private Label label2;
        private Label label1;
        private TextBox txtTema;
        private TextBox txtId;
        private Label labelNome;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnExcluir;
        private TextBox txtValor;
        private NumericUpDown numericValor;
    }
}