DROP DATABASE bonita;
CREATE DATABASE bonita;
USE bonita;

CREATE TABLE tenant(
	Id INT,
	Created DATETIME,
	CreateBy VARCHAR(50),
	Description_T VARCHAR(100),
	DefaultTenantId CHAR(7),
	Name_T VARCHAR(50),
	Statut ENUM("Celibataire", "En couple", "Autre" ),
	PRIMARY KEY (Id)
);

CREATE TABLE users(
	TenantId INT, 
	Id INT,
	Enable_U BOOL,
	Username VARCHAR(50),
	Password_U VARCHAR(15),
	FirstName VARCHAR(50),
	Lastname VARCHAR(50),
	Title VARCHAR(50),
	CreateBy VARCHAR(50),
	CreationDate DATETIME,
	LastUpdate DATETIME,
	PRIMARY KEY(Id),
	FOREIGN KEY (TenantId) REFERENCES Tenant(Id)
);

CREATE TABLE UserContactInfo(
	tenantId INT,
	Id INT,
	UserId INT,
	Email VARCHAR(50),
	Phone INT,
	Whatsapp INT,
	Adresse VARCHAR(50),
	City VARCHAR(50),
	State ENUM("Celibataire", "En couple", "Autre" ),
	Country VARCHAR(50),
	PRIMARY KEY(TenantId,Id),
	FOREIGN KEY (TenantId) REFERENCES Tenant(Id),
	FOREIGN KEY (UserId) REFERENCES Users(Id)
);


CREATE TABLE UserLogin(
	TenantId INT,
	Id INT,
	LastConnection DATETIME,
	PRIMARY KEY (Id),
	FOREIGN KEY (TenantId) REFERENCES Tenant(Id)
);

CREATE TABLE roles(
	TenantId INT,
	Id INT,
	name_R VARCHAR(50),
	DisplayName VARCHAR(50),
	CreateBy VARCHAR(50),
	CreationDate DATETIME,
	LastUpdate DATETIME,
	PRIMARY KEY(Id),
	FOREIGN KEY (TenantId) REFERENCES Tenant(Id)
);

CREATE TABLE UserMemberShip(
	TenantId INT,
	Id INT,
	UserId INT,
	RoleId INT,
	AssignBy VARCHAR(50),
	AssignDate DATETIME,
	PRIMARY KEY(Id),
	FOREIGN KEY (TenantId) REFERENCES Tenant(Id),
	FOREIGN KEY (RoleId) REFERENCES Roles(Id),
	FOREIGN KEY (UserId) REFERENCES Users(Id)
);