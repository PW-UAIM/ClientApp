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

public class NetworkClient : IClient
{
	private readonly ServiceClient serviceClient;

	public NetworkClient(string serviceHost, int servicePort)
	{
		this.serviceClient = new ServiceClient(serviceHost, servicePort);
	}

	public bool AddCar(CarData car)
	{
		string callUri = String.Format("addCar");

		bool result = this.serviceClient.CallWebService<bool, CarData>(callUri, car);

		return result;
	}
	public bool AddVisit(VisitData visit)
	{
		string callUri = String.Format("addVisit");

		bool result = this.serviceClient.CallWebService<bool, VisitData>(callUri, visit);

		return result;
	}
	public ClientLoginStatus ClientLogIn(int clientID)
	{
		string callUri = String.Format("login/{0}", clientID);

		ClientLoginStatus loginStatus = this.serviceClient.CallWebService<ClientLoginStatus>(callUri);

		return loginStatus;
	}
	public List<CarData> GetClientCars(int clientID)
	{
		string callUri = String.Format("getAllCarsByClient/{0}", clientID);

		List<CarData> cars = this.serviceClient.CallWebService<List<CarData>>(callUri);

		return cars;
	}
	public List<VisitData> GetClientVisits(int clientID)
	{
		string callUri = String.Format("getAllVisitsByClient/{0}", clientID);

		List<VisitData> visits = this.serviceClient.CallWebService<List<VisitData>>(callUri);

		return visits;
	}
	public CarData GetCar(int clientID)
	{
		string callUri = String.Format("getCar/{0}", clientID);

		CarData car = this.serviceClient.CallWebService<CarData>(callUri);

		return car;
	}
	public VisitData GetVisit(int clientID)
	{
		string callUri = String.Format("getVisit/{0}", clientID);

		VisitData visit = this.serviceClient.CallWebService<VisitData>(callUri);

		return visit;
	}
}
