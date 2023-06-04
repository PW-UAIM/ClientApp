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

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Runtime.CompilerServices;

public class ServiceClient
{
	private static readonly HttpClient httpClient = new HttpClient();

	private readonly string serviceHost;
	private readonly ushort servicePort;

	public ServiceClient(string serviceHost, int servicePort)
	{
		Debug.Assert(condition: !string.IsNullOrEmpty(serviceHost) && servicePort > 0);

		this.serviceHost = serviceHost;
		this.servicePort = (ushort)servicePort;
	}

	public R CallWebServiceGet<R>(string webServiceUri)
	{
		Task<string> webServiceCall = this.CallWebService<string>(HttpMethod.Get, webServiceUri, null); // Najbrzydszy kod ever

		webServiceCall.Wait();

		string jsonResponseContent = webServiceCall.Result;

		R result = this.ConvertFromJson<R>(jsonResponseContent);

		return result;
	}
	public R CallWebServicePost<R, T>(string webServiceUri, T bodyData)
	{
		Task<string> webServiceCall = this.CallWebService(HttpMethod.Post, webServiceUri, bodyData);

		webServiceCall.Wait();

		string jsonResponseContent = webServiceCall.Result;

		R result = this.ConvertFromJson<R>(jsonResponseContent);

		return result;
	}

	private async Task<string> CallWebService<T>(HttpMethod httpMethod, string callUri, T? bodyData)
	{
		string httpUri = String.Format("http://{0}:{1}/{2}", this.serviceHost, this.servicePort, callUri);

		string httpResponseContent = "";
		if(httpMethod == HttpMethod.Post)
		{
			string JSON = ConvertToJson(bodyData);
			HttpContent httpContent = new StringContent(JSON, Encoding.UTF8, "application/json");

			HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(httpUri, httpContent);
			httpResponseMessage.EnsureSuccessStatusCode();
			httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync();

		} else if (httpMethod == HttpMethod.Get)
		{
			HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, httpUri);
			httpRequestMessage.Headers.Add("Accept", "application/json");

			HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
			httpResponseMessage.EnsureSuccessStatusCode();
			httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync();
		}

		return httpResponseContent;
	}

	private T ConvertFromJson<T>(string json)
	{
		JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();

		jsonSerializerOptions.PropertyNameCaseInsensitive = true;

		return JsonSerializer.Deserialize<T>(json, jsonSerializerOptions);
	}

	private string ConvertToJson<T>(T obj)
	{
		JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();

		jsonSerializerOptions.PropertyNameCaseInsensitive = true;

		return JsonSerializer.Serialize(obj, jsonSerializerOptions);
	}
}
