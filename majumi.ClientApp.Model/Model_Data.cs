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
		get { return this.clientID; }
		set
		{
			this.clientID = value;
			this.RaisePropertyChanged("ClientID");
		}
	}

	private int searchedCarID;
	public int SearchedCarID
	{
		get { return this.searchedCarID; }
		set
		{
			this.searchedCarID = value;
			this.RaisePropertyChanged("SearchedCarID");
		}
	}

	private int searchedVisitID;
	public int SearchedVisitID
	{
		get { return this.searchedVisitID; }
		set
		{
			this.searchedVisitID = value;
			this.RaisePropertyChanged("SearchedVisitID");
		}
	}

	private bool loginConfirmation;
	public bool LoginConfirmation
	{
		get { return this.loginConfirmation; }
		private set
		{
			this.loginConfirmation = value;
			this.RaisePropertyChanged("LoginConfirmation");
		}
	}

	private List<CarData> carList = new List<CarData>();
	public List<CarData> CarList
	{
		get { return this.carList; }
		private set
		{
			this.carList = value;
			this.RaisePropertyChanged("CarList");
		}
	}
	private List<VisitData> visitList = new List<VisitData>();
	public List<VisitData> VisitList
	{
		get { return this.visitList; }
		private set
		{
			this.visitList = value;
			this.RaisePropertyChanged("VisitList");
		}
	}
	private CarData selectedCar;
	public CarData SelectedCar
	{
		get { return this.selectedCar; }
		set
		{
			this.selectedCar = value;
			this.RaisePropertyChanged("SelectedCar");
		}
	}
	private CarData addedCar;
	public CarData AddedCar
	{
		get { return this.addedCar; }
		set
		{
			this.addedCar = value;
			this.RaisePropertyChanged("AddedCar");
		}
	}
	private VisitData selecetedVisit;
	public VisitData SelectedVisit
	{
		get { return this.selecetedVisit; }
		set
		{
			this.selecetedVisit = value;
			this.RaisePropertyChanged("SelecetedVisit");
		}
	}
	private VisitData addedVisit;
	public VisitData AddedVisit
	{
		get { return this.addedVisit; }
		set
		{
			this.addedVisit = value;
			this.RaisePropertyChanged("AddedVisit");
		}
	}
	private DateOnly selectedDate;
	public DateOnly SelectedDate
	{
		get { return this.selectedDate; }
		set
		{
			this.selectedDate = value;
			this.RaisePropertyChanged("SelecetedDate");
		}
	}
}
