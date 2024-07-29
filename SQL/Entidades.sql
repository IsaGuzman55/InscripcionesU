-- Active: 1721864349115@@bf7x61exznojzwtat52t-mysql.services.clever-cloud.com@3306
CREATE TABLE Universities(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(45)
);

CREATE TABLE Careers(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(45)
);

CREATE TABLE Subjects(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(45)
);

CREATE TABLE Semesters(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(45)
);

CREATE TABLE Professors(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(45),
    LastName VARCHAR(45),
    Phone VARCHAR(45),
    Email VARCHAR(45)
);


CREATE TABLE Inscriptions(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Status ENUM("Aprobado", "Cancelado", "Pendiente de pago"),
    SemesterId INT,
    FOREIGN KEY (SemesterId) REFERENCES Semesters(Id)
);

CREATE TABLE CareerHasSubjects(
    CareerId INT,
    SubjectId INT,
    FOREIGN KEY (CareerId) REFERENCES Careers(Id),
    FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
);

CREATE TABLE UniversitiesHasCareer(
    CareerId INT,
    UniversityId INT
);

CREATE TABLE UniversityDeans(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(45),
    UniversityId INT
);

CREATE TABLE SubjectHasProfessors(
    SubjectId INT,
    ProfessorId INT,
    FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
    FOREIGN KEY (ProfessorId) REFERENCES Professors(Id)
);


CREATE TABLE ProfessorHasUniversities(
    ProfessorId INT,
    UniversityId INT,
    FOREIGN KEY (ProfessorId) REFERENCES Professors(Id),
    FOREIGN KEY (UniversityId) REFERENCES Universities(Id)
);

CREATE TABLE SubjectsHasIncriptions(
    SubjectId INT,
    InscriptionId INT,
    FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
    FOREIGN KEY (InscriptionId) REFERENCES Inscriptions(Id)
);

CREATE TABLE Students(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(45),
    LastName VARCHAR(45),
    Email VARCHAR(50),
    Phone VARCHAR(45),
    SemesterId INT,
    FOREIGN KEY (SemesterId) REFERENCES Semesters(Id)
);

CREATE TABLE UniversityHasStudents(
    UniversityId INT,
    EstudentId INT,
    FOREIGN KEY (UniversityId) REFERENCES Universities(Id),
    FOREIGN KEY (EstudentId) REFERENCES Estudents(Id)
);


ALTER TABLE UniversityHasStudents
RENAME COLUMN EstudentId TO StudentId;

RENAME TABLE SubjectsHasIncriptions TO SubjectHasInscriptions;
