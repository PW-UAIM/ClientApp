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

namespace majumi.ClientApp.Controller;

using majumi.ClientApp.Utilities;
using majumi.ClientApp.Model;

public partial class Controller : PropertyContainerBase, IController
{
	public IModel Model { get; private set; }

	public Controller(IEventDispatcher dispatcher, IModel model) : base(dispatcher)
	{
		Model = model;
		LoadCarsCommand    = new ControllerCommand(this.LoadCars);
		ClientLogInCommand = new ControllerCommand(this.ClientLogIn);
		LoadCarsCommand    = new ControllerCommand(this.LoadCars);
		LoadVisitsCommand  = new ControllerCommand(this.LoadVisits);
		AddCarCommand      = new ControllerCommand(this.AddCar);
		AddVisitCommand    = new ControllerCommand(this.AddVisit);
		GetCarCommand      = new ControllerCommand(this.GetCar);
		GetVisitCommand    = new ControllerCommand(this.GetVisit);
	}

}
