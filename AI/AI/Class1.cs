using System;
using System.Collections.Generic;

namespace AI
{
    /// <summary>
    /// GET, CREEATE, UPDATE, DELETE, DETAIL
    /// </summary>
    public interface IGraphManager
    {
        Node Get(Node node);
        Node Create(Node node, List<Node> FrontTarget, List<Node> BackTarget);
        Node Update(Node node);
        bool Delete(int node);
        Node Detail(Node node);
    }
    public class GraphManager : IGraphManager
    {
        public List<Node> StartNode { get; set; }

        public Node Create(Node node, List<Node> FrontTarget, List<Node> BackTarget)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int node)
        {
            throw new NotImplementedException();
        }

        public Node Detail(Node node)
        {
            throw new NotImplementedException();
        }

        public Node Get(Node node)
        {
            throw new NotImplementedException();
        }

        public Node Update(Node node)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 목적 : 최우선경로
    /// int :  거리
    /// </summary>
    public class Node
    {
        public Node Vertex { get; set; }
        public Dictionary<Node, int> Edges { get; set; }
    }
}
