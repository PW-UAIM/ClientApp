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
using System;
using System.Collections.Generic;
using System.ComponentModel;

public interface IData : INotifyPropertyChanged
{
	int ClientID { get; set; }
	int SearchedCarID { get; set; }
	int SearchedVisitID { get; set; }
	bool LoginConfirmation { get; }
	List<CarData> CarList { get; }
	List<VisitData> VisitList{ get; }
	CarData SelectedCar { get; set; }
	CarData AddedCar { get; set; }
	VisitData SelectedVisit { get; set;}
	VisitData AddedVisit { get; set; }
	DateOnly SelectedDate { get; }

	ClientData LoggedClient { get; set; }
}
