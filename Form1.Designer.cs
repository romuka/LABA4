namespace LABA_4OTIRE
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
            this.MessageBox = new System.Windows.Forms.GroupBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RAMbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HDDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GpuBox = new System.Windows.Forms.TextBox();
            this.Frequency = new System.Windows.Forms.Label();
            this.FreqBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.MessageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Controls.Add(this.ResultBox);
            this.MessageBox.Controls.Add(this.label6);
            this.MessageBox.Controls.Add(this.PriceBox);
            this.MessageBox.Controls.Add(this.label5);
            this.MessageBox.Controls.Add(this.RAMbox);
            this.MessageBox.Controls.Add(this.label4);
            this.MessageBox.Controls.Add(this.HDDBox);
            this.MessageBox.Controls.Add(this.label3);
            this.MessageBox.Controls.Add(this.GpuBox);
            this.MessageBox.Controls.Add(this.Frequency);
            this.MessageBox.Controls.Add(this.FreqBox);
            this.MessageBox.Controls.Add(this.ModelBox);
            this.MessageBox.Controls.Add(this.Model);
            this.MessageBox.Controls.Add(this.button1);
            this.MessageBox.Location = new System.Drawing.Point(12, 34);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(712, 335);
            this.MessageBox.TabIndex = 1;
            this.MessageBox.TabStop = false;
            this.MessageBox.Text = "Информейшн";
            this.MessageBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(234, 37);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(445, 252);
            this.ResultBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(80, 269);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RAM capacity";
            // 
            // RAMbox
            // 
            this.RAMbox.Location = new System.Drawing.Point(80, 220);
            this.RAMbox.Name = "RAMbox";
            this.RAMbox.Size = new System.Drawing.Size(100, 20);
            this.RAMbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HDD capacity";
            // 
            // HDDBox
            // 
            this.HDDBox.Location = new System.Drawing.Point(80, 178);
            this.HDDBox.Name = "HDDBox";
            this.HDDBox.Size = new System.Drawing.Size(100, 20);
            this.HDDBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "GPU Brand";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GpuBox
            // 
            this.GpuBox.Location = new System.Drawing.Point(80, 131);
            this.GpuBox.Name = "GpuBox";
            this.GpuBox.Size = new System.Drawing.Size(100, 20);
            this.GpuBox.TabIndex = 5;
            // 
            // Frequency
            // 
            this.Frequency.AutoSize = true;
            this.Frequency.Location = new System.Drawing.Point(6, 89);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(57, 13);
            this.Frequency.TabIndex = 4;
            this.Frequency.Text = "Frequency";
            // 
            // FreqBox
            // 
            this.FreqBox.Location = new System.Drawing.Point(80, 86);
            this.FreqBox.Name = "FreqBox";
            this.FreqBox.Size = new System.Drawing.Size(100, 20);
            this.FreqBox.TabIndex = 3;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(80, 37);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(100, 20);
            this.ModelBox.TabIndex = 2;
            this.ModelBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(6, 37);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MessageBox.ResumeLayout(false);
            this.MessageBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox MessageBox;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GpuBox;
        private System.Windows.Forms.Label Frequency;
        private System.Windows.Forms.TextBox FreqBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HDDBox;
        private System.Windows.Forms.TextBox RAMbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

