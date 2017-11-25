
namespace VirtualTreeView
{
    public class VirtualTreeNode
    {
        internal int FIndex, FChildCount, FLevel;

        static public int NodeHeightDefault = 16;

        public int index { get { return FIndex; } }
        public int childCount { get { return FChildCount; } }
        public int level { get { return FLevel; } }
        public int nodeHeight = NodeHeightDefault;

        internal VirtualTreeNode FParent;
        public VirtualTreeNode parent { get { return FParent; } }
        internal VirtualTreeNode prevSibling, nextSibling, firstChild, lastChild;
        public CheckState checkState;
        public CheckType checkType;
        internal object data;
        public VirtualTreeNode(object data)
        { this.data = data; }
        private NodeState FState;
        public NodeState state
        {
            get { return FState; }
            set
            {
                FState = value;
            }



        }
        public VirtualTreeView getNodeTree()
        {
            if (FLevel == 0) return (VirtualTreeView)data;
            return FParent.getNodeTree();
        }


    }
}
