namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TabelaClientesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // gridClientes
            // 
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Dock = DockStyle.Fill;
            gridClientes.Location = new Point(0, 0);
            gridClientes.Name = "gridClientes";
            gridClientes.RowHeadersWidth = 51;
            gridClientes.RowTemplate.Height = 29;
            gridClientes.Size = new Size(150, 150);
            gridClientes.TabIndex = 0;
            // 
            // TabelaClientesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridClientes);
            Name = "TabelaClientesControl";
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridClientes;
    }
}
