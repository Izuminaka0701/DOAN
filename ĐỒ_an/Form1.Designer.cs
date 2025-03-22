using System.Drawing;
using System.Windows.Forms;

namespace ĐỒ_an
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
        private bool isDarkMode = true;
        private bool isLightMode = true;
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.Tree = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnToggleTheme2 = new System.Windows.Forms.Button();
            this.btnShowTraversal = new System.Windows.Forms.Button();
            this.btnCheckTreeType = new System.Windows.Forms.Button();
            this.lblResultInput = new System.Windows.Forms.Label();
            this.lblResultFunction = new System.Windows.Forms.Label();
            this.btnTreeInfo = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(167, 101);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 70);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Tính và vẽ cây";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(322, 101);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 70);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpression.Location = new System.Drawing.Point(167, 11);
            this.txtExpression.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(293, 34);
            this.txtExpression.TabIndex = 2;
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tree.Location = new System.Drawing.Point(10, 176);
            this.Tree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(784, 417);
            this.Tree.TabIndex = 3;
            this.Tree.TabStop = false;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(163, 56);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(90, 26);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Kết quả:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnToggleTheme2
            // 
            this.btnToggleTheme2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleTheme2.Location = new System.Drawing.Point(674, 11);
            this.btnToggleTheme2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnToggleTheme2.Name = "btnToggleTheme2";
            this.btnToggleTheme2.Size = new System.Drawing.Size(120, 60);
            this.btnToggleTheme2.TabIndex = 6;
            this.btnToggleTheme2.Text = "Đổi nền";
            this.btnToggleTheme2.UseVisualStyleBackColor = true;
            this.btnToggleTheme2.Click += new System.EventHandler(this.btnToggleTheme2_Click);
            // 
            // btnShowTraversal
            // 
            this.btnShowTraversal.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTraversal.Location = new System.Drawing.Point(926, 11);
            this.btnShowTraversal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowTraversal.Name = "btnShowTraversal";
            this.btnShowTraversal.Size = new System.Drawing.Size(112, 60);
            this.btnShowTraversal.TabIndex = 7;
            this.btnShowTraversal.Text = "Duyệt cây";
            this.btnShowTraversal.UseVisualStyleBackColor = true;
            this.btnShowTraversal.Click += new System.EventHandler(this.btnShowTraversal_Click);
            // 
            // btnCheckTreeType
            // 
            this.btnCheckTreeType.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTreeType.Location = new System.Drawing.Point(800, 11);
            this.btnCheckTreeType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheckTreeType.Name = "btnCheckTreeType";
            this.btnCheckTreeType.Size = new System.Drawing.Size(121, 60);
            this.btnCheckTreeType.TabIndex = 8;
            this.btnCheckTreeType.Text = "Phân loại cây";
            this.btnCheckTreeType.UseVisualStyleBackColor = true;
            this.btnCheckTreeType.Click += new System.EventHandler(this.btnCheckTreeType_Click);
            // 
            // lblResultInput
            // 
            this.lblResultInput.AutoSize = true;
            this.lblResultInput.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultInput.Location = new System.Drawing.Point(10, 14);
            this.lblResultInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultInput.Name = "lblResultInput";
            this.lblResultInput.Size = new System.Drawing.Size(153, 25);
            this.lblResultInput.TabIndex = 9;
            this.lblResultInput.Text = "Nhập biểu thức:";
            // 
            // lblResultFunction
            // 
            this.lblResultFunction.AutoSize = true;
            this.lblResultFunction.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFunction.Location = new System.Drawing.Point(520, 19);
            this.lblResultFunction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultFunction.Name = "lblResultFunction";
            this.lblResultFunction.Size = new System.Drawing.Size(147, 25);
            this.lblResultFunction.TabIndex = 10;
            this.lblResultFunction.Text = "Các chức năng:";
            // 
            // btnTreeInfo
            // 
            this.btnTreeInfo.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeInfo.Location = new System.Drawing.Point(800, 77);
            this.btnTreeInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTreeInfo.Name = "btnTreeInfo";
            this.btnTreeInfo.Size = new System.Drawing.Size(120, 58);
            this.btnTreeInfo.TabIndex = 11;
            this.btnTreeInfo.Text = "Xem thông tin";
            this.btnTreeInfo.UseVisualStyleBackColor = true;
            this.btnTreeInfo.Click += new System.EventHandler(this.btnTreeInfo_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 25;
            this.lstHistory.Location = new System.Drawing.Point(800, 224);
            this.lstHistory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(283, 129);
            this.lstHistory.TabIndex = 12;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(796, 184);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(266, 25);
            this.lblHistory.TabIndex = 13;
            this.lblHistory.Text = "Lịch sử nhập và kết quả tính:";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.Location = new System.Drawing.Point(927, 374);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(156, 48);
            this.btnClearHistory.TabIndex = 14;
            this.btnClearHistory.Text = "Xóa lịch sử";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(926, 77);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(112, 58);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.Text = "Hướng dẫn";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 605);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnTreeInfo);
            this.Controls.Add(this.lblResultFunction);
            this.Controls.Add(this.lblResultInput);
            this.Controls.Add(this.btnCheckTreeType);
            this.Controls.Add(this.btnShowTraversal);
            this.Controls.Add(this.btnToggleTheme2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void StyleUI()
        {
            Color backgroundColor = isLightMode ? Color.FromArgb(0, 0, 0) : Color.White;
            Color textColor = isLightMode ? Color.White : Color.Black;
            Color buttonColor = isLightMode ? Color.FromArgb(70, 130, 180) : Color.LightBlue;
            Color clearButtonColor = isLightMode ? Color.FromArgb(220, 20, 60) : Color.LightCoral;
            Color panelColor = isLightMode ? Color.FromArgb(255, 255, 255) : Color.Black;
            Color branchColor = isLightMode ? Color.White : Color.Black;
            Color nodeTextColor = isLightMode ? Color.Black : Color.White;

            this.BackColor = backgroundColor;
            txtExpression.BackColor = isLightMode ? Color.FromArgb(50, 50, 50) : Color.LightGray;
            txtExpression.ForeColor = textColor;
            txtExpression.BorderStyle = BorderStyle.FixedSingle;
            txtExpression.Padding = new Padding(5);

            btnCalculate.BackColor = buttonColor;
            btnCalculate.ForeColor = textColor;
            btnCalculate.FlatStyle = FlatStyle.Standard;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.MouseEnter += (s, e) => btnCalculate.BackColor = Color.CornflowerBlue;
            btnCalculate.MouseLeave += (s, e) => btnCalculate.BackColor = buttonColor;

            btnClear.BackColor = clearButtonColor;
            btnClear.ForeColor = textColor;
            btnClear.FlatStyle = FlatStyle.Standard;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Cursor = Cursors.Hand;
            btnClear.MouseEnter += (s, e) => btnClear.BackColor = Color.Red;
            btnClear.MouseLeave += (s, e) => btnClear.BackColor = clearButtonColor;

            btnToggleTheme2.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnToggleTheme2.ForeColor = textColor;
            btnToggleTheme2.FlatStyle = FlatStyle.Standard;
            btnToggleTheme2.FlatAppearance.BorderSize = 1;
            btnToggleTheme2.Cursor = Cursors.Hand;

            btnShowTraversal.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnShowTraversal.ForeColor = textColor;
            btnShowTraversal.FlatStyle = FlatStyle.Standard;
            btnShowTraversal.FlatAppearance.BorderSize = 1;
            btnShowTraversal.Cursor = Cursors.Hand;

            btnCheckTreeType.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnCheckTreeType.ForeColor = textColor;
            btnCheckTreeType.FlatStyle = FlatStyle.Standard;
            btnCheckTreeType.FlatAppearance.BorderSize = 1;
            btnCheckTreeType.Cursor = Cursors.Hand;

            btnTreeInfo.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnTreeInfo.ForeColor = textColor;
            btnTreeInfo.FlatStyle = FlatStyle.Standard;
            btnTreeInfo.FlatAppearance.BorderSize = 1;
            btnTreeInfo.Cursor = Cursors.Hand;

            btnClearHistory.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnClearHistory.ForeColor = textColor;
            btnClearHistory.FlatStyle = FlatStyle.Standard;
            btnClearHistory.FlatAppearance.BorderSize = 1;
            btnClearHistory.Cursor = Cursors.Hand;

            btnHelp.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnHelp.ForeColor = textColor;
            btnHelp.FlatStyle = FlatStyle.Standard;
            btnHelp.FlatAppearance.BorderSize = 1;
            btnHelp.Cursor = Cursors.Hand;

            lblResult.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResult.Padding = new Padding(5);

            lblResultInput.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResultInput.Padding = new Padding(5);

            lblResultFunction.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResultFunction.Padding = new Padding(5);

            lblHistory.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblHistory.Padding = new Padding(5);

            Tree.BackColor = panelColor;
            Tree.BorderStyle = BorderStyle.FixedSingle;

            this.Refresh();
        }
        private void ChangeBackGroundColor()
        {
            isLightMode = !isLightMode;
            this.BackColor = isLightMode ? Color.FromArgb(30, 30, 30) : Color.White;
            txtExpression.BackColor = isLightMode ? Color.FromArgb(50, 50, 50) : Color.LightGray;
            txtExpression.ForeColor = isLightMode ? Color.White : Color.Black;

            btnCalculate.BackColor = isLightMode ? Color.FromArgb(70, 130, 180) : Color.LightBlue;
            btnClear.BackColor = isLightMode ? Color.FromArgb(220, 20, 60) : Color.LightCoral;
            btnToggleTheme2.BackColor = isLightMode ? Color.Gray : Color.DarkGray;
            btnCheckTreeType.BackColor = isLightMode ? Color.Gray : Color.DarkGray;
            btnClearHistory.BackColor = isLightMode ? Color.Gray : Color.DarkGray;
            btnShowTraversal.BackColor = isLightMode ? Color.Gray : Color.DarkGray;
            btnHelp.BackColor = isLightMode ? Color.Gray : Color.DarkGray;
            btnTreeInfo.BackColor = isLightMode ? Color.Gray : Color.DarkGray;

            btnCalculate.ForeColor = isLightMode ? Color.White : Color.Black;
            btnClear.ForeColor = isLightMode ? Color.White : Color.Black;
            btnCheckTreeType.ForeColor = isLightMode ? Color.White : Color.Black;
            btnClearHistory.ForeColor = isLightMode ? Color.White : Color.Black;
            btnHelp.ForeColor = isLightMode ? Color.White : Color.Black;
            btnShowTraversal.ForeColor = isLightMode ? Color.White : Color.Black;
            btnToggleTheme2.ForeColor = isLightMode ? Color.White : Color.Black;
            btnTreeInfo.ForeColor = isLightMode ? Color.White : Color.Black;

            lblResult.ForeColor = isLightMode ? Color.LightGreen : Color.DarkGreen;
            lblResultInput.ForeColor = isLightMode ? Color.LightGreen : Color.DarkGreen;
            lblResultFunction.ForeColor = isLightMode ? Color.LightGreen : Color.DarkGreen;
            lblHistory.ForeColor = isLightMode ? Color.LightGreen : Color.DarkGreen;
            Tree.BackColor = isLightMode ? Color.White : Color.Black;

            this.Refresh();
        }
        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.PictureBox Tree;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnToggleTheme2;
        private System.Windows.Forms.Button btnShowTraversal;
        private System.Windows.Forms.Button btnCheckTreeType;
        private Label lblResultInput;
        private Label lblResultFunction;
        private Button btnTreeInfo;
        private ListBox lstHistory;
        private Label lblHistory;
        private Button btnClearHistory;
        private Button btnHelp;
    }
}

