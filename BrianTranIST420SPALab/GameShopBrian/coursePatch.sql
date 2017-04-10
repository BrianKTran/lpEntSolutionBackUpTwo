------Drop Table tblCustomer and Start Fresh-----
if exists (select * from sys.objects where name = 'tblCustomerBrianTran')
BEGIN
    drop table tblCustomerBrianTran;
END

------New Table tblCustomer to Create-----
BEGIN TRY 
CREATE TABLE tblCustomerBrianTran (
CustomerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
CustomerName varchar(50) NOT NULL,
CustomerSSN varchar(10) NOT NULL, 
CustomerEmail varChar(50) NOT NULL, 
CustomerPhone varchar(50) NOT NULL,
CustomerActive bit);
PRINT 'tblCustomerBrianTran created';
END TRY
BEGIN CATCH
 PRINT 'tblCustomerBrianTran created was NOT created';
END CATCH

INSERT INTO tblCustomerBrianTran
(CustomerName, CustomerSSN, CustomerEmail, CustomerPhone, CustomerActive)
VALUES
('IST301', '3', 'Information and Organizations', 'Dr. Maryam Roshanaei', 1);

INSERT INTO tblCustomerBrianTran
(CustomerName, CustomerSSN, CustomerEmail, CustomerPhone, CustomerActive)
VALUES
('IST302', '3', 'Project management in IST', 'Dr. Maryam Roshanaei', 2);

INSERT INTO tblCustomerBrianTran
(CustomerName, CustomerSSN, CustomerEmail, CustomerPhone, CustomerActive )
VALUES
('IST461', '4', 'Advanced Database Administration', 'John D. Roberts', 3);


INSERT INTO tblCustomerBrianTran
(CustomerName, CustomerSSN, CustomerEmail, CustomerPhone, CustomerActive )
VALUES
('IST440W', '4', 'Integration and Problem Solving', 'Joe Oakes', 4);

INSERT INTO tblCustomerBrianTran
(CustomerName, CustomerSSN, CustomerEmail, CustomerPhone, CustomerActive )
VALUES
('IST421', '4', 'Advanced Enterprice Integration', 'Joe Oakes', 4);

select * from tblCustomerBrianTran