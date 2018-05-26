namespace ProjectSQLDescription.UI
{
    partial class Setting
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_dataDir = new System.Windows.Forms.Label();
            this.textBox_dataDir = new System.Windows.Forms.TextBox();
            this.button_setDataDir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_setDataDir);
            this.groupBox1.Controls.Add(this.textBox_dataDir);
            this.groupBox1.Controls.Add(this.label_dataDir);
            this.groupBox1.Location = new System.Drawing.Point(45, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // label_dataDir
            // 
            this.label_dataDir.AutoSize = true;
            this.label_dataDir.Location = new System.Drawing.Point(41, 59);
            this.label_dataDir.Name = "label_dataDir";
            this.label_dataDir.Size = new System.Drawing.Size(53, 12);
            this.label_dataDir.TabIndex = 0;
            this.label_dataDir.Text = "数据目录";
            // 
            // textBox_dataDir
            // 
            this.textBox_dataDir.Location = new System.Drawing.Point(107, 56);
            this.textBox_dataDir.Name = "textBox_dataDir";
            this.textBox_dataDir.Size = new System.Drawing.Size(214, 21);
            this.textBox_dataDir.TabIndex = 1;
            // 
            // button_setDataDir
            // 
            this.button_setDataDir.Location = new System.Drawing.Point(327, 54);
            this.button_setDataDir.Name = "button_setDataDir";
            this.button_setDataDir.Size = new System.Drawing.Size(46, 23);
            this.button_setDataDir.TabIndex = 2;
            this.button_setDataDir.Text = "...";
            this.button_setDataDir.UseVisualStyleBackColor = true;
            this.button_setDataDir.Click += new System.EventHandler(this.button_setDataDir_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(478, 370);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_setDataDir;
        private System.Windows.Forms.TextBox textBox_dataDir;
        private System.Windows.Forms.Label label_dataDir;
    }
}
