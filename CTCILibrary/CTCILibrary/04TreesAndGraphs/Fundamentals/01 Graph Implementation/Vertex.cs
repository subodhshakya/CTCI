using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs.Fundamentals._01_Graph_Implementation
{
    public class Vertex
    {
        public bool WasVisited { get; set; }
        public string Label { get; set; }

        public Vertex(string label)
        {
            this.Label = label;
            this.WasVisited = false;
        }
    }
}
