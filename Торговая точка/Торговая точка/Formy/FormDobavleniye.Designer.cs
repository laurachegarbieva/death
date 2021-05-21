namespace Торговая_точка.Formy
{
    partial class FormDobavleniye
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
            this.buttonSohranit = new System.Windows.Forms.Button();
            this.labelNomer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelColichestvo = new System.Windows.Forms.Label();
            this.textBoxNomer = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxColichestvo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSohranit
            // 
            this.buttonSohranit.Location = new System.Drawing.Point(61, 159);
            this.buttonSohranit.Name = "buttonSohranit";
            this.buttonSohranit.Size = new System.Drawing.Size(75, 23);
            this.buttonSohranit.TabIndex = 0;
            this.buttonSohranit.Text = "Сохранить";
            this.buttonSohranit.UseVisualStyleBackColor = true;
            this.buttonSohranit.Click += new System.EventHandler(this.buttonSohranit_Click);
            // 
            // labelNomer
            // 
            this.labelNomer.AutoSize = true;
            this.labelNomer.Location = new System.Drawing.Point(0, 13);
            this.labelNomer.Name = "labelNomer";
            this.labelNomer.Size = new System.Drawing.Size(41, 13);
            this.labelNomer.TabIndex = 1;
            this.labelNomer.Text = "Номер";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(0, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Наименование";
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(0, 86);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(33, 13);
            this.labelCena.TabIndex = 3;
            this.labelCena.Text = "Цена";
            // 
            // labelColichestvo
            // 
            this.labelColichestvo.AutoSize = true;
            this.labelColichestvo.Location = new System.Drawing.Point(0, 123);
            this.labelColichestvo.Name = "labelColichestvo";
            this.labelColichestvo.Size = new System.Drawing.Size(66, 13);
            this.labelColichestvo.TabIndex = 4;
            this.labelColichestvo.Text = "Количество";
            // 
            // textBoxNomer
            // 
            this.textBoxNomer.Location = new System.Drawing.Point(89, 6);
            this.textBoxNomer.Name = "textBoxNomer";
            this.textBoxNomer.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomer.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(89, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(89, 79);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCena.TabIndex = 7;
            // 
            // textBoxColichestvo
            // 
            this.textBoxColichestvo.Location = new System.Drawing.Point(89, 116);
            this.textBoxColichestvo.Name = "textBoxColichestvo";
            this.textBoxColichestvo.Size = new System.Drawing.Size(100, 20);
            this.textBoxColichestvo.TabIndex = 8;
            // 
            // FormDobavleniye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 198);
            this.Controls.Add(this.textBoxColichestvo);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNomer);
            this.Controls.Add(this.labelColichestvo);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNomer);
            this.Controls.Add(this.buttonSohranit);
            this.Name = "FormDobavleniye";
            this.Text = "Добавление данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSohranit;
        private System.Windows.Forms.Label labelNomer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Label labelColichestvo;
        private System.Windows.Forms.TextBox textBoxNomer;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxColichestvo;
    }
}