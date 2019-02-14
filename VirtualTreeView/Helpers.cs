using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTreeView
{


    public enum NodeAttachMode
    {
        amNoWhere,
        amInsertBefore,
        amInsertAfter,
        amAddChildFirst,
        amAddChildLast
    };

    public enum CheckType
    {
        ctNone,
        ctTriStateCheckBox,
        ctCheckBox,
        ctRadioButton,
        ctButton
    };

    public enum CheckState
    {
        csUncheckedNormal,
        csUncheckedPressed,
        csCheckedNormal,
        csCheckedPressed,
        csMixedNormal,
        csMixedPressed
    };

  

    public enum NodeState
    {
        vsExpanded = 1
    };


    [Browsable(true)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PaintOptionHelper
    {

        private bool showHorzGridLines=true;
        private bool fullVertGridLines=true;
        private bool back2Color=true;
        private bool showButtons = true;

        public bool ShowHorzGridLines { get => showHorzGridLines; set => showHorzGridLines = value; }
        public bool FullVertGridLines { get => fullVertGridLines; set => fullVertGridLines = value; }
        public bool Back2Color { get => back2Color; set => back2Color = value; }
        public bool ShowButtons { get => showButtons; set => showButtons = value; }
    }

    [Browsable(true)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MiscOptionHelper
    {
        private bool editable = false;

        public bool Editable { get => editable; set => editable = value; }

        private bool multiSelect = false;

        public bool MultiSelect { get => multiSelect; set => multiSelect = value; }

    }


    [Browsable(true)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TreeOptionsHelper
    {
        private MiscOptionHelper misc = new MiscOptionHelper();
        private PaintOptionHelper paint = new PaintOptionHelper();

        [Browsable(true)]
        public MiscOptionHelper Misc { get => misc; set => misc = value; }
        [Browsable(true)]
        public PaintOptionHelper Paint { get => paint; set => paint = value; }
    }

    class RectangleNode
    {
        public VirtualTreeNode node;
        public Rectangle rect;
        public RectangleNode next;
        public bool isInRect(int X, int Y)
        {
            return rect.Contains(X, Y);
        }
    }


    public class SelectedContainer
    {
        public VirtualTreeNode node = null;
        public SelectedContainer next = null;
        public int column = -1;

    }

    public enum SortDirection
    {
        sdAscending,
        sdDescending
    }

    public enum ButtonStyle
    {
        bsTriangle,
        bsRectangle        
    }



    public class SelectedHelper

    {

        VirtualTreeView tree = null;

        internal SelectedHelper(VirtualTreeView t)
        {
            tree = t;
        }

        public bool this[VirtualTreeNode node]
        {
            set
            {
                if (value)
                    tree.AddToSelected(node);
                else
                    tree.RemoveFromSelected(node);
            }


            get
            {

                return tree.isSelected(node);

            }


        }

    }



    public class ExpandedHelper

    {

        VirtualTreeView tree = null;

        internal ExpandedHelper(VirtualTreeView t)
        {
            tree = t;
        }

        public bool this[VirtualTreeNode node]
        {
            set
            {
                
                if( (node.childCount>0) && (!this[node]) )
                    tree.SendExpandedEvent(node);
                tree.ExpandNode(node);
            }   
            


        get
            {

                return (node.state & NodeState.vsExpanded) >0;

            }


        }

    }


}
