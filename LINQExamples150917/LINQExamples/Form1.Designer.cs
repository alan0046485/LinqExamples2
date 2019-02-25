namespace LINQExamples
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
            this.rtbNumbers = new System.Windows.Forms.RichTextBox();
            this.rtbBasicQueryValues = new System.Windows.Forms.RichTextBox();
            this.rtbSortQueryValues = new System.Windows.Forms.RichTextBox();
            this.rtbFilterQueryValues = new System.Windows.Forms.RichTextBox();
            this.rtbSortNFilterQueryValues = new System.Windows.Forms.RichTextBox();
            this.btnSortNFilterQuery = new System.Windows.Forms.Button();
            this.btnMoreExamples = new System.Windows.Forms.Button();
            this.btnBasicQuery = new System.Windows.Forms.Button();
            this.btnSortQuery = new System.Windows.Forms.Button();
            this.btnFilterQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbNumbers
            // 
            this.rtbNumbers.Location = new System.Drawing.Point(0, 0);
            this.rtbNumbers.Name = "rtbNumbers";
            this.rtbNumbers.Size = new System.Drawing.Size(447, 96);
            this.rtbNumbers.TabIndex = 0;
            this.rtbNumbers.Text = "";
            // 
            // rtbBasicQueryValues
            // 
            this.rtbBasicQueryValues.Location = new System.Drawing.Point(0, 148);
            this.rtbBasicQueryValues.Name = "rtbBasicQueryValues";
            this.rtbBasicQueryValues.Size = new System.Drawing.Size(112, 117);
            this.rtbBasicQueryValues.TabIndex = 1;
            this.rtbBasicQueryValues.Text = "";
            // 
            // rtbSortQueryValues
            // 
            this.rtbSortQueryValues.Location = new System.Drawing.Point(118, 148);
            this.rtbSortQueryValues.Name = "rtbSortQueryValues";
            this.rtbSortQueryValues.Size = new System.Drawing.Size(111, 117);
            this.rtbSortQueryValues.TabIndex = 2;
            this.rtbSortQueryValues.Text = "";
            // 
            // rtbFilterQueryValues
            // 
            this.rtbFilterQueryValues.Location = new System.Drawing.Point(235, 148);
            this.rtbFilterQueryValues.Name = "rtbFilterQueryValues";
            this.rtbFilterQueryValues.Size = new System.Drawing.Size(100, 117);
            this.rtbFilterQueryValues.TabIndex = 3;
            this.rtbFilterQueryValues.Text = "";
            // 
            // rtbSortNFilterQueryValues
            // 
            this.rtbSortNFilterQueryValues.Location = new System.Drawing.Point(341, 148);
            this.rtbSortNFilterQueryValues.Name = "rtbSortNFilterQueryValues";
            this.rtbSortNFilterQueryValues.Size = new System.Drawing.Size(106, 117);
            this.rtbSortNFilterQueryValues.TabIndex = 4;
            this.rtbSortNFilterQueryValues.Text = "";
            // 
            // btnSortNFilterQuery
            // 
            this.btnSortNFilterQuery.Location = new System.Drawing.Point(341, 102);
            this.btnSortNFilterQuery.Name = "btnSortNFilterQuery";
            this.btnSortNFilterQuery.Size = new System.Drawing.Size(106, 40);
            this.btnSortNFilterQuery.TabIndex = 8;
            this.btnSortNFilterQuery.Text = "Sort and Filter Query";
            this.btnSortNFilterQuery.UseVisualStyleBackColor = true;
            this.btnSortNFilterQuery.Click += new System.EventHandler(this.btnSortNFilterQuery_Click);
            // 
            // btnMoreExamples
            // 
            this.btnMoreExamples.Location = new System.Drawing.Point(345, 274);
            this.btnMoreExamples.Name = "btnMoreExamples";
            this.btnMoreExamples.Size = new System.Drawing.Size(96, 23);
            this.btnMoreExamples.TabIndex = 9;
            this.btnMoreExamples.Text = "More Examples";
            this.btnMoreExamples.UseVisualStyleBackColor = true;
            this.btnMoreExamples.Click += new System.EventHandler(this.btnMoreExamples_Click);
            // 
            // btnBasicQuery
            // 
            this.btnBasicQuery.Location = new System.Drawing.Point(6, 102);
            this.btnBasicQuery.Name = "btnBasicQuery";
            this.btnBasicQuery.Size = new System.Drawing.Size(106, 40);
            this.btnBasicQuery.TabIndex = 10;
            this.btnBasicQuery.Text = "Basic Query";
            this.btnBasicQuery.UseVisualStyleBackColor = true;
            this.btnBasicQuery.Click += new System.EventHandler(this.btnBasicQuery_Click);
            // 
            // btnSortQuery
            // 
            this.btnSortQuery.Location = new System.Drawing.Point(118, 102);
            this.btnSortQuery.Name = "btnSortQuery";
            this.btnSortQuery.Size = new System.Drawing.Size(106, 40);
            this.btnSortQuery.TabIndex = 11;
            this.btnSortQuery.Text = "Sort Query";
            this.btnSortQuery.UseVisualStyleBackColor = true;
            this.btnSortQuery.Click += new System.EventHandler(this.btnSortQuery_Click);
            // 
            // btnFilterQuery
            // 
            this.btnFilterQuery.Location = new System.Drawing.Point(229, 102);
            this.btnFilterQuery.Name = "btnFilterQuery";
            this.btnFilterQuery.Size = new System.Drawing.Size(106, 40);
            this.btnFilterQuery.TabIndex = 12;
            this.btnFilterQuery.Text = "Filter Query";
            this.btnFilterQuery.UseVisualStyleBackColor = true;
            this.btnFilterQuery.Click += new System.EventHandler(this.btnFilterQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 309);
            this.Controls.Add(this.btnFilterQuery);
            this.Controls.Add(this.btnSortQuery);
            this.Controls.Add(this.btnBasicQuery);
            this.Controls.Add(this.btnMoreExamples);
            this.Controls.Add(this.btnSortNFilterQuery);
            this.Controls.Add(this.rtbSortNFilterQueryValues);
            this.Controls.Add(this.rtbFilterQueryValues);
            this.Controls.Add(this.rtbSortQueryValues);
            this.Controls.Add(this.rtbBasicQueryValues);
            this.Controls.Add(this.rtbNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNumbers;
        private System.Windows.Forms.RichTextBox rtbBasicQueryValues;
        private System.Windows.Forms.RichTextBox rtbSortQueryValues;
        private System.Windows.Forms.RichTextBox rtbFilterQueryValues;
        private System.Windows.Forms.RichTextBox rtbSortNFilterQueryValues;
        private System.Windows.Forms.Button btnSortNFilterQuery;
        private System.Windows.Forms.Button btnMoreExamples;
        private System.Windows.Forms.Button btnBasicQuery;
        private System.Windows.Forms.Button btnSortQuery;
        private System.Windows.Forms.Button btnFilterQuery;
    }
}

