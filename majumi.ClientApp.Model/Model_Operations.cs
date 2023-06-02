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
		IClient networkClient = NetworkClientFactory.GetNetworkClient();

		try
		{
			ClientLoginStatus confirmation = networkClient.ClientLogIn(ClientID);
			if (!confirmation.IsSuccesfull)
			{
				this.ClientID = 0;
			}
			this.LoginConfirmation = confirmation.IsSuccesfull;
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

	}
	public void ClientLogIn()
	{
		this.ClientLogInTask();
	}

	private void GetCarByIdTask()
	{
		IClient networkClient = NetworkClientFactory.GetNetworkClient();
		try
		{
			CarData car = networkClient.GetCar(searchedCarID);
			if (car != null)
			{
				this.SelectedCar = car;
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void GetCarById()
	{
		this.GetCarByIdTask();
	}

	private void GetVisitByIdTask()
	{
		IClient networkClient = NetworkClientFactory.GetNetworkClient();
		
		try
		{
			VisitData visit = networkClient.GetVisit(searchedVisitID);
			if (visit != null)
			{
				this.SelectedVisit = visit;
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void GetVisitById()
	{
		this.GetVisitByIdTask();
	}
	private void AddCarTask()
	{
		IClient clientClient = NetworkClientFactory.GetNetworkClient();

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
		this.AddCarTask();
	}
	private void AddVisitTask()
	{
		IClient clientClient = NetworkClientFactory.GetNetworkClient();

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
		this.AddVisitTask();
	}

	private void LoadVisitsTask()
	{
		IClient clientClient = NetworkClientFactory.GetNetworkClient();

		try
		{
			this.VisitList = clientClient.GetClientVisits(this.ClientID);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void LoadVisitsList()
	{
		this.LoadVisitsTask();
	}

	private void LoadCarTask()
	{
		IClient clientClient = NetworkClientFactory.GetNetworkClient();

		try
		{
			this.CarList = clientClient.GetClientCars(this.ClientID);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public void LoadCarsList()
	{
		this.LoadCarTask();
	}
	
}
