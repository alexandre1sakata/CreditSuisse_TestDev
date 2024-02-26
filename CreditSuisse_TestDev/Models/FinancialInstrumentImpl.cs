using CreditSuisse_TestDev.Interfaces;

namespace CreditSuisse_TestDev.Models;

class FinancialInstrumentImpl : IFinancialInstrument
{
    public double MarketValue { get; set; }
    public string Type { get; set; }
}
