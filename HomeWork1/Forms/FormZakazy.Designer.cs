
namespace HomeWork1.Forms
{
    partial class FormZakazy
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
            this.labelZagolovok = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelKolich = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.textBoxKol = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxIma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelZagolovok
            // 
            this.labelZagolovok.AutoSize = true;
            this.labelZagolovok.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelZagolovok.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZagolovok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.labelZagolovok.Location = new System.Drawing.Point(38, 9);
            this.labelZagolovok.Name = "labelZagolovok";
            this.labelZagolovok.Size = new System.Drawing.Size(256, 30);
            this.labelZagolovok.TabIndex = 0;
            this.labelZagolovok.Text = "Оформление заказа";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelName.Location = new System.Drawing.Point(12, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Наименование ";
            // 
            // labelKolich
            // 
            this.labelKolich.AutoSize = true;
            this.labelKolich.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelKolich.Location = new System.Drawing.Point(12, 121);
            this.labelKolich.Name = "labelKolich";
            this.labelKolich.Size = new System.Drawing.Size(90, 20);
            this.labelKolich.TabIndex = 2;
            this.labelKolich.Text = "Количество";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelPrice.Location = new System.Drawing.Point(12, 172);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 20);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Цена";
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.buttonZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZakaz.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakaz.ForeColor = System.Drawing.Color.White;
            this.buttonZakaz.Location = new System.Drawing.Point(120, 230);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Size = new System.Drawing.Size(90, 34);
            this.buttonZakaz.TabIndex = 4;
            this.buttonZakaz.Text = "Заказать";
            this.buttonZakaz.UseVisualStyleBackColor = false;
            // 
            // textBoxKol
            // 
            this.textBoxKol.Location = new System.Drawing.Point(138, 123);
            this.textBoxKol.Multiline = true;
            this.textBoxKol.Name = "textBoxKol";
            this.textBoxKol.Size = new System.Drawing.Size(100, 21);
            this.textBoxKol.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(138, 174);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 6;
            // 
            // comboBoxIma
            // 
            this.comboBoxIma.FormattingEnabled = true;
            this.comboBoxIma.Location = new System.Drawing.Point(138, 70);
            this.comboBoxIma.Name = "comboBoxIma";
            this.comboBoxIma.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIma.TabIndex = 7;
            // 
            // FormZakazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 320);
            this.Controls.Add(this.comboBoxIma);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxKol);
            this.Controls.Add(this.buttonZakaz);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelKolich);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelZagolovok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormZakazy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZagolovok;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelKolich;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.TextBox textBoxKol;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxIma;
    }
}