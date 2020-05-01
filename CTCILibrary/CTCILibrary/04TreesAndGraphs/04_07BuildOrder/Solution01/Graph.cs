using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_07BuildOrder.Solution01
{
    public class Graph
    {
        private List<Project> nodes = new List<Project>();
        
        // This map is keeping track of which projects are alrady in the graph
        private Dictionary<string, Project> map = new Dictionary<string, Project>();

        public Project GetOrCreateNode(string name)
        {
            if (!map.ContainsKey(name))
            {
                Project node = new Project(name);
                nodes.Add(node);
                map[name] = node;
            }

            return map[name];
        }

        public void AddEdge(string startName, string endName)
        {
            Project start = GetOrCreateNode(startName);
            Project end = GetOrCreateNode(endName);
            start.AddNeighbor(end);
        }

        public List<Project> GetNodes()
        {
            return this.nodes;
        }
    }
}
