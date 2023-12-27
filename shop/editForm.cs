using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class editForm : Form
    {
        private List<TextBox> editTextBoxes = new List<TextBox> { };
        private List<Label> editLabels = new List<Label> { };

        private int textBoxesX = 454;
        private int textBoxesY = 67;

        private int labelsX = 278;
        private int labeslY = 66;

        public editForm(string[] inputs)
        {
            InitializeComponent();
            int index = 0;
            foreach (var item in inputs)
            {
                editLabels.Add(new Label { Text = item, Location = new Point(labelsX, labeslY), Font = new Font("Segoe UI", 12) });

                editTextBoxes.Add(new TextBox { Font = new Font("Segoe UI", 10), Size = new Size(176, 23), Location = new Point(textBoxesX , textBoxesY) });

                labeslY += 50;
                textBoxesY += 50;


                this.Controls.Add(editLabels[index]);
                this.Controls.Add(editTextBoxes[index]);

                index++;
            }
        }

        private void editSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
