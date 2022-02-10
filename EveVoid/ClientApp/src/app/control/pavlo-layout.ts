import { Layout, Graph, Edge, Node } from '@swimlane/ngx-graph';

export class PavloLayout implements Layout {
  settings?: any;
  inputGraph: Graph;
  outputGraph: Graph;

  radius = 120;

  run(graph: Graph): Graph {
    this.inputGraph = graph;
    const count = this.inputGraph.nodes.length;
    this.inputGraph.nodes.sort((a, b) => {
      return a.data.rank - b.data.rank;
    });
    const root = this.inputGraph.nodes.find(x => x.data.rank === 0);
    const nodeArr: string[] = [];
    this.pavlo(this.inputGraph, root, 0, 2 * Math.PI);
    this.inputGraph.edges.forEach(e => this.updateEdge(graph, e));
    this.outputGraph = {
      nodes: [...this.inputGraph.nodes.map(n => ({ ...n }))] as any,
      edges: [...this.inputGraph.edges.map(e => ({ ...e }))] as any
    };
    this.outputGraph.edgeLabels = this.outputGraph.edges;
    return this.outputGraph;
  }

  pavlo(graph: Graph, node: Node, alpha: number, beta: number) {
    if (!node) {
      return;
    }
    const rank = node.data.rank;
    let theta = alpha;
    const newRadius = (rank + 1) * this.radius;
    const subGraphLeaves = this.leavesOfSubGraph(graph, node);
    const children = graph.edges.filter(n => n.source === node.id);
    children.forEach(c => {
      const child = graph.nodes.find(n => n.id === c.target);
      const childLeaves = this.leavesOfSubGraph(graph, child);
      const u = theta + ((childLeaves / subGraphLeaves) * (beta - alpha));
      child.position.x = newRadius * Math.cos((theta + u) / 2);
      child.position.y = newRadius * Math.sin((theta + u) / 2);
      const childConnections = graph.edges.filter(n => n.source === child.id);
      if (childConnections.length > 0) {
        this.pavlo(graph, child, theta, u);
      }
      theta = u;
    });
  }

  leavesOfSubGraph(graph: Graph, node: Node): number {
    const visited: Node[] = [];
    const queue: Node[] = [];
    let leaves = 0;

    visited.push(node);
    queue.push(node);
    while (queue.length > 0) {
      const current = queue.shift();
      const children = graph.edges.filter(n => n.source === current.id);
      if (children.length === 0) {
        leaves++;
      }
      children.forEach(c => {
        const child = graph.nodes.find(n => n.id === c.target);
        if (visited.findIndex(v => v.id === child.id) < 0) {
            visited.push(child);
            queue.push(child);
          }
      });
    }
    return leaves;
  }

  updateEdge(graph: Graph, edge: Edge): Graph {
    const sourceNode = graph.nodes.find(n => n.id === edge.source);
    const targetNode = graph.nodes.find(n => n.id === edge.target);

    const startingPoint = {
      x: sourceNode.position.x,
      y: sourceNode.position.y
    };
    const endingPoint = {
      x: targetNode.position.x,
      y: targetNode.position.y
    };
    let diry = 0;
    let dirx = 0;
    if (Math.abs(targetNode.position.y - sourceNode.position.y) > Math.abs(targetNode.position.x - sourceNode.position.x)) {
      // y stronger
      diry = sourceNode.position.y <= targetNode.position.y ? -1 : 1;
      startingPoint.y -= diry * (sourceNode.dimension.height / 2);
      endingPoint.y += diry * (targetNode.dimension.height / 2);
    } else {
      // x stronger
      dirx = sourceNode.position.x <= targetNode.position.x ? -1 : 1;
      startingPoint.x -= dirx * (sourceNode.dimension.width / 2);
      endingPoint.x += dirx * (targetNode.dimension.width / 2);
    }
    const midPoint1 = {
      x: (startingPoint.x - dirx * 20),
      y: (startingPoint.y - diry * 20)
    };
    const midPoint2 = {
      x: (endingPoint.x + dirx * 20),
      y: (endingPoint.y + diry * 20)
    };
    edge.points = [startingPoint, midPoint1, midPoint2, endingPoint];
    return graph;
  }
}
