using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSQLDescription.Utils
{
    //这是我以前照着一本书上的例子封装的类，使用方法都有，你看看吧  
    /// 使用方法：
    /// 1.namespace.CtrlAutoSize autosize;          //申明本类对象为全局变量
    /// 2.private void Form1_Load(object sender, EventArgs e)
    ///    {
    ///        this.Resize+=new EventHandler(Form1_Resize);
    ///        autosize = new CMyClass.CtrlAutoSize(this);    //实例化对象并传递"this"
    ///        autosize.setTag(this);                         //调用此函数以初始化并记录窗口的初始大小等
    ///     }
    ///  3.public void Form1_Resize(object sender,EventArgs e)
    ///    {
    ///        autosize.setControls(this);                    //在resize消息里调用此函数以自动设置窗口控件大小和位置
    ///    }
    ///   

    public class CtrlAutoSize
    {
        System.Windows.Forms.Form thisForm;
        private float x, y;
        float newx, newy;

        public CtrlAutoSize(System.Windows.Forms.Form form)
        {
            thisForm = form;
            x = thisForm.Width;
            y = thisForm.Height;
        }

        public void setTag(Control cons)
        {

            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        public void setControls(Control cons)
        {
            newx = cons.Width / x;
            newy = cons.Height / y;
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { (':') });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)a;
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)a;
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)a;
                Single currentSize = Convert.ToSingle(mytag[4]) * newy;
                con.Font = new System.Drawing.Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(con);
                }
            }
        }
    }
}
