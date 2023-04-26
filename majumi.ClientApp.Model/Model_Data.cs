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

using majumi.CarService.ClientsAppService.Rest.Model.Model;
using System.Collections.Generic;

public partial class Model : IData
{
public int ClientID  
{
  get { return this.clientID; }
  set
  {
    this.clientID = value;

    this.RaisePropertyChanged( "ClientID" );
  }
}
private int clientID;

public List<CarData> CarList
{
  get { return this.carList; }
  private set
  {
    this.carList = value;

    this.RaisePropertyChanged( "CarList" );
  }
}
private List<CarData> carList = new List<CarData>( );

public CarData SelectedCar
{
  get { return this.selectedCar; }
  set
  {
    this.selectedCar = value;

    this.RaisePropertyChanged( "SelectedCar" );
  }
}
private CarData selectedCar;
}
