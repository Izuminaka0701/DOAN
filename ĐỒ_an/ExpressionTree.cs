using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỒ_an
{
    class ExpressionTree
    {
        public TreeNode Root { get; set; }

        public ExpressionTree()
        {
            Root = null;
        }

        public void BuildTree(string postfixExpression)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            string[] tokens = postfixExpression.Split(' '); // Chia theo khoảng trắng

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out _)) // Kiểm tra nếu là số
                {
                    stack.Push(new TreeNode(token));
                }
                else // Nếu là toán tử
                {
                    if (stack.Count < 2)
                        throw new Exception("Biểu thức không hợp lệ");

                    TreeNode node = new TreeNode(token);
                    node.Right = stack.Pop();
                    node.Left = stack.Pop();
                    stack.Push(node);
                }
            }

            if (stack.Count != 1)
                throw new Exception("Biểu thức không hợp lệ");

            Root = stack.Pop();
        }
        public string PreOrderTraversal()
        {
            return PreOrder(Root).Trim();
        }

        private string PreOrder(TreeNode node)
        {
            if (node == null) return "";
            return node.Data + " " + PreOrder(node.Left) + PreOrder(node.Right);
        }

        public string InOrderTraversal()
        {
            return InOrder(Root).Trim();
        }

        private string InOrder(TreeNode node)
        {
            if (node == null) return "";
            return InOrder(node.Left) + node.Data + " " + InOrder(node.Right);
        }

        public string PostOrderTraversal()
        {
            return PostOrder(Root).Trim();
        }

        private string PostOrder(TreeNode node)
        {
            if (node == null) return "";
            return PostOrder(node.Left) + PostOrder(node.Right) + node.Data + " ";
        }
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        public double Evaluate(TreeNode node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return double.Parse(node.Data);

            double leftValue = Evaluate(node.Left);
            double rightValue = Evaluate(node.Right);

            switch (node.Data)
            {
                case "+": return leftValue + rightValue;
                case "-": return leftValue - rightValue;
                case "*": return leftValue * rightValue;
                case "/": return leftValue / rightValue;
                default: throw new ArgumentException("Invalid operator");
            }
        }
        public string GetTraversal(TreeNode node, string type)
        {
            List<string> result = new List<string>();
            switch (type)
            {
                case "NLR": node.PreOrder(node, result); break;
                case "LNR": node.InOrder(node, result); break;
                case "LRN": node.PostOrder(node, result); break;
                default: return "Không hợp lệ";
            }
            return string.Join(" ", result);
        }
        public string GetTreeType()
        {
            if (Root == null) return "Cây rỗng";

            if (IsBST(Root)) return "Cây nhị phân tìm kiếm (BST)";
            if (IsAVL(Root)) return "Cây AVL (Cây tìm kiếm cân bằng)";
            if (IsFullBinaryTree(Root)) return "Cây nhị phân đầy đủ (Full Binary Tree)";
            if (IsCompleteBinaryTree(Root)) return "Cây nhị phân hoàn chỉnh (Complete Binary Tree)";

            return "Cây nhị phân thông thường";
        }

        // Kiểm tra cây có phải BST không (Chỉ nhận node có giá trị số)
        private bool IsBST(TreeNode node, int min = int.MinValue, int max = int.MaxValue)
        {
            if (node == null) return true;

            if (!int.TryParse(node.Data, out int value)) return false; // Nếu không phải số thì không phải BST

            if (value <= min || value >= max) return false;

            return IsBST(node.Left, min, value) && IsBST(node.Right, value, max);
        }

        // Kiểm tra cây có phải AVL không
        private bool IsAVL(TreeNode node)
        {
            if (node == null) return true;

            int balanceFactor = GetHeight(node.Left) - GetHeight(node.Right);
            if (Math.Abs(balanceFactor) > 1) return false;

            return IsAVL(node.Left) && IsAVL(node.Right);
        }

        // Kiểm tra cây có phải Full Binary Tree không
        private bool IsFullBinaryTree(TreeNode node)
        {
            if (node == null) return true;

            if ((node.Left == null && node.Right != null) || (node.Left != null && node.Right == null))
                return false;

            return IsFullBinaryTree(node.Left) && IsFullBinaryTree(node.Right);
        }

        // Kiểm tra cây có phải Complete Binary Tree không
        private bool IsCompleteBinaryTree(TreeNode node, int index = 0, int nodeCount = -1)
        {
            if (nodeCount == -1) nodeCount = CountNodes(Root);
            if (node == null) return true;
            if (index >= nodeCount) return false;

            return IsCompleteBinaryTree(node.Left, 2 * index + 1, nodeCount) &&
                   IsCompleteBinaryTree(node.Right, 2 * index + 2, nodeCount);
        }

        // Tính số lượng node trong cây
        private int CountNodes(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        // Tính chiều cao của cây
        private int GetHeight(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

    }
}
