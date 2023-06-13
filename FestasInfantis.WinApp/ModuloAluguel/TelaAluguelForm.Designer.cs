﻿namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            labelCliente = new Label();
            labelData = new Label();
            labelEntrada = new Label();
            labelDesconto = new Label();
            txtCliente = new ComboBox();
            txtData = new DateTimePicker();
            txtEntrada = new ComboBox();
            txtDesconto = new ComboBox();
            labelEndereco = new Label();
            txtEndereco = new TextBox();
            labelFormapgto = new Label();
            txtPagemento = new ComboBox();
            labelTema = new Label();
            txtTema = new ComboBox();
            groupBoxItens = new GroupBox();
            listItens = new ListBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            labelPreco = new Label();
            label_Id = new Label();
            txtId = new TextBox();
            txtPreco = new TextBox();
            groupBoxItens.SuspendLayout();
            SuspendLayout();
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(38, 84);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(58, 20);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente:";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(14, 134);
            labelData.Name = "labelData";
            labelData.Size = new Size(82, 20);
            labelData.TabIndex = 1;
            labelData.Text = "Data Festa:";
            // 
            // labelEntrada
            // 
            labelEntrada.AutoSize = true;
            labelEntrada.Location = new Point(33, 181);
            labelEntrada.Name = "labelEntrada";
            labelEntrada.Size = new Size(63, 20);
            labelEntrada.TabIndex = 2;
            labelEntrada.Text = "Entrada:";
            // 
            // labelDesconto
            // 
            labelDesconto.AutoSize = true;
            labelDesconto.Location = new Point(21, 230);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(75, 20);
            labelDesconto.TabIndex = 3;
            labelDesconto.Text = "Desconto:";
            // 
            // txtCliente
            // 
            txtCliente.FormattingEnabled = true;
            txtCliente.Location = new Point(111, 76);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(297, 28);
            txtCliente.TabIndex = 4;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(111, 125);
            txtData.Name = "txtData";
            txtData.Size = new Size(297, 27);
            txtData.TabIndex = 5;
            // 
            // txtEntrada
            // 
            txtEntrada.FormattingEnabled = true;
            txtEntrada.Location = new Point(111, 173);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(297, 28);
            txtEntrada.TabIndex = 6;
            // 
            // txtDesconto
            // 
            txtDesconto.FormattingEnabled = true;
            txtDesconto.Location = new Point(111, 222);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(297, 28);
            txtDesconto.TabIndex = 7;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(22, 323);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(74, 20);
            labelEndereco.TabIndex = 8;
            labelEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(111, 320);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(297, 27);
            txtEndereco.TabIndex = 9;
            // 
            // labelFormapgto
            // 
            labelFormapgto.AutoSize = true;
            labelFormapgto.Location = new Point(9, 279);
            labelFormapgto.Name = "labelFormapgto";
            labelFormapgto.Size = new Size(87, 20);
            labelFormapgto.TabIndex = 10;
            labelFormapgto.Text = "Pagamento:";
            // 
            // txtPagemento
            // 
            txtPagemento.FormattingEnabled = true;
            txtPagemento.Location = new Point(111, 271);
            txtPagemento.Name = "txtPagemento";
            txtPagemento.Size = new Size(297, 28);
            txtPagemento.TabIndex = 11;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Location = new Point(48, 376);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(48, 20);
            labelTema.TabIndex = 12;
            labelTema.Text = "Tema:";
            // 
            // txtTema
            // 
            txtTema.FormattingEnabled = true;
            txtTema.Location = new Point(111, 368);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(297, 28);
            txtTema.TabIndex = 13;
            txtTema.SelectedIndexChanged += TxtTema_SelectedIndexChanged;
            // 
            // groupBoxItens
            // 
            groupBoxItens.Controls.Add(listItens);
            groupBoxItens.Location = new Point(465, 22);
            groupBoxItens.Name = "groupBoxItens";
            groupBoxItens.Size = new Size(347, 373);
            groupBoxItens.TabIndex = 14;
            groupBoxItens.TabStop = false;
            groupBoxItens.Text = "Itens do Tema";
            // 
            // listItens
            // 
            listItens.Dock = DockStyle.Fill;
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 20;
            listItens.Location = new Point(3, 23);
            listItens.Name = "listItens";
            listItens.Size = new Size(341, 347);
            listItens.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(594, 420);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 45);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(718, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 45);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Location = new Point(26, 427);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(70, 20);
            labelPreco.TabIndex = 20;
            labelPreco.Text = "Preço R$:";
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Location = new Point(30, 36);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(66, 20);
            label_Id.TabIndex = 22;
            label_Id.Text = "Número:";
            // 
            // txtId
            // 
            txtId.Location = new Point(111, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 23;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(111, 420);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(297, 27);
            txtPreco.TabIndex = 24;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 494);
            Controls.Add(txtPreco);
            Controls.Add(txtId);
            Controls.Add(label_Id);
            Controls.Add(labelPreco);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBoxItens);
            Controls.Add(txtTema);
            Controls.Add(labelTema);
            Controls.Add(txtPagemento);
            Controls.Add(labelFormapgto);
            Controls.Add(txtEndereco);
            Controls.Add(labelEndereco);
            Controls.Add(txtDesconto);
            Controls.Add(txtEntrada);
            Controls.Add(txtData);
            Controls.Add(txtCliente);
            Controls.Add(labelDesconto);
            Controls.Add(labelEntrada);
            Controls.Add(labelData);
            Controls.Add(labelCliente);
            Name = "TelaAluguelForm";
            Text = "TelaAluguelForm";
            groupBoxItens.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCliente;
        private Label labelData;
        private Label labelEntrada;
        private Label labelDesconto;
        private ComboBox txtCliente;
        private DateTimePicker txtData;
        private ComboBox txtEntrada;
        private ComboBox txtDesconto;
        private Label labelEndereco;
        private TextBox txtEndereco;
        private Label labelFormapgto;
        private ComboBox txtPagemento;
        private Label labelTema;
        private ComboBox txtTema;
        private GroupBox groupBoxItens;
        private ListBox listItens;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label labelPreco;
        private Label label_Id;
        private TextBox txtId;
        private TextBox txtPreco;
    }
}