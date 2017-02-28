namespace Lab6_Library
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
            this.AddButton = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ChangeLoanButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booksList = new System.Windows.Forms.TextBox();
            this.titleSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(163, 46);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Book";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(13, 64);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(100, 20);
            this.ISBN.TabIndex = 1;
            this.ISBN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(163, 89);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(111, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove Book";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ChangeLoanButton
            // 
            this.ChangeLoanButton.Location = new System.Drawing.Point(163, 130);
            this.ChangeLoanButton.Name = "ChangeLoanButton";
            this.ChangeLoanButton.Size = new System.Drawing.Size(111, 23);
            this.ChangeLoanButton.TabIndex = 3;
            this.ChangeLoanButton.Text = "Change loan status";
            this.ChangeLoanButton.UseVisualStyleBackColor = true;
            this.ChangeLoanButton.Click += new System.EventHandler(this.ChangeLoanButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(163, 172);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search ISBN";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(13, 115);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(100, 20);
            this.bookTitle.TabIndex = 5;
            this.bookTitle.TextChanged += new System.EventHandler(this.bookTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Title";
            // 
            // booksList
            // 
            this.booksList.Location = new System.Drawing.Point(16, 272);
            this.booksList.Multiline = true;
            this.booksList.Name = "booksList";
            this.booksList.ReadOnly = true;
            this.booksList.Size = new System.Drawing.Size(274, 102);
            this.booksList.TabIndex = 8;
            this.booksList.TextChanged += new System.EventHandler(this.booksList_TextChanged);
            // 
            // titleSearchButton
            // 
            this.titleSearchButton.Location = new System.Drawing.Point(163, 217);
            this.titleSearchButton.Name = "titleSearchButton";
            this.titleSearchButton.Size = new System.Drawing.Size(111, 23);
            this.titleSearchButton.TabIndex = 9;
            this.titleSearchButton.Text = "Search Title";
            this.titleSearchButton.UseVisualStyleBackColor = true;
            this.titleSearchButton.Click += new System.EventHandler(this.titleSearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 398);
            this.Controls.Add(this.titleSearchButton);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ChangeLoanButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ChangeLoanButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox booksList;
        private System.Windows.Forms.Button titleSearchButton;
    }
}

