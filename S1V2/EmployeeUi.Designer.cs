

namespace S1V2
{
    partial class EmployeeUi
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
            tableLayoutPanel1 = new TableLayoutPanel();
            brnSeach = new Button();
            btnClear = new Button();
            txtSearchName = new TextBox();
            label1 = new Label();
            cmbSearchGender = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(12, 131);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(791, 315);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // brnSeach
            // 
            brnSeach.Location = new Point(584, 45);
            brnSeach.Name = "brnSeach";
            brnSeach.Size = new Size(94, 29);
            brnSeach.TabIndex = 1;
            brnSeach.Text = "Search";
            brnSeach.UseVisualStyleBackColor = true;
            brnSeach.Click += SeachByName;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(709, 45);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += ClearSearch;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(111, 45);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.PlaceholderText = "Enter Search Name";
            txtSearchName.Size = new Size(204, 27);
            txtSearchName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Name :";
            // 
            // cmbSearchGender
            // 
            cmbSearchGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchGender.FormattingEnabled = true;
            cmbSearchGender.Location = new Point(407, 46);
            cmbSearchGender.Name = "cmbSearchGender";
            cmbSearchGender.Size = new Size(151, 28);
            cmbSearchGender.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Gender :";
            // 
            // EmployeeUi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 458);
            Controls.Add(label2);
            Controls.Add(cmbSearchGender);
            Controls.Add(label1);
            Controls.Add(txtSearchName);
            Controls.Add(btnClear);
            Controls.Add(brnSeach);
            Controls.Add(tableLayoutPanel1);
            Name = "EmployeeUi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Selected";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button brnSeach;
        private Button btnClear;
        private TextBox txtSearchName;
        private Label label1;
        private ComboBox cmbSearchGender;
        private Label label2;
    }
}
