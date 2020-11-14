using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory_Work_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string Calculate(string n1, string operation, string n2)
		{
			try
			{
				int number2 = VariableValue(n2);
				if(operation == "¬")
					return Negation(number2).ToString();

				int number1 = VariableValue(n1);

				switch (operation)
				{
					case "∧":
						return Min(number1, number2).ToString();

					case "∨":
						return Max(number1, number2).ToString();

					case "⊕":
						return XOR(number1, number2).ToString();

					case "→":
						return Implication(number1, number2).ToString();

					case "←":
						return ReverseImplication(number1, number2).ToString();

					case "~":
						return Equivalence(number1, number2).ToString();
				}
			}
			catch
			{
				return "err";
			}
			return "err";
		}

		private int Max(int a, int b)
		{
			if (a > b)
				return a;
			else
				return b;
		}

		private int Min(int a, int b)
		{
			if (a < b)
				return a;
			else
				return b;
		}

		private int Negation(int a)
		{
			return Abs(a - 1);
		}

		private int Abs(int a)
		{
			if (a >= 0)
				return a;
			else
			{
				a *= -1;
				return a;
			}
		}

		private int XOR(int a, int b)
		{
			return a * Negation(b) + b * Negation(a);
		}

		private int Implication(int a, int b)
		{
			if (Negation(a) + b >= 1)
				return 1;
			else
				return 0;
		}

		private int ReverseImplication(int a, int b)
		{
			if (Negation(b) + a >= 1)
				return 1;
			else
				return 0;
		}

		private int Equivalence(int a, int b)
		{
			return a * b + Negation(a) * Negation(b);
		}

		private int VariableValue(string variable)
		{
			if (variable == "x")
				return Convert.ToInt32(xDomainUpDown.Text);
			else if (variable == "y")
				return Convert.ToInt32(yDomainUpDown.Text);
			else if(variable == "z")
				return Convert.ToInt32(zDomainUpDown.Text);
			return Convert.ToInt32(variable);
		}

		private string OperationPriorities(string text)
		{
			ChangeListBox(text);

			string firstPriority = FirstPriority();
			string secondPriority = SecondPriority();
			string thirdPriority = ThirdPriority();
			string fourthPriority = FourthPriority();
			string fifthPriority = FifthPriority();

			if(firstPriority == "err" || secondPriority == "err" || thirdPriority == "err" || fourthPriority == "err" || fifthPriority == "err")
			{
				return "err";
			}

			return outputListBox.Items[0].ToString();
		}

		private string FirstPriority()
		{
			for (int i = 0; i < outputListBox.Items.Count; i++)
			{
				if (outputListBox.Items[i].ToString() == "¬")
				{
					string result = WriteTheResultToTheListBox(i, "¬");
					if (result == "err")
						return "err";
					i = 0;
				}
			}
			return "ok";
		}

		private string SecondPriority()
		{
			for (int i = 0; i < outputListBox.Items.Count; i++)
			{
				if (outputListBox.Items[i].ToString() == "∧")
				{
					string result = WriteTheResultToTheListBox(i);
					if (result == "err")
						return "err";
					i = 0;
				}
			}
			return "ok";
		}

		private string ThirdPriority()
		{
			for (int i = 0; i < outputListBox.Items.Count; i++)
			{
				if (outputListBox.Items[i].ToString() == "∨" || outputListBox.Items[i].ToString() == "⊕")
				{
					string result = WriteTheResultToTheListBox(i);
					if (result == "err")
						return "err";
					i = 0;
				}
			}
			return "ok";
		}

		private string FourthPriority()
		{
			for (int i = 0; i < outputListBox.Items.Count; i++)
			{
				if (outputListBox.Items[i].ToString() == "←" || outputListBox.Items[i].ToString() == "→")
				{
					string result = WriteTheResultToTheListBox(i);
					if (result == "err")
						return "err";
					i = 0;
				}
			}
			return "ok";
		}

		private string FifthPriority()
		{
			for (int i = 0; i < outputListBox.Items.Count; i++)
			{
				if (outputListBox.Items[i].ToString() == "~")
				{
					string result = WriteTheResultToTheListBox(i);
					if (result == "err")
						return "err";
					i = 0;
				}
			}
			return "ok";
		}

		private void ChangeListBox(string text)
		{
			outputListBox.Items.Clear();
			string tmp = "";
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '¬' || text[i] == '∧' || text[i] == '∨' || text[i] == '⊕' || text[i] == '←' || text[i] == '→' || text[i] == '~')
				{
					outputListBox.Items.Add(tmp);
					outputListBox.Items.Add(text[i]);
					tmp = "";
				}
				else
				{
					tmp += text[i];
				}
			}
			outputListBox.Items.Add(tmp);
		}

		private string WriteTheResultToTheListBox(int index)
		{
			if (index == 0 || index == outputListBox.Items.Count - 1)
			{
				return "err";
			}
			string result = Calculate(outputListBox.Items[index - 1].ToString(), outputListBox.Items[index].ToString(), outputListBox.Items[index + 1].ToString());
			if (result == "err") return "err";
			outputListBox.Items.RemoveAt(index - 1);
			outputListBox.Items.RemoveAt(index - 1);
			outputListBox.Items.RemoveAt(index - 1);
			outputListBox.Items.Insert(index - 1, result);
			return result;
		}

		private string WriteTheResultToTheListBox(int index, string operation)
		{
			if (index == outputListBox.Items.Count - 1)
			{
				return "err";
			}
			string result = Calculate(outputListBox.Items[index - 1].ToString(), operation, outputListBox.Items[index + 1].ToString());
			if (result == "err") return "err";
			outputListBox.Items.RemoveAt(index - 1);
			outputListBox.Items.RemoveAt(index - 1);
			outputListBox.Items.RemoveAt(index - 1);
			outputListBox.Items.Insert(index - 1, result);
			return result;
		}

		private string SearchBracket(string text)
		{
			bool open = false;
			int open_pos = -1;
			int close_pos = -1;
			bool  close = false;
			for(int i = 0; i < text.Length; i++)
			{
				if(text[i] == '(')
				{
					open = true;
					open_pos = i;
				}
				if (text[i] == ')')
				{
					if(open)
					{
						close = true;
						close_pos = i;
						string res = OperationPriorities(Substring(text, open_pos + 1, close_pos - open_pos-1));
						text = Remove(text, open_pos, close_pos - open_pos + 1);
						text = Insert(text, open_pos, res);
						i = -1; //---------------------------------------------------------------------------------------------
						open = close = false;
						close_pos = open_pos = -1;
					}
					else
						return "Ошибка: нет открывающейся скобки";
				}
			}
			if(open && !close)
			{
				return "Ошибка: Вы не закрыли скобку";
			}
			for(int i = 0; i < text.Length; i++)
			{
				if(text[i] == '(')
				{
					SearchBracket(text);
				}
			}

			string result = OperationPriorities(text);
			if (result == "err")
				return "err"; 
			return "";
		}

		private string Remove(string text,int startIndex, int count)
		{
			string result = "";
			for(int i = 0; i < startIndex; i++)
			{
				result += text[i];
			}

			for(int i = startIndex + count; i < text.Length; i++)
			{
				result += text[i];
			}

			return result;
		}
		
		private string Substring(string text, int startIndex, int length)
		{
			string result = "";
			for(int i = startIndex; i < startIndex+length; i++)
			{
				result += text[i];
			}

			return result;
		}

		private string Insert(string text, int startIndex, string value)
		{
			string result = "";
			for(int i = 0; i <= text.Length; i++)
			{
				if(i == startIndex)
				{
					result += value;
				}
				if (i == text.Length)
					return result;
				result += text[i];
			}
			return result;
		}

		private void inputBox_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = SearchBracket(inputBox.Text);
		}

		private void disjunctionButton_Click(object sender, EventArgs e)
		{
			BlockOperations();
			UnBlockVariables();
			inputBox.Text += "∨";
		}

		private void xButton_Click(object sender, EventArgs e)
		{
			UnBlockOperations();
			BlockVariables();
			inputBox.Text += "x";
		}

		private void yButton_Click(object sender, EventArgs e)
		{
			UnBlockOperations();
			BlockVariables();
			inputBox.Text += "y";
		}

		private void zButton_Click(object sender, EventArgs e)
		{
			UnBlockOperations();
			BlockVariables();
			inputBox.Text += "z";
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if(inputBox.Text.Length == 0)
			{
				return;
			}
			else
			{	
				if (inputBox.Text[inputBox.Text.Length - 1].ToString() == "(" || inputBox.Text[inputBox.Text.Length - 1].ToString() == ")")
				{
					inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
					return;
				}
				else if(IsOparation())
				{
					UnBlockOperations();
					BlockVariables();
				}
				else if(IsVariable())
				{
					BlockOperations();
					UnBlockVariables();
				}
				inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
			}
		}

		private bool IsOparation()
		{
			switch(inputBox.Text[inputBox.Text.Length - 1].ToString())
			{
				case "~":
					return true;

				case "←":
					return true;

				case "→":
					return true;

				case "⊕":
					return true;

				case "∧":
					return true;

				case "∨":
					return true;
			}
			return false;
		}

		private bool IsVariable()
		{
			switch (inputBox.Text[inputBox.Text.Length - 1].ToString())
			{
				case "¬":
					return true;

				case "0":
					return true;

				case "1":
					return true;

				case "x":
					return true;

				case "y":
					return true;

				case "z":
					return true;
			}
			return false;
		}

		private void delAllButton_Click(object sender, EventArgs e)
		{
			inputBox.Text = "";
			BlockOperations();
			UnBlockVariables();
		}

		private void leftBracketButton_Click(object sender, EventArgs e)
		{
			negationButton.Enabled = true;
			negationButton.BackColor = Color.FromArgb(0, 192, 0);
			inputBox.Text += "(";
		}

		private void rightBracketButton_Click(object sender, EventArgs e)
		{
			inputBox.Text += ")";
		}

		private void negationButton_Click(object sender, EventArgs e)
		{
			BlockOperations();
			UnBlockVariables();
			negationButton.Enabled = false;
			negationButton.BackColor = Color.FromArgb(255, 128, 128);
			inputBox.Text += "¬";
		}

		private void equivalenceButton_Click(object sender, EventArgs e)
		{
			BlockOperations();
			UnBlockVariables();
			inputBox.Text += "~";
		}

		private void reversImplicationButton_Click(object sender, EventArgs e)
		{
			BlockOperations();
			UnBlockVariables();
			inputBox.Text += "←";
		}

		private void implicationButton_Click(object sender, EventArgs e)
		{
			BlockOperations();
			UnBlockVariables();
			inputBox.Text += "→";
		}

		private void constantZeroButton_Click(object sender, EventArgs e)
		{
			UnBlockOperations();
			BlockVariables();
			inputBox.Text += "0";
		}

		private void constantOneButton_Click(object sender, EventArgs e)
		{
			UnBlockOperations();
			BlockVariables();
			inputBox.Text += "1";
		}

		private void conjuctionButton_Click(object sender, EventArgs e)
		{
			BlockOperations();
			UnBlockVariables();
			inputBox.Text += "∧";
		}

		private void xorButton_Click(object sender, EventArgs e)
		{
			BlockOperations();
			UnBlockVariables();
			inputBox.Text += "⊕";
		}

		private void xDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
		{
			if(xDomainUpDown.Text != "" && constantOneButton.Enabled)
			{
				xButton.Enabled = true;
				xButton.BackColor = Color.FromArgb(0, 192, 0);
				SearchBracket(inputBox.Text);
			}
			else
			{
				xButton.Enabled = false;
				xButton.BackColor = Color.FromArgb(255, 128, 128);
				SearchBracket(inputBox.Text);
			}
		}

		private void yDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
		{
			if (yDomainUpDown.Text != "" && constantOneButton.Enabled)
			{
				yButton.Enabled = true;
				yButton.BackColor = Color.FromArgb(0, 192, 0);
				SearchBracket(inputBox.Text);
			}
			else
			{
				yButton.Enabled = false;
				yButton.BackColor = Color.FromArgb(255, 128, 128);
				SearchBracket(inputBox.Text);
			}
		}

		private void zDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
		{
			if (zDomainUpDown.Text != "" && constantOneButton.Enabled)
			{
				zButton.Enabled = true;
				zButton.BackColor = Color.FromArgb(0, 192, 0);
				SearchBracket(inputBox.Text);
			}
			else
			{
				zButton.Enabled = false;
				zButton.BackColor = Color.FromArgb(255, 128, 128);
				SearchBracket(inputBox.Text);
			}
		}

		private void BlockOperations()
		{
			xorButton.Enabled = false;
			xorButton.BackColor = Color.FromArgb(255, 128, 128);

			conjuctionButton.Enabled = false;
			conjuctionButton.BackColor = Color.FromArgb(255, 128, 128);

			disjunctionButton.Enabled = false;
			disjunctionButton.BackColor = Color.FromArgb(255, 128, 128);

			equivalenceButton.Enabled = false;
			equivalenceButton.BackColor = Color.FromArgb(255, 128, 128);

			reversImplicationButton.Enabled = false;
			reversImplicationButton.BackColor = Color.FromArgb(255, 128, 128);

			implicationButton.Enabled = false;
			implicationButton.BackColor = Color.FromArgb(255, 128, 128);
		}

		private void UnBlockOperations()
		{
			xorButton.Enabled = true;
			xorButton.BackColor = Color.FromArgb(0, 192, 0);

			conjuctionButton.Enabled = true;
			conjuctionButton.BackColor = Color.FromArgb(0, 192, 0);

			disjunctionButton.Enabled = true;
			disjunctionButton.BackColor = Color.FromArgb(0, 192, 0);

			equivalenceButton.Enabled = true;
			equivalenceButton.BackColor = Color.FromArgb(0, 192, 0);

			reversImplicationButton.Enabled = true;
			reversImplicationButton.BackColor = Color.FromArgb(0, 192, 0);

			implicationButton.Enabled = true;
			implicationButton.BackColor = Color.FromArgb(0, 192, 0);
		}

		private void BlockVariables()
		{
			negationButton.Enabled = false;
			negationButton.BackColor = Color.FromArgb(255, 128, 128);

			constantZeroButton.Enabled = false;
			constantZeroButton.BackColor = Color.FromArgb(255, 128, 128);

			constantOneButton.Enabled = false;
			constantOneButton.BackColor = Color.FromArgb(255, 128, 128);

			xButton.Enabled = false;
			xButton.BackColor = Color.FromArgb(255, 128, 128);

			yButton.Enabled = false;
			yButton.BackColor = Color.FromArgb(255, 128, 128);

			zButton.Enabled = false;
			zButton.BackColor = Color.FromArgb(255, 128, 128);
		}

		private void UnBlockVariables()
		{

			if(inputBox.Text.Length > 1)
			{
				if (inputBox.Text[inputBox.Text.Length - 2].ToString() != "¬")
				{
					negationButton.Enabled = true;
					negationButton.BackColor = Color.FromArgb(0, 192, 0);
				}
			}
			else
			{
				negationButton.Enabled = true;
				negationButton.BackColor = Color.FromArgb(0, 192, 0);
			}


			constantZeroButton.Enabled = true;
			constantZeroButton.BackColor = Color.FromArgb(0, 192, 0);

			constantOneButton.Enabled = true;
			constantOneButton.BackColor = Color.FromArgb(0, 192, 0);


			if (xDomainUpDown.Text != "")
			{
				xButton.Enabled = true;
				xButton.BackColor = Color.FromArgb(0, 192, 0);
			}
			
			if (yDomainUpDown.Text != "")
			{
				yButton.Enabled = true;
				yButton.BackColor = Color.FromArgb(0, 192, 0);
			}

			if (zDomainUpDown.Text != "")
			{
				zButton.Enabled = true;
				zButton.BackColor = Color.FromArgb(0, 192, 0);
			}

		}
	}
}
