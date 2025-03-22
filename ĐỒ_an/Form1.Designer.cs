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
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(191, 89);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 74);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Tính và vẽ cây";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(368, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 74);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpression.Location = new System.Drawing.Point(191, 12);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(334, 34);
            this.txtExpression.TabIndex = 2;
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tree.Location = new System.Drawing.Point(12, 188);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(1225, 445);
            this.Tree.TabIndex = 3;
            this.Tree.TabStop = false;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(90, 26);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Kết quả:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnToggleTheme2
            // 
            this.btnToggleTheme2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleTheme2.Location = new System.Drawing.Point(771, 12);
            this.btnToggleTheme2.Name = "btnToggleTheme2";
            this.btnToggleTheme2.Size = new System.Drawing.Size(137, 64);
            this.btnToggleTheme2.TabIndex = 6;
            this.btnToggleTheme2.Text = "Đổi nền";
            this.btnToggleTheme2.UseVisualStyleBackColor = true;
            this.btnToggleTheme2.Click += new System.EventHandler(this.btnToggleTheme2_Click);
            // 
            // btnShowTraversal
            // 
            this.btnShowTraversal.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTraversal.Location = new System.Drawing.Point(1059, 12);
            this.btnShowTraversal.Name = "btnShowTraversal";
            this.btnShowTraversal.Size = new System.Drawing.Size(128, 64);
            this.btnShowTraversal.TabIndex = 7;
            this.btnShowTraversal.Text = "Duyệt cây";
            this.btnShowTraversal.UseVisualStyleBackColor = true;
            this.btnShowTraversal.Click += new System.EventHandler(this.btnShowTraversal_Click);
            // 
            // btnCheckTreeType
            // 
            this.btnCheckTreeType.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTreeType.Location = new System.Drawing.Point(914, 12);
            this.btnCheckTreeType.Name = "btnCheckTreeType";
            this.btnCheckTreeType.Size = new System.Drawing.Size(139, 64);
            this.btnCheckTreeType.TabIndex = 8;
            this.btnCheckTreeType.Text = "Phân loại cây";
            this.btnCheckTreeType.UseVisualStyleBackColor = true;
            this.btnCheckTreeType.Click += new System.EventHandler(this.btnCheckTreeType_Click);
            // 
            // lblResultInput
            // 
            this.lblResultInput.AutoSize = true;
            this.lblResultInput.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultInput.Location = new System.Drawing.Point(12, 15);
            this.lblResultInput.Name = "lblResultInput";
            this.lblResultInput.Size = new System.Drawing.Size(153, 25);
            this.lblResultInput.TabIndex = 9;
            this.lblResultInput.Text = "Nhập biểu thức:";
            // 
            // lblResultFunction
            // 
            this.lblResultFunction.AutoSize = true;
            this.lblResultFunction.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFunction.Location = new System.Drawing.Point(594, 20);
            this.lblResultFunction.Name = "lblResultFunction";
            this.lblResultFunction.Size = new System.Drawing.Size(147, 25);
            this.lblResultFunction.TabIndex = 10;
            this.lblResultFunction.Text = "Các chức năng:";
            // 
            // btnTreeInfo
            // 
            this.btnTreeInfo.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeInfo.Location = new System.Drawing.Point(771, 82);
            this.btnTreeInfo.Name = "btnTreeInfo";
            this.btnTreeInfo.Size = new System.Drawing.Size(137, 62);
            this.btnTreeInfo.TabIndex = 11;
            this.btnTreeInfo.Text = "Xem thông tin";
            this.btnTreeInfo.UseVisualStyleBackColor = true;
            this.btnTreeInfo.Click += new System.EventHandler(this.btnTreeInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1249, 645);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void StyleUI()
        {
            Color backgroundColor = isLightMode ? Color.FromArgb(30, 30, 30) : Color.White;
            Color textColor = isLightMode ? Color.White : Color.Black;
            Color buttonColor = isLightMode ? Color.FromArgb(70, 130, 180) : Color.LightBlue;
            Color clearButtonColor = isLightMode ? Color.FromArgb(220, 20, 60) : Color.LightCoral;
            Color panelColor = isLightMode ? Color.FromArgb(40, 40, 40) : Color.White;
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

            lblResult.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResult.Padding = new Padding(5);

            lblResultInput.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResultInput.Padding = new Padding(5);

            lblResultFunction.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResultFunction.Padding = new Padding(5);

            Tree.BackColor = panelColor;
            Tree.BorderStyle = BorderStyle.FixedSingle;

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
    }
}

