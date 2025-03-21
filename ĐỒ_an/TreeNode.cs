using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỒ_an
{
    class TreeNode
    {
        public string Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(string data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
        // Duyệt cây theo NLR
        public void PreOrder(TreeNode node, List<string> result)
        {
            if (node == null) return;
            result.Add(node.Data);
            PreOrder(node.Left, result);
            PreOrder(node.Right, result);
        }

        // Duyệt cây theo LNR
        public void InOrder(TreeNode node, List<string> result)
        {
            if (node == null) return;
            InOrder(node.Left, result);
            result.Add(node.Data);
            InOrder(node.Right, result);
        }

        // Duyệt cây theo LRN
        public void PostOrder(TreeNode node, List<string> result)
        {
            if (node == null) return;
            PostOrder(node.Left, result);
            PostOrder(node.Right, result);
            result.Add(node.Data);
        }
    }
}
