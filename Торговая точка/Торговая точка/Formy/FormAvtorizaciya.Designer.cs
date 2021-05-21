namespace Торговая_точка
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelParol = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxParol = new System.Windows.Forms.TextBox();
            this.buttonAvtor = new System.Windows.Forms.Button();
            this.checkBoxProsmotr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelPrivetstviye
            // 
            this.labelPrivetstviye.AutoSize = true;
            this.labelPrivetstviye.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrivetstviye.Location = new System.Drawing.Point(36, 9);
            this.labelPrivetstviye.Name = "labelPrivetstviye";
            this.labelPrivetstviye.Size = new System.Drawing.Size(189, 20);
            this.labelPrivetstviye.TabIndex = 0;
            this.labelPrivetstviye.Text = "Добро пожаловать!";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(27, 53);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 16);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // labelParol
            // 
            this.labelParol.AutoSize = true;
            this.labelParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParol.Location = new System.Drawing.Point(27, 89);
            this.labelParol.Name = "labelParol";
            this.labelParol.Size = new System.Drawing.Size(57, 16);
            this.labelParol.TabIndex = 2;
            this.labelParol.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(100, 50);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxParol
            // 
            this.textBoxParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParol.Location = new System.Drawing.Point(100, 85);
            this.textBoxParol.Name = "textBoxParol";
            this.textBoxParol.Size = new System.Drawing.Size(100, 22);
            this.textBoxParol.TabIndex = 4;
            this.textBoxParol.UseSystemPasswordChar = true;
            // 
            // buttonAvtor
            // 
            this.buttonAvtor.BackColor = System.Drawing.Color.Red;
            this.buttonAvtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAvtor.Location = new System.Drawing.Point(57, 159);
            this.buttonAvtor.Name = "buttonAvtor";
            this.buttonAvtor.Size = new System.Drawing.Size(132, 27);
            this.buttonAvtor.TabIndex = 5;
            this.buttonAvtor.Text = "Авторизоваться";
            this.buttonAvtor.UseVisualStyleBackColor = false;
            this.buttonAvtor.Click += new System.EventHandler(this.buttonAvtor_Click);
            // 
            // checkBoxProsmotr
            // 
            this.checkBoxProsmotr.AutoSize = true;
            this.checkBoxProsmotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxProsmotr.Location = new System.Drawing.Point(60, 122);
            this.checkBoxProsmotr.Name = "checkBoxProsmotr";
            this.checkBoxProsmotr.Size = new System.Drawing.Size(140, 20);
            this.checkBoxProsmotr.TabIndex = 6;
            this.checkBoxProsmotr.Text = "Показать пароль";
            this.checkBoxProsmotr.UseVisualStyleBackColor = true;
            this.checkBoxProsmotr.CheckedChanged += new System.EventHandler(this.checkBoxProsmotr_CheckedChanged);
            // 
            // FormAvtorizaciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(258, 208);
            this.Controls.Add(this.checkBoxProsmotr);
            this.Controls.Add(this.buttonAvtor);
            this.Controls.Add(this.textBoxParol);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelParol);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPrivetstviye);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAvtorizaciya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAvtorizaciya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrivetstviye;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelParol;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxParol;
        private System.Windows.Forms.Button buttonAvtor;
        private System.Windows.Forms.CheckBox checkBoxProsmotr;
    }
}

