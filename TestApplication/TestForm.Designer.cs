namespace TestApplication
{
    partial class TestForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            VirtualTreeView.MiscOptionHelper miscOptionHelper1 = new VirtualTreeView.MiscOptionHelper();
            VirtualTreeView.PaintOptionHelper paintOptionHelper1 = new VirtualTreeView.PaintOptionHelper();
            VirtualTreeView.MiscOptionHelper miscOptionHelper2 = new VirtualTreeView.MiscOptionHelper();
            VirtualTreeView.PaintOptionHelper paintOptionHelper2 = new VirtualTreeView.PaintOptionHelper();
            VirtualTreeView.MiscOptionHelper miscOptionHelper3 = new VirtualTreeView.MiscOptionHelper();
            VirtualTreeView.PaintOptionHelper paintOptionHelper3 = new VirtualTreeView.PaintOptionHelper();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.virtualTreeView2 = new VirtualTreeView.VirtualTreeView();
            this.virtualTreeView1 = new VirtualTreeView.VirtualTreeView();
            this.vtItems = new VirtualTreeView.VirtualTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 42);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tree";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.virtualTreeView2);
            this.panel2.Controls.Add(this.virtualTreeView1);
            this.panel2.Controls.Add(this.vtItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 637);
            this.panel2.TabIndex = 1;
            // 
            // virtualTreeView2
            // 
            this.virtualTreeView2.Back2Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.virtualTreeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.virtualTreeView2.ButtonStyle = VirtualTreeView.ButtonStyle.bsRectangle;
            this.virtualTreeView2.Header.BackColor = System.Drawing.Color.White;
            this.virtualTreeView2.Header.Columns = ((System.Collections.Generic.List<VirtualTreeView.VirtualTreeColumn>)(resources.GetObject("resource.Columns")));
            this.virtualTreeView2.Header.Font = new System.Drawing.Font("Tahoma", 8F);
            this.virtualTreeView2.Header.ForeColor = System.Drawing.Color.Black;
            this.virtualTreeView2.Header.Height = 16;
            this.virtualTreeView2.Header.Visible = true;
            this.virtualTreeView2.LineColor = System.Drawing.Color.Silver;
            this.virtualTreeView2.LineWidth = 1F;
            this.virtualTreeView2.Location = new System.Drawing.Point(756, 346);
            this.virtualTreeView2.Name = "virtualTreeView2";
            miscOptionHelper1.Editable = false;
            miscOptionHelper1.MultiSelect = false;
            this.virtualTreeView2.Options.Misc = miscOptionHelper1;
            paintOptionHelper1.Back2Color = true;
            paintOptionHelper1.FullVertGridLines = true;
            paintOptionHelper1.ShowButtons = true;
            paintOptionHelper1.ShowHorzGridLines = true;
            this.virtualTreeView2.Options.Paint = paintOptionHelper1;
            this.virtualTreeView2.ShowHint = true;
            this.virtualTreeView2.Size = new System.Drawing.Size(101, 80);
            this.virtualTreeView2.TabIndex = 2;
            // 
            // virtualTreeView1
            // 
            this.virtualTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualTreeView1.Back2Color = System.Drawing.SystemColors.InactiveCaption;
            this.virtualTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.virtualTreeView1.ButtonStyle = VirtualTreeView.ButtonStyle.bsRectangle;
            this.virtualTreeView1.Header.BackColor = System.Drawing.Color.LightGray;
            this.virtualTreeView1.Header.Columns = ((System.Collections.Generic.List<VirtualTreeView.VirtualTreeColumn>)(resources.GetObject("resource.Columns1")));
            this.virtualTreeView1.Header.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.virtualTreeView1.Header.ForeColor = System.Drawing.Color.Black;
            this.virtualTreeView1.Header.Height = 20;
            this.virtualTreeView1.Header.Visible = true;
            this.virtualTreeView1.LineColor = System.Drawing.Color.Black;
            this.virtualTreeView1.LineWidth = 1F;
            this.virtualTreeView1.Location = new System.Drawing.Point(3, 259);
            this.virtualTreeView1.Name = "virtualTreeView1";
            miscOptionHelper2.Editable = true;
            miscOptionHelper2.MultiSelect = false;
            this.virtualTreeView1.Options.Misc = miscOptionHelper2;
            paintOptionHelper2.Back2Color = true;
            paintOptionHelper2.FullVertGridLines = true;
            paintOptionHelper2.ShowButtons = true;
            paintOptionHelper2.ShowHorzGridLines = true;
            this.virtualTreeView1.Options.Paint = paintOptionHelper2;
            this.virtualTreeView1.ShowHint = false;
            this.virtualTreeView1.Size = new System.Drawing.Size(731, 365);
            this.virtualTreeView1.TabIndex = 1;
            this.virtualTreeView1.OnGetNodeCellText += new VirtualTreeView.GetNodeCellText(this.virtualTreeView1_OnGetNodeCellText);
            this.virtualTreeView1.OnNodeNewText += new VirtualTreeView.NodeNewText(this.virtualTreeView1_OnNodeNewText);
            this.virtualTreeView1.Editing += new VirtualTreeView.CellEditing(this.virtualTreeView1_Editing);
            this.virtualTreeView1.OnGetNodeHintText += new VirtualTreeView.GetNodeHintText(this.virtualTreeView1_OnGetNodeHintText);
            this.virtualTreeView1.NodeDrawText += new VirtualTreeView.OnDrawText(this.virtualTreeView1_NodeDrawText);
            this.virtualTreeView1.OnBeforeCellPaint += new VirtualTreeView.BeforeCellPaint(this.virtualTreeView1_OnBeforeCellPaint);
            this.virtualTreeView1.Load += new System.EventHandler(this.virtualTreeView1_Load);
            this.virtualTreeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.virtualTreeView1_MouseClick);
            // 
            // vtItems
            // 
            this.vtItems.Back2Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.vtItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vtItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vtItems.ButtonStyle = VirtualTreeView.ButtonStyle.bsRectangle;
            this.vtItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.vtItems.Header.BackColor = System.Drawing.Color.White;
            this.vtItems.Header.Columns = ((System.Collections.Generic.List<VirtualTreeView.VirtualTreeColumn>)(resources.GetObject("resource.Columns2")));
            this.vtItems.Header.Font = new System.Drawing.Font("Tahoma", 8F);
            this.vtItems.Header.ForeColor = System.Drawing.Color.Black;
            this.vtItems.Header.Height = 16;
            this.vtItems.Header.Visible = true;
            this.vtItems.imageList = this.imageList1;
            this.vtItems.LineColor = System.Drawing.Color.Silver;
            this.vtItems.LineWidth = 1F;
            this.vtItems.Location = new System.Drawing.Point(0, 0);
            this.vtItems.Name = "vtItems";
            miscOptionHelper3.Editable = true;
            miscOptionHelper3.MultiSelect = false;
            this.vtItems.Options.Misc = miscOptionHelper3;
            paintOptionHelper3.Back2Color = true;
            paintOptionHelper3.FullVertGridLines = false;
            paintOptionHelper3.ShowButtons = true;
            paintOptionHelper3.ShowHorzGridLines = true;
            this.vtItems.Options.Paint = paintOptionHelper3;
            this.vtItems.ShowHint = true;
            this.vtItems.Size = new System.Drawing.Size(868, 227);
            this.vtItems.TabIndex = 0;
            this.vtItems.OnGetNodeCellText += new VirtualTreeView.GetNodeCellText(this.vtItems_OnGetNodeCellText);
            this.vtItems.OnNodeNewText += new VirtualTreeView.NodeNewText(this.vtItems_OnNodeNewText);
            this.vtItems.GetImageIndex += new VirtualTreeView.OnGetImageIndex(this.vtItems_GetImageIndex);
            this.vtItems.DrawCell += new VirtualTreeView.OnDrawCell(this.vtItems_DrawCell);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "green.bmp");
            this.imageList1.Images.SetKeyName(1, "red.png");
            this.imageList1.Images.SetKeyName(2, "yellow.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Init";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TestForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private VirtualTreeView.VirtualTreeView vtItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private VirtualTreeView.VirtualTreeView virtualTreeView1;
        private VirtualTreeView.VirtualTreeView virtualTreeView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

