namespace HuffmanAlgorithm
{
    partial class form_Main
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
            this.button_Encode = new System.Windows.Forms.Button();
            this.outputRTB = new System.Windows.Forms.RichTextBox();
            this.outputRTS = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.outputKey = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_LoadKey = new System.Windows.Forms.Button();
            this.button_SaveKey = new System.Windows.Forms.Button();
            this.button_CreateKey = new System.Windows.Forms.Button();
            this.button_Decode = new System.Windows.Forms.Button();
            this.checkBox_WriteTreeInfo = new System.Windows.Forms.CheckBox();
            this.comboBox_SaveSelection = new System.Windows.Forms.ComboBox();
            this.openFileDialog_loadFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // inputRTB
            // 
            this.inputRTB.Location = new System.Drawing.Point(12, 22);
            this.inputRTB.Name = "inputRTB";
            this.inputRTB.Size = new System.Drawing.Size(385, 232);
            this.inputRTB.TabIndex = 1;
            this.inputRTB.Text = "";
            // 
            // button_Encode
            // 
            this.button_Encode.Location = new System.Drawing.Point(168, 260);
            this.button_Encode.Name = "button_Encode";
            this.button_Encode.Size = new System.Drawing.Size(75, 23);
            this.button_Encode.TabIndex = 2;
            this.button_Encode.Text = "Encode";
            this.button_Encode.UseVisualStyleBackColor = true;
            this.button_Encode.Click += new System.EventHandler(this.button_EncodeText_Click);
            // 
            // outputRTB
            // 
            this.outputRTB.Location = new System.Drawing.Point(15, 289);
            this.outputRTB.Name = "outputRTB";
            this.outputRTB.Size = new System.Drawing.Size(382, 237);
            this.outputRTB.TabIndex = 4;
            this.outputRTB.Text = "";
            // 
            // outputRTS
            // 
            this.outputRTS.Location = new System.Drawing.Point(515, 289);
            this.outputRTS.Name = "outputRTS";
            this.outputRTS.Size = new System.Drawing.Size(344, 237);
            this.outputRTS.TabIndex = 5;
            this.outputRTS.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Encoded Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Original Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(512, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Decoded Text";
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.Location = new System.Drawing.Point(412, 260);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(75, 23);
            this.button_ClearAll.TabIndex = 11;
            this.button_ClearAll.Text = "Clear All";
            this.button_ClearAll.UseVisualStyleBackColor = true;
            this.button_ClearAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // outputKey
            // 
            this.outputKey.BackColor = System.Drawing.Color.White;
            this.outputKey.Location = new System.Drawing.Point(515, 22);
            this.outputKey.Name = "outputKey";
            this.outputKey.Size = new System.Drawing.Size(344, 153);
            this.outputKey.TabIndex = 14;
            this.outputKey.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(512, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Key";
            // 
            // button_LoadKey
            // 
            this.button_LoadKey.Location = new System.Drawing.Point(515, 181);
            this.button_LoadKey.Name = "button_LoadKey";
            this.button_LoadKey.Size = new System.Drawing.Size(75, 23);
            this.button_LoadKey.TabIndex = 16;
            this.button_LoadKey.Text = "Load File";
            this.button_LoadKey.UseVisualStyleBackColor = true;
            this.button_LoadKey.Click += new System.EventHandler(this.button_LoadKey_Click);
            // 
            // button_SaveKey
            // 
            this.button_SaveKey.Location = new System.Drawing.Point(515, 210);
            this.button_SaveKey.Name = "button_SaveKey";
            this.button_SaveKey.Size = new System.Drawing.Size(75, 23);
            this.button_SaveKey.TabIndex = 17;
            this.button_SaveKey.Text = "Save File";
            this.button_SaveKey.UseVisualStyleBackColor = true;
            this.button_SaveKey.Click += new System.EventHandler(this.button_SaveKey_Click);
            // 
            // button_CreateKey
            // 
            this.button_CreateKey.Location = new System.Drawing.Point(415, 126);
            this.button_CreateKey.Name = "button_CreateKey";
            this.button_CreateKey.Size = new System.Drawing.Size(75, 23);
            this.button_CreateKey.TabIndex = 21;
            this.button_CreateKey.Text = "Create Key";
            this.button_CreateKey.UseVisualStyleBackColor = true;
            this.button_CreateKey.Click += new System.EventHandler(this.button_CreateKey_Click);
            // 
            // button_Decode
            // 
            this.button_Decode.Location = new System.Drawing.Point(415, 387);
            this.button_Decode.Name = "button_Decode";
            this.button_Decode.Size = new System.Drawing.Size(75, 23);
            this.button_Decode.TabIndex = 22;
            this.button_Decode.Text = "Decode";
            this.button_Decode.UseVisualStyleBackColor = true;
            this.button_Decode.Click += new System.EventHandler(this.button_Decode_Click);
            // 
            // checkBox_WriteTreeInfo
            // 
            this.checkBox_WriteTreeInfo.AutoSize = true;
            this.checkBox_WriteTreeInfo.Location = new System.Drawing.Point(403, 161);
            this.checkBox_WriteTreeInfo.Name = "checkBox_WriteTreeInfo";
            this.checkBox_WriteTreeInfo.Size = new System.Drawing.Size(103, 17);
            this.checkBox_WriteTreeInfo.TabIndex = 23;
            this.checkBox_WriteTreeInfo.Text = "Write Tree Info?";
            this.checkBox_WriteTreeInfo.UseVisualStyleBackColor = true;
            // 
            // comboBox_SaveSelection
            // 
            this.comboBox_SaveSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SaveSelection.FormattingEnabled = true;
            this.comboBox_SaveSelection.Items.AddRange(new object[] {
            "Original Text",
            "Key",
            "Encoded Text",
            "Decoded Text",
            "Debug Info"});
            this.comboBox_SaveSelection.Location = new System.Drawing.Point(596, 183);
            this.comboBox_SaveSelection.Name = "comboBox_SaveSelection";
            this.comboBox_SaveSelection.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SaveSelection.TabIndex = 24;
            // 
            // openFileDialog_loadFile
            // 
            this.openFileDialog_loadFile.DefaultExt = "txt";
            this.openFileDialog_loadFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog_loadFile.RestoreDirectory = true;
            this.openFileDialog_loadFile.Title = "Select File";
            this.openFileDialog_loadFile.HelpRequest += new System.EventHandler(this.button_LoadKey_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 536);
            this.Controls.Add(this.comboBox_SaveSelection);
            this.Controls.Add(this.checkBox_WriteTreeInfo);
            this.Controls.Add(this.button_Decode);
            this.Controls.Add(this.button_CreateKey);
            this.Controls.Add(this.button_SaveKey);
            this.Controls.Add(this.button_LoadKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputKey);
            this.Controls.Add(this.button_ClearAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputRTS);
            this.Controls.Add(this.outputRTB);
            this.Controls.Add(this.button_Encode);
            this.Controls.Add(this.inputRTB);
            this.MaximumSize = new System.Drawing.Size(888, 575);
            this.MinimumSize = new System.Drawing.Size(888, 575);
            this.Name = "form_Main";
            this.Text = "Huffman Coder/Decoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRTB;
        private System.Windows.Forms.Button button_Encode;
        private System.Windows.Forms.RichTextBox outputRTB;
        private System.Windows.Forms.RichTextBox outputRTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ClearAll;
        private System.Windows.Forms.RichTextBox outputKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_LoadKey;
        private System.Windows.Forms.Button button_SaveKey;
        private System.Windows.Forms.Button button_CreateKey;
        private System.Windows.Forms.Button button_Decode;
        private System.Windows.Forms.CheckBox checkBox_WriteTreeInfo;
        private System.Windows.Forms.ComboBox comboBox_SaveSelection;
        private System.Windows.Forms.OpenFileDialog openFileDialog_loadFile;
    }
}

