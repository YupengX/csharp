namespace ProjectSQLDescription.UI
{
    partial class NewProject
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
            this.textBox_prjectName = new System.Windows.Forms.TextBox();
            this.label_projectName = new System.Windows.Forms.Label();
            this.label_prjectDesc = new System.Windows.Forms.Label();
            this.groupBox_project = new System.Windows.Forms.GroupBox();
            this.label_projectUserName = new System.Windows.Forms.Label();
            this.textBox_projectUserName = new System.Windows.Forms.TextBox();
            this.richTextBox_projectDesc = new System.Windows.Forms.RichTextBox();
            this.groupBox_project.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_prjectName
            // 
            this.textBox_prjectName.Location = new System.Drawing.Point(168, 36);
            this.textBox_prjectName.Name = "textBox_prjectName";
            this.textBox_prjectName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_prjectName.Size = new System.Drawing.Size(154, 21);
            this.textBox_prjectName.TabIndex = 0;
            // 
            // label_projectName
            // 
            this.label_projectName.AutoSize = true;
            this.label_projectName.Location = new System.Drawing.Point(97, 45);
            this.label_projectName.Name = "label_projectName";
            this.label_projectName.Size = new System.Drawing.Size(29, 12);
            this.label_projectName.TabIndex = 1;
            this.label_projectName.Text = "Name";
            // 
            // label_prjectDesc
            // 
            this.label_prjectDesc.AutoSize = true;
            this.label_prjectDesc.Location = new System.Drawing.Point(97, 124);
            this.label_prjectDesc.Name = "label_prjectDesc";
            this.label_prjectDesc.Size = new System.Drawing.Size(65, 12);
            this.label_prjectDesc.TabIndex = 2;
            this.label_prjectDesc.Text = "Descrition";
            // 
            // groupBox_project
            // 
            this.groupBox_project.Controls.Add(this.richTextBox_projectDesc);
            this.groupBox_project.Controls.Add(this.textBox_projectUserName);
            this.groupBox_project.Controls.Add(this.label_projectUserName);
            this.groupBox_project.Controls.Add(this.label_projectName);
            this.groupBox_project.Controls.Add(this.textBox_prjectName);
            this.groupBox_project.Controls.Add(this.label_prjectDesc);
            this.groupBox_project.Location = new System.Drawing.Point(22, 18);
            this.groupBox_project.Name = "groupBox_project";
            this.groupBox_project.Size = new System.Drawing.Size(449, 333);
            this.groupBox_project.TabIndex = 3;
            this.groupBox_project.TabStop = false;
            this.groupBox_project.Text = "Project";
            // 
            // label_projectUserName
            // 
            this.label_projectUserName.AutoSize = true;
            this.label_projectUserName.Location = new System.Drawing.Point(97, 84);
            this.label_projectUserName.Name = "label_projectUserName";
            this.label_projectUserName.Size = new System.Drawing.Size(53, 12);
            this.label_projectUserName.TabIndex = 4;
            this.label_projectUserName.Text = "UserName";
            // 
            // textBox_projectUserName
            // 
            this.textBox_projectUserName.Location = new System.Drawing.Point(168, 84);
            this.textBox_projectUserName.Name = "textBox_projectUserName";
            this.textBox_projectUserName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_projectUserName.Size = new System.Drawing.Size(154, 21);
            this.textBox_projectUserName.TabIndex = 5;
            // 
            // richTextBox_projectDesc
            // 
            this.richTextBox_projectDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_projectDesc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_projectDesc.Location = new System.Drawing.Point(76, 167);
            this.richTextBox_projectDesc.Name = "richTextBox_projectDesc";
            this.richTextBox_projectDesc.Size = new System.Drawing.Size(305, 139);
            this.richTextBox_projectDesc.TabIndex = 6;
            this.richTextBox_projectDesc.Text = "";
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_project);
            this.Name = "NewProject";
            this.Size = new System.Drawing.Size(487, 370);
            this.groupBox_project.ResumeLayout(false);
            this.groupBox_project.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_prjectName;
        private System.Windows.Forms.Label label_projectName;
        private System.Windows.Forms.Label label_prjectDesc;
        private System.Windows.Forms.GroupBox groupBox_project;
        private System.Windows.Forms.TextBox textBox_projectUserName;
        private System.Windows.Forms.Label label_projectUserName;
        private System.Windows.Forms.RichTextBox richTextBox_projectDesc;
    }
}
