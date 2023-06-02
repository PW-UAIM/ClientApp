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
using majumi.CarService.ClientsAppService.Rest.Model.Model;
using System;

[TestClass]
public class ModelTests
{
	IModel model;
	int clientID;
	[TestInitialize]
	public void t00_TestInitialize()
	{
		model = new Model(new EmptyEventDispatcher());
		clientID = 1;
		model.ClientID = clientID;
		model.ClientLogIn();
	}

	[TestMethod]
	public void t01_LogInAsClient_SuccesfullLogIn()
	{
		clientID = 1;
		model.ClientID = clientID;
		model.ClientLogIn();
		bool expectedConfirmation = true;
		bool actualConfirmation = model.LoginConfirmation;
		Assert.AreEqual(expectedConfirmation, actualConfirmation, "Car count should be {0} and not {1}", expectedConfirmation, actualConfirmation);
	}

	[TestMethod]
	public void t_02_LogInAsClient_ThereIsNoClientWithProvidedID()
	{
		clientID = 10000;
		model.ClientID = clientID;
		model.ClientLogIn();
		bool expectedConfirmation = false;
		bool actualConfirmation = model.LoginConfirmation;
		Assert.AreEqual(expectedConfirmation, actualConfirmation, "Car count should be {0} and not {1}", expectedConfirmation, actualConfirmation);
	}

	[TestMethod]
	public void t_03_GetCarById_ThisCarExists()
	{
		model.SearchedCarID = 1;
		model.GetCarById();

		Assert.IsNotNull(model.SelectedCar, "Car is null");
	}

	[TestMethod]
	public void t_04_GetVisitById_SuchVisitExists()
	{
		model.SearchedVisitID = 1;
		model.GetVisitById();

		Assert.IsNotNull(model.SelectedVisit, "Car is null");
	}


	[TestMethod]
	public void t_05_LoadCarList_ReadFromFakeClient_ThereIsOneClientsCar()
	{
		model.LoadCarsList();
		int expectedCount = 1;
		int actualCount = model.CarList.Count;

		Assert.AreEqual(expectedCount, actualCount, "Car count should be {0} and not {1}", expectedCount, actualCount);
	}

	[TestMethod]
	public void t_06_LoadVisitList_ReadFromFakeClient_ThereIsOneClientsVisit()
	{
		model.LoadVisitsList();
		int expectedCount = 1;
		int actualCount = model.VisitList.Count;

		Assert.AreEqual(expectedCount, actualCount, "Visit count should be {0} and not {1}", expectedCount, actualCount);
	}

	[TestMethod]
	public void t_07_AddCar_CheckIfCarExists()
	{
		CarData addedCar = new CarData()
		{
			CarID = 2,
			Make = "Ford",
			Model = "Mustang",
			EngineSize = "2.3V",
			LicensePlate = "WPL 23300",
			ClientID = 1,
			Mileage = 300000,
			VIN = "98ZCC798ZSD",
			Year = 2023
		};
		model.AddedCar = addedCar;
		model.AddCar();

		model.SearchedCarID = addedCar.CarID;
		model.GetCarById();

		Assert.IsNotNull(model.SelectedCar, "Car is null");
		Assert.AreEqual(model.SelectedCar, addedCar, "Got Wrong Car");
	}

	[TestMethod]
	public void t_08_AddVisit_CheckIfVisitExists()
	{
		VisitData addedVisit = new VisitData()
		{
			VisitID = 2,
			CarID = 1,
			ClientID = 1,
			MechanicID = 1,
			Notes = "",
			ServiceCost = 230,
			ServiceDate = DateTime.Now,
			ServiceStatus = "W trakcie",
			ServiceType = "Wymiana plynu w wycieraczkach"
		};
		model.AddedVisit = addedVisit;
		model.AddVisit();

		model.SearchedVisitID = addedVisit.VisitID;
		model.GetVisitById();

		Assert.IsNotNull(model.SelectedVisit, "Visit is null");
		Assert.AreEqual(model.SelectedVisit, addedVisit, "Got Wrong Visit");
	}
}
