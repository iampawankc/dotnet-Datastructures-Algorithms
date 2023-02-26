using System;
using System.Collections;
using System.Collections.Generic;

namespace graphs
{
    public class graphs{
        public static void Main(string[] args){
            //Class date: Feb 25, 26
            //Graphs are like trees. It has nodes and edges 
            //Edges: Lines connecting nodes
            //Types of graphs: Unidirectional and Bidirectional : Edges can be directional
            
            //Weighted and unweighted graph: Weights can represent anything. 
            //Eg: Distance b/w two nodes, cost incured for travelling b/w nodes, etc. 

            
            //Storing the information of graph
            //Adjacency matrix: Here lot of space is wasted as only the edges that has value will be stored.
            //Data is stored in Matrix
            //Adjacency list: Stores Node and edge information as a array of arraylist 

            //To store information of graph, we need arraylist of edges. (Java theory) C# implementation below
            List<Edge>[] graph = new List<Edge>[9];
            ConstructGraph(graph);

            Display(graph);

            //Return index of where the node is matched 
            var res = FindEdge(graph, 7, 8);
            Console.WriteLine("Finding edge "+res);

            //Remove edge given u and v 
            RemoveEdge(graph, 8, 7);

        }

        public class Edge{
            public int v;
            public int w;
            public Edge(int v, int w){
                this.v = v;
                this.w = w;
            } 
        }
        public static void addEdgeUNI(List<Edge>[] graph, int u, int v, int w){
            graph[u].Add(new Edge(v,w));
        }

        public static void addEdgeBI(List<Edge>[] graph, int u, int v, int w){
            graph[u].Add(new Edge(v,w));
            graph[v].Add(new Edge(u,w));
        }

        public static void ConstructGraph(List<Edge>[] graph){
            int n=graph.Length;
            //Init array to avoid null pointer exception
            for(int v=0; v<n; v++){
                graph[v] = new List<Edge>();
            }

            addEdgeBI(graph, 0,1,10);
            addEdgeBI(graph, 0,6,10);

            addEdgeBI(graph, 1,5,20);
            addEdgeBI(graph, 1,2,5);

            addEdgeBI(graph, 2,4,50);
            addEdgeBI(graph, 2,3,50);

            addEdgeBI(graph, 3,4,30);

            addEdgeBI(graph, 5,6,10);
            addEdgeBI(graph, 5,7,20);
            addEdgeBI(graph, 5,8,20);

            addEdgeBI(graph, 7,8,20);
        }

        public static void Display(List<Edge>[] graph){
            for(int u=0; u<graph.Length; u++){
                Console.WriteLine("[ "+u+"  -> ");

                foreach(Edge ed in graph[u]){
                    Console.WriteLine(" ( "+ed.v+" , "+ ed.w+" ) ");
                }
                Console.WriteLine("]");
            }
        }

        public static int FindEdge(List<Edge>[] graph, int u, int v){
            for(int i=0; i< graph[u].Count; i++){
                Edge ed = graph[u][i];
                if(ed.v == v) return i;
            }
            return -1;
        }

        public static void RemoveEdge(List<Edge>[] graph, int u, int v){
            //THIS IS A BIDIMENTIONAL ARRAY
            int x=FindEdge(graph, u, v);
            int y=FindEdge(graph, v, u);

            if(x!=-1){
                graph[u].RemoveAt(x);
                graph[v].RemoveAt(y);
                Console.WriteLine($"Removed nodes at {x} and {y}");
            }
            else{
                Console.WriteLine("Noes not found to remove!!");
            }
        }

        public static void RemoveVertex(List<Edge>[] graph, int u){}

        public static void hasPath(List<Edge>[] graph, int u, int v){}

    }
}