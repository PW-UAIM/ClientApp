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

namespace majumi.ClientApp.Controller;

using majumi.ClientApp.Utilities;
using majumi.ClientApp.Model;

public partial class Controller : PropertyContainerBase, IController
{
public IModel Model { get; private set; }

public Controller( IEventDispatcher dispatcher, IModel model ) : base( dispatcher )
{
  this.Model = model;

  this.SearchNodesCommand = new ControllerCommand( this.SearchNodes );

  this.ShowListCommand = new ControllerCommand( this.ShowList );

  this.ShowMapCommand = new ControllerCommand( this.ShowMap );
}
}
