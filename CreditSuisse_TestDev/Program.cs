using CreditSuisse_TestDev;
using CreditSuisse_TestDev.Interfaces;
using CreditSuisse_TestDev.Models;
using CreditSuisse_TestDev.Repositories;
using System.Text.Json;

List<IFinancialInstrument> instruments = new List<IFinancialInstrument>
{
    new FinancialInstrumentImpl { MarketValue = 800000, Type = "Stock" },
    new FinancialInstrumentImpl { MarketValue = 1500000, Type = "Bond" },
    new FinancialInstrumentImpl { MarketValue = 6000000, Type = "Derivative" },
    new FinancialInstrumentImpl { MarketValue = 300000, Type = "Stock" }
};

IInstrumentCategorizer categorizer = new DefaultInstrumentCategorizer();
List<FinancialInstrument> categorizedInstruments = categorizer.CategorizeInstruments(instruments, categorizer);

InstrumentRepository repository = new InstrumentRepository();

///
/// Remove coments if you already create tables and proc on DB
///
//repository.InsertFinancialInstruments(instruments);
//repository.ExecuteCategorizeInstrumentsProcedure();

var intrumentCategories = JsonSerializer.Serialize(categorizedInstruments.Select(s => s.Category.ToString()));

Console.WriteLine($"financialInstruments = {intrumentCategories}");

