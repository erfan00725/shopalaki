namespace shop
{
    partial class editForm
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
            editSubmit = new Button();
            SuspendLayout();
            // 
            // editSubmit
            // 
            editSubmit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            editSubmit.Location = new Point(275, 363);
            editSubmit.Name = "editSubmit";
            editSubmit.Size = new Size(128, 40);
            editSubmit.TabIndex = 0;
            editSubmit.Text = "تایید";
            editSubmit.UseVisualStyleBackColor = true;
            editSubmit.Click += editSubmit_Click;
            // 
            // editForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            ControlBox = false;
            Controls.Add(editSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "editForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit form";
            ResumeLayout(false);
        }

        #endregion

        private Button editSubmit;
    }
}