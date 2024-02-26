using CreditSuisse_TestDev.Enums;
using CreditSuisse_TestDev.Interfaces;

namespace CreditSuisse_TestDev.Models;

class FinancialInstrument
{
    public IFinancialInstrument Instrument { get; set; }
    public InstrumentCategory Category { get; set; }
}
