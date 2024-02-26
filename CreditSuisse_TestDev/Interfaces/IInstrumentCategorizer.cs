using CreditSuisse_TestDev.Enums;
using CreditSuisse_TestDev.Models;

namespace CreditSuisse_TestDev.Interfaces;

interface IInstrumentCategorizer
{
    List<FinancialInstrument> CategorizeInstruments(List<IFinancialInstrument> instruments, IInstrumentCategorizer categorizer);
    InstrumentCategory Categorize(IFinancialInstrument instrument);
}
