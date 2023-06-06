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

public static class FakeNetworkClientFactory
{
	public static IClient GetNetworkClient()
	{

		if (System.Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true")
		{
			return new NetworkClient("clientappservice", 5010);
		}
		else
		{
			return new FakeNetworkClient();
		}
	}
}
