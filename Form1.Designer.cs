namespace WordCounterApp
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_chooseFile = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_wordList = new System.Windows.Forms.Button();
			this.btn_sortWords = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btn_countWords = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(106, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "1. Load a Text File";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(346, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "2. Split the File into Words";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(582, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "3. Count the Frequency of Each Word";
			// 
			// btn_chooseFile
			// 
			this.btn_chooseFile.Location = new System.Drawing.Point(69, 29);
			this.btn_chooseFile.Name = "btn_chooseFile";
			this.btn_chooseFile.Size = new System.Drawing.Size(75, 37);
			this.btn_chooseFile.TabIndex = 3;
			this.btn_chooseFile.Text = "Choose a File";
			this.btn_chooseFile.UseVisualStyleBackColor = true;
			this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(172, 29);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(75, 37);
			this.btn_clear.TabIndex = 4;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(22, 72);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(321, 535);
			this.textBox1.TabIndex = 5;
			// 
			// btn_wordList
			// 
			this.btn_wordList.Location = new System.Drawing.Point(349, 29);
			this.btn_wordList.Name = "btn_wordList";
			this.btn_wordList.Size = new System.Drawing.Size(70, 37);
			this.btn_wordList.TabIndex = 6;
			this.btn_wordList.Text = "Create Word List";
			this.btn_wordList.UseVisualStyleBackColor = true;
			this.btn_wordList.Click += new System.EventHandler(this.btn_wordList_Click);
			// 
			// btn_sortWords
			// 
			this.btn_sortWords.Location = new System.Drawing.Point(425, 29);
			this.btn_sortWords.Name = "btn_sortWords";
			this.btn_sortWords.Size = new System.Drawing.Size(70, 37);
			this.btn_sortWords.TabIndex = 7;
			this.btn_sortWords.Text = "Sort Wrods";
			this.btn_sortWords.UseVisualStyleBackColor = true;
			this.btn_sortWords.Click += new System.EventHandler(this.btn_sortWords_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(349, 72);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(175, 537);
			this.listBox1.TabIndex = 8;
			// 
			// btn_countWords
			// 
			this.btn_countWords.Location = new System.Drawing.Point(585, 29);
			this.btn_countWords.Name = "btn_countWords";
			this.btn_countWords.Size = new System.Drawing.Size(75, 36);
			this.btn_countWords.TabIndex = 9;
			this.btn_countWords.Text = "Count";
			this.btn_countWords.UseVisualStyleBackColor = true;
			this.btn_countWords.Click += new System.EventHandler(this.btn_countWords_Click);
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(531, 72);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(257, 537);
			this.listView1.TabIndex = 10;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 633);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btn_countWords);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btn_sortWords);
			this.Controls.Add(this.btn_wordList);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_chooseFile);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_chooseFile;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_wordList;
		private System.Windows.Forms.Button btn_sortWords;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btn_countWords;
		private System.Windows.Forms.ListView listView1;
	}
}

