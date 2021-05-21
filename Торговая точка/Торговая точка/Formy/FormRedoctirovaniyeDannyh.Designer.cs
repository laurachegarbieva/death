namespace Торговая_точка
{
    partial class FormRedactirovaniyeDannyh
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
            this.buttonDobavit = new System.Windows.Forms.Button();
            this.buttonUdalit = new System.Windows.Forms.Button();
            this.dataGridViewBd = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColichestvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDobavit
            // 
            this.buttonDobavit.Location = new System.Drawing.Point(55, 243);
            this.buttonDobavit.Name = "buttonDobavit";
            this.buttonDobavit.Size = new System.Drawing.Size(84, 23);
            this.buttonDobavit.TabIndex = 0;
            this.buttonDobavit.Text = "Добавление";
            this.buttonDobavit.UseVisualStyleBackColor = true;
            this.buttonDobavit.Click += new System.EventHandler(this.buttonDobavit_Click);
            // 
            // buttonUdalit
            // 
            this.buttonUdalit.Location = new System.Drawing.Point(345, 243);
            this.buttonUdalit.Name = "buttonUdalit";
            this.buttonUdalit.Size = new System.Drawing.Size(75, 23);
            this.buttonUdalit.TabIndex = 1;
            this.buttonUdalit.Text = "Удалить";
            this.buttonUdalit.UseVisualStyleBackColor = true;
            this.buttonUdalit.Click += new System.EventHandler(this.buttonUdalit_Click);
            // 
            // dataGridViewBd
            // 
            this.dataGridViewBd.AllowUserToAddRows = false;
            this.dataGridViewBd.AllowUserToDeleteRows = false;
            this.dataGridViewBd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnColichestvo,
            this.ColumnCena});
            this.dataGridViewBd.Location = new System.Drawing.Point(3, 12);
            this.dataGridViewBd.Name = "dataGridViewBd";
            this.dataGridViewBd.ReadOnly = true;
            this.dataGridViewBd.Size = new System.Drawing.Size(461, 225);
            this.dataGridViewBd.TabIndex = 2;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Номер";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnColichestvo
            // 
            this.ColumnColichestvo.HeaderText = "Количество";
            this.ColumnColichestvo.Name = "ColumnColichestvo";
            this.ColumnColichestvo.ReadOnly = true;
            // 
            // ColumnCena
            // 
            this.ColumnCena.HeaderText = "Цена";
            this.ColumnCena.Name = "ColumnCena";
            this.ColumnCena.ReadOnly = true;
            // 
            // FormRedactirovaniyeDannyh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 278);
            this.Controls.Add(this.dataGridViewBd);
            this.Controls.Add(this.buttonUdalit);
            this.Controls.Add(this.buttonDobavit);
            this.Name = "FormRedactirovaniyeDannyh";
            this.Text = "Редактирование дааных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRedactirovaniyeDannyh_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDobavit;
        private System.Windows.Forms.Button buttonUdalit;
        private System.Windows.Forms.DataGridView dataGridViewBd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColichestvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCena;
    }
}