namespace praktikum_w7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tShirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longPantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jewelleriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data = new System.Windows.Forms.DataGridView();
            this.listTshirt = new System.Windows.Forms.ImageList(this.components);
            this.listshirt = new System.Windows.Forms.ImageList(this.components);
            this.listshorts = new System.Windows.Forms.ImageList(this.components);
            this.listlongpants = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listperhiasan = new System.Windows.Forms.ImageList(this.components);
            this.listsepatu = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.topToolStripMenuItem,
            this.bottomToolStripMenuItem,
            this.accessoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tShirtToolStripMenuItem,
            this.shirtToolStripMenuItem});
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.topToolStripMenuItem.Text = "Top";
            // 
            // tShirtToolStripMenuItem
            // 
            this.tShirtToolStripMenuItem.Name = "tShirtToolStripMenuItem";
            this.tShirtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tShirtToolStripMenuItem.Text = "T-Shirt";
            this.tShirtToolStripMenuItem.Click += new System.EventHandler(this.tShirtToolStripMenuItem_Click);
            // 
            // shirtToolStripMenuItem
            // 
            this.shirtToolStripMenuItem.Name = "shirtToolStripMenuItem";
            this.shirtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shirtToolStripMenuItem.Text = "Shirt";
            this.shirtToolStripMenuItem.Click += new System.EventHandler(this.shirtToolStripMenuItem_Click);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortsToolStripMenuItem,
            this.longPantsToolStripMenuItem});
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.bottomToolStripMenuItem.Text = "Bottom";
            // 
            // shortsToolStripMenuItem
            // 
            this.shortsToolStripMenuItem.Name = "shortsToolStripMenuItem";
            this.shortsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shortsToolStripMenuItem.Text = "Shorts";
            this.shortsToolStripMenuItem.Click += new System.EventHandler(this.shortsToolStripMenuItem_Click);
            // 
            // longPantsToolStripMenuItem
            // 
            this.longPantsToolStripMenuItem.Name = "longPantsToolStripMenuItem";
            this.longPantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.longPantsToolStripMenuItem.Text = "Long Pants";
            this.longPantsToolStripMenuItem.Click += new System.EventHandler(this.longPantsToolStripMenuItem_Click);
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jewelleriesToolStripMenuItem,
            this.shoesToolStripMenuItem});
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.accessoriesToolStripMenuItem.Text = "Accessories";
            // 
            // jewelleriesToolStripMenuItem
            // 
            this.jewelleriesToolStripMenuItem.Name = "jewelleriesToolStripMenuItem";
            this.jewelleriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jewelleriesToolStripMenuItem.Text = "Jewelleries";
            this.jewelleriesToolStripMenuItem.Click += new System.EventHandler(this.jewelleriesToolStripMenuItem_Click);
            // 
            // shoesToolStripMenuItem
            // 
            this.shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            this.shoesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shoesToolStripMenuItem.Text = "Shoes";
            this.shoesToolStripMenuItem.Click += new System.EventHandler(this.shoesToolStripMenuItem_Click);
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(500, 28);
            this.data.Name = "data";
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(380, 173);
            this.data.TabIndex = 3;
            // 
            // listTshirt
            // 
            this.listTshirt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listTshirt.ImageStream")));
            this.listTshirt.TransparentColor = System.Drawing.Color.Transparent;
            this.listTshirt.Images.SetKeyName(0, "usgoods_55_455365.jpeg");
            this.listTshirt.Images.SetKeyName(1, "usgoods_56_422992.jpeg");
            this.listTshirt.Images.SetKeyName(2, "usgoods_68_456772.jpeg");
            // 
            // listshirt
            // 
            this.listshirt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listshirt.ImageStream")));
            this.listshirt.TransparentColor = System.Drawing.Color.Transparent;
            this.listshirt.Images.SetKeyName(0, "usgoods_09_458065.jpeg");
            this.listshirt.Images.SetKeyName(1, "usgoods_52_445174.jpeg");
            this.listshirt.Images.SetKeyName(2, "usgoods_61_455957.jpeg");
            // 
            // listshorts
            // 
            this.listshorts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listshorts.ImageStream")));
            this.listshorts.TransparentColor = System.Drawing.Color.Transparent;
            this.listshorts.Images.SetKeyName(0, "goods_455534_sub17.jpeg");
            this.listshorts.Images.SetKeyName(1, "goods_458245_sub14.jpeg");
            this.listshorts.Images.SetKeyName(2, "goods_458404_sub14.jpeg");
            // 
            // listlongpants
            // 
            this.listlongpants.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listlongpants.ImageStream")));
            this.listlongpants.TransparentColor = System.Drawing.Color.Transparent;
            this.listlongpants.Images.SetKeyName(0, "goods_455938_sub11.jpeg");
            this.listlongpants.Images.SetKeyName(1, "goods_456194_sub11.jpeg");
            this.listlongpants.Images.SetKeyName(2, "goods_456519_sub14.jpeg");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 421);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sub -Total :";
            // 
            // listperhiasan
            // 
            this.listperhiasan.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listperhiasan.ImageStream")));
            this.listperhiasan.TransparentColor = System.Drawing.Color.Transparent;
            this.listperhiasan.Images.SetKeyName(0, "gmbr1.jpg");
            this.listperhiasan.Images.SetKeyName(1, "gmbr2.jpg");
            this.listperhiasan.Images.SetKeyName(2, "gmb3.jpg");
            // 
            // listsepatu
            // 
            this.listsepatu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listsepatu.ImageStream")));
            this.listsepatu.TransparentColor = System.Drawing.Color.Transparent;
            this.listsepatu.Images.SetKeyName(0, "blackshoes.jpg");
            this.listsepatu.Images.SetKeyName(1, "blueshoes.jpg");
            this.listsepatu.Images.SetKeyName(2, "redshoes.jpg");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total         :";
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Location = new System.Drawing.Point(569, 214);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(13, 13);
            this.sub.TabIndex = 7;
            this.sub.Text = "0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(569, 238);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(13, 13);
            this.total.TabIndex = 8;
            this.total.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 517);
            this.Controls.Add(this.total);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tShirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longPantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jewelleriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoesToolStripMenuItem;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ImageList listTshirt;
        private System.Windows.Forms.ImageList listshirt;
        private System.Windows.Forms.ImageList listshorts;
        private System.Windows.Forms.ImageList listlongpants;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList listperhiasan;
        private System.Windows.Forms.ImageList listsepatu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Label total;
    }
}

