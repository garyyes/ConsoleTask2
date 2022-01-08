
using System.Net;

var url = "https://www.google.com";
try
{
    // Creates an HttpWebRequest for the specified URL.
    HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
    // Sends the HttpWebRequest and waits for a response.
    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
    if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
        Console.WriteLine("It works!!!");
    else
        Console.WriteLine(myHttpWebResponse.StatusCode.GetHashCode());
    myHttpWebResponse.Close();
}
catch (Exception e)
{
    Console.WriteLine("\nThe following Exception was raised : {0}", e.Message);
}


