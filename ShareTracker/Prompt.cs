using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareTracker
{
    public static class Prompt
    {
        public static string ShowAddCategoryDialog(string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 50, Top = 25, Width = 200 };
            Button confirmation = new Button() { Text = "Add", Left = 100, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }


        public static string ShowRemoveCategoryDialog(string caption, List<string> items)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            ComboBox combo = new ComboBox() { Left = 60, Top = 25, Width = 150 };
            Button confirmation = new Button() { Text = "Remove", Left = 80, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            foreach (string item in items)
                combo.Items.Add(item);
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(combo);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? Convert.ToString(combo.SelectedItem) : "";
        }
    }
}
