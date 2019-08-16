namespace COMP123_S2019_Assignment5_300614352.Views
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.OSOutputLabel = new System.Windows.Forms.Label();
            this.WebCamOutputLabel = new System.Windows.Forms.Label();
            this.GPUTypeOutputLabel = new System.Windows.Forms.Label();
            this.HDDOutputLabel = new System.Windows.Forms.Label();
            this.MemoryOutputLabel = new System.Windows.Forms.Label();
            this.CPUBrandOutputLabel = new System.Windows.Forms.Label();
            this.CPUTypeOutputLabel = new System.Windows.Forms.Label();
            this.CPUSpeedOutputLabel = new System.Windows.Forms.Label();
            this.OrderFormLCDSizeOutputLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OSLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ModelOutputLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerOutputLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformOutputLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ConditionOutputLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Seperator = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalOutputLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxOutputLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceOutputLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.OrderFormPictureBox = new System.Windows.Forms.PictureBox();
            this.OrderFormPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(1008, 33);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.undoToolStripMenuItem.Text = "&Back";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(758, 640);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(116, 49);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(636, 640);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(116, 49);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(880, 640);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(116, 49);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemComponentsGroupBox.Controls.Add(this.OSOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormLCDSizeOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.panel1);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.shapeContainer1);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(12, 39);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(505, 650);
            this.SystemComponentsGroupBox.TabIndex = 4;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // OSOutputLabel
            // 
            this.OSOutputLabel.BackColor = System.Drawing.Color.White;
            this.OSOutputLabel.Location = new System.Drawing.Point(152, 576);
            this.OSOutputLabel.Name = "OSOutputLabel";
            this.OSOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.OSOutputLabel.TabIndex = 20;
            // 
            // WebCamOutputLabel
            // 
            this.WebCamOutputLabel.BackColor = System.Drawing.Color.White;
            this.WebCamOutputLabel.Location = new System.Drawing.Point(152, 521);
            this.WebCamOutputLabel.Name = "WebCamOutputLabel";
            this.WebCamOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.WebCamOutputLabel.TabIndex = 19;
            // 
            // GPUTypeOutputLabel
            // 
            this.GPUTypeOutputLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeOutputLabel.Location = new System.Drawing.Point(152, 474);
            this.GPUTypeOutputLabel.Name = "GPUTypeOutputLabel";
            this.GPUTypeOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.GPUTypeOutputLabel.TabIndex = 18;
            // 
            // HDDOutputLabel
            // 
            this.HDDOutputLabel.BackColor = System.Drawing.Color.White;
            this.HDDOutputLabel.Location = new System.Drawing.Point(152, 423);
            this.HDDOutputLabel.Name = "HDDOutputLabel";
            this.HDDOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.HDDOutputLabel.TabIndex = 17;
            // 
            // MemoryOutputLabel
            // 
            this.MemoryOutputLabel.BackColor = System.Drawing.Color.White;
            this.MemoryOutputLabel.Location = new System.Drawing.Point(152, 237);
            this.MemoryOutputLabel.Name = "MemoryOutputLabel";
            this.MemoryOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.MemoryOutputLabel.TabIndex = 15;
            // 
            // CPUBrandOutputLabel
            // 
            this.CPUBrandOutputLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandOutputLabel.Location = new System.Drawing.Point(152, 281);
            this.CPUBrandOutputLabel.Name = "CPUBrandOutputLabel";
            this.CPUBrandOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.CPUBrandOutputLabel.TabIndex = 14;
            // 
            // CPUTypeOutputLabel
            // 
            this.CPUTypeOutputLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeOutputLabel.Location = new System.Drawing.Point(152, 333);
            this.CPUTypeOutputLabel.Name = "CPUTypeOutputLabel";
            this.CPUTypeOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.CPUTypeOutputLabel.TabIndex = 13;
            // 
            // CPUSpeedOutputLabel
            // 
            this.CPUSpeedOutputLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedOutputLabel.Location = new System.Drawing.Point(152, 377);
            this.CPUSpeedOutputLabel.Name = "CPUSpeedOutputLabel";
            this.CPUSpeedOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.CPUSpeedOutputLabel.TabIndex = 12;
            // 
            // OrderFormLCDSizeOutputLabel
            // 
            this.OrderFormLCDSizeOutputLabel.BackColor = System.Drawing.Color.White;
            this.OrderFormLCDSizeOutputLabel.Location = new System.Drawing.Point(152, 195);
            this.OrderFormLCDSizeOutputLabel.Name = "OrderFormLCDSizeOutputLabel";
            this.OrderFormLCDSizeOutputLabel.Size = new System.Drawing.Size(335, 28);
            this.OrderFormLCDSizeOutputLabel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OSLabel);
            this.panel1.Controls.Add(this.WebCamLabel);
            this.panel1.Controls.Add(this.GPUTypeLabel);
            this.panel1.Controls.Add(this.HDDLabel);
            this.panel1.Controls.Add(this.MemoryLabel);
            this.panel1.Controls.Add(this.CPUBrandLabel);
            this.panel1.Controls.Add(this.CPUTypeLabel);
            this.panel1.Controls.Add(this.CPUSpeedLabel);
            this.panel1.Controls.Add(this.LCDSizeLabel);
            this.panel1.Location = new System.Drawing.Point(15, 181);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(131, 440);
            this.panel1.TabIndex = 10;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(71, 398);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(57, 36);
            this.OSLabel.TabIndex = 17;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(17, 343);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(137, 36);
            this.WebCamLabel.TabIndex = 16;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(9, 293);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(154, 36);
            this.GPUTypeLabel.TabIndex = 15;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(59, 245);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(78, 36);
            this.HDDLabel.TabIndex = 14;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(30, 59);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(121, 36);
            this.MemoryLabel.TabIndex = 13;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(2, 103);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(166, 36);
            this.CPUBrandLabel.TabIndex = 12;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(9, 155);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(152, 36);
            this.CPUTypeLabel.TabIndex = 11;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(3, 199);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(172, 36);
            this.CPUSpeedLabel.TabIndex = 10;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(17, 17);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(140, 36);
            this.LCDSizeLabel.TabIndex = 9;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelOutputLabel
            // 
            this.ModelOutputLabel.BackColor = System.Drawing.Color.White;
            this.ModelOutputLabel.Location = new System.Drawing.Point(358, 97);
            this.ModelOutputLabel.Name = "ModelOutputLabel";
            this.ModelOutputLabel.Size = new System.Drawing.Size(129, 25);
            this.ModelOutputLabel.TabIndex = 7;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(286, 97);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(97, 36);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Model";
            // 
            // ManufacturerOutputLabel
            // 
            this.ManufacturerOutputLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerOutputLabel.Location = new System.Drawing.Point(137, 97);
            this.ManufacturerOutputLabel.Name = "ManufacturerOutputLabel";
            this.ManufacturerOutputLabel.Size = new System.Drawing.Size(124, 25);
            this.ManufacturerOutputLabel.TabIndex = 5;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(10, 97);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(190, 36);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformOutputLabel
            // 
            this.PlatformOutputLabel.BackColor = System.Drawing.Color.White;
            this.PlatformOutputLabel.Location = new System.Drawing.Point(358, 47);
            this.PlatformOutputLabel.Name = "PlatformOutputLabel";
            this.PlatformOutputLabel.Size = new System.Drawing.Size(129, 25);
            this.PlatformOutputLabel.TabIndex = 3;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(269, 47);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(124, 36);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platfrom";
            // 
            // ConditionOutputLabel
            // 
            this.ConditionOutputLabel.BackColor = System.Drawing.Color.White;
            this.ConditionOutputLabel.Location = new System.Drawing.Point(134, 47);
            this.ConditionOutputLabel.Name = "ConditionOutputLabel";
            this.ConditionOutputLabel.Size = new System.Drawing.Size(127, 25);
            this.ConditionOutputLabel.TabIndex = 1;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(33, 47);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(143, 36);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 37);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Seperator});
            this.shapeContainer1.Size = new System.Drawing.Size(499, 610);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // Seperator
            // 
            this.Seperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Seperator.BorderColor = System.Drawing.Color.White;
            this.Seperator.BorderWidth = 3;
            this.Seperator.Name = "Seperator";
            this.Seperator.X1 = 0;
            this.Seperator.X2 = 498;
            this.Seperator.Y1 = 129;
            this.Seperator.Y2 = 129;
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalOutputLabel);
            this.YourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxOutputLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceOutputLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(552, 340);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(444, 282);
            this.YourPriceGroupBox.TabIndex = 5;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // TotalOutputLabel
            // 
            this.TotalOutputLabel.BackColor = System.Drawing.Color.White;
            this.TotalOutputLabel.Location = new System.Drawing.Point(245, 210);
            this.TotalOutputLabel.Name = "TotalOutputLabel";
            this.TotalOutputLabel.Size = new System.Drawing.Size(173, 35);
            this.TotalOutputLabel.TabIndex = 5;
            this.TotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(27, 220);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(81, 36);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total";
            // 
            // SalesTaxOutputLabel
            // 
            this.SalesTaxOutputLabel.BackColor = System.Drawing.Color.White;
            this.SalesTaxOutputLabel.Location = new System.Drawing.Point(245, 124);
            this.SalesTaxOutputLabel.Name = "SalesTaxOutputLabel";
            this.SalesTaxOutputLabel.Size = new System.Drawing.Size(173, 35);
            this.SalesTaxOutputLabel.TabIndex = 3;
            this.SalesTaxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(27, 134);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(235, 36);
            this.SalesTaxLabel.TabIndex = 2;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // PriceOutputLabel
            // 
            this.PriceOutputLabel.BackColor = System.Drawing.Color.White;
            this.PriceOutputLabel.Location = new System.Drawing.Point(243, 47);
            this.PriceOutputLabel.Name = "PriceOutputLabel";
            this.PriceOutputLabel.Size = new System.Drawing.Size(173, 35);
            this.PriceOutputLabel.TabIndex = 1;
            this.PriceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(25, 57);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(83, 36);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // OrderFormPictureBox
            // 
            this.OrderFormPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderFormPictureBox.Location = new System.Drawing.Point(552, 34);
            this.OrderFormPictureBox.Name = "OrderFormPictureBox";
            this.OrderFormPictureBox.Size = new System.Drawing.Size(444, 300);
            this.OrderFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OrderFormPictureBox.TabIndex = 6;
            this.OrderFormPictureBox.TabStop = false;
            // 
            // OrderFormPrintForm
            // 
            this.OrderFormPrintForm.DocumentName = "document";
            this.OrderFormPrintForm.Form = this;
            this.OrderFormPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.OrderFormPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("OrderFormPrintForm.PrinterSettings")));
            this.OrderFormPrintForm.PrintFileName = null;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 701);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormPictureBox);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label ModelOutputLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerOutputLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformOutputLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ConditionOutputLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.PictureBox OrderFormPictureBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape Seperator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label OSOutputLabel;
        private System.Windows.Forms.Label WebCamOutputLabel;
        private System.Windows.Forms.Label GPUTypeOutputLabel;
        private System.Windows.Forms.Label HDDOutputLabel;
        private System.Windows.Forms.Label MemoryOutputLabel;
        private System.Windows.Forms.Label CPUBrandOutputLabel;
        private System.Windows.Forms.Label CPUTypeOutputLabel;
        private System.Windows.Forms.Label CPUSpeedOutputLabel;
        private System.Windows.Forms.Label OrderFormLCDSizeOutputLabel;
        private System.Windows.Forms.Label TotalOutputLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxOutputLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceOutputLabel;
        private System.Windows.Forms.Label PriceLabel;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm OrderFormPrintForm;
    }
}