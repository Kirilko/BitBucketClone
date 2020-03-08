namespace labTrainerAccount
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.laWrong = new System.Windows.Forms.Label();
            this.laCorrect = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buYes = new System.Windows.Forms.Button();
            this.buNo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.laCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.laWrong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.laCorrect, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 115);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // laWrong
            // 
            this.laWrong.BackColor = System.Drawing.Color.Red;
            this.laWrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laWrong.Location = new System.Drawing.Point(190, 0);
            this.laWrong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.laWrong.Name = "laWrong";
            this.laWrong.Size = new System.Drawing.Size(172, 115);
            this.laWrong.TabIndex = 1;
            this.laWrong.Text = "Неверно: 0";
            this.laWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCorrect
            // 
            this.laCorrect.BackColor = System.Drawing.Color.Lime;
            this.laCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laCorrect.Location = new System.Drawing.Point(6, 0);
            this.laCorrect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.laCorrect.Name = "laCorrect";
            this.laCorrect.Size = new System.Drawing.Size(172, 115);
            this.laCorrect.TabIndex = 0;
            this.laCorrect.Text = "Верно: 0";
            this.laCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buYes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buNo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 314);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 114);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buYes
            // 
            this.buYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buYes.ForeColor = System.Drawing.Color.SeaGreen;
            this.buYes.Location = new System.Drawing.Point(3, 3);
            this.buYes.Name = "buYes";
            this.buYes.Size = new System.Drawing.Size(178, 108);
            this.buYes.TabIndex = 3;
            this.buYes.Text = "Да";
            this.buYes.UseVisualStyleBackColor = true;
            // 
            // buNo
            // 
            this.buNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buNo.ForeColor = System.Drawing.Color.Red;
            this.buNo.Location = new System.Drawing.Point(187, 3);
            this.buNo.Name = "buNo";
            this.buNo.Size = new System.Drawing.Size(178, 108);
            this.buNo.TabIndex = 4;
            this.buNo.Text = "Нет";
            this.buNo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(22, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "Верно?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCode
            // 
            this.laCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.laCode.Location = new System.Drawing.Point(20, 142);
            this.laCode.Name = "laCode";
            this.laCode.Size = new System.Drawing.Size(364, 125);
            this.laCode.TabIndex = 4;
            this.laCode.Text = "10 + 21 = 21";
            this.laCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 449);
            this.Controls.Add(this.laCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(431, 496);
            this.Name = "fm";
            this.Text = "labTrainerAccount";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label laCorrect;
        private System.Windows.Forms.Label laWrong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buYes;
        private System.Windows.Forms.Button buNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laCode;
    }
}

