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

        private string[] inputs;

        private int textBoxesX = 454;
        private int textBoxesY = 67;

        private int labelsX = 278;
        private int labeslY = 66;

        private Action<string[]> exitAction;

        public editForm(string[] inputs, Action<string[]> func)
        {
            InitializeComponent();

            this.inputs = inputs;

            int index = 0;
            foreach (var item in inputs)
            {
                editLabels.Add(new Label { Text = item, Location = new Point(labelsX, labeslY), Font = new Font("Segoe UI", 12) });

                editTextBoxes.Add(new TextBox { Font = new Font("Segoe UI", 10), Size = new Size(176, 23), Location = new Point(textBoxesX, textBoxesY) });

                labeslY += 50;
                textBoxesY += 50;


                this.Controls.Add(editLabels[index]);
                this.Controls.Add(editTextBoxes[index]);

                index++;
            }

            exitAction = func;
        }

        public string[] getEdits()
        {
            List<string> edits = new List<string>();

            foreach (var item in this.editTextBoxes)
            {
                edits.Add(item.Text);
            }

            return edits.ToArray();
        }

        private void editSubmit_Click(object sender, EventArgs e)
        {

            bool arrayEmpty = false;

            foreach (var item in this.editTextBoxes)
            {
                if (item.Text == "")
                {
                    arrayEmpty = true;
                }
            }
            if (!arrayEmpty)
            {
                exitAction(this.getEdits());

                this.Close();
            }
        }
    }
}
