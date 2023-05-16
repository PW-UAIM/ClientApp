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

    public ICommand ClientLogInCommands { get; private set; }
    public async Task SearchCarsAsync( )
{
  await Task.Run( ( ) => this.SearchCars( ) );
}
public async Task ClientLogInAsync()
{
    await Task.Run(() => this.ClientLogIn());
}

    private void SearchCars( )
{
  this.Model.LoadCarList( );
}

   
    private void ClientLogIn()
    {
        this.Model.ClientLogIn();
    }
}
