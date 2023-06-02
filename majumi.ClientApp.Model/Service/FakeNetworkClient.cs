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
using System;
using System.Linq;
using System.Net.Http;

public class FakeNetworkClient : IClient
{
	private static List<CarData> cars = new List<CarData> { 
		new CarData() { 
			CarID = 1, 
			Make = "Ford", 
			Model = "Mustang",
			EngineSize = "2.3V",
			LicensePlate = "WPL 23300",
			ClientID = 1, 
			Mileage = 300000, 
			VIN = "98ZCC798ZSD",
			Year = 2023
		} 
	};
	private static List<ClientData> clients = new List<ClientData> { 
		new ClientData() { 
			ClientID = 1, 
			Address = "Warszawa", 
			Email = "kamil.slimak@smail.com", 
			FirstName = "Kamil", 
			LastName = "Slimak", 
			InsuranceCompany = "EGiDA", 
			PhoneNumber = "123456789", 
			PolicyNumber = "123" 
		} 
	};
	private static List<VisitData> visits = new List<VisitData> { 
		new VisitData() {
			VisitID = 1,
			CarID = 1, 
			ClientID = 1, 
			MechanicID = 1, 
			Notes = "", 
			ServiceCost = 230, 
			ServiceDate = DateTime.Now, 
			ServiceStatus = "W trakcie", 
			ServiceType = "Wymiana plynu w wycieraczkach"
		} 
	};

	public bool AddCar(CarData car)
	{
		cars.Add(car);

		return true;
	}
	public bool AddVisit(VisitData visit)
	{
		visits.Add(visit);

		return true;
	}
	public ClientLoginStatus ClientLogIn(int clientID)
	{
		ClientData client = clients.Find((client) => client.ClientID == clientID);

		if (client != null)
		{
			return new ClientLoginStatus(true, client);
		}

		return new ClientLoginStatus(false, null);
	}
	public List<CarData> GetClientCars(int clientID)
	{
		return cars.FindAll((car) => car.ClientID == clientID);
	}
	public List<VisitData> GetClientVisits(int clientID)
	{
		return visits.FindAll((visit) => visit.ClientID == clientID);
	}
	public CarData GetCar(int carID)
	{
		return cars.Find((car) => car.CarID == carID);
	}
	public VisitData GetVisit(int visitID)
	{
		return visits.Find((visit) => visit.VisitID == visitID);
	}
}
