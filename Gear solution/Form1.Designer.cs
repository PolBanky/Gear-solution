namespace Gear_solution
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDbl1 = new Gear_solution.TxtBoxDbl();
            this.aLabel3 = new Gear_solution.aLabel();
            this.aLabel2 = new Gear_solution.aLabel();
            this.aLabel1 = new Gear_solution.aLabel();
            this.txtBoxInt1 = new Gear_solution.TxtBoxInt();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число зубьев\r\nшестерни, z";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(71, 69);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Модуль, m\r\nГОСТ 9563-60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Диаметр делительной\r\nокружности d, мм\r\nd=m*z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Диаметр окружности\r\nвершин зубъев da, мм\r\nda = d + (2 * m) + (2 * x * m)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Диаметр окружности\r\nвпадин зубъев df, мм\r\ndf = d - (2.5 * m) + (2 * x * m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Коэффициэнт смещения\r\nисходного контура, x\r\n(минус - к оси шестерни)";
            // 
            // txtBoxDbl1
            // 
            this.txtBoxDbl1.Location = new System.Drawing.Point(12, 223);
            this.txtBoxDbl1.MaxLength = 6;
            this.txtBoxDbl1.Name = "txtBoxDbl1";
            this.txtBoxDbl1.Size = new System.Drawing.Size(71, 20);
            this.txtBoxDbl1.TabIndex = 3;
            this.txtBoxDbl1.TextChanged += new System.EventHandler(this.txtBoxDbl1_TextChanged);
            // 
            // aLabel3
            // 
            this.aLabel3.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel3.Location = new System.Drawing.Point(187, 200);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(140, 20);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.Text = "aLabel3";
            this.aLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLabel2
            // 
            this.aLabel2.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel2.Location = new System.Drawing.Point(187, 127);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(140, 20);
            this.aLabel2.TabIndex = 8;
            this.aLabel2.Text = "aLabel2";
            this.aLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLabel1
            // 
            this.aLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel1.Location = new System.Drawing.Point(184, 48);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(140, 20);
            this.aLabel1.TabIndex = 6;
            this.aLabel1.Text = "aLabel1";
            this.aLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxInt1
            // 
            this.txtBoxInt1.Location = new System.Drawing.Point(12, 38);
            this.txtBoxInt1.MaxLength = 3;
            this.txtBoxInt1.Name = "txtBoxInt1";
            this.txtBoxInt1.Size = new System.Drawing.Size(71, 20);
            this.txtBoxInt1.TabIndex = 0;
            this.txtBoxInt1.TextChanged += new System.EventHandler(this.txtBoxInt1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 339);
            this.Controls.Add(this.txtBoxDbl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aLabel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxInt1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gear Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TxtBoxInt txtBoxInt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private aLabel aLabel1;
        private System.Windows.Forms.Label label4;
        private aLabel aLabel2;
        private System.Windows.Forms.Label label5;
        private aLabel aLabel3;
        private System.Windows.Forms.Label label6;
        private TxtBoxDbl txtBoxDbl1;
    }
}

