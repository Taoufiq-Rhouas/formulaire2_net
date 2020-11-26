use GestionApprenants
GO
create table apprenant
(
id int identity,
nom varchar(50),
prenom varchar(50),
email varchar(50),
telephone int,
adrese varchar(50),
pays varchar(50),
ville varchar(50),
choixSpecialite varchar(50),
)

drop table apprenant

insert into apprenant values ('taoufiq','rh','rh@gmail.com',0699889988,'darna','maroc','safi','c#')
insert into apprenant values ('taoufiq2','rh','rh2@gmail.com',0622222222,'darna2','maroc2','safi2','c#')
insert into apprenant values ('taoufiq3','rh3','rh3@gmail.com',0633333333,'darna3','maroc3','safi3','c#')
insert into apprenant values ('taoufiq4','rh4','rh4@gmail.com',0644444444,'darna4','maroc4','safi4','c#')

select * from apprenant
select count(id) from apprenant where id = 1
