-- Any database name
CREATE DATABASE PointManagement; 
GO

USE PointManagement;
GO

CREATE TABLE Course (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ClassName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Student (
    ID INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255),
    Email NVARCHAR(100),
    Image NVARCHAR(255),
    CourseID INT,
    FOREIGN KEY (CourseID) REFERENCES Course(ID)
);
GO

CREATE TABLE Point (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Point DECIMAL(5,2) NOT NULL,
    StudentID INT,
    CourseID INT,
    FOREIGN KEY (StudentID) REFERENCES Student(ID),
    FOREIGN KEY (CourseID) REFERENCES Course(ID)
);
GO
