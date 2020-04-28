using CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_01RouteBetweenNodes
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
            graph.AddVertex("Random City"); // 5

            graph.AddEdge(0, 1); // Dallas -> Austin
            graph.AddEdge(0, 2); // Austin -> San Antonio
            graph.AddEdge(1, 3); // Dallas -> Houston
            graph.AddEdge(1, 4); // Dallas -> Fort Worth


            RouteBetweenNodes routeFinder = new RouteBetweenNodes();
            Console.WriteLine(routeFinder.Search(graph, graph.GetVertex(1), graph.GetVertex(2)));
            routeFinder = new RouteBetweenNodes();
            graph.ResetVisitStatus(false);
            Console.WriteLine(routeFinder.Search(graph, graph.GetVertex(3), graph.GetVertex(4)));
            routeFinder = new RouteBetweenNodes();
            graph.ResetVisitStatus(false);
            Console.WriteLine(routeFinder.Search(graph, graph.GetVertex(3), graph.GetVertex(5)));
        }
    }
}
