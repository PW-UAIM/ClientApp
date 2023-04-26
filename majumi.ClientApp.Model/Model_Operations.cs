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

using majumi.CarService.ClientsAppService.Rest.Model.Model;
using System;
using System.Linq;

public partial class Model : IOperations
{
public void LoadCarList( )
{
  this.LoadCarTask( );
  /* AT
  Task.Run( ( ) => this.LoadNodesTask( ) );
  */
}

private void LoadCarTask( )
{
  IClient clientClient = ClientClientFactory.GetClientClient( );

  try
  {
    this.CarList = clientClient.GetClientCars(this.ClientID);
  }
  catch( Exception e )
  {
    Console.WriteLine( e.Message );
  }
}
}