namespace BinarySearchTreePrograms
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //Console.WriteLine("Welcome to Master branch of Binary Search Tree.");

            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(11);
            bst.Insert(16);
            bst.Insert(3);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(65);
            bst.Insert(63);
            bst.Insert(67);

            //Console.WriteLine("\n");
            Console.WriteLine("Size of BST: " + bst.Size(bst.root));

            Console.WriteLine("Preorder Traversal of BST:");
            bst.PreorderTraversal(bst.root);

            Node node1 = bst.Search(bst.root,63);
            if (node1 == null)
            {
                Console.WriteLine("Node not found");
            }
            else
            {
                Console.WriteLine("Node found: " + node1.data);
            }



        }

    }
}