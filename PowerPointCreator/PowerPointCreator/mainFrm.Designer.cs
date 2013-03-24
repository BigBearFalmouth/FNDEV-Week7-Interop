namespace PowerPointCreator
{
    partial class mainFrm
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
            this.createTitleSlideBtn = new System.Windows.Forms.Button();
            this.createPresentationBtn = new System.Windows.Forms.Button();
            this.addTextSlideBtn = new System.Windows.Forms.Button();
            this.addPicSlideBtn = new System.Windows.Forms.Button();
            this.savePresentationBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // createTitleSlideBtn
            // 
            this.createTitleSlideBtn.Location = new System.Drawing.Point(129, 12);
            this.createTitleSlideBtn.Name = "createTitleSlideBtn";
            this.createTitleSlideBtn.Size = new System.Drawing.Size(102, 47);
            this.createTitleSlideBtn.TabIndex = 0;
            this.createTitleSlideBtn.Text = "Create Title Slide";
            this.createTitleSlideBtn.UseVisualStyleBackColor = true;
            this.createTitleSlideBtn.Click += new System.EventHandler(this.createTitleSlideBtn_Click);
            // 
            // createPresentationBtn
            // 
            this.createPresentationBtn.Location = new System.Drawing.Point(12, 12);
            this.createPresentationBtn.Name = "createPresentationBtn";
            this.createPresentationBtn.Size = new System.Drawing.Size(102, 47);
            this.createPresentationBtn.TabIndex = 1;
            this.createPresentationBtn.Text = "Create Presentation";
            this.createPresentationBtn.UseVisualStyleBackColor = true;
            this.createPresentationBtn.Click += new System.EventHandler(this.createPresentationBtn_Click);
            // 
            // addTextSlideBtn
            // 
            this.addTextSlideBtn.Location = new System.Drawing.Point(249, 12);
            this.addTextSlideBtn.Name = "addTextSlideBtn";
            this.addTextSlideBtn.Size = new System.Drawing.Size(102, 47);
            this.addTextSlideBtn.TabIndex = 2;
            this.addTextSlideBtn.Text = "Add Text Slide";
            this.addTextSlideBtn.UseVisualStyleBackColor = true;
            this.addTextSlideBtn.Click += new System.EventHandler(this.addTextSlideBtn_Click);
            // 
            // addPicSlideBtn
            // 
            this.addPicSlideBtn.Location = new System.Drawing.Point(373, 12);
            this.addPicSlideBtn.Name = "addPicSlideBtn";
            this.addPicSlideBtn.Size = new System.Drawing.Size(102, 47);
            this.addPicSlideBtn.TabIndex = 3;
            this.addPicSlideBtn.Text = "Add Picture Slide";
            this.addPicSlideBtn.UseVisualStyleBackColor = true;
            this.addPicSlideBtn.Click += new System.EventHandler(this.addPicSlideBtn_Click);
            // 
            // savePresentationBtn
            // 
            this.savePresentationBtn.Location = new System.Drawing.Point(198, 96);
            this.savePresentationBtn.Name = "savePresentationBtn";
            this.savePresentationBtn.Size = new System.Drawing.Size(102, 47);
            this.savePresentationBtn.TabIndex = 4;
            this.savePresentationBtn.Text = "Save Presentation";
            this.savePresentationBtn.UseVisualStyleBackColor = true;
            this.savePresentationBtn.Click += new System.EventHandler(this.savePresentationBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Powerpoint files|*.ppt";
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 155);
            this.Controls.Add(this.savePresentationBtn);
            this.Controls.Add(this.addPicSlideBtn);
            this.Controls.Add(this.addTextSlideBtn);
            this.Controls.Add(this.createPresentationBtn);
            this.Controls.Add(this.createTitleSlideBtn);
            this.Name = "mainFrm";
            this.Text = "Powerpoint Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createTitleSlideBtn;
        private System.Windows.Forms.Button createPresentationBtn;
        private System.Windows.Forms.Button addTextSlideBtn;
        private System.Windows.Forms.Button addPicSlideBtn;
        private System.Windows.Forms.Button savePresentationBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

