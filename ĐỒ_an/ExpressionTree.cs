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

            foreach (char c in postfixExpression)
            {
                if (char.IsDigit(c))
                {
                    stack.Push(new TreeNode(c.ToString()));
                }
                else
                {
                    TreeNode node = new TreeNode(c.ToString());
                    node.Right = stack.Pop();
                    node.Left = stack.Pop();
                    stack.Push(node);
                }
            }

            Root = stack.Pop();
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
    }
}
