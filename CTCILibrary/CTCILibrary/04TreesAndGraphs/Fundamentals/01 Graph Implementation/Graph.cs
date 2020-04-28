using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation
{
    public class Graph
    {
        private const int NUM_VERTICES = 10;
        private Vertex[] vertices;
        private int[,] adjMatrix;
        private int numVerts;

        public Graph()
        {
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for (int i = 0; i < NUM_VERTICES; i++)
            {
                for (int j = 0; j < NUM_VERTICES; j++)
                {
                    adjMatrix[i, j] = 0; // No edges between vertices at the beginning.
                }
            }
        }

        public void AddVertex(string label)
        {
            vertices[numVerts] = new Vertex(label);
            numVerts++;
        }

        public void AddEdge(int start, int end)
        {
            adjMatrix[start, end] = 1;
            adjMatrix[end, start] = 1;
        }

        public void ShowVertex(int v)
        {
            Console.WriteLine(vertices[v].Label + " ");
        }

        public void ShowAdjMatrix()
        {
            Console.WriteLine();
            Console.WriteLine("*******   Adj Matrix   *******");
            if (this.adjMatrix != null)
            {
                Console.Write("   ");
                for (int k = 0; k < NUM_VERTICES; k++)
                {
                    Console.Write(k.ToString() + "  ");
                }
                Console.WriteLine();
                for (int i = 0; i < NUM_VERTICES; i++)
                {
                    Console.Write(i.ToString() + "  ");
                    for (int j = 0; j < NUM_VERTICES; j++)
                    {
                        Console.Write(adjMatrix[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
