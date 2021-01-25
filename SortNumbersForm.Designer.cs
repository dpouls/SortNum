
namespace SortNum
{
    partial class SortNumbersForm
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
            this.LstBoxNumbers = new System.Windows.Forms.ListView();
            this.BtnSort = new System.Windows.Forms.Button();
            this.TxtBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxNumbers
            // 
            this.LstBoxNumbers.HideSelection = false;
            this.LstBoxNumbers.Location = new System.Drawing.Point(781, 66);
            this.LstBoxNumbers.Name = "LstBoxNumbers";
            this.LstBoxNumbers.Size = new System.Drawing.Size(219, 282);
            this.LstBoxNumbers.TabIndex = 0;
            this.LstBoxNumbers.UseCompatibleStateImageBehavior = false;
            this.LstBoxNumbers.View = System.Windows.Forms.View.List;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(780, 370);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(219, 49);
            this.BtnSort.TabIndex = 1;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // TxtBoxNumber
            // 
            this.TxtBoxNumber.Location = new System.Drawing.Point(107, 188);
            this.TxtBoxNumber.Name = "TxtBoxNumber";
            this.TxtBoxNumber.Size = new System.Drawing.Size(444, 45);
            this.TxtBoxNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Number";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(107, 248);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(444, 56);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // SortNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 678);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxNumber);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.LstBoxNumbers);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SortNumbersForm";
            this.Text = "Dallin\'s Number Sorter";
            this.Load += new System.EventHandler(this.SortNumbersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstBoxNumbers;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.TextBox TxtBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
    }
}

