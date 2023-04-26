//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace majumi.ClientApp.Model;

using System.Linq;

public class FakeNetworkClient : INetwork
{
private static readonly NodeData[ ] nodes = new NodeData[ ] { new NodeData( ) { Id = "node1", Position = new PointData( ) { X = 0, Y = 0 } }, new NodeData( ) { Id = "node2", Position = new PointData( ) { X = 1, Y = 1 } } };

public NodeData[ ] GetNodes( string searchText )
{
  return FakeNetworkClient.nodes.Where( node => node.Id.IndexOf( searchText ) >= 0 ).ToArray( );
}
}
