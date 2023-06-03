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

public partial class Model : IOperations
{
	private void ClientLogInTask()
	{
		IClient networkClient = FakeNetworkClientFactory.GetNetworkClient();

		try
		{
			ClientLoginStatus confirmation = networkClient.ClientLogIn(ClientID);
			if (!confirmation.IsSuccesfull)
			{
				ClientID = 0;
			}
			LoginConfirmation = confirmation.IsSuccesfull;
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

	}
	public void ClientLogIn()
	{
		ClientLogInTask();
	}

	private void GetCarByIdTask()
	{
		IClient networkClient = FakeNetworkClientFactory.GetNetworkClient();
		try
		{
			CarData car = networkClient.GetCar(searchedCarID);
			if (car != null)
			{
				SelectedCar = car;
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void GetCarById()
	{
		GetCarByIdTask();
	}

	private void GetVisitByIdTask()
	{
		IClient networkClient = FakeNetworkClientFactory.GetNetworkClient();
		
		try
		{
			VisitData visit = networkClient.GetVisit(searchedVisitID);
			if (visit != null)
			{
				SelectedVisit = visit;
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void GetVisitById()
	{
		GetVisitByIdTask();
	}
	private void AddCarTask()
	{
		IClient clientClient = FakeNetworkClientFactory.GetNetworkClient();

		try {
			clientClient.AddCar(addedCar);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void AddCar()
	{
		AddCarTask();
	}
	private void AddVisitTask()
	{
		IClient clientClient = FakeNetworkClientFactory.GetNetworkClient();

		try
		{
			clientClient.AddVisit(addedVisit);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void AddVisit()
	{
		AddVisitTask();
	}

	private void LoadVisitsTask()
	{
		IClient clientClient = FakeNetworkClientFactory.GetNetworkClient();

		try
		{
			VisitList = clientClient.GetClientVisits(ClientID);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void LoadVisitsList()
	{
		LoadVisitsTask();
	}

	private void LoadCarTask()
	{
		IClient clientClient = FakeNetworkClientFactory.GetNetworkClient();

		try
		{
			CarList = clientClient.GetClientCars(ClientID);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void LoadCarsList()
	{
		LoadCarTask();
	}
}
