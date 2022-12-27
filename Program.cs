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
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                    {
                        parent.lchild = tmp;
                    }
                }
                else
                {
                    parent.rchild = tmp;
                }
            }
        }
        public void Find(string element, ref Node parent, ref Node currentnode)
        {
            currentnode = ROOT;
            parent = null;
            while ((currentnode != null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                {
                    currentnode = currentnode.lchild;
                }
                else
                {
                    currentnode = currentnode.rchild;
                }
            }
        }
        public void Inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Inorder(ptr.lchild);
                Console.WriteLine(ptr.info + " ");
                Inorder(ptr.rchild);
            }
        }
        public void Preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                Inorder(ptr.lchild);
                Inorder(ptr.rchild);
            }
        }
        public void Posteorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Inorder(ptr.lchild);
                Inorder(ptr.rchild);
                Console.WriteLine(ptr.info + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Insert operation");
                Console.WriteLine("2. Inorder traversal");
                Console.WriteLine("3. Preorder traversal");
                Console.WriteLine("4. Postorder traversal");
                Console.WriteLine("5. exit\n");
                Console.WriteLine("Enter your choice (1-5): ");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("Enter a word: ");
                        string word = Console.ReadLine();
                        x.Insert(word);
                        break;
                    case '2':
                        x.Inorder(x.ROOT)
                        break;
                    case '3':
                        x.Preorder(x.ROOT);
                        break;
                    case '4':
                        x.Posteorder(x.ROOT);
                        break;
                    case '5':
                        return;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option!!");
                        break;
                }
            }
        }
    }
}