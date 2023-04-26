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

namespace majumi.ClientApp.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using majumi.ClientApp.Model;
using majumi.ClientApp.Utilities;

[TestClass]
public class ModelTests
{
[TestMethod]
public void LoadNodeList_ReadsFromNodeArray_ThereIsOneMatchingNode( )
{
  IModel model = new Model( new EmptyEventDispatcher( ) );

  string searchText = "node2";

  model.SearchText = searchText;

  model.LoadNodeList( );

  int expectedCount = 1;

  int actualCount = model.NodeList.Count;

  Assert.AreEqual( expectedCount, actualCount, "Node count should be {0} and not {1}", expectedCount, actualCount );
}
}
