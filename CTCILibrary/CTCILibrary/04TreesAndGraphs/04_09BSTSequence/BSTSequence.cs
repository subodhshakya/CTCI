using CTCILibrary._04TreesAndGraphs._04_06Successor;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_09BSTSequence
{
    public class BSTSequence
    {
        public List<LinkedList<int>> AllSequences(TreeNode node)
        {
            List<LinkedList<int>> result = new List<LinkedList<int>>();

            if (node == null)
            {
                return new List<LinkedList<int>>();
            }

            LinkedList<int> prefix = new LinkedList<int>();
            prefix.AddLast(node.Data);

            // Recurse on left and right subtree
            List<LinkedList<int>> leftSequence = AllSequences(node.Left);
            List<LinkedList<int>> rightSequence = AllSequences(node.Right);

            // Weave together each list from the left and right sides
            foreach (LinkedList<int> left in leftSequence)
            {
                foreach (LinkedList<int> right in rightSequence)
                {
                    List<LinkedList<int>> weaved = new List<LinkedList<int>>();
                    WeaveLists(left, right, weaved, prefix);
                    foreach (var weavedItem in weaved)
                    {
                        result.Add(weavedItem);
                    }
                }
            }

            return result;
        }

        private void WeaveLists(LinkedList<int> first, LinkedList<int> second,
            List<LinkedList<int>> results, LinkedList<int> prefix)
        {
            // One list is empty. Add remainder to [a clone] prefix and store result.
            if (first.Count == 0 || second.Count == 0)
            {
                LinkedList<int> result = new LinkedList<int>();
                foreach (var prfx in prefix)
                {
                    result.AddLast(prfx);
                }

                foreach (var fst in first)
                {
                    result.AddLast(fst);
                }

                foreach (var scn in second)
                {
                    result.AddLast(scn);
                }

                results.Add(result);
            }

            // Recurse with head of first added to the prefix. Removing the head will damage
            // first, so we'll need to put it back where we found it afterwards.
            int headFirst = first.First.Value;
            first.RemoveFirst();
            prefix.AddLast(headFirst);

            WeaveLists(first, second, results, prefix);
            prefix.RemoveLast();
            first.AddFirst(headFirst);

            // Same thing with the second
            int headSecond = second.First.Value;
            second.RemoveFirst();
            prefix.AddLast(headSecond);

            WeaveLists(first, second, results, prefix);
            prefix.RemoveLast();
            second.AddFirst(headSecond);
        }
    }
}
