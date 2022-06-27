insert into Users values
(6, 'FF', 'ffr', '123', '06/01/2000', 'ff@gmail.com', 'Homeless', 'Receptionist');
/*
(1, 'John Doe', 'jdoe', '123', '01/01/2000', 'jdoe@gmail.com', 'Bukit Jalil', 'Customer'),
(2, 'Jane Do', 'jann', '123', '02/01/2000', 'jann@gmail.com', 'Bukit Jalil', 'Customer'),
(3, 'Mark', 'mmm', '123', '03/01/2000', 'mmm@gmail.com', 'Homeless', 'Technician'),
(4, 'Jax', 'jaxx', '123', '04/01/2000', 'jaxx@gmail.com', 'Bukit Bintang', 'Manager'),
(5, 'Jack', 'jj', '123', '05/01/2000', 'jack@gmail.com', 'Sripet', 'Customer'),
(6, 'FF', 'ffr', '123', '06/01/2000', 'ff@gmail.com', 'Homeless', 'Receptionist');
*/
insert into Requests values
(1, '01/01/2022', 'A', 'Normal', 'Unpaid', 1, NULL),
(2, '02/01/2022', 'B', 'Urgent', 'Pending', 2, NULL),
(3, '03/01/2022', 'C', 'Normal', 'Fixing', 1, 3),
(4, '04/01/2022', 'D', 'Urgent', 'Ready to Collect', 5, 3),
(5, '05/01/2022', 'E', 'Normal', 'Done', 2, 5);

SELECT * FROM Requests WHERE Status = 'Fixing' AND TechnicianID = (SELECT UserID FROM Users WHERE Users.Username = 'mmm');

SELECT * FROM Requests where Status = 'Done' AND CustomerID = (SELECT UserID FROM Users WHERE Username = 'jann');

SELECT * FROM Users WHERE Role = 'Customer';

SELECT COUNT(1) FROM Users WHERE username = 'jann' AND role = 'Customer';

ALTER TABLE Requests ADD Revenue int;

SELECT UserID FROM Users WHERE username = 'cuss';

insert into Requests values
('01/01/2022', 'A', 'Normal', 'Pending', 1, NULL, 90);

SELECT RequestID FROM Requests WHERE Status = 'Pending' AND Revenue = 90; 

SELECT TOP 1 UserID FROM Users ORDER BY UserID DESC;

SELECT COUNT(1) FROM Users WHERE username = 'pp' AND role = 'Customer';