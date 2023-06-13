namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TabelaTemaControl
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
            gridTema = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTema).BeginInit();
            SuspendLayout();
            // 
            // gridTema
            // 
            gridTema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTema.Dock = DockStyle.Fill;
            gridTema.Location = new Point(0, 0);
            gridTema.Name = "gridTema";
            gridTema.RowHeadersWidth = 51;
            gridTema.RowTemplate.Height = 29;
            gridTema.Size = new Size(407, 373);
            gridTema.TabIndex = 1;
            // 
            // TabelaTemaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridTema);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TabelaTemaControl";
            Size = new Size(407, 373);
            ((System.ComponentModel.ISupportInitialize)gridTema).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridTema;
    }
}
