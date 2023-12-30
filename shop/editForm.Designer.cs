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
            button1 = new Button();
            SuspendLayout();
            // 
            // editSubmit
            // 
            editSubmit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            editSubmit.Location = new Point(406, 496);
            editSubmit.Margin = new Padding(3, 4, 3, 4);
            editSubmit.Name = "editSubmit";
            editSubmit.Size = new Size(146, 53);
            editSubmit.TabIndex = 0;
            editSubmit.Text = "تایید";
            editSubmit.UseVisualStyleBackColor = true;
            editSubmit.Click += editSubmit_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(222, 496);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 53);
            button1.TabIndex = 0;
            button1.Text = "لغو";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // editForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 600);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(editSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "editForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit form";
            ResumeLayout(false);
        }

        #endregion

        private Button editSubmit;
        private Button button1;
    }
}