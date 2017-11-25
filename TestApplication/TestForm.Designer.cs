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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vtItems = new VirtualTreeView.VirtualTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTest2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.vtItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 637);
            this.panel2.TabIndex = 1;
            // 
            // vtItems
            // 
            this.vtItems.Back2Color = System.Drawing.SystemColors.ActiveCaption;
            this.vtItems.BackColor = System.Drawing.SystemColors.Control;
            this.vtItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vtItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vtItems.Header.BackColor = System.Drawing.Color.White;
            this.vtItems.Header.Columns = ((System.Collections.Generic.List<VirtualTreeView.VirtualTreeColumn>)(resources.GetObject("resource.Columns")));
            this.vtItems.Header.Font = new System.Drawing.Font("Tahoma", 8F);
            this.vtItems.Header.ForeColor = System.Drawing.Color.Black;
            this.vtItems.Header.Height = 16;
            this.vtItems.Header.Visible = true;
            this.vtItems.imageList = this.imageList1;
            this.vtItems.LineColor = System.Drawing.Color.Silver;
            this.vtItems.LineWidth = 1F;
            this.vtItems.Location = new System.Drawing.Point(0, 0);
            this.vtItems.Name = "vtItems";
            miscOptionHelper1.Editable = false;
            this.vtItems.Options.Misc = miscOptionHelper1;
            paintOptionHelper1.Back2Color = true;
            paintOptionHelper1.FullVertGridLines = true;
            paintOptionHelper1.ShowButtons = true;
            paintOptionHelper1.ShowHorzGridLines = true;
            this.vtItems.Options.Paint = paintOptionHelper1;
            this.vtItems.Size = new System.Drawing.Size(868, 635);
            this.vtItems.TabIndex = 0;
            this.vtItems.OnGetNodeCellText += new VirtualTreeView.GetNodeCellText(this.vtItems_OnGetNodeCellText);
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
            // buttonTest1
            // 
            this.buttonTest1.Location = new System.Drawing.Point(0, 0);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(165, 36);
            this.buttonTest1.TabIndex = 2;
            this.buttonTest1.Text = "Init with checkboxes and images";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(171, 0);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(141, 36);
            this.buttonTest2.TabIndex = 0;
            this.buttonTest2.Text = "Init with childrens";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 679);
            this.Controls.Add(this.buttonTest1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private VirtualTreeView.VirtualTreeView vtItems;
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonTest2;
    }
}

