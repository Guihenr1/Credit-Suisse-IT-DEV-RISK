using ItDevRisk.enums;
using ItDevRisk.factories;
using ItDevRisk.models;

var result = new List<EStatus>();
var date = DateTime.Parse(Console.ReadLine());
var numberOfTrade = Convert.ToInt32(Console.ReadLine());

while (numberOfTrade != 0)
{
  var data = Console.ReadLine().Split(' ');

  var trade = new Trade()
  {
    CurrentDate = date,
    Value = Convert.ToDouble(data[0]),
    ClientSector = data[1],
    NextPaymentDate = DateTime.Parse(data[2])
  };

  var client = ClientFactory.CreateClient(trade);

  result.Add(client.GetStatus());

  numberOfTrade--;
}

foreach (var status in result)
{
  Console.WriteLine(status);
}

Console.ReadKey();