USE bonita;
CREATE TABLE Etudiant(
   Matricule CHAR(7),
   Nom VARCHAR(50) NOT NULL,
   Prenom VARCHAR(50) NOT NULL,
   DateNaissance DATE NOT NULL,
   VilleNaissance VARCHAR(50),
   PRIMARY KEY(Matricule)
);

CREATE TABLE Fiiiere(
   IdFiiiere INT AUTO_INCREMENT,
   CodeFiiiere VARCHAR(10) NOT NULL,
   Intitule VARCHAR(100) NOT NULL,
   Title VARCHAR(50),
   PRIMARY KEY(IdFiiiere)
);

CREATE TABLE Evaluation(
   IdEvaluation INT AUTO_INCREMENT,
   TypeEvaluation VARCHAR(50) NOT NULL,
   DateEvaluation DATE NOT NULL,
   Bareme INT NOT NULL,
   PRIMARY KEY(IdEvaluation)
);

CREATE TABLE Classe(
   IdClasse INT AUTO_INCREMENT,
   Niveau INT NOT NULL,
   Grade CHAR(1),
   IdFiiiere INT NOT NULL,
   PRIMARY KEY(IdClasse),
   FOREIGN KEY(IdFiiiere) REFERENCES Fiiiere(IdFiiiere)
);

CREATE TABLE Specialite(
   IdSpecialite INT AUTO_INCREMENT,
   CodeSpecialite VARCHAR(50) NOT NULL,
   Intitule VARCHAR(50) NOT NULL,
   Title VARCHAR(50) NOT NULL,
   IdClasse INT NOT NULL,
   PRIMARY KEY(IdSpecialite),
   FOREIGN KEY(IdClasse) REFERENCES Classe(IdClasse)
);

CREATE TABLE UE(
   IdUE INT AUTO_INCREMENT,
   Intitule VARCHAR(50) NOT NULL,
   Title VARCHAR(50) NOT NULL,
   Annee DATE NOT NULL,
   IdClasse INT NOT NULL,
   PRIMARY KEY(IdUE),
   FOREIGN KEY(IdClasse) REFERENCES Classe(IdClasse)
);

CREATE TABLE Inscrire(
   Matricule CHAR(7),
   IdClasse INT,
   Annee DATE,
   PRIMARY KEY(Matricule, IdClasse),
   FOREIGN KEY(Matricule) REFERENCES Etudiant(Matricule),
   FOREIGN KEY(IdClasse) REFERENCES Classe(IdClasse)
);

CREATE TABLE Programmer(
   IdUE INT,
   IdEvaluation INT,
   Annee VARCHAR(50) NOT NULL,
   Semestre INT NOT NULL,
   PRIMARY KEY(IdUE, IdEvaluation),
   FOREIGN KEY(IdUE) REFERENCES UE(IdUE),
   FOREIGN KEY(IdEvaluation) REFERENCES Evaluation(IdEvaluation)
);

CREATE TABLE suivre(
   Matricule CHAR(7),
   IdUE INT,
   PRIMARY KEY(Matricule, IdUE),
   FOREIGN KEY(Matricule) REFERENCES Etudiant(Matricule),
   FOREIGN KEY(IdUE) REFERENCES UE(IdUE)
);
