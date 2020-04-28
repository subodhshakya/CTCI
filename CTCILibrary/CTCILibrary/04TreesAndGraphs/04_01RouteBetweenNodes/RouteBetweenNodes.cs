using CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_01RouteBetweenNodes
{
    public class RouteBetweenNodes
    {
        public bool Search(Graph g, Vertex start, Vertex end)
        {
            if (start == end) return true;

            // Queue
            LinkedList<Vertex> q = new LinkedList<Vertex>();

            q.AddFirst(start);

            while (q.Count > 0)
            {
                Vertex current = q.First.Value;
                q.RemoveFirst();
                List<Vertex> adjacentVertices = g.GetAdjacent(current);

                foreach (Vertex adjVer in adjacentVertices)
                {
                    if (!adjVer.WasVisited)
                    {
                        if (adjVer == end)
                        {
                            return true;
                        }
                        else
                        {
                            adjVer.WasVisited = false;
                            q.AddLast(adjVer);
                        }
                    }
                }

                current.WasVisited = true;
            }            

            return false;
        }
    }
}
