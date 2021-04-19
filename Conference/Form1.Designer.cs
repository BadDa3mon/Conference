
namespace Conference
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.r_textBox = new System.Windows.Forms.TextBox();
            this.r_title = new System.Windows.Forms.Label();
            this.n_title = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.inCircle_num = new System.Windows.Forms.Label();
            this.pixel_num = new System.Windows.Forms.Label();
            this.pi_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(51, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отобразить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // n_textBox
            // 
            this.n_textBox.Location = new System.Drawing.Point(131, 33);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(113, 22);
            this.n_textBox.TabIndex = 1;
            // 
            // r_textBox
            // 
            this.r_textBox.Location = new System.Drawing.Point(131, 6);
            this.r_textBox.Name = "r_textBox";
            this.r_textBox.Size = new System.Drawing.Size(113, 22);
            this.r_textBox.TabIndex = 2;
            // 
            // r_title
            // 
            this.r_title.AutoSize = true;
            this.r_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_title.Location = new System.Drawing.Point(32, 6);
            this.r_title.Name = "r_title";
            this.r_title.Size = new System.Drawing.Size(74, 20);
            this.r_title.TabIndex = 3;
            this.r_title.Text = "Радиус:";
            // 
            // n_title
            // 
            this.n_title.AutoSize = true;
            this.n_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_title.Location = new System.Drawing.Point(26, 33);
            this.n_title.Name = "n_title";
            this.n_title.Size = new System.Drawing.Size(80, 20);
            this.n_title.TabIndex = 4;
            this.n_title.Text = "N точек:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Задержка";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // inCircle_num
            // 
            this.inCircle_num.AutoSize = true;
            this.inCircle_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inCircle_num.Location = new System.Drawing.Point(25, 178);
            this.inCircle_num.Name = "inCircle_num";
            this.inCircle_num.Size = new System.Drawing.Size(142, 25);
            this.inCircle_num.TabIndex = 7;
            this.inCircle_num.Text = "Точек внутри:";
            // 
            // pixel_num
            // 
            this.pixel_num.AutoSize = true;
            this.pixel_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pixel_num.Location = new System.Drawing.Point(25, 153);
            this.pixel_num.Name = "pixel_num";
            this.pixel_num.Size = new System.Drawing.Size(90, 25);
            this.pixel_num.TabIndex = 10;
            this.pixel_num.Text = "Точка №";
            // 
            // pi_label
            // 
            this.pi_label.AutoSize = true;
            this.pi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pi_label.Location = new System.Drawing.Point(25, 203);
            this.pi_label.Name = "pi_label";
            this.pi_label.Size = new System.Drawing.Size(46, 25);
            this.pi_label.TabIndex = 11;
            this.pi_label.Text = "Pi =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 143);
            this.Controls.Add(this.pi_label);
            this.Controls.Add(this.pixel_num);
            this.Controls.Add(this.inCircle_num);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.n_title);
            this.Controls.Add(this.r_title);
            this.Controls.Add(this.r_textBox);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Conference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.TextBox r_textBox;
        private System.Windows.Forms.Label r_title;
        private System.Windows.Forms.Label n_title;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label inCircle_num;
        private System.Windows.Forms.Label pixel_num;
        private System.Windows.Forms.Label pi_label;
    }
}

