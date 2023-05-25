
namespace OOP678
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbColorViolet = new System.Windows.Forms.RadioButton();
            this.rbColorBlue = new System.Windows.Forms.RadioButton();
            this.rbColorGreen = new System.Windows.Forms.RadioButton();
            this.rbColorYellow = new System.Windows.Forms.RadioButton();
            this.rbColorRed = new System.Windows.Forms.RadioButton();
            this.rbColorBlack = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnReGroup = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnArrow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 752);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(836, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 222);
            this.panel1.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(122, 11);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(18, 20);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "0";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 71);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 24);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Отрезок";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 172);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(129, 24);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Треугольник";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 105);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Круг";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фигура:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 139);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Квадрат";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbColorViolet);
            this.panel2.Controls.Add(this.rbColorBlue);
            this.panel2.Controls.Add(this.rbColorGreen);
            this.panel2.Controls.Add(this.rbColorYellow);
            this.panel2.Controls.Add(this.rbColorRed);
            this.panel2.Controls.Add(this.rbColorBlack);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(836, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 246);
            this.panel2.TabIndex = 2;
            // 
            // rbColorViolet
            // 
            this.rbColorViolet.AutoSize = true;
            this.rbColorViolet.ForeColor = System.Drawing.Color.Violet;
            this.rbColorViolet.Location = new System.Drawing.Point(19, 206);
            this.rbColorViolet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbColorViolet.Name = "rbColorViolet";
            this.rbColorViolet.Size = new System.Drawing.Size(133, 24);
            this.rbColorViolet.TabIndex = 6;
            this.rbColorViolet.TabStop = true;
            this.rbColorViolet.Text = "Фиолетовый";
            this.rbColorViolet.UseVisualStyleBackColor = true;
            this.rbColorViolet.CheckedChanged += new System.EventHandler(this.rbColorViolet_CheckedChanged);
            // 
            // rbColorBlue
            // 
            this.rbColorBlue.AutoSize = true;
            this.rbColorBlue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rbColorBlue.Location = new System.Drawing.Point(19, 171);
            this.rbColorBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbColorBlue.Name = "rbColorBlue";
            this.rbColorBlue.Size = new System.Drawing.Size(81, 24);
            this.rbColorBlue.TabIndex = 5;
            this.rbColorBlue.TabStop = true;
            this.rbColorBlue.Text = "Синий";
            this.rbColorBlue.UseVisualStyleBackColor = true;
            this.rbColorBlue.CheckedChanged += new System.EventHandler(this.rbColorBlue_CheckedChanged);
            // 
            // rbColorGreen
            // 
            this.rbColorGreen.AutoSize = true;
            this.rbColorGreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.rbColorGreen.Location = new System.Drawing.Point(19, 136);
            this.rbColorGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbColorGreen.Name = "rbColorGreen";
            this.rbColorGreen.Size = new System.Drawing.Size(102, 24);
            this.rbColorGreen.TabIndex = 4;
            this.rbColorGreen.TabStop = true;
            this.rbColorGreen.Text = "Зеленый";
            this.rbColorGreen.UseVisualStyleBackColor = true;
            this.rbColorGreen.CheckedChanged += new System.EventHandler(this.rbColorGreen_CheckedChanged);
            // 
            // rbColorYellow
            // 
            this.rbColorYellow.AutoSize = true;
            this.rbColorYellow.ForeColor = System.Drawing.Color.Gold;
            this.rbColorYellow.Location = new System.Drawing.Point(19, 101);
            this.rbColorYellow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbColorYellow.Name = "rbColorYellow";
            this.rbColorYellow.Size = new System.Drawing.Size(95, 24);
            this.rbColorYellow.TabIndex = 3;
            this.rbColorYellow.TabStop = true;
            this.rbColorYellow.Text = "Желтый";
            this.rbColorYellow.UseVisualStyleBackColor = true;
            this.rbColorYellow.CheckedChanged += new System.EventHandler(this.rbColorYellow_CheckedChanged);
            // 
            // rbColorRed
            // 
            this.rbColorRed.AutoSize = true;
            this.rbColorRed.ForeColor = System.Drawing.Color.Red;
            this.rbColorRed.Location = new System.Drawing.Point(19, 66);
            this.rbColorRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbColorRed.Name = "rbColorRed";
            this.rbColorRed.Size = new System.Drawing.Size(99, 24);
            this.rbColorRed.TabIndex = 2;
            this.rbColorRed.TabStop = true;
            this.rbColorRed.Text = "Красный";
            this.rbColorRed.UseVisualStyleBackColor = true;
            this.rbColorRed.CheckedChanged += new System.EventHandler(this.rbColorRed_CheckedChanged);
            // 
            // rbColorBlack
            // 
            this.rbColorBlack.AutoSize = true;
            this.rbColorBlack.Location = new System.Drawing.Point(19, 31);
            this.rbColorBlack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbColorBlack.Name = "rbColorBlack";
            this.rbColorBlack.Size = new System.Drawing.Size(93, 24);
            this.rbColorBlack.TabIndex = 1;
            this.rbColorBlack.TabStop = true;
            this.rbColorBlack.Text = "Черный";
            this.rbColorBlack.UseVisualStyleBackColor = true;
            this.rbColorBlack.CheckedChanged += new System.EventHandler(this.rbColorBlack_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Цвет:";
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(855, 587);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(171, 44);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.Text = "Группировка";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnReGroup
            // 
            this.btnReGroup.Location = new System.Drawing.Point(1059, 587);
            this.btnReGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReGroup.Name = "btnReGroup";
            this.btnReGroup.Size = new System.Drawing.Size(171, 44);
            this.btnReGroup.TabIndex = 4;
            this.btnReGroup.Text = "Разгруппировка";
            this.btnReGroup.UseVisualStyleBackColor = true;
            this.btnReGroup.Click += new System.EventHandler(this.btnReGroup_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(857, 639);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1059, 639);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(171, 44);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnArrow
            // 
            this.btnArrow.Location = new System.Drawing.Point(855, 484);
            this.btnArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(171, 44);
            this.btnArrow.TabIndex = 7;
            this.btnArrow.Text = "Стрелка";
            this.btnArrow.UseVisualStyleBackColor = true;
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(856, 535);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 44);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1437, 824);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnArrow);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReGroup);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbColorBlack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbColorViolet;
        private System.Windows.Forms.RadioButton rbColorBlue;
        private System.Windows.Forms.RadioButton rbColorGreen;
        private System.Windows.Forms.RadioButton rbColorYellow;
        private System.Windows.Forms.RadioButton rbColorRed;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnReGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnArrow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lb1;
    }
}

