using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        public editForm(string[] inputs, Action<string[]> func, string[]? orginal)
        {
            InitializeComponent();

            this.inputs = inputs;

            for (int i = 0; i < inputs.Count(); i++)
            {
                editLabels.Add(new Label { Text = inputs[i], Location = new Point(labelsX, labeslY), Font = new Font("Segoe UI", 12) });

                editTextBoxes.Add(new TextBox { Font = new Font("Segoe UI", 10), Size = new Size(176, 23), Location = new Point(textBoxesX, textBoxesY) });

                if (!(orginal.Length < i + 1))
                {
                    editTextBoxes[i].Text = orginal[i];
                }

                labeslY += 50;
                textBoxesY += 50;


                this.Controls.Add(editLabels[i]);
                this.Controls.Add(editTextBoxes[i]);
            }

            exitAction = func;
            orginal = orginal;
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
