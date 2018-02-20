using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualTreeView
{

    public interface IEditor
    {
        void setText(String s);
        string getText();
        void PrepareEdit(Rectangle r);
        Control getEdit();
        void Focus();

        VirtualTreeNode getNode();
        int getColumn();

        void setEdit(Control edit);

    }



    public class Editor : IEditor
    {

        protected String FText = "";
        protected Control FEdit = null;
        protected VirtualTreeView FTree = null;
        protected VirtualTreeNode FNode = null;
        protected int FColumn = -1;


        public void setEdit(Control edit) { FEdit = edit;  }

        public void setText(String s) { FText = s; }
        virtual public string getText() { return FText; }

        public Editor(VirtualTreeView tree, VirtualTreeNode node,int column)
        {
            FTree = tree;
            FNode = node;
            FColumn = column;
            
        }

        public VirtualTreeNode getNode() { return FNode; }
        public int getColumn() { return FColumn; }

        public void PrepareEdit(Rectangle r)
        {
            FEdit.Top = r.Top;
            FEdit.Left = r.Left;
            FEdit.Width = r.Width;
            FEdit.Height = r.Height;
            FEdit.KeyUp += this.editOnKeyUp;
        }

        public Control getEdit() { return FEdit; }
        public void Focus() { FEdit.Focus(); }


        protected void editOnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                VirtualTreeNode node = FNode;
                int column = FColumn;

                string s = getText();



                FTree.NewText(node, column, s);
                FTree.RemoveControl(getEdit());
                FTree.EndUpdate();
                FTree.ReDrawTree();


            }
            else
            if (e.KeyCode == Keys.Escape)
            {

                
                FTree.RemoveControl(getEdit());
                FTree.EndUpdate();
                FTree.ReDrawTree();

            }

        }

    }


    public class TextEditor:Editor,IEditor
        {

            public TextEditor(VirtualTreeView tree, VirtualTreeNode node, int column):base(tree,node,column)
            {
            
                var edit = new TextBox();
                setEdit(edit);
               
            }


      

        public new void setText(String s)
            {
                FText = s;
                (FEdit as TextBox).Text = s;
            }

        public override string getText() { return (FEdit as TextBox).Text; }
        }


    public class DateEditor:Editor,IEditor
    {

        public DateEditor(VirtualTreeView tree, VirtualTreeNode node, int column):base(tree,node,column)
        {

            var edit = new DateTimePicker();
            setEdit(edit);
            
        }

        public new void setText(String s)
        {
            FText = s;

            DateTime dt;
            if(DateTime.TryParse(FText,out dt))
            {
                (FEdit as DateTimePicker).Value = dt;

            }

            
        }
        override public string getText()
        {
            return (FEdit as DateTimePicker).Value.ToString("dd.MM.YY");
        }


    }




}
