namespace Algorithm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.num_btnTransform = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SN_pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QRC_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SN_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRC_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.Location = new System.Drawing.Point(317, 122);
            this.txtInput.MaxLength = 8;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 29);
            this.txtInput.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(223, 205);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 21);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(166, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SN(起始编号)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(166, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PW：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(446, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "个数：";
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.Location = new System.Drawing.Point(521, 121);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(42, 29);
            this.number.TabIndex = 6;
            // 
            // num_btnTransform
            // 
            this.num_btnTransform.BackColor = System.Drawing.Color.White;
            this.num_btnTransform.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num_btnTransform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num_btnTransform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num_btnTransform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_btnTransform.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_btnTransform.Location = new System.Drawing.Point(613, 117);
            this.num_btnTransform.Name = "num_btnTransform";
            this.num_btnTransform.Size = new System.Drawing.Size(87, 30);
            this.num_btnTransform.TabIndex = 7;
            this.num_btnTransform.Text = "生成";
            this.num_btnTransform.UseVisualStyleBackColor = false;
            this.num_btnTransform.Click += new System.EventHandler(this.num_btnTransform_Click);
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResults.Location = new System.Drawing.Point(482, 254);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(218, 207);
            this.txtResults.TabIndex = 10;
            // 
            // SN_pictureBox
            // 
            this.SN_pictureBox.Location = new System.Drawing.Point(171, 264);
            this.SN_pictureBox.Name = "SN_pictureBox";
            this.SN_pictureBox.Size = new System.Drawing.Size(151, 67);
            this.SN_pictureBox.TabIndex = 12;
            this.SN_pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(477, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "PW：";
            // 
            // QRC_pictureBox
            // 
            this.QRC_pictureBox.Location = new System.Drawing.Point(171, 394);
            this.QRC_pictureBox.Name = "QRC_pictureBox";
            this.QRC_pictureBox.Size = new System.Drawing.Size(151, 67);
            this.QRC_pictureBox.TabIndex = 15;
            this.QRC_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 574);
            this.Controls.Add(this.QRC_pictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SN_pictureBox);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.num_btnTransform);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtInput);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Algorithm(版本号1.04)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SN_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRC_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button num_btnTransform;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.PictureBox SN_pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox QRC_pictureBox;
    }
}

