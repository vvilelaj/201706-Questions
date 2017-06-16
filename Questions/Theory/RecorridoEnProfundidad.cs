using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Theory
{
    public class RecorridoEnProfundidad
    {
        private Stack<MyNode> stack = new Stack<MyNode>();

        public string GetPreOrdenRec(MyNode tree)
        {
            if (tree == null)
                return null;

            var result = tree.GetPreOrder();

            return result;
        }

        public string GetInOrdenRec(MyNode tree)
        {
            if (tree == null)
                return null;

            var result = tree.GetInOrder();

            return result;
        }

        public string GetPreOrdenIterativo(MyNode tree)
        {
            if (tree == null)
            {
                return null;
            }

            stack.Clear();
            stack.Push(tree);

            var result = string.Empty;
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();

                result += (currentNode.Parent == null) ?  currentNode.Value.ToString() : $"({currentNode.Value.ToString()})";

                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                }

                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                }
            }

            return result;
        }

        public string GetInOrdenIterativo(MyNode tree)
        {
            if (tree == null)
            {
                return null;
            }

            stack.Clear();
            stack.Push(tree);

            var result = string.Empty;
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();


                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                }

                stack.Push(currentNode);

                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                }
            }

            return result;
        }
    }
}
