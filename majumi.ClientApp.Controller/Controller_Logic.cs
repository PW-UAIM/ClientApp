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
			this.currentState = value;

			this.RaisePropertyChanged("CurrentState");
		}
	}
	private ApplicationState currentState = ApplicationState.List;

	public ICommand ClientLogInCommand { get; private set; }
	public async Task LoadCarsAsync()
	{
		await Task.Run(() => this.LoadCars());
	}
	public async Task ClientLogInAsync()
	{
		await Task.Run(() => this.ClientLogIn());
	}

	public ICommand LoadCarsCommand { get; private set; }
	private void LoadCars()
	{
		this.Model.LoadCarsList();
	}


	private void ClientLogIn()
	{
		this.Model.ClientLogIn();
	}
}
