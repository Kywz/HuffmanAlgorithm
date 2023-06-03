namespace HuffmanAlgorithm
{
    partial class Form_DebugInfo
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
            this.richTextBox_DebugInfo = new System.Windows.Forms.RichTextBox();
            this.richTextBox_TimeInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_DebugInfo
            // 
            this.richTextBox_DebugInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_DebugInfo.Location = new System.Drawing.Point(13, 32);
            this.richTextBox_DebugInfo.Name = "richTextBox_DebugInfo";
            this.richTextBox_DebugInfo.Size = new System.Drawing.Size(542, 376);
            this.richTextBox_DebugInfo.TabIndex = 0;
            this.richTextBox_DebugInfo.Text = "";
            // 
            // richTextBox_TimeInfo
            // 
            this.richTextBox_TimeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_TimeInfo.Location = new System.Drawing.Point(12, 433);
            this.richTextBox_TimeInfo.Name = "richTextBox_TimeInfo";
            this.richTextBox_TimeInfo.Size = new System.Drawing.Size(543, 112);
            this.richTextBox_TimeInfo.TabIndex = 1;
            this.richTextBox_TimeInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Huffman Tree Info";
            // 
            // Form_DebugInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_TimeInfo);
            this.Controls.Add(this.richTextBox_DebugInfo);
            this.Name = "Form_DebugInfo";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_DebugInfo;
        private System.Windows.Forms.RichTextBox richTextBox_TimeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}