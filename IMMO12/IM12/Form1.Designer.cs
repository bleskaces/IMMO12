
namespace IM12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.NumericUpDown();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sunny = new System.Windows.Forms.TextBox();
            this.Rainy = new System.Windows.Forms.TextBox();
            this.Windy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N";
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(284, 244);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(67, 20);
            this.T.TabIndex = 2;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(284, 270);
            this.N.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(67, 20);
            this.N.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Snow;
            this.Start.Location = new System.Drawing.Point(357, 217);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(179, 84);
            this.Start.TabIndex = 4;
            this.Start.Text = "Начать прогноз";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(22, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Солнечно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дождливо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ветренно";
            // 
            // Sunny
            // 
            this.Sunny.Location = new System.Drawing.Point(108, 202);
            this.Sunny.Name = "Sunny";
            this.Sunny.Size = new System.Drawing.Size(80, 20);
            this.Sunny.TabIndex = 8;
            // 
            // Rainy
            // 
            this.Rainy.Location = new System.Drawing.Point(108, 274);
            this.Rainy.Name = "Rainy";
            this.Rainy.Size = new System.Drawing.Size(80, 20);
            this.Rainy.TabIndex = 9;
            // 
            // Windy
            // 
            this.Windy.Location = new System.Drawing.Point(108, 237);
            this.Windy.Name = "Windy";
            this.Windy.Size = new System.Drawing.Size(80, 20);
            this.Windy.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(548, 313);
            this.Controls.Add(this.Windy);
            this.Controls.Add(this.Rainy);
            this.Controls.Add(this.Sunny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.N);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown T;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sunny;
        private System.Windows.Forms.TextBox Rainy;
        private System.Windows.Forms.TextBox Windy;
    }
}

