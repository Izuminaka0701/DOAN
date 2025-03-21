using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private ExpressionTree tree;

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
                string postfixExpression = string.Join(" ", ExpressionParser.InfixToPostfix(infixExpression));

                tree = new ExpressionTree();
                tree.BuildTree(postfixExpression);

                double result = tree.Evaluate(tree.Root);
                lblResult.Text = "Kết quả: " + result.ToString();

                if (tree.Root != null)
                {
                    Tree.Refresh();
                    DrawTree(tree.Root, Tree.CreateGraphics(), Tree.Width / 2, 30, 100);
                }
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
        private void DrawTree(TreeNode node, Graphics g, int x, int y, int xOffset)
        {
            if (node == null) return;

            int nodeSize = 35; // Kích thước node
            Font nodeFont = new Font("Times New Roman", 13, FontStyle.Bold);
            Pen branchPen = new Pen(Color.ForestGreen, 3); // Màu đường nối

            // Vẽ đường nối đến node con trái
            if (node.Left != null)
            {
                g.DrawLine(branchPen, x, y, x - xOffset, y + 60);
                DrawTree(node.Left, g, x - xOffset, y + 60, xOffset / 2);
            }

            // Vẽ đường nối đến node con phải
            if (node.Right != null)
            {
                g.DrawLine(branchPen, x, y, x + xOffset, y + 60);
                DrawTree(node.Right, g, x + xOffset, y + 60, xOffset / 2);
            }

            // Vẽ node (hình tròn)
            g.FillEllipse(Brushes.LightBlue, x - nodeSize / 2, y - nodeSize / 2, nodeSize, nodeSize);
            g.DrawEllipse(Pens.Black, x - nodeSize / 2, y - nodeSize / 2, nodeSize, nodeSize);

            // Hiển thị dữ liệu của node
            SizeF textSize = g.MeasureString(node.Data, nodeFont);
            g.DrawString(node.Data, nodeFont, Brushes.Black, x - textSize.Width / 2, y - textSize.Height / 2);

        }
        private void btnShowTraversal_Click(object sender, EventArgs e)
        {
            if (tree == null || tree.Root == null)
            {
                MessageBox.Show("Vui lòng nhập biểu thức và tạo cây trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string preOrder = tree.PreOrderTraversal();
            string inOrder = tree.InOrderTraversal();
            string postOrder = tree.PostOrderTraversal();

            MessageBox.Show($"Preorder: {preOrder}\nInorder: {inOrder}\nPostorder: {postOrder}", "Kết quả Duyệt Cây");
        }
        private void btnCheckTreeType_Click(object sender, EventArgs e)
        {
            if (tree == null || tree.Root == null)
            {
                MessageBox.Show("Vui lòng nhập biểu thức và tạo cây trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string treeType = tree.GetTreeType();
            MessageBox.Show($"Loại cây: {treeType}", "Thông tin cây");
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
