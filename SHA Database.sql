-- Create the database
CREATE DATABASE BelgiumCampusDB;
GO

-- Use the new database
USE BelgiumCampusDB;
GO

-- Create the Student table
CREATE TABLE Student (
    StudentNumber INT PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    Surname NVARCHAR(100) NOT NULL,
    Age INT CHECK (Age BETWEEN 16 AND 120),
    Course NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NULL
);
