
namespace ImageEditorFormApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.loadImageButton = new System.Windows.Forms.Button();
            this.boxOpen = new System.Windows.Forms.PictureBox();
            this.boxPreview = new System.Windows.Forms.PictureBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(140, 12);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(96, 43);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "Open Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // boxOpen
            // 
            this.boxOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxOpen.Location = new System.Drawing.Point(12, 90);
            this.boxOpen.Name = "boxOpen";
            this.boxOpen.Size = new System.Drawing.Size(353, 333);
            this.boxOpen.TabIndex = 2;
            this.boxOpen.TabStop = false;
            // 
            // boxPreview
            // 
            this.boxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPreview.Location = new System.Drawing.Point(401, 90);
            this.boxPreview.Name = "boxPreview";
            this.boxPreview.Size = new System.Drawing.Size(387, 333);
            this.boxPreview.TabIndex = 19;
            this.boxPreview.TabStop = false;
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(546, 12);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(96, 43);
            this.saveImageButton.TabIndex = 20;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.boxPreview);
            this.Controls.Add(this.boxOpen);
            this.Controls.Add(this.loadImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boxOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.PictureBox boxOpen;
        //private System.Windows.Forms.TextBox hueText;
        //private System.Windows.Forms.Label hueLabel;
        //private System.Windows.Forms.Label saturationLabel;
        //private System.Windows.Forms.TextBox saturationText;
        //private System.Windows.Forms.Label lightnessLabel;
        //private System.Windows.Forms.TextBox lightnessText;
        //private System.Windows.Forms.Label blueLabel;
        //private System.Windows.Forms.TextBox blueText;
        //private System.Windows.Forms.Label greenLabel;
        //private System.Windows.Forms.TextBox greenText;
        //private System.Windows.Forms.Label redLabel;
        //private System.Windows.Forms.TextBox redText;
        //private System.Windows.Forms.Label argbLabel;
        //private System.Windows.Forms.TextBox argbText;
        //private System.Windows.Forms.Label rgbLabel;
        //private System.Windows.Forms.TextBox rgbText;
        private System.Windows.Forms.PictureBox boxPreview;
        private System.Windows.Forms.Button saveImageButton;
    }
}

