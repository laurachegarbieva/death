
namespace HomeWork1.Forms
{
    partial class FormMeneger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeneger));
            this.pictureBoxWoomen = new System.Windows.Forms.PictureBox();
            this.labelName1 = new System.Windows.Forms.Label();
            this.comboBoxProsmotr = new System.Windows.Forms.ComboBox();
            this.buttonOform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonfiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoomen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWoomen
            // 
            this.pictureBoxWoomen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWoomen.Image")));
            this.pictureBoxWoomen.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxWoomen.Name = "pictureBoxWoomen";
            this.pictureBoxWoomen.Size = new System.Drawing.Size(160, 147);
            this.pictureBoxWoomen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWoomen.TabIndex = 0;
            this.pictureBoxWoomen.TabStop = false;
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelName1.Location = new System.Drawing.Point(12, 162);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(50, 20);
            this.labelName1.TabIndex = 1;
            this.labelName1.Text = "label1";
            // 
            // comboBoxProsmotr
            // 
            this.comboBoxProsmotr.FormattingEnabled = true;
            this.comboBoxProsmotr.Location = new System.Drawing.Point(216, 42);
            this.comboBoxProsmotr.Name = "comboBoxProsmotr";
            this.comboBoxProsmotr.Size = new System.Drawing.Size(233, 21);
            this.comboBoxProsmotr.TabIndex = 2;
            // 
            // buttonOform
            // 
            this.buttonOform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.buttonOform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOform.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOform.ForeColor = System.Drawing.Color.White;
            this.buttonOform.Location = new System.Drawing.Point(12, 217);
            this.buttonOform.Name = "buttonOform";
            this.buttonOform.Size = new System.Drawing.Size(160, 33);
            this.buttonOform.TabIndex = 3;
            this.buttonOform.Text = "Оформление заказа";
            this.buttonOform.UseVisualStyleBackColor = false;
            this.buttonOform.Click += new System.EventHandler(this.buttonOform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список заказов";
            // 
            // buttonfiltr
            // 
            this.buttonfiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.buttonfiltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfiltr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonfiltr.ForeColor = System.Drawing.Color.White;
            this.buttonfiltr.Location = new System.Drawing.Point(281, 217);
            this.buttonfiltr.Name = "buttonfiltr";
            this.buttonfiltr.Size = new System.Drawing.Size(142, 33);
            this.buttonfiltr.TabIndex = 5;
            this.buttonfiltr.Text = "Отфильтровать ";
            this.buttonfiltr.UseVisualStyleBackColor = false;
            // 
            // FormMeneger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 262);
            this.Controls.Add(this.buttonfiltr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOform);
            this.Controls.Add(this.comboBoxProsmotr);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.pictureBoxWoomen);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMeneger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoomen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWoomen;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.ComboBox comboBoxProsmotr;
        private System.Windows.Forms.Button buttonOform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonfiltr;
    }
}