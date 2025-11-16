namespace CodeChallenges.Challenges;

/*
 * https://leetcode.com/problems/binary-tree-level-order-traversal/description/
 *
 * Given the root of a binary tree, return the level order traversal of its nodes' values.
 * (i.e., from left to right, level by level).
 *
 * Example:
 * Input: root = [3,9,20,null,null,15,7]
 * Output: [[3],[9,20],[15,7]]
 */
public class BinaryTreeLevelOrderTraversal
{ 
     /*
      * Definition for a binary tree node.
      * public class TreeNode {
      *     public int val;
      *     public TreeNode left;
      *     public TreeNode right;
      *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
      *         this.val = val;
      *         this.left = left;
      *         this.right = right;
      *     }
      * }
      */
     public IList<IList<int>> GetLevelOrder()
     {
         /*
          * To solve this, we will need to use a Breadth First Seasrch (BFS) to traverse the nodes.
          * At each node, we will add a level list to hold all nodes for that level.
          * A root node will look something like this structure wise:
          *       3
          *      / \
          *     9  20
          *        / \
          *       15  7
          * After traversing, we will put each level in the results list to return it.
          */
          var root = GetRoot(); // Initial input for the problem
          var result = new List<IList<int>>();
          if (root == null) return result;

          var queue = new Queue<TreeNode>();
          queue.Enqueue(root);

          while (queue.Count > 0)
          {
              var levelSize = queue.Count;
              var level = new List<int>();

              for (var i = 0; i < levelSize; i++)
              {
                  var node = queue.Dequeue();
                  level.Add(node.val);

                  if (node.left != null)
                      queue.Enqueue(node.left);

                  if (node.right != null)
                      queue.Enqueue(node.right);
              }
              result.Add(level);
          }
          return result;
     }

     // Creates the TreeNode for testing.
     private TreeNode GetRoot()
     {
         return new TreeNode(3,
             new TreeNode(9),
             new TreeNode(20,
                 new TreeNode(15),
                 new TreeNode(7)
             )
         );
     }

     // Builds shape from description
      public class TreeNode {
          public int val;
           public TreeNode left;
           public TreeNode right;
           public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
               this.val = val;
               this.left = left;
               this.right = right;
           }
       }
}