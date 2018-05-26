namespace ProjectSQLDescription.UI
{
    partial class NewSql
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
            this.richTextBox_SqlDesc = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Sql = new System.Windows.Forms.RichTextBox();
            this.textBox_sqlUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sql = new System.Windows.Forms.Label();
            this.label_sqlUserName = new System.Windows.Forms.Label();
            this.textBox_sqlName = new System.Windows.Forms.TextBox();
            this.label_sqlName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_SqlDesc);
            this.groupBox1.Controls.Add(this.richTextBox_Sql);
            this.groupBox1.Controls.Add(this.textBox_sqlUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_sql);
            this.groupBox1.Controls.Add(this.label_sqlUserName);
            this.groupBox1.Controls.Add(this.textBox_sqlName);
            this.groupBox1.Controls.Add(this.label_sqlName);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 628);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL信息";
            // 
            // richTextBox_SqlDesc
            // 
            this.richTextBox_SqlDesc.Location = new System.Drawing.Point(72, 228);
            this.richTextBox_SqlDesc.Name = "richTextBox_SqlDesc";
            this.richTextBox_SqlDesc.Size = new System.Drawing.Size(313, 119);
            this.richTextBox_SqlDesc.TabIndex = 7;
            this.richTextBox_SqlDesc.Text = "";
            // 
            // richTextBox_Sql
            // 
            this.richTextBox_Sql.Location = new System.Drawing.Point(72, 76);
            this.richTextBox_Sql.Name = "richTextBox_Sql";
            this.richTextBox_Sql.Size = new System.Drawing.Size(313, 119);
            this.richTextBox_Sql.TabIndex = 6;
            this.richTextBox_Sql.Text = "";
            // 
            // textBox_sqlUserName
            // 
            this.textBox_sqlUserName.Location = new System.Drawing.Point(296, 30);
            this.textBox_sqlUserName.Name = "textBox_sqlUserName";
            this.textBox_sqlUserName.Size = new System.Drawing.Size(157, 21);
            this.textBox_sqlUserName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL描述";
            // 
            // label_sql
            // 
            this.label_sql.AutoSize = true;
            this.label_sql.Location = new System.Drawing.Point(19, 76);
            this.label_sql.Name = "label_sql";
            this.label_sql.Size = new System.Drawing.Size(23, 12);
            this.label_sql.TabIndex = 3;
            this.label_sql.Text = "SQL";
            // 
            // label_sqlUserName
            // 
            this.label_sqlUserName.AutoSize = true;
            this.label_sqlUserName.Location = new System.Drawing.Point(249, 33);
            this.label_sqlUserName.Name = "label_sqlUserName";
            this.label_sqlUserName.Size = new System.Drawing.Size(41, 12);
            this.label_sqlUserName.TabIndex = 2;
            this.label_sqlUserName.Text = "添加人";
            // 
            // textBox_sqlName
            // 
            this.textBox_sqlName.Location = new System.Drawing.Point(72, 30);
            this.textBox_sqlName.Name = "textBox_sqlName";
            this.textBox_sqlName.Size = new System.Drawing.Size(157, 21);
            this.textBox_sqlName.TabIndex = 1;
            // 
            // label_sqlName
            // 
            this.label_sqlName.AutoSize = true;
            this.label_sqlName.Location = new System.Drawing.Point(19, 33);
            this.label_sqlName.Name = "label_sqlName";
            this.label_sqlName.Size = new System.Drawing.Size(47, 12);
            this.label_sqlName.TabIndex = 0;
            this.label_sqlName.Text = "SQL名称";
            // 
            // NewSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "NewSql";
            this.Size = new System.Drawing.Size(530, 669);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_sql;
        private System.Windows.Forms.Label label_sqlUserName;
        private System.Windows.Forms.TextBox textBox_sqlName;
        private System.Windows.Forms.Label label_sqlName;
        private System.Windows.Forms.TextBox textBox_sqlUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Sql;
        private System.Windows.Forms.RichTextBox richTextBox_SqlDesc;
    }
}
