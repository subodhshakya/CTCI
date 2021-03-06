﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation
{
    public class Graph
    {
        private const int NUM_VERTICES = 20;
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

        public void ShowVertex(Vertex v)
        {
            Console.WriteLine(v.Label + " ");
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

        public List<Vertex> GetAdjacent(Vertex v)
        {
            int index = GetIndex(v);
            List<Vertex> adjacentVertices = new List<Vertex>();
            for (int i = 0; i < NUM_VERTICES; i++)
            {
                if (i != index && adjMatrix[index, i] == 1)
                {
                    adjacentVertices.Add(this.vertices[i]);
                }
            }

            return adjacentVertices;
        }

        public Vertex GetUnvisitedAdjacent(Vertex v)
        {
            int index = GetIndex(v);
            Vertex unvisitedAdjVertex = null;

            List<Vertex> adjacentUnvisitedVertices = new List<Vertex>();
            for (int i = 0; i < NUM_VERTICES; i++)
            {
                if (i != index && adjMatrix[index, i] == 1 && !this.vertices[i].WasVisited)
                {
                    unvisitedAdjVertex = this.vertices[i];
                    break;
                }
            }

            return unvisitedAdjVertex;
        }

        private int GetIndex(Vertex v)
        {
            int index = -1;
            for (int i = 0; i < NUM_VERTICES; i++)
            {
                if (v == vertices[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public List<Vertex> GetVertices()
        {
            List<Vertex> allVertices = new List<Vertex>();
            for (int i = 0; i < NUM_VERTICES; i++)
            {
                if (this.vertices[i] != null)
                {
                    allVertices.Add(this.vertices[i]);
                }
            };

            return allVertices;
        }

        public Vertex GetVertex(int index)
        {
            return this.vertices[index];
        }

        public void ResetVisitStatus(bool status)
        {
            foreach (Vertex vertex in this.vertices)
            {
                if (vertex != null)
                {
                    vertex.WasVisited = status;
                }                
            }
        }
    }
}
