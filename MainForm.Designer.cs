namespace ContactList
{
    partial class MainForm
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
            this.btnthemlienhe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthemlienhe
            // 
            this.btnthemlienhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemlienhe.ForeColor = System.Drawing.Color.IndianRed;
            this.btnthemlienhe.Location = new System.Drawing.Point(233, 174);
            this.btnthemlienhe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthemlienhe.Name = "btnthemlienhe";
            this.btnthemlienhe.Size = new System.Drawing.Size(161, 54);
            this.btnthemlienhe.TabIndex = 0;
            this.btnthemlienhe.Text = "Thêm liên hệ";
            this.btnthemlienhe.UseVisualStyleBackColor = true;
            this.btnthemlienhe.Click += new System.EventHandler(this.btnthemlienhe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(206, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách liên hệ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthemlienhe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthemlienhe;
        private System.Windows.Forms.Label label1;
    }
}

