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


    class Selected
    {
        public VirtualTreeNode node = null;
        public Selected next = null;
        public int column = -1;

    }

    public enum SortDirection
    {
        sdAscending,
        sdDescending
    }

}
