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
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 385);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 35);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(99, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "button2";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(12, 357);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(202, 22);
            this.txtExpression.TabIndex = 2;
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tree.Location = new System.Drawing.Point(12, 12);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(776, 328);
            this.Tree.TabIndex = 3;
            this.Tree.TabStop = false;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(241, 363);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(44, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label1";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.MouseEnter += (s, e) => btnCalculate.BackColor = Color.CornflowerBlue;
            btnCalculate.MouseLeave += (s, e) => btnCalculate.BackColor = buttonColor;

            btnClear.BackColor = clearButtonColor;
            btnClear.ForeColor = textColor;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Cursor = Cursors.Hand;
            btnClear.MouseEnter += (s, e) => btnClear.BackColor = Color.Red;
            btnClear.MouseLeave += (s, e) => btnClear.BackColor = clearButtonColor;
        
            btnToggleTheme2.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnToggleTheme2.ForeColor = textColor;
            btnToggleTheme2.FlatStyle = FlatStyle.Flat;
            btnToggleTheme2.FlatAppearance.BorderSize = 1;
            btnToggleTheme2.Cursor = Cursors.Hand;
        
            btnShowTraversal.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnShowTraversal.ForeColor = textColor;
            btnShowTraversal.FlatStyle = FlatStyle.Flat;
            btnShowTraversal.FlatAppearance.BorderSize = 1;
            btnShowTraversal.Cursor = Cursors.Hand;
        
            btnCheckTreeType.BackColor = isDarkMode ? Color.Gray : Color.DarkGray;
            btnCheckTreeType.ForeColor = textColor;
            btnCheckTreeType.FlatStyle = FlatStyle.Flat;
            btnCheckTreeType.FlatAppearance.BorderSize = 1;
            btnCheckTreeType.Cursor = Cursors.Hand;
        
        
            lblResult.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResult.Padding = new Padding(5);
        
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
    }
}

