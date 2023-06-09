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
            groupBox1 = new GroupBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelCpf = new Label();
            labelNome = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário Cliente";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(109, 114);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(375, 27);
            txtCpf.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(104, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(378, 30);
            txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 9;
            label1.Text = "Número:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(106, 149);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(376, 30);
            txtTelefone.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(106, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(378, 30);
            txtNome.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(108, 38);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(23, 186);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 23);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(23, 149);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(77, 23);
            labelTelefone.TabIndex = 12;
            labelTelefone.Text = "Telefone:";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(23, 112);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(40, 23);
            labelCpf.TabIndex = 11;
            labelCpf.Text = "Cpf:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = SystemColors.ButtonFace;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(23, 75);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(61, 23);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.BackgroundImageLayout = ImageLayout.Center;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(287, 283);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 43);
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
            btnCancelar.Location = new Point(401, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 43);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 354);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Name = "TelaClienteForm";
            Text = "TelaClienteForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtId;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelCpf;
        private Label labelNome;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtTelefone;
        private TextBox txtCpf;
    }
}