using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Theory
{
    public class MyNode
    {
        private MyNode _left;

        private MyNode _right;

        public MyNode(int value)
        {
            this.Value = value;
        }

        public int Deep
        {
            get
            {
                if (Parent == null)
                    return 0;
                else
                    return Parent.Deep + 1;
            }
            private set
            {

            }
        }

        public int Value { get; set; }

        public int Level
        {
            get
            {
                if (Parent == null)
                    return 1;
                else
                    return Parent.Level + 1;
            }
            private set
            {

            }
        }

        public MyNode Parent { get; set; }

        public MyNode Left
        {
            get { return _left; }
            set
            {
                _left = value;
                _left.Parent = this;
            }
        }

        public MyNode Right {
            get { return _right; }
            set
            {
                _right = value;
                _right.Parent = this;
            }
        }

        public string GetPreOrder()
        {
            string preOrder = string.Empty;
            if(Left == null && Right== null)
            {
                preOrder = GetNodeString();
            }

            if (Left != null && Right == null)
            {
                preOrder += GetNodeString();
                preOrder += $"({Left.GetPreOrder()} )";
            }

            if (Left == null && Right != null)
            {
                preOrder += GetNodeString();
                preOrder += $"( {Right.GetPreOrder()})";
            }

            if (Left != null && Right != null)
            {
                preOrder += GetNodeString();
                preOrder += $"({Left.GetPreOrder()} {Right.GetPreOrder()})";
            }

            return preOrder;
        }

        public string GetInOrder()
        {
            string inOrder = string.Empty;
            if (Left == null && Right == null)
            {
                inOrder = GetNodeString();
            }

            if (Left != null && Right == null)
            {
                inOrder += $"(";
                inOrder += $"({Left.GetInOrder()})";
                inOrder += $" {GetNodeString()} ";
                inOrder += $")";

            }

            if (Left == null && Right != null)
            {
                inOrder += $"(";
                inOrder += $" {GetNodeString()} ";
                inOrder += $"({Right.GetInOrder()})";
                inOrder += $")";
            }

            if (Left != null && Right != null)
            {
                inOrder += $"(";
                inOrder += $"({Left.GetInOrder()})";
                inOrder += $" {GetNodeString()} ";
                inOrder += $"({Right.GetInOrder()})";
                inOrder += $")";
            }

            return inOrder;
        }

        private string GetNodeString()
        {
            return (Parent == null) ? Value.ToString() : $"({Value.ToString()})";
        }
    }
}
