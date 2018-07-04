using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

namespace HttpTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string apiKey = "";
			string target = "genious97";
			string url = "https://na1.api.riotgames.com/lol/summoner/v3/summoners/by-name/";
			Console.Write(Get(url + target + "?api_key=" + apiKey));
			Console.ReadLine();

		}

		public static string Get(string uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using(StreamReader reader = new StreamReader(stream))
			{
				return reader.ReadToEnd();
			}
		}
	}
}
