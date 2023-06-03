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

public static class NetworkClientFactory
{
	public static IClient GetNetworkClient()
	{
		return new NetworkClient("localhost", 5010);
	}
}
