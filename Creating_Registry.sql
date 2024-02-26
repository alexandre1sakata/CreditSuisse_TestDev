------------------------------------------------------------------
---------------------- Creating tables ---------------------------
------------------------------------------------------------------

CREATE TABLE FinancialInstruments
(
    InstrumentID INT PRIMARY KEY IDENTITY(1,1),
    MarketValue DECIMAL(18, 2),
    Type NVARCHAR(50)
);

CREATE TABLE InstrumentCategories
(
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(50)
);

CREATE TABLE CategorizedInstruments
(
    InstrumentID INT,
    CategoryID INT,
    FOREIGN KEY (InstrumentID) REFERENCES FinancialInstruments(InstrumentID),
    FOREIGN KEY (CategoryID) REFERENCES InstrumentCategories(CategoryID)
);


------------------------------------------------------------------
------------ Insert instrument categories values -----------------
------------------------------------------------------------------

IF NOT EXISTS (SELECT * FROM InstrumentCategories)
BEGIN
    INSERT INTO InstrumentCategories (CategoryName)
    VALUES ('Low Value'), ('Medium Value'), ('High Value');
END;