using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualTreeView;

namespace TestApplication
{
    public partial class TestForm : Form
    {

        Random random;

        string hello = "HelloHelloHelloHelloHelloHello";

        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VirtualTreeColumn column = null;

            random = new Random();

           // vtItems.PaintOptions |=PaintOption.toFullVertGridLines|PaintOption.toShowHorzGridLines;

            vtItems.BeginUpdate();

            for(int i=0;i<10;i++)
            {

                column = new VirtualTreeColumn();
                column.Width = 70;
                column.Name = i.ToString();
                column.Alignment = StringAlignment.Far;
                column.CaptionAlignment = StringAlignment.Center;

                vtItems.Header.Columns.Add(column);
               
            }


            for (int i=0;i<100000;i++)
            {
                var node=vtItems.InsertNode(null, NodeAttachMode.amInsertAfter, null);
                node.checkType = CheckType.ctCheckBox;


            }

            vtItems.Invalidate();
            vtItems.EndUpdate();




        }


        string hello1 = "hello";

        private void vtItems_OnGetNodeCellText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out string cellText)
        {
            if (column == 0)
                cellText = node.index.ToString();
            else
                cellText =  hello1;

        }

        private void vtItems_GetImageIndex(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out int index)
        {
            index = -1;
            if(column==0)
                index = 0;

        }

        private void vtItems_DrawCell(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, Graphics g, RectangleF rect, out bool handled)
        {
            handled = column == 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            virtualTreeView1.BeginUpdate();
            for (int i = 0; i < 10; i++)
            {
                var node = virtualTreeView1.InsertNode(null, NodeAttachMode.amInsertAfter, null);
                node.nodeHeight *= 2;
                node= virtualTreeView1.InsertNode(node, NodeAttachMode.amAddChildLast, null);
                //node.nodeHeight *= 2;
            }
            virtualTreeView1.EndUpdate();



           // var en = new NodesEnumerator(virtualTreeView1);
            

            var cnt = 0;
           foreach( var n in virtualTreeView1.Nodes)
            {
                var s1 = ";";
                cnt++;
            }



            var s = ";";






        }

        private void virtualTreeView1_CreateEditor(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out IEditor edit)
        {
            edit = new   DateEditor(tree,node,column);
        }

        private void virtualTreeView1_Editing(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out bool enable)
        {
            enable = (column>0);
        }

        private void virtualTreeView1_Load(object sender, EventArgs e)
        {

        }

        private void virtualTreeView1_OnGetNodeCellText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out string cellText)
        {
            cellText = hello;
        }

        private void virtualTreeView1_OnNodeNewText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, string cellText)
        {
            hello = cellText;
            MessageBox.Show("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            virtualTreeView1.ShowHint = true;
        }

        private void virtualTreeView1_OnGetNodeHintText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out string hintText)
        {
            hintText = "Olalala";
        }

        private void virtualTreeView1_MouseClick(object sender, MouseEventArgs e)
        {
            virtualTreeView1.GetNodeAt(e.X, e.Y);
            
        }

        private void virtualTreeView1_NodeDrawText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, Graphics g, string text, Font font, Brush brush, RectangleF rect, StringFormat format, out bool handled)
        {
            handled = false;
            if(column==1)
            {
                handled = true;
                g.DrawString("bbbbbb", font, brush, rect,format);

            }


        }

        private void vtItems_OnNodeNewText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, string cellText)
        {
            //MessageBox.Show(cellText);
            hello1 = cellText;
        }

        private void virtualTreeView1_OnBeforeCellPaint(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, Graphics g, RectangleF rect)
        {
            //
            g.FillRectangle(new SolidBrush(Color.Red),rect);
        }

        /*private void virtualTreeView1_CreateEditor(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out Control edit)
        {
            //
            var dt=new DateTimePicker();
            edit = dt;
        }*/
    }
}
