namespace labGenPassword
{
    partial class fm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.buGen = new System.Windows.Forms.Button();
            this.chUp = new System.Windows.Forms.CheckBox();
            this.chDown = new System.Windows.Forms.CheckBox();
            this.chNum = new System.Windows.Forms.CheckBox();
            this.chSpec = new System.Windows.Forms.CheckBox();
            this.edLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edLength)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(208, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(410, 51);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "<Password>";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buGen
            // 
            this.buGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buGen.Location = new System.Drawing.Point(302, 69);
            this.buGen.Name = "buGen";
            this.buGen.Size = new System.Drawing.Size(219, 55);
            this.buGen.TabIndex = 1;
            this.buGen.Text = "Generate";
            this.buGen.UseVisualStyleBackColor = true;
            // 
            // chUp
            // 
            this.chUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chUp.AutoSize = true;
            this.chUp.Location = new System.Drawing.Point(312, 143);
            this.chUp.Name = "chUp";
            this.chUp.Size = new System.Drawing.Size(221, 21);
            this.chUp.TabIndex = 2;
            this.chUp.Text = "Символы в верхнем регистре";
            this.chUp.UseVisualStyleBackColor = true;
            // 
            // chDown
            // 
            this.chDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chDown.AutoSize = true;
            this.chDown.Location = new System.Drawing.Point(312, 170);
            this.chDown.Name = "chDown";
            this.chDown.Size = new System.Drawing.Size(217, 21);
            this.chDown.TabIndex = 3;
            this.chDown.Text = "Символы в нижнем регистре";
            this.chDown.UseVisualStyleBackColor = true;
            // 
            // chNum
            // 
            this.chNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chNum.AutoSize = true;
            this.chNum.Location = new System.Drawing.Point(312, 197);
            this.chNum.Name = "chNum";
            this.chNum.Size = new System.Drawing.Size(78, 21);
            this.chNum.TabIndex = 4;
            this.chNum.Text = "Цифры";
            this.chNum.UseVisualStyleBackColor = true;
            // 
            // chSpec
            // 
            this.chSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chSpec.AutoSize = true;
            this.chSpec.Location = new System.Drawing.Point(312, 224);
            this.chSpec.Name = "chSpec";
            this.chSpec.Size = new System.Drawing.Size(181, 21);
            this.chSpec.TabIndex = 5;
            this.chSpec.Text = "Специальные символы";
            this.chSpec.UseVisualStyleBackColor = true;
            // 
            // edLength
            // 
            this.edLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edLength.Location = new System.Drawing.Point(409, 305);
            this.edLength.Name = "edLength";
            this.edLength.Size = new System.Drawing.Size(130, 22);
            this.edLength.TabIndex = 6;
            this.edLength.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Длина пароля";
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edLength);
            this.Controls.Add(this.chSpec);
            this.Controls.Add(this.chNum);
            this.Controls.Add(this.chDown);
            this.Controls.Add(this.chUp);
            this.Controls.Add(this.buGen);
            this.Controls.Add(this.textBox);
            this.MinimumSize = new System.Drawing.Size(846, 503);
            this.Name = "fm";
            this.Text = "labGenPassword";
            ((System.ComponentModel.ISupportInitialize)(this.edLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buGen;
        private System.Windows.Forms.CheckBox chUp;
        private System.Windows.Forms.CheckBox chDown;
        private System.Windows.Forms.CheckBox chNum;
        private System.Windows.Forms.CheckBox chSpec;
        private System.Windows.Forms.NumericUpDown edLength;
        private System.Windows.Forms.Label label1;
    }
}

