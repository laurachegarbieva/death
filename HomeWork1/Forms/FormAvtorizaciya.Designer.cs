
namespace HomeWork1
{
    partial class FormAvtorizaciya
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrivetstviye = new System.Windows.Forms.Label();
            this.labellogin1 = new System.Windows.Forms.Label();
            this.labeltuptup = new System.Windows.Forms.Label();
            this.buttonAvtor = new System.Windows.Forms.Button();
            this.checkBoxPokazat = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPrivetstviye
            // 
            this.labelPrivetstviye.AutoSize = true;
            this.labelPrivetstviye.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrivetstviye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(95)))));
            this.labelPrivetstviye.Location = new System.Drawing.Point(49, 21);
            this.labelPrivetstviye.Name = "labelPrivetstviye";
            this.labelPrivetstviye.Size = new System.Drawing.Size(180, 30);
            this.labelPrivetstviye.TabIndex = 0;
            this.labelPrivetstviye.Text = "Здравствуйте!";
            // 
            // labellogin1
            // 
            this.labellogin1.AutoSize = true;
            this.labellogin1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellogin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labellogin1.Location = new System.Drawing.Point(31, 77);
            this.labellogin1.Name = "labellogin1";
            this.labellogin1.Size = new System.Drawing.Size(52, 20);
            this.labellogin1.TabIndex = 1;
            this.labellogin1.Text = "Логин";
            // 
            // labeltuptup
            // 
            this.labeltuptup.AutoSize = true;
            this.labeltuptup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltuptup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labeltuptup.Location = new System.Drawing.Point(26, 116);
            this.labeltuptup.Name = "labeltuptup";
            this.labeltuptup.Size = new System.Drawing.Size(62, 20);
            this.labeltuptup.TabIndex = 2;
            this.labeltuptup.Text = "Пароль";
            // 
            // buttonAvtor
            // 
            this.buttonAvtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.buttonAvtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvtor.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvtor.ForeColor = System.Drawing.Color.White;
            this.buttonAvtor.Location = new System.Drawing.Point(73, 190);
            this.buttonAvtor.Name = "buttonAvtor";
            this.buttonAvtor.Size = new System.Drawing.Size(139, 30);
            this.buttonAvtor.TabIndex = 3;
            this.buttonAvtor.Text = "Авторизоваться ";
            this.buttonAvtor.UseVisualStyleBackColor = false;
            this.buttonAvtor.Click += new System.EventHandler(this.buttonAvtor_Click);
            // 
            // checkBoxPokazat
            // 
            this.checkBoxPokazat.AutoSize = true;
            this.checkBoxPokazat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPokazat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkBoxPokazat.Location = new System.Drawing.Point(73, 151);
            this.checkBoxPokazat.Name = "checkBoxPokazat";
            this.checkBoxPokazat.Size = new System.Drawing.Size(147, 24);
            this.checkBoxPokazat.TabIndex = 4;
            this.checkBoxPokazat.Text = "Показать пароль";
            this.checkBoxPokazat.UseVisualStyleBackColor = true;
            this.checkBoxPokazat.CheckedChanged += new System.EventHandler(this.checkBoxPokazat_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(94, 116);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Location = new System.Drawing.Point(94, 79);
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxlogin.TabIndex = 6;
            // 
            // FormAvtorizaciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 276);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxPokazat);
            this.Controls.Add(this.buttonAvtor);
            this.Controls.Add(this.labeltuptup);
            this.Controls.Add(this.labellogin1);
            this.Controls.Add(this.labelPrivetstviye);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAvtorizaciya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrivetstviye;
        private System.Windows.Forms.Label labellogin1;
        private System.Windows.Forms.Label labeltuptup;
        private System.Windows.Forms.Button buttonAvtor;
        private System.Windows.Forms.CheckBox checkBoxPokazat;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxlogin;
    }
}

