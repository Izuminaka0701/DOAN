using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐỒ_an
{
    class ExpressionParser
    {
        public static bool IsValidExpression(string expression)
        {
            // Kiểm tra biểu thức có hợp lệ không (dấu âm, dấu nhân chia, ngoặc...)
            Stack<char> stack = new Stack<char>();
            bool lastWasOperator = true;
            foreach (char c in expression)
            {
                if (char.IsDigit(c)) lastWasOperator = false;
                else if (c == '(') stack.Push(c);
                else if (c == ')') { if (stack.Count == 0) return false; stack.Pop(); }
                else if ("+-*/".Contains(c))
                {
                    if (lastWasOperator) return false;
                    lastWasOperator = true;
                }
                else return false;
            }
            return stack.Count == 0;
        }

        public static List<string> InfixToPostfix(string infix)
        {
            if (!IsValidExpression(infix)) throw new Exception("Biểu thức không hợp lệ");
            Stack<char> stack = new Stack<char>();
            List<string> output = new List<string>();

            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];
                if (char.IsDigit(c))
                {
                    string num = c.ToString();
                    while (i + 1 < infix.Length && char.IsDigit(infix[i + 1]))
                    {
                        num += infix[++i];
                    }
                    output.Add(num);
                }
                else if (c == '(') stack.Push(c);
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(') output.Add(stack.Pop().ToString());
                    stack.Pop();
                }
                else if ("+-*/".Contains(c))
                {
                    while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(c))
                        output.Add(stack.Pop().ToString());
                    stack.Push(c);
                }
            }
            while (stack.Count > 0) output.Add(stack.Pop().ToString());
            return output;
        }

        // Hàm xác định độ ưu tiên của toán tử
        private static int Precedence(char op)
        {
            return (op == '+' || op == '-') ? 1 : (op == '*' || op == '/') ? 2 : 0;
        }
    }
}
