using ItDevRisk.interfaces;
using ItDevRisk.models;

namespace ItDevRisk.factories
{
  public static class ClientFactory
  {
    public static ITrade CreateClient(Trade trade)
    {
      switch (trade.ClientSector)
      {
        case "Public":
          return new Public(trade);
        case "Private":
          return new Private(trade);
        default:
          throw new ArgumentException("Invalid client type");
      }
    }

  }
}