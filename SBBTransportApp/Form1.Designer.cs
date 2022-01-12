namespace SBBTransportApp
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
            this.cmb_Start = new System.Windows.Forms.ComboBox();
            this.cmb_End = new System.Windows.Forms.ComboBox();
            this.dgv_Verbindungen = new System.Windows.Forms.DataGridView();
            this.gleis_kante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Von = new System.Windows.Forms.Label();
            this.lbl_Nach = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Start
            // 
            this.cmb_Start.FormattingEnabled = true;
            this.cmb_Start.Location = new System.Drawing.Point(30, 98);
            this.cmb_Start.Name = "cmb_Start";
            this.cmb_Start.Size = new System.Drawing.Size(220, 28);
            this.cmb_Start.TabIndex = 0;
            this.cmb_Start.DropDown += new System.EventHandler(this.cmb_Start_DropDown);
            // 
            // cmb_End
            // 
            this.cmb_End.FormattingEnabled = true;
            this.cmb_End.Location = new System.Drawing.Point(281, 98);
            this.cmb_End.Name = "cmb_End";
            this.cmb_End.Size = new System.Drawing.Size(220, 28);
            this.cmb_End.TabIndex = 1;
            this.cmb_End.DropDown += new System.EventHandler(this.cmb_End_DropDown);
            // 
            // dgv_Verbindungen
            // 
            this.dgv_Verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Verbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gleis_kante,
            this.wann,
            this.bis,
            this.dauer});
            this.dgv_Verbindungen.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_Verbindungen.Location = new System.Drawing.Point(31, 179);
            this.dgv_Verbindungen.Name = "dgv_Verbindungen";
            this.dgv_Verbindungen.RowHeadersWidth = 51;
            this.dgv_Verbindungen.RowTemplate.Height = 29;
            this.dgv_Verbindungen.Size = new System.Drawing.Size(636, 188);
            this.dgv_Verbindungen.TabIndex = 9;
            // 
            // gleis_kante
            // 
            this.gleis_kante.HeaderText = "Gleis / Kante";
            this.gleis_kante.MinimumWidth = 6;
            this.gleis_kante.Name = "gleis_kante";
            this.gleis_kante.Width = 125;
            // 
            // wann
            // 
            this.wann.HeaderText = "Wann";
            this.wann.MinimumWidth = 6;
            this.wann.Name = "wann";
            this.wann.Width = 165;
            // 
            // bis
            // 
            this.bis.HeaderText = "Bis";
            this.bis.MinimumWidth = 6;
            this.bis.Name = "bis";
            this.bis.Width = 165;
            // 
            // dauer
            // 
            this.dauer.HeaderText = "Dauer";
            this.dauer.MinimumWidth = 6;
            this.dauer.Name = "dauer";
            this.dauer.Width = 125;
            // 
            // lbl_Von
            // 
            this.lbl_Von.AutoSize = true;
            this.lbl_Von.Location = new System.Drawing.Point(30, 75);
            this.lbl_Von.Name = "lbl_Von";
            this.lbl_Von.Size = new System.Drawing.Size(34, 20);
            this.lbl_Von.TabIndex = 3;
            this.lbl_Von.Text = "Von";
            // 
            // lbl_Nach
            // 
            this.lbl_Nach.AutoSize = true;
            this.lbl_Nach.Location = new System.Drawing.Point(281, 75);
            this.lbl_Nach.Name = "lbl_Nach";
            this.lbl_Nach.Size = new System.Drawing.Size(43, 20);
            this.lbl_Nach.TabIndex = 4;
            this.lbl_Nach.Text = "Nach";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(31, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(389, 46);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "SBB Transport App Lite";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(520, 87);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 49);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Nach Verbindungen Suchen";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Nach);
            this.Controls.Add(this.lbl_Von);
            this.Controls.Add(this.dgv_Verbindungen);
            this.Controls.Add(this.cmb_End);
            this.Controls.Add(this.cmb_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Verbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_Start;
        private ComboBox cmb_End;
        private DataGridView dgv_Verbindungen;
        private Label lbl_Von;
        private Label lbl_Nach;
        private Label lbl_Title;
        private Button btn_Search;
        private DataGridViewTextBoxColumn gleis_kante;
        private DataGridViewTextBoxColumn wann;
        private DataGridViewTextBoxColumn bis;
        private DataGridViewTextBoxColumn dauer;
    }
}