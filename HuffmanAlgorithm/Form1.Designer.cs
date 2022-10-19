namespace HuffmanAlgorithm
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
            this.inputRTB = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputAbsoluteRTB = new System.Windows.Forms.RichTextBox();
            this.outputRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inputRTB
            // 
            this.inputRTB.Location = new System.Drawing.Point(12, 12);
            this.inputRTB.Name = "inputRTB";
            this.inputRTB.Size = new System.Drawing.Size(342, 269);
            this.inputRTB.TabIndex = 1;
            this.inputRTB.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputAbsoluteRTB
            // 
            this.outputAbsoluteRTB.Location = new System.Drawing.Point(468, 12);
            this.outputAbsoluteRTB.Name = "outputAbsoluteRTB";
            this.outputAbsoluteRTB.Size = new System.Drawing.Size(342, 269);
            this.outputAbsoluteRTB.TabIndex = 3;
            this.outputAbsoluteRTB.Text = "";
            // 
            // outputRTB
            // 
            this.outputRTB.Location = new System.Drawing.Point(12, 309);
            this.outputRTB.Name = "outputRTB";
            this.outputRTB.Size = new System.Drawing.Size(798, 269);
            this.outputRTB.TabIndex = 4;
            this.outputRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 630);
            this.Controls.Add(this.outputRTB);
            this.Controls.Add(this.outputAbsoluteRTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputRTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox outputAbsoluteRTB;
        private System.Windows.Forms.RichTextBox outputRTB;
    }
}

