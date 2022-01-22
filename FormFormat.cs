using FontAwesome.Sharp;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace NetsiFlat
{
    public class FormFormat
    {
        public void HighlightSaveBtn(IconButton senderBtn)
        {
            senderBtn.BackColor = Color.FromArgb(46, 51, 73);
            senderBtn.IconColor = Color.Tomato;
            senderBtn.ForeColor = Color.Tomato;
            senderBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            senderBtn.IconSize = 50;
        }

        public void DeHighlightSaveBtn(IconButton senderBtn)
        {
            senderBtn.BackColor = Color.FromArgb(41, 48, 82);
            senderBtn.IconColor = Color.AliceBlue;
            senderBtn.ForeColor = Color.AliceBlue;
            senderBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            senderBtn.IconSize = 40;
        }

        public void EnterTextBox(string text, TextBox textBox, Panel panelName, params Label[] lableName)
        {
            if (textBox.Text == text)
            {
                int span = 8;
                int size = 12;

                textBox.Text = "";
                textBox.ForeColor = Color.Gainsboro;
                panelName.Size = new Size(0, 1);
                panelName.Visible = true;

                for (int i = 12; i <= 240; i += size)
                {
                    panelName.Size = new Size(i, 1);
                    Thread.Sleep(span);
                }

                foreach (Label item in lableName)
                {
                    item.Visible = false;
                }
            }
        }

        public void LeaveTextBox(string text, TextBox textBox, Panel panelName)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Gray;
                panelName.Visible = false;
            }
        }

        public void ResetTextBox(string text, TextBox textBox, Panel panelName)
        {
            textBox.Text = text;
            textBox.ForeColor = Color.Gray;
            panelName.Visible = false;
        }

        public void HighlightBtn(IconButton senderBtn, Color color)
        {
            senderBtn.BackColor = color;
            senderBtn.ForeColor = Color.Tomato;
            senderBtn.IconColor = Color.Tomato;
            senderBtn.TextAlign = ContentAlignment.MiddleCenter;
            senderBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            senderBtn.ImageAlign = ContentAlignment.MiddleRight;
            senderBtn.IconSize = 30;
        }

        public void DeHighlightBtn(IconButton senderBtn)
        {
            senderBtn.BackColor = Color.FromArgb(72, 82, 125);
            senderBtn.ForeColor = Color.Black;
            senderBtn.IconColor = Color.Black;
            senderBtn.TextAlign = ContentAlignment.MiddleCenter;
            senderBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            senderBtn.ImageAlign = ContentAlignment.BottomLeft;
            senderBtn.IconSize = 25;
        }

        public void Search(TextBox txt, AutoCompleteStringCollection strc)
        {
            txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt.AutoCompleteCustomSource = strc;
        }

        public int Index(string word, DataGridView dgv)
        {
            int index = 0;

            if (dgv.Rows.Count == 0)
            {
                throw new System.IndexOutOfRangeException();
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (word == dgv.Rows[i].Cells[1].Value.ToString())
                {
                    index = i;
                    return index;
                }
            }

            return index;
        }
    }
}
