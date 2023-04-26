﻿//===============================================================================
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
using System.ComponentModel;
using System.Windows.Input;

using majumi.ClientApp.Model;

public interface IController : INotifyPropertyChanged
{
IModel Model { get; }

ApplicationState CurrentState { get; }

ICommand SearchCarCommands { get; }

ICommand ShowListCommand { get; }

ICommand ShowMapCommand { get; }

Task SearchNodesAsync( );

Task ShowListAsync( );

Task ShowMapAsync( );
}
