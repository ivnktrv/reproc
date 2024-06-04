namespace reproc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(51, 9);
            label1.Margin = new Padding(12, 0, 12, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 128);
            label1.TabIndex = 0;
            label1.Text = ":(";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(28F, 63F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 179);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(12, 13, 12, 13);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
