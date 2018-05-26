using ProjectSQLDescription.POJO;
using ProjectSQLDescription.Service;
using ProjectSQLDescription.UI;
using ProjectSQLDescription.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSQLDescription
{
    public partial class Main : Form
    {
        private MainService mainService = new MainService();
        private static Dictionary<string, ProjectInfo> dic = new Dictionary<string,ProjectInfo>();
        Utils.CtrlAutoSize autosize;
        public Main()
        {
            InitializeComponent();
            treeInit();
        }
        //加载工作目录下的json
        private void treeInit()
        {
            string dataDir = "D:/MyGitRes/projectDir";
            dic = mainService.getDicFromAllDirJsonFiles(dataDir);
            if (dic != null&& dic.Count>0)
            {
                foreach (ProjectInfo project in dic.Values)
                {
                    TreeNode treeNodeProject = new TreeNode(project.ProjectName);
                    treeNodeProject.Name = project.ProjectId;
                    treeNodeProject.Text = project.ProjectName;
                    foreach (SqlInfo sqlInfo in project.SqlList)
                    {
                        TreeNode treeNodeSql = new TreeNode(sqlInfo.SqlName);
                        treeNodeSql.Name = sqlInfo.SqlId;
                        treeNodeSql.Text = sqlInfo.SqlId;
                        treeNodeProject.Nodes.Add(treeNodeSql);
                    }
                    this.treeView1.Nodes.Add(treeNodeProject);
                    this.treeView1.ExpandAll();
                    this.treeView1.MouseClick += Node_Click;
                }
            }
        }
        private void Node_Click(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                TreeNode tn = this.treeView1.GetNodeAt(e.X, e.Y);
                ProjectInfo selectedPro = null;
                SqlInfo selectedSql = null;
                if (tn != null)
                {
                    this.treeView1.SelectedNode = tn;
                    if (tn.Parent!=null)
                    {
                        selectedPro = dic[tn.Parent.Name];
                        selectedSql =  selectedPro.SqlList.Find(item =>
                        {
                            if (item.SqlId.Equals(tn.Name))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        });
                        MessageBox.Show(selectedSql.Sql);
                    }
                    else
                    {
                       selectedPro =  dic[tn.Name];
                        MessageBox.Show(selectedPro.ProjectDescription);
                    }
                   
                }
            }
        }
        //添加新项目，根节点
        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject newProjectWin = new NewProject();
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(newProjectWin);
        }
        //添加新sql,对应根节点的子节点
        private void newSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSql newSql = new NewSql();
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(newSql);
        }
        //打开文件目录
        private void fileSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "D:/MyGitRes/projectDir");
        }
        //设置，如file 目录
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(setting);
        }
        //about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Main_Resize);
            autosize = new CtrlAutoSize(this);  
            autosize.setTag(this);    
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            autosize.setControls(this);
        }
    }
}
