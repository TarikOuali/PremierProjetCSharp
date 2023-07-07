namespace TasksCourse
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
            addBtn = new Button();
            srcText = new TextBox();
            resultLstbox = new ListBox();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(317, 11);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 0;
            addBtn.Text = "Ajouter";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // srcText
            // 
            srcText.Location = new Point(12, 12);
            srcText.Name = "srcText";
            srcText.Size = new Size(252, 23);
            srcText.TabIndex = 1;
            // 
            // resultLstbox
            // 
            resultLstbox.FormattingEnabled = true;
            resultLstbox.ItemHeight = 15;
            resultLstbox.Location = new Point(12, 41);
            resultLstbox.Name = "resultLstbox";
            resultLstbox.Size = new Size(252, 94);
            resultLstbox.TabIndex = 2;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(317, 41);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = "Annuler";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 175);
            Controls.Add(CancelBtn);
            Controls.Add(resultLstbox);
            Controls.Add(srcText);
            Controls.Add(addBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox srcText;
        private ListBox resultLstbox;
        private Button CancelBtn;
    }
}