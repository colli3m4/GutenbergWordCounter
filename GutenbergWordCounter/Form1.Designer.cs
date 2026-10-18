namespace GutenbergWordCounter
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
            label2 = new Label();
            txtFile1 = new TextBox();
            txtFile2 = new TextBox();
            btnProcess = new Button();
            button2 = new Button();
            lstBook1 = new ListBox();
            lstBook2 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            btnBrowse1 = new Button();
            btnBrowse2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Book1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 42);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Book2";
            // 
            // txtFile1
            // 
            txtFile1.Location = new Point(111, 40);
            txtFile1.Name = "txtFile1";
            txtFile1.Size = new Size(201, 23);
            txtFile1.TabIndex = 2;
            // 
            // txtFile2
            // 
            txtFile2.Location = new Point(491, 35);
            txtFile2.Name = "txtFile2";
            txtFile2.Size = new Size(201, 23);
            txtFile2.TabIndex = 3;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(302, 82);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(75, 23);
            btnProcess.TabIndex = 4;
            btnProcess.Text = "submit";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // button2
            // 
            button2.Location = new Point(398, 82);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lstBook1
            // 
            lstBook1.FormattingEnabled = true;
            lstBook1.ItemHeight = 15;
            lstBook1.Location = new Point(12, 122);
            lstBook1.Name = "lstBook1";
            lstBook1.Size = new Size(400, 304);
            lstBook1.TabIndex = 6;
            // 
            // lstBook2
            // 
            lstBook2.FormattingEnabled = true;
            lstBook2.ItemHeight = 15;
            lstBook2.Location = new Point(418, 122);
            lstBook2.Name = "lstBook2";
            lstBook2.Size = new Size(370, 304);
            lstBook2.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "\"C:\\Users\\colli3m4\\Desktop\\pg11.txt\"";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "\"C:\\Users\\colli3m4\\Desktop\\pg1342.txt\"";
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(327, 40);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(75, 23);
            btnBrowse1.TabIndex = 8;
            btnBrowse1.Text = "Browse";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(713, 35);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(75, 23);
            btnBrowse2.TabIndex = 9;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse2);
            Controls.Add(btnBrowse1);
            Controls.Add(lstBook2);
            Controls.Add(lstBook1);
            Controls.Add(button2);
            Controls.Add(btnProcess);
            Controls.Add(txtFile2);
            Controls.Add(txtFile1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFile1;
        private TextBox txtFile2;
        private Button btnProcess;
        private Button button2;
        private ListBox lstBook1;
        private ListBox lstBook2;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button btnBrowse1;
        private Button btnBrowse2;
    }
}
