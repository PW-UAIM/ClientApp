﻿//===============================================================================
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

using System.Collections.Generic;

public partial class Model : IData
{
public string SearchText
{
  get { return this.searchText; }
  set
  {
    this.searchText = value;

    this.RaisePropertyChanged( "SearchText" );
  }
}
private string searchText;

public List<NodeData> NodeList
{
  get { return this.nodeList; }
  private set
  {
    this.nodeList = value;

    this.RaisePropertyChanged( "NodeList" );
  }
}
private List<NodeData> nodeList = new List<NodeData>( );

public NodeData SelectedNode
{
  get { return this.selectedNode; }
  set
  {
    this.selectedNode = value;

    this.RaisePropertyChanged( "SelectedNode" );
  }
}
private NodeData selectedNode;
}
