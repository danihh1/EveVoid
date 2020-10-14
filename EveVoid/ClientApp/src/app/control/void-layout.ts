import { Edge, Graph, Layout, Node } from '@swimlane/ngx-graph';
import { Observable, of } from 'rxjs';
import { IndexedVariable } from 'webcola';

export class VoidLayout implements Layout {
  settings?: any;
  inputGraph: Graph;
  outputGraph: Graph;

  run(graph: Graph): Graph {
    this.inputGraph = graph;
    const count = this.inputGraph.nodes.length;
    this.inputGraph.nodes.sort((a, b) => {
      return a.data.rank - b.data.rank;
    });
    const root = this.inputGraph.nodes.find(x => x.data.rank === 0);
    const nodeArr: string[] = [];
    this.recursivePositionNeighbors(root, root, graph, nodeArr);

    this.inputGraph.edges.forEach(e => this.updateEdge(graph, e));
    this.outputGraph = {
      nodes: [...this.inputGraph.nodes.map(n => ({ ...n }))] as any,
      edges: [...this.inputGraph.edges.map(e => ({ ...e }))] as any
    };
    this.outputGraph.edgeLabels = this.outputGraph.edges;
    return this.outputGraph;
  }

  recursivePositionNeighbors(father: Node, node: Node, graph: Graph, nodeArr: string[]) {
    if (!node) {
      return;
    }
    nodeArr.push(node.id);
    const connections = this.inputGraph.edges.filter(n => n.source === node.id && nodeArr.findIndex(x => x === n.target) < 0 );
    const neighborCount = connections.length;
    let index = neighborCount > 1 ? neighborCount / -3 : 0;
    connections.forEach(connection => {
      const neighbor = graph.nodes.find(n => n.id === connection.target);
      const rank = neighbor.data.rank > 4 ? 4 : neighbor.data.rank;
      const edgeLength = 170 * Math.sqrt(Math.sqrt(neighborCount));
      const fatherX = father.position.x;
      const fatherY = father.position.y;
      const vectorX = node.position.x;
      const vectorY = node.position.y;
      neighbor.position.x = vectorX + (edgeLength * (Math.cos(((2 * Math.PI * index) / (rank * neighborCount))
        + Math.atan2(vectorY - fatherY, vectorX - fatherX))));
      neighbor.position.y = vectorY + (edgeLength * (Math.sin(((2 * Math.PI * index) / (rank * neighborCount))
        + Math.atan2(vectorY - fatherY, vectorX - fatherX))));
      index++;
      this.recursivePositionNeighbors(node, neighbor, graph, nodeArr);
    });
  }

  updateEdge(graph: Graph, edge: Edge): Graph {
    const sourceNode = graph.nodes.find(n => n.id === edge.source);
    const targetNode = graph.nodes.find(n => n.id === edge.target);

    // determine new arrow position
    const dir = sourceNode.position.y <= targetNode.position.y ? -1 : 1;
    const startingPoint = {
      x: sourceNode.position.x,
      y: sourceNode.position.y // - dir * (sourceNode.dimension.height / 2)
    };
    const endingPoint = {
      x: targetNode.position.x,
      y: targetNode.position.y // + dir * (targetNode.dimension.height / 2)
    };

    // generate new points
    edge.points = [startingPoint, endingPoint];
    return graph;
  }
}
