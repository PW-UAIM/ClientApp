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

using majumi.CarService.ClientsAppService.Rest.Model.Model;
using System.Collections.Generic;

namespace majumi.ClientApp.Model;

public interface IClient
{
    bool AddCar(CarData car);
    bool AddVisit(VisitData visit);
    ClientLoginStatus ClientLogIn(int clientID);
    List<CarData> GetClientCars(int clientID);
    List<VisitData> GetClientVisits(int clientID);
    CarData GetCar(int clientID);
    VisitData GetVisit(int clientID);

}
