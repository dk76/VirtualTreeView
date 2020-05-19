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

        



        public TestForm()
        {
            InitializeComponent();
        }





        private void vtItems_OnGetNodeCellText(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node, int column, out string cellText)
        {
            var n = vtItems.GetNodeData<NodeData>(node);
            switch (column)
            {
                case 0: cellText = (n.num).ToString(); break;
                default: cellText = n.name; break;
            }
        }

        private void buttonMakeMillion_Click(object sender, EventArgs e)
        {
            try
            {
                vtItems.BeginUpdate();
                vtItems.Clear();
                for (int i = 1; i <= 1000000; i++)
                {
                    var n = new NodeData();
                    n.num = i;
                    n.name = $"Node {i}";
                    var node=vtItems.InsertNode(null, NodeAttachMode.amInsertAfter, n);
                    vtItems.InsertNode(node, NodeAttachMode.amAddChildLast, n);
                }
            }
            finally
            {
                vtItems.EndUpdate();
            }

        }

        SortDirection sd = SortDirection.sdAscending;
        private void vtItems_OnHeaderClick(VirtualTreeView.VirtualTreeView tree, int column)
        {

            if (column == 0)
            {
                if (sd == SortDirection.sdAscending)
                    sd = SortDirection.sdDescending;
                else
                    sd = SortDirection.sdAscending;
                tree.SortTree(column, sd);
            }
        }

        private void vtItems_OnCompareNode(VirtualTreeView.VirtualTreeView tree, VirtualTreeNode node1, VirtualTreeNode node2, int column, out int result)
        {
            var n1 = vtItems.GetNodeData<NodeData>(node1);
            var n2 = vtItems.GetNodeData<NodeData>(node2);

            if (column == 0)
            {
                result = n1.num - n2.num;
            }
            else
                result = string.Compare(n1.name,n2.name);



        }
    }
    public class NodeData
    {
        public int num = 0;
        public string name = "";
    }

}
