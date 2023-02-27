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

            Console.WriteLine("Preorder Traversal of BST:");
            bst.PreorderTraversal(bst.root);
        }

    }
}