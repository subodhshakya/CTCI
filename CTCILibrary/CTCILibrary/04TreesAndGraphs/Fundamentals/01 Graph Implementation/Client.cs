using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation
{
    public class Client
    {
        public void Run()
        {
            Graph graph = new Graph();
            graph.AddVertex("Austin"); // 0
            graph.AddVertex("Dallas"); // 1
            graph.AddVertex("San Antonio"); // 2
            graph.AddVertex("Houston"); // 3
            graph.AddVertex("Fort Worth"); // 4

            graph.AddEdge(0, 1); // Dallas -> Austin
            graph.AddEdge(0, 2); // Austin -> San Antonio
            graph.AddEdge(1, 3); // Dallas -> Houston
            graph.AddEdge(1, 4); // Dallas -> Fort Worth

            graph.ShowVertex(0);
            graph.ShowVertex(1);
            graph.ShowVertex(2);
            graph.ShowVertex(3);
            graph.ShowVertex(4);

            graph.ShowAdjMatrix();
        }
    }
}
