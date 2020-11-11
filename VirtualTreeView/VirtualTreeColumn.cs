using System;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Reflection;

namespace VirtualTreeView
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class VirtualTreeColumn
    {

        private string FName = "Column";
        private int FWidth = 50;
        private StringAlignment FLineAlignment = StringAlignment.Center;
        private StringAlignment FAlignment = StringAlignment.Near;
        private StringAlignment FCaptionLineAlignment = StringAlignment.Center;
        private StringAlignment FCaptionAlignment = StringAlignment.Near;

        [Category("Behavior")]
        public string Name { get { return FName; } set { FName = value; } }
        [Category("Behavior")]
        public int Width { get { return FWidth; } set { FWidth = value; } }

        [Category("Alignment")]
        public StringAlignment LineAlignment { get => FLineAlignment; set => FLineAlignment = value; }

        [Category("Alignment")]
        public StringAlignment Alignment { get => FAlignment; set => FAlignment = value; }

        [Category("Alignment")]
        public StringAlignment CaptionLineAlignment { get => FCaptionLineAlignment; set => FCaptionLineAlignment = value; }

        [Category("Alignment")]
        public StringAlignment CaptionAlignment { get => FCaptionAlignment; set => FCaptionAlignment = value; }


        internal FieldInfo fieldInfo = null;

        public VirtualTreeColumn()
        {


        }

        public VirtualTreeColumn(FieldInfo fi)
        {
            fieldInfo = fi;

        }


        public void SetFieldInfo(FieldInfo fi)
        {
            fieldInfo = fi;
        }

       



       


    }
}
