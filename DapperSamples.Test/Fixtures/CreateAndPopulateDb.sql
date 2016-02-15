Create table Users (
  FirstName nvarchar(20) not null, 
  LastName nvarchar(20) not null
);

Insert into Users 
  (FirstName, LastName) 
values 
  ('John', 'Doe');
