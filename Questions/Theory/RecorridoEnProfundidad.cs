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

        public string GetPreOrden(MyNode tree)
        {
            if (tree == null)
                return null;

            var result = tree.GetPreOrder();

            return result;
        }

        public string GetInOrden(MyNode tree)
        {
            if (tree == null)
                return null;

            var result = tree.GetInOrder();

            return result;
        }
    }
}
