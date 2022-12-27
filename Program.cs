using System.Security.Cryptography.X509Certificates;

namespace Binary_Search_Tree
{
    class Node
    {
        public string info;
        public Node lchild;
        public Node rchild;
        public Node(string i, Node l, Node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }

    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null;
        }

        public void Insert(string element)
        {
            Node tmp, parent = null, currentnode = null;
            Find(element, ref parent, ref currentnode);
            if (currentnode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else
            {

            }
        }
        public void Find(string element, ref Node parent, ref Node currentnode)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}