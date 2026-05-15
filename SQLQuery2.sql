CREATE TABLE Furnizori (
    Id INT PRIMARY KEY,
    Nume NVARCHAR(100) NOT NULL,
    CUI NVARCHAR(50),
    Adresa NVARCHAR(200),
    Telefon NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE Materiale (
    Id INT PRIMARY KEY,
    Denumire NVARCHAR(100) NOT NULL,
    Cantitate FLOAT NOT NULL,
    PretUnitar DECIMAL(10,2) NOT NULL,
    IdFurnizor INT NOT NULL,
    FOREIGN KEY (IdFurnizor) REFERENCES Furnizori(Id)
);

CREATE TABLE Contracte (
    IdContract INT PRIMARY KEY,
    IdFurnizor INT NOT NULL,
    DataContract DATE NOT NULL,
    Observatii NVARCHAR(300),
    TotalContract DECIMAL(10,2),
    FOREIGN KEY (IdFurnizor) REFERENCES Furnizori(Id)
);