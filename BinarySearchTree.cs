﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreePrograms
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;

                    if (data < current.data)
                    {
                        current = current.left;

                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void PreorderTraversal(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data+" ");
                PreorderTraversal(node.left);
                PreorderTraversal(node.right);
            }
        }

        public int Size(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return Size(node.right) + 1 + Size(node.left);
            }
        }

        public Node Search(Node node, int data)
        {
            if (node == null || node.data == data)
            {
                return node;
            }
            else if (data < node.data)
            {
                return Search(node.left, data);
            }
            else
            {
                return Search(node.right, data);
            }
        }
    }
}
    

