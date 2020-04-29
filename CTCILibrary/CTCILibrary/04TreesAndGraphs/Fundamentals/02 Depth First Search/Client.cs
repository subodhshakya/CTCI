using CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs.Fundamentals._02_Depth_First_Search
{
    public class Client
    {
        public void Run()
        {
            // Create Graph
            Graph g = new Graph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddVertex("F");
            g.AddVertex("G");
            g.AddVertex("H");
            g.AddVertex("I");
            g.AddVertex("J");
            g.AddVertex("K");
            g.AddVertex("L");
            g.AddVertex("M");

            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
            g.AddEdge(0, 4);
            g.AddEdge(4, 5);
            g.AddEdge(5, 6);
            g.AddEdge(0, 7);
            g.AddEdge(7, 8);
            g.AddEdge(8, 9);
            g.AddEdge(0, 10);
            g.AddEdge(10, 11);
            g.AddEdge(11, 12);

            Search dfs = new Search();
            dfs.DepthFirstSearch(g, g.GetVertex(0));
            Console.WriteLine();
        }
    }
}
