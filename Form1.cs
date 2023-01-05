using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordCounterApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_chooseFile_Click(object sender, EventArgs e)
		{
			 OpenFileDialog openFileDialog = new OpenFileDialog();
			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath =  openFileDialog.FileName;
				textBox1.Text = File.ReadAllText(filePath);
			}
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}

		private void btn_wordList_Click(object sender, EventArgs e)
		{
			string allWords = textBox1.Text;
			string[] wordsArray = allWords.Split(' ', ',', '.', '-', '!');

			foreach (string word in wordsArray)
			{
				// only add a word if it is not yet in the list
				if(!listBox1.Items.Contains(word))
				{
					listBox1.Items.Add(word);
				}
			}
		}

		private void btn_sortWords_Click(object sender, EventArgs e)
		{
			listBox1.Sorted= true;
		}

		private void btn_countWords_Click(object sender, EventArgs e)
		{
			string allWords = textBox1.Text;
			string[] wordsArray = allWords.Split(' ', ',', '.', '-', '!');

			// change the array into a list
			List<WordCounter> wordCounters = new List<WordCounter>();

			// go through the word array. If the word is found in the list, add 1 to the frequency value. If the word is not found in the list, add it to the list and set its frequency to 1.

			foreach (string w in wordsArray) 
			{ 
				WordCounter foundWord = wordCounters.Find(x => x.word == w);
				if (foundWord == null)
				{
					// the word is not in the list yet. Add it
					wordCounters.Add(new WordCounter(w, 1));
				}
				else
				{
					// the word is found in the list. Increment the frequency
					foundWord.frequency++;
				}
			}

			listView1.Columns.Add("Frequency", 70);
			listView1.Columns.Add("Word", 100);

			listView1.View = View.Details;
			listView1.GridLines= true;
			listView1.FullRowSelect= true;
			listView1.Sorting = SortOrder.Descending;

			foreach (WordCounter word in wordCounters)
			{
				string[] rowItem = new string[] { word.frequency.ToString("D5"), word.word };
				listView1.Items.Add( new ListViewItem(rowItem) );
			}
		}
	}
}
