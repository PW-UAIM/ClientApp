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

using System.Threading.Tasks;
using System.Windows.Input;

public partial class Controller : IController
{
public ApplicationState CurrentState
{
  get { return this.currentState; }
  set
  {
    this.currentState = value;

    this.RaisePropertyChanged( "CurrentState" );
  }
}
private ApplicationState currentState = ApplicationState.List;

public ICommand SearchCarCommands { get; private set; }

public ICommand ShowListCommand { get; private set; }

public ICommand ShowMapCommand { get; private set; }

public async Task SearchNodesAsync( )
{
  await Task.Run( ( ) => this.SearchCars( ) );
}

public async Task ShowListAsync( )
{
  await Task.Run( ( ) => this.ShowList( ) );
}

public async Task ShowMapAsync( )
{
  await Task.Run( ( ) => this.ShowMap( ) );
}

private void SearchCars( )
{
  this.Model.LoadCarList( );
}

private void ShowList( )
{
  switch( this.CurrentState )
  {
    case ApplicationState.List:
      break;

    default:
      this.CurrentState = ApplicationState.List;
      break;
  }
}

private void ShowMap( )
{
  switch( this.CurrentState )
  {
    case ApplicationState.Map:
      break;

    default:
      this.CurrentState = ApplicationState.Map;
      break;
  }
}
}
