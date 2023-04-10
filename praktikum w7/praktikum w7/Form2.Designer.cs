namespace praktikum_w7
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listgmbr = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listgmbr
            // 
            this.listgmbr.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listgmbr.ImageStream")));
            this.listgmbr.TransparentColor = System.Drawing.Color.Transparent;
            this.listgmbr.Images.SetKeyName(0, "usgoods_55_455365.jpeg");
            this.listgmbr.Images.SetKeyName(1, "usgoods_56_422992.jpeg");
            this.listgmbr.Images.SetKeyName(2, "usgoods_68_456772.jpeg");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList listgmbr;
    }
}