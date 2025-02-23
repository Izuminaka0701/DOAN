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
    }
}
