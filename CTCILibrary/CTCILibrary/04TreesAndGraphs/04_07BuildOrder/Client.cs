using CTCILibrary._04TreesAndGraphs._04_07BuildOrder.Solution01;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_07BuildOrder
{
    public class Client
    {
        public void Run()
        {
            BuildOrder buildOrder = new BuildOrder();
            string[] projects = new string[] { "a", "b", "c", "d", "e", "f" };
            string[,] dependencies = new string[,] 
            {    
                { "a", "d" }, 
                { "f", "b" },
                { "b", "d" },
                { "f", "a" },
                { "d", "c" }
            };
            Project[] projectOrder = buildOrder.FindBuildOrder(projects, dependencies);
        }
    }
}
