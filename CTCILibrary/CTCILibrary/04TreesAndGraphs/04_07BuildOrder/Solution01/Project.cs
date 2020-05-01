using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_07BuildOrder.Solution01
{
    public class Project
    {
        private List<Project> children = new List<Project>();
        private Dictionary<string, Project> map = new Dictionary<string, Project>();
        private string name;
        private int dependencies = 0;

        public Project(string n)
        {
            this.name = n;
        }

        public void AddNeighbor(Project node)
        {
            if (!map.ContainsKey(node.GetName()))
            {
                children.Add(node);
                map[node.GetName()] = node;
                node.IncrementDependencies();
            }
        }

        public string GetName()
        {
            return this.name;
        }

        public List<Project> GetChildren()
        {
            return this.children;
        }

        public int GetNumberDependencies()
        {
            return dependencies;
        }

        public void IncrementDependencies()
        {
            this.dependencies++;
        }

        public void DecrementDependencies()
        {
            this.dependencies--;
        }
    }
}
