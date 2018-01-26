using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;
using QuickGraph.Algorithms;

namespace GraphExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyGraph<string, Edge<string>> graph = new AdjacencyGraph<string, Edge<string>>(true);

            //Add vertices to graph
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");

            //Create edges for vertices
            Edge<string> a_b = new Edge<string>("A", "B");
            Edge<string> a_c = new Edge<string>("A", "C");
            Edge<string> b_d = new Edge<string>("B", "D");
            Edge<string> c_d = new Edge<string>("C", "D");

            //Add edges to vertices
            graph.AddEdge(a_b);
            graph.AddEdge(a_c);
            graph.AddEdge(b_d);
            graph.AddEdge(c_d);

            //Add weight to edges
            Dictionary<Edge<string>, double> edgeCost = new Dictionary<Edge<string>, double>(graph.EdgeCount);
            edgeCost.Add(a_b, 2);
            edgeCost.Add(a_c, 5);
            edgeCost.Add(b_d, 3);
            edgeCost.Add(c_d, 4);

            Console.WriteLine(graph);


;
        }
    }
}
