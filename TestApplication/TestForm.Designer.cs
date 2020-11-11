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
            VirtualTreeView.VirtualTreeColumn virtualTreeColumn1 = new VirtualTreeView.VirtualTreeColumn();
            VirtualTreeView.VirtualTreeColumn virtualTreeColumn2 = new VirtualTreeView.VirtualTreeColumn();
            VirtualTreeView.MiscOptionHelper miscOptionHelper1 = new VirtualTreeView.MiscOptionHelper();
            VirtualTreeView.PaintOptionHelper paintOptionHelper1 = new VirtualTreeView.PaintOptionHelper();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMakeMillion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vtItems = new VirtualTreeView.VirtualTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMakeMillion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 48);
            this.panel1.TabIndex = 0;
            // 
            // buttonMakeMillion
            // 
            this.buttonMakeMillion.Location = new System.Drawing.Point(14, 14);
            this.buttonMakeMillion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMakeMillion.Name = "buttonMakeMillion";
            this.buttonMakeMillion.Size = new System.Drawing.Size(112, 27);
            this.buttonMakeMillion.TabIndex = 0;
            this.buttonMakeMillion.Text = "Make million";
            this.buttonMakeMillion.UseVisualStyleBackColor = true;
            this.buttonMakeMillion.Click += new System.EventHandler(this.buttonMakeMillion_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.vtItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 735);
            this.panel2.TabIndex = 1;
            // 
            // vtItems
            // 
            this.vtItems.Back2Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.vtItems.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vtItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vtItems.ButtonStyle = VirtualTreeView.ButtonStyle.bsRectangle;
            this.vtItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vtItems.Header.BackColor = System.Drawing.Color.White;
            virtualTreeColumn1.Alignment = System.Drawing.StringAlignment.Near;
            virtualTreeColumn1.CaptionAlignment = System.Drawing.StringAlignment.Near;
            virtualTreeColumn1.CaptionLineAlignment = System.Drawing.StringAlignment.Center;
            virtualTreeColumn1.LineAlignment = System.Drawing.StringAlignment.Center;
            virtualTreeColumn1.Name = "Num";
            virtualTreeColumn1.Width = 100;
            virtualTreeColumn2.Alignment = System.Drawing.StringAlignment.Near;
            virtualTreeColumn2.CaptionAlignment = System.Drawing.StringAlignment.Near;
            virtualTreeColumn2.CaptionLineAlignment = System.Drawing.StringAlignment.Center;
            virtualTreeColumn2.LineAlignment = System.Drawing.StringAlignment.Center;
            virtualTreeColumn2.Name = "Name";
            virtualTreeColumn2.Width = 300;
            this.vtItems.Header.Columns.Add(virtualTreeColumn1);
            this.vtItems.Header.Columns.Add(virtualTreeColumn2);
            this.vtItems.Header.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vtItems.Header.ForeColor = System.Drawing.Color.Black;
            this.vtItems.Header.Height = 16;
            this.vtItems.Header.Visible = true;
            this.vtItems.imageList = this.imageList1;
            this.vtItems.LineColor = System.Drawing.Color.Silver;
            this.vtItems.LineWidth = 1F;
            this.vtItems.Location = new System.Drawing.Point(0, 0);
            this.vtItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vtItems.Name = "vtItems";
            miscOptionHelper1.Editable = false;
            miscOptionHelper1.MultiSelect = false;
            this.vtItems.Options.Misc = miscOptionHelper1;
            paintOptionHelper1.Back2Color = true;
            paintOptionHelper1.FullVertGridLines = true;
            paintOptionHelper1.ShowButtons = true;
            paintOptionHelper1.ShowHorzGridLines = true;
            this.vtItems.Options.Paint = paintOptionHelper1;
            this.vtItems.ShowHint = true;
            this.vtItems.Size = new System.Drawing.Size(1013, 733);
            this.vtItems.TabIndex = 0;
            this.vtItems.OnGetNodeCellText += new VirtualTreeView.GetNodeCellText(this.vtItems_OnGetNodeCellText);
            this.vtItems.OnHeaderClick += new VirtualTreeView.HeaderClick(this.vtItems_OnHeaderClick);
            this.vtItems.OnCompareNode += new VirtualTreeView.CompareNode(this.vtItems_OnCompareNode);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "green.bmp");
            this.imageList1.Images.SetKeyName(1, "red.png");
            this.imageList1.Images.SetKeyName(2, "yellow.png");
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 783);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TestForm";
            this.Text = "Test application";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private VirtualTreeView.VirtualTreeView vtItems;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonMakeMillion;
    }
}

