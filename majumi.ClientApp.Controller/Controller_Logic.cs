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

using System.Threading.Tasks;
using System.Windows.Input;

public partial class Controller : IController
{
	public ApplicationState CurrentState
	{
		get { return this.currentState; }
		set
		{
			currentState = value;
			RaisePropertyChanged("CurrentState");
		}
	}
	private ApplicationState currentState = ApplicationState.List;

	public ICommand ClientLogInCommand { get; private set; }
	private void ClientLogIn()
	{
		Model.ClientLogIn();
	}
	public async Task ClientLogInAsync()
	{
		await Task.Run(() => ClientLogIn());
	}

	public ICommand LoadCarsCommand { get; private set; }
	private void LoadCars()
	{
		Model.LoadCarsList();
	}
	public async Task LoadCarsAsync()
	{
		await Task.Run(() => LoadCars());
	}

	public ICommand LoadVisitsCommand { get; private set; }
	private void LoadVisits()
	{
		Model.LoadVisitsList();
	}
	public async Task LoadVisitsAsync()
	{
		await Task.Run(() => LoadVisits());
	}

	public ICommand AddCarCommand { get; private set; }
	private void AddCar()
	{
		Model.AddCar();
	}
	public async Task AddCarAsync()
	{
		await Task.Run(() => AddCar());
	}

	public ICommand AddVisitCommand { get; private set; }
	private void AddVisit()
	{
		Model.AddVisit();
	}
	public async Task AddVisitAsync()
	{
		await Task.Run(() => AddVisit());
	}

	public ICommand GetCarCommand { get; private set; }
	private void GetCar()
	{
		Model.GetCarById();
	}
	public async Task GetCarAsync()
	{
		await Task.Run(() => GetCar());
	}

	public ICommand GetVisitCommand { get; private set; }
	private void GetVisit()
	{
		Model.GetVisitById();
	}
	public async Task GetVisitAsync()
	{
		await Task.Run(() => GetVisit());
	}

}
