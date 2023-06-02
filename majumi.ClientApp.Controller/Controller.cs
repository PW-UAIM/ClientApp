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
using System.Windows.Input;
using System.Threading.Tasks;

public partial class Controller : PropertyContainerBase, IController
{
	public IModel Model { get; private set; }

	public Controller(IEventDispatcher dispatcher, IModel model) : base(dispatcher)
	{
		this.Model = model;
		this.LoadCarsCommand = new ControllerCommand(this.LoadCars);
		this.ClientLogInCommand = new ControllerCommand(this.ClientLogIn);
		this.LoadCarsCommand = new ControllerCommand(this.LoadCars);
		this.LoadVisitsCommand = new ControllerCommand(this.LoadVisits);
		this.AddCarCommand = new ControllerCommand(this.AddCar);
		this.AddVisitCommand = new ControllerCommand(this.AddVisit);
		this.GetCarCommand = new ControllerCommand(this.GetCar);
		this.GetVisitCommand = new ControllerCommand(this.GetVisit);
	}

}
