using ItDevRisk.enums;

namespace ItDevRisk.interfaces
{
  public interface ITrade
  {
    DateTime CurrentDate { get; }
    double Value { get; }
    string ClientSector { get; }
    DateTime NextPaymentDate { get; }

    EStatus GetStatus();
  }
}