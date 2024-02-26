using CreditSuisse_TestDev.Enums;
using CreditSuisse_TestDev.Interfaces;
using CreditSuisse_TestDev.Models;

namespace CreditSuisse_TestDev;

public class DefaultInstrumentCategorizer : IInstrumentCategorizer
{
    List<FinancialInstrument> IInstrumentCategorizer.CategorizeInstruments(List<IFinancialInstrument> instruments, IInstrumentCategorizer categorizer)
    {
        List<FinancialInstrument> categorizedInstruments = new List<FinancialInstrument>();

        foreach (var instrument in instruments)
        {
            InstrumentCategory category = categorizer.Categorize(instrument);
            categorizedInstruments.Add(new FinancialInstrument { Instrument = instrument, Category = category });
        }

        return categorizedInstruments;
    }

    InstrumentCategory IInstrumentCategorizer.Categorize(IFinancialInstrument instrument)
    {
        double marketValue = instrument.MarketValue;

        if (marketValue < 1000000)
            return InstrumentCategory.LowValue;
        else if (marketValue >= 1000000 && marketValue <= 5000000)
            return InstrumentCategory.MediumValue;
        else
            return InstrumentCategory.HighValue;
    }
}
