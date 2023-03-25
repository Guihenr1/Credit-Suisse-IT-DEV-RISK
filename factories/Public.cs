using ItDevRisk.enums;
using ItDevRisk.interfaces;

namespace ItDevRisk.factories
{
  public class Public : ITrade
  {
    public DateTime CurrentDate { get; set; }

    public double Value { get; set; }

    public string ClientSector { get; set; }

    public DateTime NextPaymentDate { get; set; }

    public Public(ITrade trade)
    {
      CurrentDate = trade.CurrentDate;
      Value = trade.Value;
      ClientSector = trade.ClientSector;
      NextPaymentDate = trade.NextPaymentDate;
    }

    public EStatus GetStatus()
    {
      var result = EStatus.None;

      if ((CurrentDate.Date - NextPaymentDate.Date).Days > 30)
        result = EStatus.Expired;
      else if (Value > 1000000)
        result = EStatus.MediumRisk;

      return result;
    }
  }
}