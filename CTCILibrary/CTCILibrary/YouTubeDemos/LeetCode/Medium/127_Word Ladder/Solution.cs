using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._127_Word_Ladder
{
    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, List<string> wordList)
        {
            // Since all words are of same length.
            int L = beginWord.Length;

            // Dictionary to hold combination of words that can be formed,
            // from any given word. By changing one letter at a time.
            Dictionary<string, List<string>> allComboDict = new Dictionary<string, List<string>>();

            foreach(var word in wordList)
            {
                for (int i = 0; i < L; i++)
                {
                    // Key is the generic word
                    // Value is a list of words which have the same intermediate generic word.
                    string newWord = word.Substring(0, i) + '*' + word.Substring(i + 1, L - i - 1);
                    List<string> transformations = new List<string>();
                    if (allComboDict.ContainsKey(newWord))
                    {
                        transformations = allComboDict[newWord];
                    }
                    transformations.Add(word);
                    allComboDict[newWord] = transformations;                    
                }
            };

            // Queue for BFS
            Queue<Tuple<string, int>> Q = new Queue<Tuple<string, int>>();            
            Q.Enqueue(new Tuple<string, int>(beginWord, 1));

            // Visited to make sure we don't repeat processing same word.
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            visited.Add(beginWord, true);

            while (Q.Count != 0)
            {
                Tuple<string, int> node = Q.Dequeue();                
                string word = node.Item1;
                int level = node.Item2;
                for (int i = 0; i < L; i++)
                {
                    // Intermediate words for current word
                    string newWord = word.Substring(0, i) + '*' + word.Substring(i + 1, L - i - 1);

                    // Next states are all the words which share the same intermediate state.
                    if (allComboDict.ContainsKey(newWord))
                    {
                        var allAdjWord = allComboDict[newWord];

                        foreach (var adjacentWord in allAdjWord)
                        {
                            // If at any point if we find what we are looking for
                            // i.e. the end word - we can return with the answer.
                            if (adjacentWord.Equals(endWord))
                            {
                                return level + 1;
                            }
                            // Otherwise, add it to the BFS Queue. Also mark it visited
                            if (!visited.ContainsKey(adjacentWord))
                            {
                                visited.Add(adjacentWord, true);
                                Q.Enqueue(new Tuple<string, int>(adjacentWord, level + 1));
                            }
                        }
                    }
                }
            }

            return 0;
        }
    }
}
