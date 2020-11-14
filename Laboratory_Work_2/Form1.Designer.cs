namespace Laboratory_Work_2
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
			this.inputBox = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.outputListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.negationButton = new System.Windows.Forms.Button();
			this.implicationButton = new System.Windows.Forms.Button();
			this.reversImplicationButton = new System.Windows.Forms.Button();
			this.conjuctionButton = new System.Windows.Forms.Button();
			this.xorButton = new System.Windows.Forms.Button();
			this.equivalenceButton = new System.Windows.Forms.Button();
			this.disjunctionButton = new System.Windows.Forms.Button();
			this.zDomainUpDown = new System.Windows.Forms.DomainUpDown();
			this.xDomainUpDown = new System.Windows.Forms.DomainUpDown();
			this.yDomainUpDown = new System.Windows.Forms.DomainUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.yButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.xButton = new System.Windows.Forms.Button();
			this.zButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.leftBracketButton = new System.Windows.Forms.Button();
			this.rightBracketButton = new System.Windows.Forms.Button();
			this.constantZeroButton = new System.Windows.Forms.Button();
			this.constantOneButton = new System.Windows.Forms.Button();
			this.delAllButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// inputBox
			// 
			this.inputBox.Enabled = false;
			this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.inputBox.Location = new System.Drawing.Point(256, 77);
			this.inputBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(465, 29);
			this.inputBox.TabIndex = 0;
			this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(256, 624);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(465, 31);
			this.textBox2.TabIndex = 1;
			// 
			// outputListBox
			// 
			this.outputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.outputListBox.FormattingEnabled = true;
			this.outputListBox.ItemHeight = 25;
			this.outputListBox.Items.AddRange(new object[] {
            "Result"});
			this.outputListBox.Location = new System.Drawing.Point(758, 77);
			this.outputListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.outputListBox.Name = "outputListBox";
			this.outputListBox.Size = new System.Drawing.Size(222, 579);
			this.outputListBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(251, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Input";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(251, 569);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Erorr box";
			// 
			// negationButton
			// 
			this.negationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.negationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.negationButton.Location = new System.Drawing.Point(256, 241);
			this.negationButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.negationButton.Name = "negationButton";
			this.negationButton.Size = new System.Drawing.Size(70, 70);
			this.negationButton.TabIndex = 5;
			this.negationButton.Text = "¬";
			this.negationButton.UseVisualStyleBackColor = false;
			this.negationButton.Click += new System.EventHandler(this.negationButton_Click);
			// 
			// implicationButton
			// 
			this.implicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.implicationButton.Enabled = false;
			this.implicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.implicationButton.Location = new System.Drawing.Point(650, 241);
			this.implicationButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.implicationButton.Name = "implicationButton";
			this.implicationButton.Size = new System.Drawing.Size(70, 70);
			this.implicationButton.TabIndex = 6;
			this.implicationButton.Text = "→";
			this.implicationButton.UseVisualStyleBackColor = false;
			this.implicationButton.Click += new System.EventHandler(this.implicationButton_Click);
			// 
			// reversImplicationButton
			// 
			this.reversImplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.reversImplicationButton.Enabled = false;
			this.reversImplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.reversImplicationButton.Location = new System.Drawing.Point(522, 241);
			this.reversImplicationButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.reversImplicationButton.Name = "reversImplicationButton";
			this.reversImplicationButton.Size = new System.Drawing.Size(70, 70);
			this.reversImplicationButton.TabIndex = 7;
			this.reversImplicationButton.Text = "←";
			this.reversImplicationButton.UseVisualStyleBackColor = false;
			this.reversImplicationButton.Click += new System.EventHandler(this.reversImplicationButton_Click);
			// 
			// conjuctionButton
			// 
			this.conjuctionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.conjuctionButton.Enabled = false;
			this.conjuctionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.conjuctionButton.Location = new System.Drawing.Point(522, 338);
			this.conjuctionButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.conjuctionButton.Name = "conjuctionButton";
			this.conjuctionButton.Size = new System.Drawing.Size(70, 70);
			this.conjuctionButton.TabIndex = 9;
			this.conjuctionButton.Text = "∧";
			this.conjuctionButton.UseVisualStyleBackColor = false;
			this.conjuctionButton.Click += new System.EventHandler(this.conjuctionButton_Click);
			// 
			// xorButton
			// 
			this.xorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.xorButton.Enabled = false;
			this.xorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.xorButton.Location = new System.Drawing.Point(389, 338);
			this.xorButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.xorButton.Name = "xorButton";
			this.xorButton.Size = new System.Drawing.Size(70, 70);
			this.xorButton.TabIndex = 10;
			this.xorButton.Text = "⊕";
			this.xorButton.UseVisualStyleBackColor = false;
			this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
			// 
			// equivalenceButton
			// 
			this.equivalenceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.equivalenceButton.Enabled = false;
			this.equivalenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.equivalenceButton.ForeColor = System.Drawing.Color.Black;
			this.equivalenceButton.Location = new System.Drawing.Point(389, 241);
			this.equivalenceButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.equivalenceButton.Name = "equivalenceButton";
			this.equivalenceButton.Size = new System.Drawing.Size(70, 70);
			this.equivalenceButton.TabIndex = 13;
			this.equivalenceButton.Text = "~";
			this.equivalenceButton.UseVisualStyleBackColor = false;
			this.equivalenceButton.Click += new System.EventHandler(this.equivalenceButton_Click);
			// 
			// disjunctionButton
			// 
			this.disjunctionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.disjunctionButton.Enabled = false;
			this.disjunctionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.disjunctionButton.Location = new System.Drawing.Point(650, 338);
			this.disjunctionButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.disjunctionButton.Name = "disjunctionButton";
			this.disjunctionButton.Size = new System.Drawing.Size(70, 70);
			this.disjunctionButton.TabIndex = 15;
			this.disjunctionButton.Text = "∨";
			this.disjunctionButton.UseVisualStyleBackColor = false;
			this.disjunctionButton.Click += new System.EventHandler(this.disjunctionButton_Click);
			// 
			// zDomainUpDown
			// 
			this.zDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.zDomainUpDown.Items.Add("1");
			this.zDomainUpDown.Items.Add("0");
			this.zDomainUpDown.Items.Add("");
			this.zDomainUpDown.Location = new System.Drawing.Point(98, 332);
			this.zDomainUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.zDomainUpDown.Name = "zDomainUpDown";
			this.zDomainUpDown.ReadOnly = true;
			this.zDomainUpDown.Size = new System.Drawing.Size(44, 31);
			this.zDomainUpDown.TabIndex = 19;
			this.zDomainUpDown.SelectedItemChanged += new System.EventHandler(this.zDomainUpDown_SelectedItemChanged);
			// 
			// xDomainUpDown
			// 
			this.xDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.xDomainUpDown.Items.Add("1");
			this.xDomainUpDown.Items.Add("0");
			this.xDomainUpDown.Items.Add("");
			this.xDomainUpDown.Location = new System.Drawing.Point(100, 192);
			this.xDomainUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.xDomainUpDown.Name = "xDomainUpDown";
			this.xDomainUpDown.ReadOnly = true;
			this.xDomainUpDown.Size = new System.Drawing.Size(44, 31);
			this.xDomainUpDown.TabIndex = 20;
			this.xDomainUpDown.SelectedItemChanged += new System.EventHandler(this.xDomainUpDown_SelectedItemChanged);
			// 
			// yDomainUpDown
			// 
			this.yDomainUpDown.BackColor = System.Drawing.SystemColors.Control;
			this.yDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.yDomainUpDown.Items.Add("1");
			this.yDomainUpDown.Items.Add("0");
			this.yDomainUpDown.Items.Add("");
			this.yDomainUpDown.Location = new System.Drawing.Point(100, 261);
			this.yDomainUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.yDomainUpDown.Name = "yDomainUpDown";
			this.yDomainUpDown.ReadOnly = true;
			this.yDomainUpDown.Size = new System.Drawing.Size(44, 31);
			this.yDomainUpDown.TabIndex = 21;
			this.yDomainUpDown.SelectedItemChanged += new System.EventHandler(this.yDomainUpDown_SelectedItemChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(40, 198);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 25);
			this.label3.TabIndex = 22;
			this.label3.Text = "X = ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(40, 338);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 25);
			this.label4.TabIndex = 23;
			this.label4.Text = "Z = ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(40, 269);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 25);
			this.label5.TabIndex = 24;
			this.label5.Text = "Y = ";
			// 
			// yButton
			// 
			this.yButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.yButton.Enabled = false;
			this.yButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.yButton.Location = new System.Drawing.Point(522, 446);
			this.yButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.yButton.Name = "yButton";
			this.yButton.Size = new System.Drawing.Size(70, 70);
			this.yButton.TabIndex = 25;
			this.yButton.Text = "Y";
			this.yButton.UseVisualStyleBackColor = false;
			this.yButton.Click += new System.EventHandler(this.yButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteButton.Location = new System.Drawing.Point(650, 134);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(70, 70);
			this.deleteButton.TabIndex = 26;
			this.deleteButton.Text = "del";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// xButton
			// 
			this.xButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.xButton.Enabled = false;
			this.xButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.xButton.Location = new System.Drawing.Point(389, 446);
			this.xButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.xButton.Name = "xButton";
			this.xButton.Size = new System.Drawing.Size(70, 70);
			this.xButton.TabIndex = 27;
			this.xButton.Text = "X";
			this.xButton.UseVisualStyleBackColor = false;
			this.xButton.Click += new System.EventHandler(this.xButton_Click);
			// 
			// zButton
			// 
			this.zButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.zButton.Enabled = false;
			this.zButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.zButton.Location = new System.Drawing.Point(650, 446);
			this.zButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.zButton.Name = "zButton";
			this.zButton.Size = new System.Drawing.Size(70, 70);
			this.zButton.TabIndex = 28;
			this.zButton.Text = "Z";
			this.zButton.UseVisualStyleBackColor = false;
			this.zButton.Click += new System.EventHandler(this.zButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(752, 30);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 25);
			this.label6.TabIndex = 29;
			this.label6.Text = "Output";
			// 
			// leftBracketButton
			// 
			this.leftBracketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.leftBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.leftBracketButton.Location = new System.Drawing.Point(256, 134);
			this.leftBracketButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.leftBracketButton.Name = "leftBracketButton";
			this.leftBracketButton.Size = new System.Drawing.Size(70, 70);
			this.leftBracketButton.TabIndex = 30;
			this.leftBracketButton.Text = "(";
			this.leftBracketButton.UseVisualStyleBackColor = false;
			this.leftBracketButton.Click += new System.EventHandler(this.leftBracketButton_Click);
			// 
			// rightBracketButton
			// 
			this.rightBracketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.rightBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rightBracketButton.Location = new System.Drawing.Point(389, 134);
			this.rightBracketButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.rightBracketButton.Name = "rightBracketButton";
			this.rightBracketButton.Size = new System.Drawing.Size(70, 70);
			this.rightBracketButton.TabIndex = 31;
			this.rightBracketButton.Text = ")";
			this.rightBracketButton.UseVisualStyleBackColor = false;
			this.rightBracketButton.Click += new System.EventHandler(this.rightBracketButton_Click);
			// 
			// constantZeroButton
			// 
			this.constantZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.constantZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.constantZeroButton.Location = new System.Drawing.Point(256, 338);
			this.constantZeroButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.constantZeroButton.Name = "constantZeroButton";
			this.constantZeroButton.Size = new System.Drawing.Size(70, 70);
			this.constantZeroButton.TabIndex = 32;
			this.constantZeroButton.Text = "0";
			this.constantZeroButton.UseVisualStyleBackColor = false;
			this.constantZeroButton.Click += new System.EventHandler(this.constantZeroButton_Click);
			// 
			// constantOneButton
			// 
			this.constantOneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.constantOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.constantOneButton.Location = new System.Drawing.Point(256, 446);
			this.constantOneButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.constantOneButton.Name = "constantOneButton";
			this.constantOneButton.Size = new System.Drawing.Size(70, 70);
			this.constantOneButton.TabIndex = 33;
			this.constantOneButton.Text = "1";
			this.constantOneButton.UseVisualStyleBackColor = false;
			this.constantOneButton.Click += new System.EventHandler(this.constantOneButton_Click);
			// 
			// delAllButton
			// 
			this.delAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.delAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.delAllButton.Location = new System.Drawing.Point(522, 134);
			this.delAllButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.delAllButton.Name = "delAllButton";
			this.delAllButton.Size = new System.Drawing.Size(70, 70);
			this.delAllButton.TabIndex = 8;
			this.delAllButton.Text = "delAll";
			this.delAllButton.UseVisualStyleBackColor = false;
			this.delAllButton.Click += new System.EventHandler(this.delAllButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1057, 720);
			this.Controls.Add(this.constantOneButton);
			this.Controls.Add(this.constantZeroButton);
			this.Controls.Add(this.rightBracketButton);
			this.Controls.Add(this.leftBracketButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.zButton);
			this.Controls.Add(this.xButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.yButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.yDomainUpDown);
			this.Controls.Add(this.xDomainUpDown);
			this.Controls.Add(this.zDomainUpDown);
			this.Controls.Add(this.disjunctionButton);
			this.Controls.Add(this.equivalenceButton);
			this.Controls.Add(this.xorButton);
			this.Controls.Add(this.conjuctionButton);
			this.Controls.Add(this.delAllButton);
			this.Controls.Add(this.reversImplicationButton);
			this.Controls.Add(this.implicationButton);
			this.Controls.Add(this.negationButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.outputListBox);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.inputBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.Text = "Boolean calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListBox outputListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button negationButton;
		private System.Windows.Forms.Button implicationButton;
		private System.Windows.Forms.Button reversImplicationButton;
		private System.Windows.Forms.Button delAllButton;
		private System.Windows.Forms.Button conjuctionButton;
		private System.Windows.Forms.Button xorButton;
		private System.Windows.Forms.Button equivalenceButton;
		private System.Windows.Forms.Button disjunctionButton;
		private System.Windows.Forms.DomainUpDown zDomainUpDown;
		private System.Windows.Forms.DomainUpDown xDomainUpDown;
		private System.Windows.Forms.DomainUpDown yDomainUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button yButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button xButton;
		private System.Windows.Forms.Button zButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button leftBracketButton;
		private System.Windows.Forms.Button rightBracketButton;
		private System.Windows.Forms.Button constantZeroButton;
		private System.Windows.Forms.Button constantOneButton;
	}
}

