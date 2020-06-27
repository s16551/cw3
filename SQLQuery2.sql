select * from dbo.Enrollment
select * from dbo.Student
select * from dbo.Studies

insert into dbo.Studies Values(1, 'Socjologia')
insert into dbo.Studies Values(2, 'Informatyka')
insert into dbo.Studies Values(3, 'Matematyka')

insert into dbo.Enrollment Values(1, 1, 1, '2015-12-05')
insert into dbo.Enrollment Values(2, 2, 2, '2018-12-05')
insert into dbo.Enrollment Values(3, 1, 3, '2016-12-05')

insert into dbo.Student Values(1, 'Maciej', 'Koval', '1998-12-02', 1)
insert into dbo.Student Values(2, 'Agata', 'Adamek', '1999-12-02', 2)
