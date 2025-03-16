using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒ_an
{
    public partial class Form1 : Form
    {
        private ExpressionTree currentTree;
        private bool isDarkMode = true;
        private bool isLightMode = true;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator with Expression Tree";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(50, 50, 50);

            btnCalculate.Click += btnCalculate_Click;
            btnClear.Click += btnClear_Click;
            lblResult.Click += (s, e) =>
            {
                Clipboard.SetText(lblResult.Text.Replace("Kết quả: ", ""));
            };
            StyleUI();
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

            lblResult.ForeColor = isDarkMode ? Color.LightGreen : Color.DarkGreen;
            lblResult.Padding = new Padding(5);

            Tree.BackColor = panelColor;
            Tree.BorderStyle = BorderStyle.FixedSingle;

            this.Refresh();
        }
        private void btnToggleTheme2_Click(object sender, EventArgs e)
        {
            isLightMode = !isLightMode;
            this.BackColor = isLightMode ? Color.FromArgb(30, 30, 30) : Color.White;
            txtExpression.BackColor = isLightMode ? Color.FromArgb(50, 50, 50) : Color.LightGray;
            txtExpression.ForeColor = isLightMode ? Color.White : Color.Black;

            btnCalculate.BackColor = isLightMode ? Color.FromArgb(70, 130, 180) : Color.LightBlue;
            btnClear.BackColor = isLightMode ? Color.FromArgb(220, 20, 60) : Color.LightCoral;
            btnToggleTheme2.BackColor = isLightMode ? Color.DarkGray : Color.Gray;

            lblResult.ForeColor = isLightMode ? Color.LightGreen : Color.DarkGreen;
            Tree.BackColor = isLightMode ? Color.White : Color.Black;

            this.Refresh();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string infixExpression = txtExpression.Text;
                string postfixExpression = InfixToPostfix(infixExpression);

                ExpressionTree tree = new ExpressionTree();
                tree.BuildTree(postfixExpression);

                double result = tree.Evaluate(tree.Root);
                lblResult.Text = "Kết quả: " + result.ToString();

                Tree.Refresh();
                DrawTree(tree.Root, Tree.CreateGraphics(), Tree.Width / 2, 30, 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpression.Clear();
            lblResult.Text = "Kết quả: ";
            Tree.Refresh();
        }
        private string InfixToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string postfix = "";
            foreach (char c in infix)
            {
                if (char.IsDigit(c))
                {
                    postfix += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(c))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                postfix += stack.Pop();
            }
            return postfix;
        }

        private int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }
        private void DrawTree(TreeNode node, Graphics g, int x, int y, int xOffset)
        {
            if (node == null)
                return;

            g.DrawEllipse(Pens.White, x - 15, y - 15, 30, 30);
            g.DrawString(node.Data, Font, Brushes.White, x - 10, y - 10);
            Pen branchPen = new Pen(isDarkMode ? Color.Gray : Color.Black, 3);

            if (node.Left != null)
            {
                g.DrawLine(branchPen, x, y, x - xOffset, y + 50);
                DrawTree(node.Left, g, x - xOffset, y + 50, xOffset / 2);
            }

            if (node.Right != null)
            {
                g.DrawLine(branchPen, x, y, x + xOffset, y + 50);
                DrawTree(node.Right, g, x + xOffset, y + 50, xOffset / 2);
            }


            Brush brush = new SolidBrush(Color.LightBlue);
            Pen pen = new Pen(Color.White, 2);
            Font font = new Font("Arial", 12, FontStyle.Bold);

            g.FillEllipse(brush, x - 15, y - 15, 30, 30);
            g.DrawEllipse(pen, x - 15, y - 15, 30, 30);
            g.DrawString(node.Data, font, Brushes.Black, x - 10, y - 10);

        }
        private void txtExpression_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tree_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
