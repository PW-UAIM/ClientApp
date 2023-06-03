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

public partial class Model : IData
{
	private int clientID;
	public int ClientID
	{
		get { return clientID; }
		set
		{
			clientID = value;
			RaisePropertyChanged(nameof(ClientID));
		}
	}

	private int searchedCarID;
	public int SearchedCarID
	{
		get { return searchedCarID; }
		set
		{
			searchedCarID = value;
			RaisePropertyChanged(nameof(SearchedCarID));
		}
	}

	private int searchedVisitID;
	public int SearchedVisitID
	{
		get { return searchedVisitID; }
		set
		{
			searchedVisitID = value;
			RaisePropertyChanged(nameof(SearchedVisitID));
		}
	}

	private bool loginConfirmation;
	public bool LoginConfirmation
	{
		get { return loginConfirmation; }
		private set
		{
			loginConfirmation = value;
			RaisePropertyChanged(nameof(LoginConfirmation));
		}
	}

	private List<CarData> carList = new List<CarData>();
	public List<CarData> CarList
	{
		get { return carList; }
		private set
		{
			carList = value;
			RaisePropertyChanged(nameof(CarList));
		}
	}
	private List<VisitData> visitList = new List<VisitData>();
	public List<VisitData> VisitList
	{
		get { return visitList; }
		private set
		{
			visitList = value;
			RaisePropertyChanged(nameof(VisitList));
		}
	}
	private CarData selectedCar;
	public CarData SelectedCar
	{
		get { return selectedCar; }
		set
		{
			selectedCar = value;
			RaisePropertyChanged(nameof(SelectedCar));
		}
	}
	private CarData addedCar;
	public CarData AddedCar
	{
		get { return addedCar; }
		set
		{
			addedCar = value;
			RaisePropertyChanged(nameof(AddedCar));
		}
	}
	private VisitData selecetedVisit;
	public VisitData SelectedVisit
	{
		get { return selecetedVisit; }
		set
		{
			selecetedVisit = value;
			RaisePropertyChanged(nameof(SelectedVisit));
		}
	}
	private VisitData addedVisit;
	public VisitData AddedVisit
	{
		get { return addedVisit; }
		set
		{
			addedVisit = value;
			RaisePropertyChanged(nameof(AddedVisit));
		}
	}
	private DateOnly selectedDate;
	public DateOnly SelectedDate
	{
		get { return selectedDate; }
		set
		{
			selectedDate = value;
			RaisePropertyChanged(nameof(SelectedDate));
		}
	}
}
