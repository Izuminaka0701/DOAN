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
    public partial class Form1: Form
    {
        private ExpressionTree currentTree;
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click;
            btnClear.Click += btnClear_Click;
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

            if (node.Left != null)
            {
                g.DrawLine(Pens.White, x, y, x - xOffset, y + 50);
                DrawTree(node.Left, g, x - xOffset, y + 50, xOffset / 2);
            }

            if (node.Right != null)
            {
                g.DrawLine(Pens.White, x, y, x + xOffset, y + 50);
                DrawTree(node.Right, g, x + xOffset, y + 50, xOffset / 2);
            }
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
