using CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs.Fundamentals._03_Breadth_First_Search
{
    public class Search
    {
        /* How BFS implementation works:
         * 1> Find an unvisted vertex that is adjacent to the current vertex, mark it as visited and add to a queue.
         * 2> If an unvisted, adj vertex can't be found, remove a vertex from the queue (as long as there is a vertex to remove), make it the current vertex, and start over.     
         * 3> If second step cannot be performed because the queue is empty then the algorithm is over.
         */

        public void BreadthFirstSearch(Graph g, Vertex v)
        {
            Queue<Vertex> gQueue = new Queue<Vertex>();

            v.WasVisited = true;
            g.ShowVertex(v);
            gQueue.Enqueue(v);

            Vertex current, unvisitedAdjVertex;

            while (gQueue.Count > 0)
            {
                current = gQueue.Dequeue();
                unvisitedAdjVertex = g.GetUnvisitedAdjacent(current);

                while (unvisitedAdjVertex != null)
                {
                    unvisitedAdjVertex.WasVisited = true;
                    g.ShowVertex(unvisitedAdjVertex);
                    gQueue.Enqueue(unvisitedAdjVertex);
                    unvisitedAdjVertex = g.GetUnvisitedAdjacent(current);
                }
            }
        }
    }
}
