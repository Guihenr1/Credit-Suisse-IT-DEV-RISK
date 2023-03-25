using ItDevRisk.enums;
using ItDevRisk.interfaces;

namespace ItDevRisk.models
{
  public class Trade : ITrade
  {
    public DateTime CurrentDate { get; set; }

    public double Value { get; set; }

    public string ClientSector { get; set; }

    public DateTime NextPaymentDate { get; set; }

    public EStatus GetStatus()
    {
      throw new NotImplementedException();
    }
  }
}