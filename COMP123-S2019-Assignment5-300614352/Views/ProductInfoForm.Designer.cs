namespace COMP123_S2019_Assignment5_300614352.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductInfoFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDOutputLabel = new System.Windows.Forms.Label();
            this.ConditionOutputLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.PriceOutputLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelOutputLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerOutputLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OSOutputLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatFormOutputLabel = new System.Windows.Forms.Label();
            this.PlatFormLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryOutputLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamOutputLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeOutputLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDOutputLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedOutputLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUBrandOutputLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeOutputLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.LCDSizeOutputLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUnumberOutputLabel = new System.Windows.Forms.Label();
            this.CPUnumberLabel = new System.Windows.Forms.Label();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductInfoFormOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoFormSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProductInfoFormMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoFormMenuStrip
            // 
            this.ProductInfoFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ProductInfoFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ProductInfoFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoFormMenuStrip.Name = "ProductInfoFormMenuStrip";
            this.ProductInfoFormMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.ProductInfoFormMenuStrip.TabIndex = 0;
            this.ProductInfoFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.helpToolStripMenuItem.Text = "&Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aboutToolStripMenuItem.Text = "&Select Another Product";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(45, 69);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(103, 25);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductIDOutputLabel
            // 
            this.ProductIDOutputLabel.BackColor = System.Drawing.Color.White;
            this.ProductIDOutputLabel.Location = new System.Drawing.Point(154, 69);
            this.ProductIDOutputLabel.Name = "ProductIDOutputLabel";
            this.ProductIDOutputLabel.Size = new System.Drawing.Size(142, 25);
            this.ProductIDOutputLabel.TabIndex = 3;
            // 
            // ConditionOutputLabel
            // 
            this.ConditionOutputLabel.BackColor = System.Drawing.Color.White;
            this.ConditionOutputLabel.Location = new System.Drawing.Point(476, 69);
            this.ConditionOutputLabel.Name = "ConditionOutputLabel";
            this.ConditionOutputLabel.Size = new System.Drawing.Size(142, 25);
            this.ConditionOutputLabel.TabIndex = 5;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(375, 69);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(95, 25);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition";
            // 
            // PriceOutputLabel
            // 
            this.PriceOutputLabel.BackColor = System.Drawing.Color.White;
            this.PriceOutputLabel.Location = new System.Drawing.Point(768, 69);
            this.PriceOutputLabel.Name = "PriceOutputLabel";
            this.PriceOutputLabel.Size = new System.Drawing.Size(142, 25);
            this.PriceOutputLabel.TabIndex = 7;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(706, 69);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 25);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelOutputLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerOutputLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSOutputLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatFormOutputLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatFormLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(50, 128);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(909, 191);
            this.ProductInfoGroupBox.TabIndex = 8;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelOutputLabel
            // 
            this.ModelOutputLabel.BackColor = System.Drawing.Color.White;
            this.ModelOutputLabel.Location = new System.Drawing.Point(477, 123);
            this.ModelOutputLabel.Name = "ModelOutputLabel";
            this.ModelOutputLabel.Size = new System.Drawing.Size(357, 25);
            this.ModelOutputLabel.TabIndex = 11;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(405, 123);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(66, 25);
            this.ModelLabel.TabIndex = 10;
            this.ModelLabel.Text = "Model";
            // 
            // ManufacturerOutputLabel
            // 
            this.ManufacturerOutputLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerOutputLabel.Location = new System.Drawing.Point(149, 123);
            this.ManufacturerOutputLabel.Name = "ManufacturerOutputLabel";
            this.ManufacturerOutputLabel.Size = new System.Drawing.Size(271, 25);
            this.ManufacturerOutputLabel.TabIndex = 9;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(16, 123);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(127, 25);
            this.ManufacturerLabel.TabIndex = 8;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // OSOutputLabel
            // 
            this.OSOutputLabel.BackColor = System.Drawing.Color.White;
            this.OSOutputLabel.Location = new System.Drawing.Point(477, 63);
            this.OSOutputLabel.Name = "OSOutputLabel";
            this.OSOutputLabel.Size = new System.Drawing.Size(357, 25);
            this.OSOutputLabel.TabIndex = 7;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(429, 63);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(42, 25);
            this.OSLabel.TabIndex = 6;
            this.OSLabel.Text = "OS";
            // 
            // PlatFormOutputLabel
            // 
            this.PlatFormOutputLabel.BackColor = System.Drawing.Color.White;
            this.PlatFormOutputLabel.Location = new System.Drawing.Point(149, 63);
            this.PlatFormOutputLabel.Name = "PlatFormOutputLabel";
            this.PlatFormOutputLabel.Size = new System.Drawing.Size(271, 25);
            this.PlatFormOutputLabel.TabIndex = 5;
            // 
            // PlatFormLabel
            // 
            this.PlatFormLabel.AutoSize = true;
            this.PlatFormLabel.Location = new System.Drawing.Point(60, 63);
            this.PlatFormLabel.Name = "PlatFormLabel";
            this.PlatFormLabel.Size = new System.Drawing.Size(83, 25);
            this.PlatFormLabel.TabIndex = 4;
            this.PlatFormLabel.Text = "Platform";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(48, 52);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(83, 25);
            this.MemoryLabel.TabIndex = 4;
            this.MemoryLabel.Text = "Memory";
            // 
            // MemoryOutputLabel
            // 
            this.MemoryOutputLabel.BackColor = System.Drawing.Color.White;
            this.MemoryOutputLabel.Location = new System.Drawing.Point(137, 52);
            this.MemoryOutputLabel.Name = "MemoryOutputLabel";
            this.MemoryOutputLabel.Size = new System.Drawing.Size(120, 25);
            this.MemoryOutputLabel.TabIndex = 5;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebCamOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUnumberOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUnumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryOutputLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(50, 366);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(909, 239);
            this.TechSpecsGroupBox.TabIndex = 9;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebCamOutputLabel
            // 
            this.WebCamOutputLabel.BackColor = System.Drawing.Color.White;
            this.WebCamOutputLabel.Location = new System.Drawing.Point(603, 178);
            this.WebCamOutputLabel.Name = "WebCamOutputLabel";
            this.WebCamOutputLabel.Size = new System.Drawing.Size(269, 25);
            this.WebCamOutputLabel.TabIndex = 21;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(501, 178);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(96, 25);
            this.WebCamLabel.TabIndex = 20;
            this.WebCamLabel.Text = "WebCam";
            // 
            // GPUTypeOutputLabel
            // 
            this.GPUTypeOutputLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeOutputLabel.Location = new System.Drawing.Point(603, 108);
            this.GPUTypeOutputLabel.Name = "GPUTypeOutputLabel";
            this.GPUTypeOutputLabel.Size = new System.Drawing.Size(269, 25);
            this.GPUTypeOutputLabel.TabIndex = 19;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(493, 108);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(104, 25);
            this.GPUTypeLabel.TabIndex = 18;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDOutputLabel
            // 
            this.HDDOutputLabel.BackColor = System.Drawing.Color.White;
            this.HDDOutputLabel.Location = new System.Drawing.Point(603, 52);
            this.HDDOutputLabel.Name = "HDDOutputLabel";
            this.HDDOutputLabel.Size = new System.Drawing.Size(269, 25);
            this.HDDOutputLabel.TabIndex = 17;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(543, 52);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(54, 25);
            this.HDDLabel.TabIndex = 16;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedOutputLabel
            // 
            this.CPUSpeedOutputLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedOutputLabel.Location = new System.Drawing.Point(387, 178);
            this.CPUSpeedOutputLabel.Name = "CPUSpeedOutputLabel";
            this.CPUSpeedOutputLabel.Size = new System.Drawing.Size(108, 25);
            this.CPUSpeedOutputLabel.TabIndex = 15;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(264, 178);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(117, 25);
            this.CPUSpeedLabel.TabIndex = 14;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUBrandOutputLabel
            // 
            this.CPUBrandOutputLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandOutputLabel.Location = new System.Drawing.Point(137, 108);
            this.CPUBrandOutputLabel.Name = "CPUBrandOutputLabel";
            this.CPUBrandOutputLabel.Size = new System.Drawing.Size(120, 25);
            this.CPUBrandOutputLabel.TabIndex = 13;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(20, 108);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(111, 25);
            this.CPUBrandLabel.TabIndex = 12;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // CPUTypeOutputLabel
            // 
            this.CPUTypeOutputLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeOutputLabel.Location = new System.Drawing.Point(137, 178);
            this.CPUTypeOutputLabel.Name = "CPUTypeOutputLabel";
            this.CPUTypeOutputLabel.Size = new System.Drawing.Size(120, 25);
            this.CPUTypeOutputLabel.TabIndex = 11;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(20, 178);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(104, 25);
            this.CPUTypeLabel.TabIndex = 10;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // LCDSizeOutputLabel
            // 
            this.LCDSizeOutputLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeOutputLabel.Location = new System.Drawing.Point(384, 53);
            this.LCDSizeOutputLabel.Name = "LCDSizeOutputLabel";
            this.LCDSizeOutputLabel.Size = new System.Drawing.Size(107, 25);
            this.LCDSizeOutputLabel.TabIndex = 9;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(282, 52);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(96, 25);
            this.LCDSizeLabel.TabIndex = 8;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUnumberOutputLabel
            // 
            this.CPUnumberOutputLabel.BackColor = System.Drawing.Color.White;
            this.CPUnumberOutputLabel.Location = new System.Drawing.Point(389, 108);
            this.CPUnumberOutputLabel.Name = "CPUnumberOutputLabel";
            this.CPUnumberOutputLabel.Size = new System.Drawing.Size(112, 25);
            this.CPUnumberOutputLabel.TabIndex = 7;
            // 
            // CPUnumberLabel
            // 
            this.CPUnumberLabel.AutoSize = true;
            this.CPUnumberLabel.Location = new System.Drawing.Point(263, 108);
            this.CPUnumberLabel.Name = "CPUnumberLabel";
            this.CPUnumberLabel.Size = new System.Drawing.Size(125, 25);
            this.CPUnumberLabel.TabIndex = 6;
            this.CPUnumberLabel.Text = "CPU number";
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(460, 631);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(224, 48);
            this.SelectAnotherProductButton.TabIndex = 10;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(711, 631);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 48);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(847, 631);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(112, 48);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Click Next to Confirm Your Selection";
            // 
            // ProductInfoFormOpenFileDialog
            // 
            this.ProductInfoFormOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1008, 701);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.PriceOutputLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ConditionOutputLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDOutputLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductInfoFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ProductInfoFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoFormMenuStrip.ResumeLayout(false);
            this.ProductInfoFormMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductIDOutputLabel;
        private System.Windows.Forms.Label ConditionOutputLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label PriceOutputLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelOutputLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerOutputLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label OSOutputLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label PlatFormOutputLabel;
        private System.Windows.Forms.Label PlatFormLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label MemoryOutputLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label WebCamOutputLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeOutputLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDOutputLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedOutputLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUBrandOutputLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeOutputLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label LCDSizeOutputLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUnumberOutputLabel;
        private System.Windows.Forms.Label CPUnumberLabel;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ProductInfoFormOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductInfoFormSaveFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}