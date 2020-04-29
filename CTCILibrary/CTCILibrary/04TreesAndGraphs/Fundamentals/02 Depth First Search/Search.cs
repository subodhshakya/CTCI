using CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs.Fundamentals._02_Depth_First_Search
{
    public class Search
    {
        public void DepthFirstSearch(Graph g, Vertex v)
        {
            /* How DFS implementation works:
             * 1> Get the starting node
             * 2> push starting node to stack
             * 3> While stack is not empty
             * 4> Pop the stack
             * 5> Get unvisited adjacent nodes of poped node
             * 6> Foreach unvisited nodes:
             *      a> If unvisited nodes is 0 then pop the stack
             *      b> Else for each unvisited nodes, display the node and push it into the stack
             */

            Stack<Vertex> gStack = new Stack<Vertex>();
            v.WasVisited = true;
            g.ShowVertex(v);
            gStack.Push(v);

            while (gStack.Count > 0)
            {                
                Vertex unvisitedAdjVertex = g.GetUnvisitedAdjacent(gStack.Peek());
                if (unvisitedAdjVertex == null)
                {
                    gStack.Pop();
                }
                else
                {
                    unvisitedAdjVertex.WasVisited = true;
                    g.ShowVertex(unvisitedAdjVertex);
                    gStack.Push(unvisitedAdjVertex);
                }                                
            }
        }
    }
}
