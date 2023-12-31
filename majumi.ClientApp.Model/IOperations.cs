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

namespace majumi.ClientApp.Model;

public interface IOperations
{
	void ClientLogIn();
	void GetCarById();
	void GetVisitById();
	void AddCar();
	void AddVisit();
	void LoadCarsList();
	void LoadVisitsList();
}