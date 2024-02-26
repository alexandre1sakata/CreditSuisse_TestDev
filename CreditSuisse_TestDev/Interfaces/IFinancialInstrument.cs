namespace CreditSuisse_TestDev.Interfaces;

interface IFinancialInstrument
{
    double MarketValue { get; }
    string Type { get; }
}
