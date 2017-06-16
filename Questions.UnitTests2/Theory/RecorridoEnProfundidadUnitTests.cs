using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questions.Theory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.UnitTests2.Theory
{
    [TestClass]
    public class RecorridoEnProfundidadUnitTests
    {
        [TestClass]
        public class GetPreOrden
        {
            [TestMethod]
            public void GetPreOrden_RootNodeIsNull_ReturnsNull()
            {
                var tree = (MyNode)null;
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenRec(tree);

                Assert.AreEqual<string>(null, result);
            }

            [TestMethod]
            public void GetPreOrden_RootNodeHasNoChildren_ReturnsRootValue()
            {
                var tree = new MyNode(1);
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenRec(tree);

                Assert.AreEqual<string>("1", result);
            }

            [TestMethod]
            public void GetPreOrden_RootNodeHasLeftChildren_ReturnsRootValue()
            {
                var tree = new MyNode(1);
                tree.Left = new MyNode(2);
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenRec(tree);

                Assert.AreEqual<string>("1((2) )", result);
            }

            [TestMethod]
            public void GetPreOrden_RootNodeHasRightChildren_ReturnsRootValue()
            {
                var tree = new MyNode(1);
                tree.Right = new MyNode(3);
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenRec(tree);
                Assert.AreEqual<string>("1( (3))", result);
            }

            [TestMethod]
            public void GetPreOrden_RootNodeHasChildren_ReturnsRootValue()
            {
                var tree = new MyNode(1);
                tree.Left = new MyNode(3);
                tree.Right = new MyNode(2);
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenRec(tree);
                Assert.AreEqual<string>("1((3) (2))", result);
            }

            [TestMethod]
            public void GetPreOrden_RootNodeHasManyChildren_ReturnsRootValue()
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
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenRec(tree);
                Assert.AreEqual<string>("2((7)((2) (6)((5) (11))) (5)( (9)((4) )))", result);
            }
        }

        [TestClass]
        public class GetPreOrdenIte
        {
            [TestMethod]
            public void GetPreOrdenIte_TreeIsNull_ReturnsNull()
            {
                MyNode rootNode = null;
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenIterativo(rootNode);

                Assert.IsNull(result);
            }

            [TestMethod]
            public void GetPreOrdenIte_TreeOnlyHasRoot_ReturnsRootValue()
            {
                MyNode rootNode = new MyNode(10);
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenIterativo(rootNode);

                Assert.AreEqual("10",result);
            }

            [TestMethod]
            public void GetPreOrdenIte_TreeOnlyHasLeft_ReturnsRootValue()
            {
                MyNode rootNode = new MyNode(10);
                rootNode.Left = new MyNode(30);
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenIterativo(rootNode);

                Assert.AreEqual("10(30)", result);
            }

            [TestMethod]
            public void GetPreOrdenIte_TreeOnlyHasManyChildren_ReturnsRootValue()
            {
                var tree = new MyNode(2);
                //
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
                var recorridoEnProfundidad = new RecorridoEnProfundidad();

                var result = recorridoEnProfundidad.GetPreOrdenIterativo(tree);

                Assert.AreEqual("2(7)(2)(6)(5)(11)(5)(9)(4)", result);
            }
        }
    }
}
