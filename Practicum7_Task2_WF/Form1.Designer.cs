namespace Practicum7_Task2_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.buttonGetRes = new System.Windows.Forms.Button();
            this.textBoxResArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите  исходную строку:";
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(12, 29);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(482, 20);
            this.textBoxString.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите  символ, на который должно оканчиваться слово:";
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(12, 82);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(482, 20);
            this.textBoxChar.TabIndex = 3;
            // 
            // buttonGetRes
            // 
            this.buttonGetRes.Location = new System.Drawing.Point(12, 120);
            this.buttonGetRes.Name = "buttonGetRes";
            this.buttonGetRes.Size = new System.Drawing.Size(482, 35);
            this.buttonGetRes.TabIndex = 4;
            this.buttonGetRes.Text = "Удалить подходящие слова";
            this.buttonGetRes.UseVisualStyleBackColor = true;
            this.buttonGetRes.Click += new System.EventHandler(this.buttonGetRes_Click);
            // 
            // textBoxResArea
            // 
            this.textBoxResArea.Location = new System.Drawing.Point(12, 172);
            this.textBoxResArea.Name = "textBoxResArea";
            this.textBoxResArea.Size = new System.Drawing.Size(482, 20);
            this.textBoxResArea.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 208);
            this.Controls.Add(this.textBoxResArea);
            this.Controls.Add(this.buttonGetRes);
            this.Controls.Add(this.textBoxChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Практикум 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Button buttonGetRes;
        private System.Windows.Forms.TextBox textBoxResArea;
    }
}

