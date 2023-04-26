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

using System;
using System.Linq;

public partial class Model : IOperations
{
public void LoadNodeList( )
{
  this.LoadNodesTask( );
  /* AT
  Task.Run( ( ) => this.LoadNodesTask( ) );
  */
}

private void LoadNodesTask( )
{
  INetwork networkClient = NetworkClientFactory.GetNetworkClient( );

  try
  {
    NodeData[ ] nodes = networkClient.GetNodes( this.SearchText );

    this.NodeList = nodes.ToList( );
  }
  catch( Exception e )
  {
    Console.WriteLine( e.Message );
  }
}
}
