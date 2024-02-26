
------------------------------------------------------------------
------------ Procedure of Instruments Categorize -----------------
------------------------------------------------------------------

CREATE PROCEDURE CategorizeInstruments
AS
BEGIN
    INSERT INTO CategorizedInstruments (InstrumentID, CategoryID)
    SELECT
        InstrumentID,
        CASE
            WHEN MarketValue < 1000000 THEN 1
            WHEN MarketValue BETWEEN 1000000 AND 5000000 THEN 2
            WHEN MarketValue > 5000000 THEN 3
        END
    FROM FinancialInstruments;
END;
