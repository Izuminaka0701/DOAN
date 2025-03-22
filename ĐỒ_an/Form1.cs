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
        private ExpressionTree tree;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator with Expression Tree";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(50, 50, 50);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

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
            ChangeBackGroundColor();
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

                string historyEntry = $"{infixExpression} = {result}";
                if (!lstHistory.Items.Contains(historyEntry))
                {
                    lstHistory.Items.Insert(0, historyEntry);
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
        private void btnTreeInfo_Click(object sender, EventArgs e)
        {
            if (tree == null || tree.Root == null)
            {
                MessageBox.Show("Cây rỗng, không có thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nodeCount = tree.CountNodes();
            int treeHeight = tree.GetHeight();
            int leafCount = tree.CountLeaves();

            MessageBox.Show($"Thông tin Cây:\n\n"
                + $"Số lượng node: {nodeCount}\n"
                + $"Chiều cao cây: {treeHeight}\n"
                + $"Số lượng lá: {leafCount}",
                "Thông tin Cây", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            string guide = "Hướng Dẫn Sử Dụng\n\n" +
                   "Nhập biểu thức vào ô input (VD: 12 + 5 * 3)\n" +
                   "Nhấn nút 'Tính và vẽ cây' để xem kết quả và vẽ cây\n" +
                   "Nhấn nút 'Xóa' để xóa kết quả và cây\n" +
                   "Dùng tổ hợp phím nhanh:\n" +
                   "  • Ctrl + Enter: Tính toán và vẽ cây\n" +
                   "  • Ctrl + X: Xóa biểu thức và cây\n" +
                   "  • Ctrl + P: Phân loại cây\n" +
                   "  • Ctrl + R: Xóa lịch sử\n" +
                   "  • Ctrl + D: Duyệt cây\n" +
                   "  • Ctrl + F: Thông tin cây";

            MessageBox.Show(guide, "Hướng Dẫn Sử Dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter) btnCalculate.PerformClick();
            if (e.Control && e.KeyCode == Keys.R) lstHistory.Items.Clear();
            if (e.Control && e.KeyCode == Keys.X) btnClear.PerformClick();
            if (e.Control && e.KeyCode == Keys.P) btnCheckTreeType.PerformClick();
            if (e.Control && e.KeyCode == Keys.D) btnShowTraversal.PerformClick();
            if (e.Control && e.KeyCode == Keys.F) btnTreeInfo.PerformClick();
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
