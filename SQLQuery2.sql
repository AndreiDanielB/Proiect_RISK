CREATE TABLE PROIECT (
    Cod_proiect INT PRIMARY KEY, -- Cheia primară pentru identificarea unică a fiecărui proiect
    Denumire VARCHAR(255) NOT NULL,
    Domeniul VARCHAR(255) NOT NULL,
    Data_de_inceput DATE NOT NULL,
    Data_de_final DATE NOT NULL
);

CREATE TABLE BUNURI (
    Cod_Bun INT PRIMARY KEY, -- Cheia primară pentru identificarea unică a fiecărui bun
    Nume_Bun VARCHAR(255) NOT NULL,
    Cod_proiect INT NOT NULL, -- Cheie externă care face referință la tabela PROIECT
    Impact_minim INT NOT NULL,
    Impact_maxim INT NOT NULL,
    Domeniu_Categorie VARCHAR(255) NOT NULL,
    Cost DECIMAL(10, 2) NOT NULL,
    Cost_de_reducere DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (Cod_proiect) REFERENCES PROIECT(Cod_proiect) -- Definirea cheii externe
);

CREATE TABLE AMENINTARI (
    Amenintare VARCHAR(255) NOT NULL,
    Cod_Bun INT NOT NULL,
    Nivel_minim INT,
    Nivel_maxim INT,
    PRIMARY KEY (Amenintare, Cod_Bun),
    FOREIGN KEY (Cod_Bun) REFERENCES BUNURI(Cod_Bun)
);

INSERT INTO AMENINTARI (Amenintare, Cod_Bun, Nivel_minim, Nivel_maxim) 
VALUES ('Amenintare1', 1, 3, 5),
       ('Amenintare2', 2, 2, 4);


SELECT * FROM proiect;

SELECT * FROM bunuri;

SELECT * FROM amenintari;