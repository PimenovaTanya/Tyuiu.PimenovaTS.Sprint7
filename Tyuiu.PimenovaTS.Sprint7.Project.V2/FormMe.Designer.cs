
namespace Tyuiu.PimenovaTS.Sprint7.Project.V2
{
    partial class FormMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMe));
            this.labelInfo_PTS = new System.Windows.Forms.Label();
            this.pictureBoxMe_PTS = new System.Windows.Forms.PictureBox();
            this.buttonOK_PTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_PTS
            // 
            this.labelInfo_PTS.AutoSize = true;
            this.labelInfo_PTS.Location = new System.Drawing.Point(221, 9);
            this.labelInfo_PTS.Name = "labelInfo_PTS";
            this.labelInfo_PTS.Size = new System.Drawing.Size(340, 153);
            this.labelInfo_PTS.TabIndex = 0;
            this.labelInfo_PTS.Text = resources.GetString("labelInfo_PTS.Text");
            // 
            // pictureBoxMe_PTS
            // 
            this.pictureBoxMe_PTS.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxMe_PTS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_PTS.Image")));
            this.pictureBoxMe_PTS.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMe_PTS.Name = "pictureBoxMe_PTS";
            this.pictureBoxMe_PTS.Size = new System.Drawing.Size(215, 288);
            this.pictureBoxMe_PTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMe_PTS.TabIndex = 1;
            this.pictureBoxMe_PTS.TabStop = false;
            // 
            // buttonOK_PTS
            // 
            this.buttonOK_PTS.Location = new System.Drawing.Point(441, 241);
            this.buttonOK_PTS.Name = "buttonOK_PTS";
            this.buttonOK_PTS.Size = new System.Drawing.Size(113, 35);
            this.buttonOK_PTS.TabIndex = 2;
            this.buttonOK_PTS.Text = "OK";
            this.buttonOK_PTS.UseVisualStyleBackColor = true;
            this.buttonOK_PTS.Click += new System.EventHandler(this.buttonOK_PTS_Click);
            // 
            // FormMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 288);
            this.Controls.Add(this.buttonOK_PTS);
            this.Controls.Add(this.pictureBoxMe_PTS);
            this.Controls.Add(this.labelInfo_PTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_PTS;
        private System.Windows.Forms.PictureBox pictureBoxMe_PTS;
        private System.Windows.Forms.Button buttonOK_PTS;
    }
}