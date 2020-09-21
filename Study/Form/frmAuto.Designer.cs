namespace Study
{
    partial class frmAuto
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lsbResult = new System.Windows.Forms.ListBox();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(120, 70);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(62, 16);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "label1";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(240, 70);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(62, 16);
            this.lblOp.TabIndex = 1;
            this.lblOp.Text = "label2";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(365, 70);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(62, 16);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "label3";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(472, 70);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(17, 16);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(555, 67);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 25);
            this.txtResult.TabIndex = 4;
            // 
            // lsbResult
            // 
            this.lsbResult.FormattingEnabled = true;
            this.lsbResult.ItemHeight = 16;
            this.lsbResult.Location = new System.Drawing.Point(123, 171);
            this.lsbResult.Name = "lsbResult";
            this.lsbResult.Size = new System.Drawing.Size(532, 196);
            this.lsbResult.TabIndex = 5;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(160, 133);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(102, 32);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Text = "出题";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.BtnQuestion_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(509, 133);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(102, 32);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "判题";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(830, 394);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.lsbResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblNum1);
            this.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动出题";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ListBox lsbResult;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnResult;
    }
}

