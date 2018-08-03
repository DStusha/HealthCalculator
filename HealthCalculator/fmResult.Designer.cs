namespace HealthCalculator
{
    partial class fmResult
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.KritName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(402, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ОК";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KritName,
            this.Res,
            this.Mark,
            this.Level});
            this.dgv.Location = new System.Drawing.Point(23, 12);
            this.dgv.MaximumSize = new System.Drawing.Size(460, 155);
            this.dgv.MinimumSize = new System.Drawing.Size(460, 155);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(460, 155);
            this.dgv.TabIndex = 6;
            // 
            // KritName
            // 
            this.KritName.DataPropertyName = "Name";
            this.KritName.Frozen = true;
            this.KritName.HeaderText = "Критерий";
            this.KritName.Name = "KritName";
            this.KritName.ReadOnly = true;
            this.KritName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KritName.Width = 170;
            // 
            // Res
            // 
            this.Res.DataPropertyName = "Res";
            this.Res.Frozen = true;
            this.Res.HeaderText = "Результат";
            this.Res.Name = "Res";
            this.Res.ReadOnly = true;
            this.Res.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Mark
            // 
            this.Mark.DataPropertyName = "Mark";
            this.Mark.Frozen = true;
            this.Mark.HeaderText = "Баллы";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mark.Width = 70;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.Frozen = true;
            this.Level.HeaderText = "Уровень";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Level.Width = 120;
            // 
            // fmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 237);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnExit);
            this.MaximumSize = new System.Drawing.Size(525, 276);
            this.MinimumSize = new System.Drawing.Size(525, 276);
            this.Name = "fmResult";
            this.Text = "Результат";
            this.Load += new System.EventHandler(this.fmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KritName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Res;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}