using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_07BuildOrder.Solution02
{
    public class BuildOrder
    {
        /* Solution 2: Alternatively we can use DFS to find the build path.
         * 
         *                          f                 d
         *                         /|\                |
         *                        / | \               g
         *                       c  |  b
         *                        \ | /|\
         *                         \|/ | \
         *                          a  /  h
         *                          | /
         *                          e
         * 
         * Suppose we picked an arbitrary node (say b) and performed DFS on it.
         * When we get to the end of a path and can't go any further (which will
         * happen at h and e), we know that those terminating nodes can be the last
         * projects to be built. No projects depend on them.
         * 
         * TOUGH TO UNDERSTAND...need to give this a second try NEXT TIME.
         */
    }
}
