using Questions.Theory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            var xx = new List<int>();
            var count1 = xx.Count();
            if (!xx.Contains(3))
            {
                xx.Add(3);
            }
            var count2 = xx.Count();


            MyNode tree = GetTree();

            Console.WriteLine($"Pre-Orden : {tree.GetPreOrder()}");
            Console.WriteLine($"Pre-Orden : {tree.GetInOrder()}");
            Console.ReadLine();
        }

        private static MyNode GetTree()
        {
            var tree = new MyNode(2);

            tree.Left = new MyNode(7);
            //
            tree.Left.Left = new MyNode(2);
            tree.Left.Right = new MyNode(6);
            //
            tree.Left.Right.Left = new MyNode(5);
            tree.Left.Right.Right = new MyNode(11);

            tree.Right = new MyNode(5);
            //
            tree.Right.Right = new MyNode(9);
            //
            tree.Right.Right.Left = new MyNode(4);
            return tree;
        }
    }
}
