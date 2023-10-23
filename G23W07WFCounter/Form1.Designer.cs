namespace G23W07WFCounter
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
            labelCount = new Label();
            btnAdd = new Button();
            btnSub = new Button();
            SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.BackColor = SystemColors.Info;
            labelCount.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelCount.Location = new Point(13, 9);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(381, 169);
            labelCount.TabIndex = 0;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(282, 192);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(112, 34);
            btnSub.TabIndex = 2;
            btnSub.Text = "감소";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += OnSub;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 240);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(labelCount);
            Name = "Form1";
            Text = "카운터";
            ResumeLayout(false);
        }

        #endregion

        private Label labelCount;
        private Button btnAdd;
        private Button btnSub;
    }
}