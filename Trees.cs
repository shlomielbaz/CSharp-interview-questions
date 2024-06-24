using Models;

namespace main;
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Trees
{
    TreeNode? root;

    public Trees()
    {
        root = null;
    }

    Trees(int value) { root = new TreeNode(value); }


    private TreeNode add(TreeNode root, int val)
    {
        if (root == null)
        {
            root = new TreeNode(val);
        }
        else
        {
            // Otherwise, recur down the tree
            if (val < root.val)
            {
                root.left = add(root.left, val);
            }
            else if (val > root.val)
            {
                root.right = add(root.right, val);
            }
        }
        return root;
    }

    public void Add(int val) {
        root = add(root, val);
    }

    private void print(TreeNode root)
    {
       if (root == null)
        {
            return;
        }

        Console.Write(root.val + " ");

        print(root.left);
        print(root.right);
    }

    public void print()
    {
        print(root);
    }

    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, null, null);
    }

    private bool IsValidBST(TreeNode node, int? lower, int? upper)
    {
        if (node == null)
        {
            return true;
        }
        int val = node.val;

        // Check the current node value against the bounds
        if (lower.HasValue && val <= lower.Value)
        {
            return false;
        }
        if (upper.HasValue && val >= upper.Value)
        {
            return false;
        }

        // Recursively validate the left and right subtrees
        if (!IsValidBST(node.right, val, upper))
        {
            return false;
        }
        if (!IsValidBST(node.left, lower, val))
        {
            return false;
        }
        return true;
    }

    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        // Recursively find the depth of the left and right subtrees
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        // The depth of the tree rooted at this node is the max of the depths of the subtrees, plus one for the root itself
        return Math.Max(leftDepth, rightDepth) + 1;
    }


    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode t1, TreeNode t2)
    {
        if (t1 == null && t2 == null)
        {
            return true;
        }
        if (t1 == null || t2 == null)
        {
            return false;
        }
        return (t1.val == t2.val) && IsMirror(t1.right, t2.left) && IsMirror(t1.left, t2.right);
    }

    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return null;
        }
        return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        // Always choose the middle element to ensure balance
        int mid = left + (right - left) / 2;

        TreeNode node = new TreeNode(nums[mid]);

        // Recursively build the left and right subtrees
        node.left = Helper(nums, left, mid - 1);
        node.right = Helper(nums, mid + 1, right);

        return node;
    }
}
