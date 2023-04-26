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
using System.ComponentModel;

public interface IData : INotifyPropertyChanged
{
int ClientID { get; set; }

List<CarData> CarList { get; }

CarData SelectedCar{ get; set; }
}
