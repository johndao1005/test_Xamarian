CREATE TABLE StaffContacts (
    StaffID INTEGER PRIMARY KEY AUTOINCREMENT ,
    StaffType INT,
    Title INT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    MiddleInitial CHAR(1),
    HomePhone VARCHAR(15),
    CellPhone VARCHAR(15),
    OfficeExtension VARCHAR(10),
    IRDNumber VARCHAR(11),
    Status INT,
    ManagerID INT NULL
);

-- Insert manager record
INSERT INTO StaffContacts (StaffType, Title, FirstName, LastName, MiddleInitial, HomePhone, CellPhone, OfficeExtension, IRDNumber, Status)
VALUES (1, 1, 'John', 'Doe', 2, '123-456-7890', '987-654-3210', 'Ext123', '123-45-6789', 1);
 
Select * from StaffContacts;
-- Insert employees with the manager's StaffID as ManagerID
INSERT INTO StaffContacts (StaffType, Title, FirstName, LastName, MiddleInitial, HomePhone, CellPhone, OfficeExtension, IRDNumber, Status, ManagerID)
VALUES (1, 2, 'Alice', 'Smith', 1, '111-222-3333', '444-555-6666', 'Ext111', '987-65-4321', 1,3);
