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

        
        int nodeCount = 100000;
        int FMode = -1;

        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VirtualTreeColumn column = null;
            vtItems.GetImageIndex += vtItems_GetImageIndex;
            vtItems.DrawCell += vtItems_DrawCell;

            FMode = 0;
           

            vtItems.BeginUpdate();
            vtItems.Header.Columns.Clear();
            vtItems.Clear();

            for (int i=0;i<10;i++)
            {

                column = new VirtualTreeColumn();
                column.Width = 70;
                column.Name = i.ToString();
                column.Alignment = StringAlignment.Far;
                column.CaptionAlignment = StringAlignment.Center;

                vtItems.Header.Columns.Add(column);
               
            }


            for (int i=0;i<nodeCount;i++)
            {
                var node=vtItems.InsertNode(null, NodeAttachMode.amInsertAfter, null);
                node.checkType = CheckType.ctCheckBox;
            }
            vtItems.Invalidate();
            vtItems.EndUpdate();
        }

      
        private void vtItems_OnGetNodeCellText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out string cellText)
        {
            if (column == 0)
                cellText = node.index.ToString();
            else
                cellText =  column.ToString();

        }

        private void vtItems_GetImageIndex(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out int index)
        {
            index = -1;
            if((column==0) && (FMode==0))
                index = 0;

        }

        private void vtItems_DrawCell(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, Graphics g, RectangleF rect, out bool handled)
        {
            handled = column == 1;
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            FMode = 1;

            VirtualTreeColumn column = null;
            vtItems.GetImageIndex -= vtItems_GetImageIndex;
            vtItems.DrawCell -= vtItems_DrawCell;
            vtItems.BeginUpdate();
            vtItems.Header.Columns.Clear();
            vtItems.Clear();

            for (int i = 0; i < 10; i++)
            {

                column = new VirtualTreeColumn();
                column.Width = 70;
                column.Name = i.ToString();

                if(i>0)
                    column.Alignment = StringAlignment.Far;

                column.CaptionAlignment = StringAlignment.Center;

                vtItems.Header.Columns.Add(column);

            }


            for (int i = 0; i < nodeCount; i++)
            {
                var node = vtItems.InsertNode(null, NodeAttachMode.amInsertAfter, null);
                for (int j = 0; j < 10; j++)
                    vtItems.InsertNode(node,NodeAttachMode.amAddChildLast,null);
            }
            vtItems.Invalidate();




            vtItems.EndUpdate();
        }
    }
}
