using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GutenbergWordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Browse prompt for Book 1
        //Monica Collins
        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFile1.Text = ofd.FileName; // FIX: Correctly sets txtFile1!
                }
            }
        }

        // Browse prompt for Book 2
        //Monica Collins
        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFile2.Text = ofd.FileName; // Correctly sets txtFile2
                }
            }
        }

        // Asynchronous processing button
        //Monica Collins
        private async void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFile1.Text) || string.IsNullOrWhiteSpace(txtFile2.Text))
            {
                MessageBox.Show("Please select both book files before processing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // FIX: Added return so it actually stops here if empty!
            }

            btnProcess.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                // 1. Run file processing tasks asynchronously using the correct text boxes
                var task1 = ProcessBookAsync(txtFile1.Text);
                var task2 = ProcessBookAsync(txtFile2.Text);

                var wordsBook1 = await task1;
                var wordsBook2 = await task2;

                // 2. Populate ListBox 1 using the correct designer name
                lstBook1.Items.Clear();
                foreach (var entry in wordsBook1)
                {
                    lstBook1.Items.Add($"{entry.Word}: {entry.Count} times");
                }

                // 3. Populate ListBox 2 using the correct designer name
                lstBook2.Items.Clear();
                foreach (var entry in wordsBook2)
                {
                    lstBook2.Items.Add($"{entry.Word}: {entry.Count} times");
                }

                MessageBox.Show("Both books have been successfully processed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnProcess.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        // Background worker method to read and compute top 10 words
        //Monica Collins
        private async Task<(string Word, int Count)[]> ProcessBookAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                // Explicitly use UTF-8 to handle special text characters properly
                string text = File.ReadAllText(filePath, System.Text.Encoding.UTF8);

                // Extract valid alphabetical words (length 2+), convert to lowercase, count frequencies, and take top 10
                var topWords = Regex.Matches(text.ToLower(), @"\b[a-z]{2,}\b")
                                  .Cast<Match>()
                                  .Select(m => m.Value)
                                  .GroupBy(word => word)
                                  .OrderByDescending(group => group.Count())
                                  .Take(10)
                                  .Select(group => (Word: group.Key, Count: group.Count()))
                                  .ToArray();

                return topWords;
            });
        }

        // Exit Button
        //Monica Collins
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Monica Collins
        private void btnProcess_Click_1(object sender, EventArgs e)
        {

        }
    }
}






