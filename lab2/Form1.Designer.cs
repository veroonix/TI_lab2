namespace lab2
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
            this.fileInput = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileChoice = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.resLabel = new System.Windows.Forms.Label();
            this.encryp = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.regInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.lengthCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileInput
            // 
            this.fileInput.Location = new System.Drawing.Point(21, 31);
            this.fileInput.Multiline = true;
            this.fileInput.Name = "fileInput";
            this.fileInput.ReadOnly = true;
            this.fileInput.Size = new System.Drawing.Size(439, 158);
            this.fileInput.TabIndex = 0;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(21, 12);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(45, 16);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "Файл:";
            // 
            // fileChoice
            // 
            this.fileChoice.Location = new System.Drawing.Point(516, 218);
            this.fileChoice.Name = "fileChoice";
            this.fileChoice.Size = new System.Drawing.Size(121, 37);
            this.fileChoice.TabIndex = 2;
            this.fileChoice.Text = "Выбрать файл";
            this.fileChoice.UseVisualStyleBackColor = true;
            this.fileChoice.Click += new System.EventHandler(this.fileChoice_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(21, 282);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(44, 16);
            this.keyLabel.TabIndex = 3;
            this.keyLabel.Text = "Ключ:";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(21, 301);
            this.keyInput.Multiline = true;
            this.keyInput.Name = "keyInput";
            this.keyInput.ReadOnly = true;
            this.keyInput.Size = new System.Drawing.Size(439, 152);
            this.keyInput.TabIndex = 4;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(516, 31);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(446, 158);
            this.output.TabIndex = 5;
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(513, 9);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(80, 16);
            this.resLabel.TabIndex = 6;
            this.resLabel.Text = "Результат:";
            // 
            // encryp
            // 
            this.encryp.BackColor = System.Drawing.Color.Chartreuse;
            this.encryp.Location = new System.Drawing.Point(516, 301);
            this.encryp.Name = "encryp";
            this.encryp.Size = new System.Drawing.Size(217, 37);
            this.encryp.TabIndex = 7;
            this.encryp.Text = "Шифровать/Дешифровать";
            this.encryp.UseVisualStyleBackColor = false;
            this.encryp.Click += new System.EventHandler(this.encryp_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(660, 218);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(131, 37);
            this.save.TabIndex = 9;
            this.save.Text = "Сохранить файл";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // regInput
            // 
            this.regInput.Location = new System.Drawing.Point(21, 225);
            this.regInput.Name = "regInput";
            this.regInput.Size = new System.Drawing.Size(439, 22);
            this.regInput.TabIndex = 11;
            this.regInput.TextChanged += new System.EventHandler(this.regInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сеансовый ключ";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(516, 344);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(90, 37);
            this.cleanButton.TabIndex = 12;
            this.cleanButton.Text = "очистить";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // lengthCount
            // 
            this.lengthCount.AutoSize = true;
            this.lengthCount.Location = new System.Drawing.Point(22, 250);
            this.lengthCount.Name = "lengthCount";
            this.lengthCount.Size = new System.Drawing.Size(0, 16);
            this.lengthCount.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1016, 475);
            this.Controls.Add(this.lengthCount);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.regInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.encryp);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.output);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.fileChoice);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileInput);
            this.Name = "Form1";
            this.Text = "StreamCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileInput;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button fileChoice;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Button encryp;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox regInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label lengthCount;
    }
}

