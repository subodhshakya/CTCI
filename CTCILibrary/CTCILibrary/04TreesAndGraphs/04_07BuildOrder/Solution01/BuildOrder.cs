using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_07BuildOrder.Solution01
{
    public class BuildOrder
    {
        /* Build Order: You are given a list of projects and a list of dependencies (which
         * is a list of pairs of projects, where the second project is dependent on the 
         * first project). All of a project's dependencies must be built before the project is.
         * Find a build order that will allow the projects to be built. If there is no valid
         * order, return an error.
         * 
         * Example:
         * *******
         * Input:
         * Projects:        a, b, c, d, e, f
         * Dependencies:    (a,d), (f,b), (b,d), (f,a), (d,c)
         * Output:          f, e, a, b, d, c
         * 
         * 
         * Solution:
         * Visualizing the information as a graph probably works best. Be careful with the 
         * direction of the arrows. In the graph below, an arrow from d to g means that d
         * must be compiled before g. You can also draw them in the opposite direction, but
         * you need to be consistent and clear about what you mean.
         * 
         * Solution #1:
         * Where do we start? Are there any nodes that we can definitely compile immediately?
         * Yes, Nodes with no incoming edges can be built immediately since they don't depend
         * on anything. Let's add all such nodes to the build order. In the earlier example,
         * this means we have an order of f,d.
         * 
         * Once we've done that, it's irrelevant that some nodes are dependent on d and f since
         * d and f have already been built. We can reflect this new state by removing d and f's 
         * outgoing edges.
         * 
         *                      Build order: f, d
         *                      
         * Next, we know that c, b and g are free to build since they have no incoming edges.
         * Let's build those and then remove their outgoing edges.
         * 
         *                      Build order: f, d, c, b, g
         *                      
         * Project c can be built next, so let's do that and remove its outgoing edges. This leaves
         * just e. We build that next, giving us complete build order.
         * 
         *                      Build order: f, d, c, b, g, a, e
         */

        /* A helper function to insert projects with zero dependencies into the order array,
         * starting at index offset */
        private int AddNonDependent(Project[] order, List<Project> projects, int offset)
        {
            foreach (Project project in projects)
            {
                if (project.GetNumberDependencies() == 0)
                {
                    order[offset] = project;
                    offset++;
                }
            }
            return offset;
        }

        /* Return a list of the projects a correct build order */
        private Project[] OrderProjects(List<Project> projects)
        {
            Project[] order = new Project[projects.Count];

            /* Add "roots" to the build order first */
            int endOfList = AddNonDependent(order, projects, 0);

            int toBeProcessed = 0;
            while (toBeProcessed < order.Length)
            {
                Project current = order[toBeProcessed];

                // We have a circular dependencies since there are no remaining projects with zero dependencies
                if (current == null)
                {
                    return null;
                }

                // Remove myself as a dependency
                List<Project> children = current.GetChildren();
                foreach (Project child in children)
                {
                    child.DecrementDependencies();
                }

                // Add children that have no one depending on them
                endOfList = AddNonDependent(order, children, endOfList);
                toBeProcessed++;
            }

            return order;
        }

        /* Build the graph, adding the edge (a,b) if b is dependent on a. Assumes a pair is listed in "build order".
         * The pair (a,b) in dependencies indicates that be depends on a and a must be built before b. */
        private Graph BuildGraph(string[] projects, string[,] dependencies)
        {
            Graph graph = new Graph();
            foreach (string project in projects)
            {
                graph.GetOrCreateNode(project);
            }

            for (int i = 0; i < dependencies.GetLength(0); i++)
            {
                string first = dependencies[i, 0];
                string second = dependencies[i, 1];
                graph.AddEdge(first, second);
            }

            return graph;
        }

        /* Find a correct build order.*/
        public Project[] FindBuildOrder(string[] projects, string[,] dependencies)
        {
            Graph graph = BuildGraph(projects, dependencies);
            return OrderProjects(graph.GetNodes());
        }
    }
}