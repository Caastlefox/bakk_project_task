@echo off
REM Create SQLite database and fill it with data

REM 1️⃣ Create the database file (Clients.db) and a table
sqlite3 Clientdatabase.db "CREATE TABLE IF NOT EXISTS Clients (Id INTEGER PRIMARY KEY AUTOINCREMENT,FirstName TEXT NOT NULL,LastName TEXT NOT NULL,Address TEXT,Email TEXT,PhoneNumber TEXT,Status TEXT);"

REM 2️⃣ Insert sample data
sqlite3 Clientdatabase.db "INSERT INTO Clients (FirstName, LastName,Address, Email, PhoneNumber, Status) VALUES ('John', 'Doe','123 Elm Street', 'john.doe@example.com', '123456789','Aktualny'),('Jane', 'Smith','456 Oak Avenue', 'jane.smith@example.com', '987654321','Aktualny'),('Alice', 'Johnson', '', 'alice.johnson@example.com', '555555555', 'Potencjalny'),('John', 'Smith', '','', '123456789','Aktualny'),('John', 'Doe', '','', '','Potencjalny');"


REM 3️⃣ Show inserted data
sqlite3 Clientdatabase.db "SELECT * FROM Clients;"

echo Database Clientdatabase.db created and filled with sample data!

pause