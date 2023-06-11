namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            labelNome = new Label();
            labelCpf = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackgroundImageLayout = ImageLayout.Center;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(251, 212);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 32);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(351, 212);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = SystemColors.ButtonFace;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(20, 56);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(49, 19);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome:";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(20, 84);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 19);
            labelCpf.TabIndex = 11;
            labelCpf.Text = "Cpf:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(20, 112);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(62, 19);
            labelTelefone.TabIndex = 12;
            labelTelefone.Text = "Telefone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(20, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 19);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email:";
            // 
            // txtId
            // 
            txtId.Location = new Point(94, 28);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(93, 56);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 25);
            txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(93, 112);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(330, 25);
            txtTelefone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 9;
            label1.Text = "Número:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(91, 140);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(331, 25);
            txtEmail.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(95, 86);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(329, 23);
            txtCpf.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelTelefone);
            groupBox1.Controls.Add(labelCpf);
            groupBox1.Controls.Add(labelNome);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(10, 18);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(453, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário Cliente";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 266);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaClienteForm";
            Text = "TelaClienteForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalvar;
        private Button btnCancelar;
        private Label labelNome;
        private Label labelCpf;
        private Label labelTelefone;
        private Label labelEmail;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private GroupBox groupBox1;
    }
}