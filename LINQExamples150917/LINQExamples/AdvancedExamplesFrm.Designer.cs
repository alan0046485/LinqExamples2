namespace LINQExamples
{
    partial class AdvancedExamplesFrm
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
            this.rtbStudents = new System.Windows.Forms.RichTextBox();
            this.rtbExtraQueries = new System.Windows.Forms.RichTextBox();
            this.rtbNumbers = new System.Windows.Forms.RichTextBox();
            this.btnCCPP = new System.Windows.Forms.Button();
            this.btnShowType = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDeferredExecution = new System.Windows.Forms.Button();
            this.btnToList = new System.Windows.Forms.Button();
            this.btnTopPerformingStudents = new System.Windows.Forms.Button();
            this.btnReturningResults = new System.Windows.Forms.Button();
            this.btnInnerJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbStudents
            // 
            this.rtbStudents.Location = new System.Drawing.Point(0, 0);
            this.rtbStudents.Name = "rtbStudents";
            this.rtbStudents.ReadOnly = true;
            this.rtbStudents.Size = new System.Drawing.Size(711, 201);
            this.rtbStudents.TabIndex = 0;
            this.rtbStudents.Text = "";
            // 
            // rtbExtraQueries
            // 
            this.rtbExtraQueries.Location = new System.Drawing.Point(0, 288);
            this.rtbExtraQueries.Name = "rtbExtraQueries";
            this.rtbExtraQueries.ReadOnly = true;
            this.rtbExtraQueries.Size = new System.Drawing.Size(337, 135);
            this.rtbExtraQueries.TabIndex = 1;
            this.rtbExtraQueries.Text = "";
            // 
            // rtbNumbers
            // 
            this.rtbNumbers.Location = new System.Drawing.Point(335, 288);
            this.rtbNumbers.Name = "rtbNumbers";
            this.rtbNumbers.ReadOnly = true;
            this.rtbNumbers.Size = new System.Drawing.Size(376, 135);
            this.rtbNumbers.TabIndex = 2;
            this.rtbNumbers.Text = "";
            // 
            // btnCCPP
            // 
            this.btnCCPP.Location = new System.Drawing.Point(627, 207);
            this.btnCCPP.Name = "btnCCPP";
            this.btnCCPP.Size = new System.Drawing.Size(84, 75);
            this.btnCCPP.TabIndex = 10;
            this.btnCCPP.Text = "Count Courses Per Programme";
            this.btnCCPP.UseVisualStyleBackColor = true;
            this.btnCCPP.Click += new System.EventHandler(this.btnCCPP_Click);
            // 
            // btnShowType
            // 
            this.btnShowType.Location = new System.Drawing.Point(0, 207);
            this.btnShowType.Name = "btnShowType";
            this.btnShowType.Size = new System.Drawing.Size(84, 75);
            this.btnShowType.TabIndex = 11;
            this.btnShowType.Text = "Show Type";
            this.btnShowType.UseVisualStyleBackColor = true;
            this.btnShowType.Click += new System.EventHandler(this.btnShowType_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(90, 207);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(84, 75);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDeferredExecution
            // 
            this.btnDeferredExecution.Location = new System.Drawing.Point(180, 207);
            this.btnDeferredExecution.Name = "btnDeferredExecution";
            this.btnDeferredExecution.Size = new System.Drawing.Size(84, 75);
            this.btnDeferredExecution.TabIndex = 13;
            this.btnDeferredExecution.Text = "DeferredExecution";
            this.btnDeferredExecution.UseVisualStyleBackColor = true;
            this.btnDeferredExecution.Click += new System.EventHandler(this.btnDeferredExecution_Click);
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(270, 207);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(84, 75);
            this.btnToList.TabIndex = 14;
            this.btnToList.Text = "ToList() (Immediate Exec Cache Results)";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnTopPerformingStudents
            // 
            this.btnTopPerformingStudents.Location = new System.Drawing.Point(357, 205);
            this.btnTopPerformingStudents.Name = "btnTopPerformingStudents";
            this.btnTopPerformingStudents.Size = new System.Drawing.Size(84, 75);
            this.btnTopPerformingStudents.TabIndex = 15;
            this.btnTopPerformingStudents.Text = "Top Performing Students";
            this.btnTopPerformingStudents.UseVisualStyleBackColor = true;
            this.btnTopPerformingStudents.Click += new System.EventHandler(this.btnTopPerformingStudents_Click);
            // 
            // btnReturningResults
            // 
            this.btnReturningResults.Location = new System.Drawing.Point(447, 207);
            this.btnReturningResults.Name = "btnReturningResults";
            this.btnReturningResults.Size = new System.Drawing.Size(84, 75);
            this.btnReturningResults.TabIndex = 16;
            this.btnReturningResults.Text = "Returning Results";
            this.btnReturningResults.UseVisualStyleBackColor = true;
            this.btnReturningResults.Click += new System.EventHandler(this.btnReturningResults_Click);
            // 
            // btnInnerJoin
            // 
            this.btnInnerJoin.Location = new System.Drawing.Point(537, 207);
            this.btnInnerJoin.Name = "btnInnerJoin";
            this.btnInnerJoin.Size = new System.Drawing.Size(84, 75);
            this.btnInnerJoin.TabIndex = 17;
            this.btnInnerJoin.Text = "Inner Join";
            this.btnInnerJoin.UseVisualStyleBackColor = true;
            this.btnInnerJoin.Click += new System.EventHandler(this.btnInnerJoin_Click);
            // 
            // AdvancedExamplesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 421);
            this.Controls.Add(this.btnInnerJoin);
            this.Controls.Add(this.btnReturningResults);
            this.Controls.Add(this.btnTopPerformingStudents);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.btnDeferredExecution);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnShowType);
            this.Controls.Add(this.btnCCPP);
            this.Controls.Add(this.rtbNumbers);
            this.Controls.Add(this.rtbExtraQueries);
            this.Controls.Add(this.rtbStudents);
            this.Name = "AdvancedExamplesFrm";
            this.Text = "AdvancedExamplesFrm";
            this.Load += new System.EventHandler(this.AdvancedExamplesFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbStudents;
        private System.Windows.Forms.RichTextBox rtbExtraQueries;
        private System.Windows.Forms.RichTextBox rtbNumbers;
        private System.Windows.Forms.Button btnCCPP;
        private System.Windows.Forms.Button btnShowType;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDeferredExecution;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Button btnTopPerformingStudents;
        private System.Windows.Forms.Button btnReturningResults;
        private System.Windows.Forms.Button btnInnerJoin;
    }
}