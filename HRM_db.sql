CREATE DATABASE HRM
GO

USE HRM
GO

CREATE TABLE EMPLOYEE (
	id INT IDENTITY PRIMARY KEY ,
	name NVARCHAR(100) NOT NULL DEFAULT N'NV chưa được đặt tên',
	gender NVARCHAR(100),	--nam/nữ
	date_Of_Birth	DATE DEFAULT GETDATE(),
	date_joined DATE NOT NULL DEFAULT GETDATE(),
	date_left DATE,
	phone NVARCHAR(10),
	email NVARCHAR(100),
	img_path NVARCHAR(1000),
	base_pay DECIMAL(9,2) DEFAULT 5000000.00,
	status NVARCHAR(100) DEFAULT N'Thử việc' --Nhân viên chính thức, Thử việc, Đã nghỉ việc
)
GO

CREATE TABLE ACCOUNT (
	username NVARCHAR(100) PRIMARY KEY,
	employee_id INT NOT NULL,
	password NVARCHAR(100) NOT NULL,
	createDate DATE DEFAULT GETDATE()

	FOREIGN KEY (employee_id) REFERENCES EMPLOYEE(id) ON DELETE CASCADE
)
GO

CREATE TABLE PERFORMANCE_REVIEWS (
	id INT IDENTITY PRIMARY KEY ,
	employee_id INT NOT NULL,
	review_by INT NOT NULL,
	status NVARCHAR (100) DEFAULT N'acceptable',		--good/bad/acceptable
	description NVARCHAR(1000) DEFAULT N'Chưa có mô tả'

	FOREIGN KEY (employee_id) REFERENCES EMPLOYEE(id) ON DELETE CASCADE,
	FOREIGN KEY (review_by) REFERENCES EMPLOYEE(id) ON DELETE CASCADE
)
GO

CREATE TABLE TRAINING_HISTORY (
	id INT IDENTITY PRIMARY KEY ,
	employee_id INT NOT NULL,
	status NVARCHAR(100) DEFAULT N'acceptable',			--good/bad/acceptable
	description NVARCHAR(1000),
	fromDate DATE DEFAULT GETDATE(),
	toDate DATE,

	FOREIGN KEY (employee_id) REFERENCES EMPLOYEE(id) ON DELETE CASCADE
)
GO

--SKILL

CREATE TABLE LEVEL (
	id INT IDENTITY PRIMARY KEY ,
	level NVARCHAR(100) NOT NULL		--beginner, advanced, expert
)
GO

CREATE TABLE SKILL (
	id INT IDENTITY PRIMARY KEY ,
	name NVARCHAR(100) NOT NULL,
	description NVARCHAR(1000)
)
GO

CREATE TABLE EMPLOYEE_SKILLS (
	id INT IDENTITY PRIMARY KEY ,
	skill_id INT NOT NULL,
	level_id INT NOT NULL,
	employee_id INT NOT NULL,
	description NVARCHAR(1000)

	FOREIGN KEY (employee_id) REFERENCES EMPLOYEE(id) ON DELETE CASCADE,
	FOREIGN KEY (skill_id) REFERENCES SKILL(id),
	FOREIGN KEY (level_id) REFERENCES LEVEL(id)
)
GO

--END SKILL

--SALARY

CREATE TABLE SALARY (
	id INT IDENTITY PRIMARY KEY ,
	employee_id	INT NOT NULL,
	time DATE DEFAULT GETDATE(),
	total DECIMAL(9,2)

	FOREIGN KEY (employee_id) REFERENCES EMPLOYEE(id) ON DELETE CASCADE,
)
GO

CREATE TABLE BONUS_AND_FINES (
	id INT IDENTITY PRIMARY KEY ,
	salary_id INT NOT NULL,
	amount DECIMAL(9,2),
	type NVARCHAR(100),		--bonus/fines
	reason NVARCHAR(1000)

	FOREIGN KEY (salary_id) REFERENCES SALARY(id) ON DELETE CASCADE,
)
GO

--END SALARY

--JOB

CREATE TABLE JOB (
	id INT IDENTITY PRIMARY KEY ,
	job_name NVARCHAR(100) NOT NULL DEFAULT N'Công việc chưa đặt tên',
	role NVARCHAR(100) DEFAULT N'member',	--
	description NVARCHAR(1000) 
)
GO

CREATE TABLE LOCATION (
	id INT IDENTITY PRIMARY KEY ,
	address NVARCHAR(1000)
)
GO

CREATE TABLE DEPARTMENT(
	id INT IDENTITY PRIMARY KEY ,
	location_id INT NOT NULL,
	name NVARCHAR(100),
	address_detail NVARCHAR(100)

	FOREIGN KEY (location_id) REFERENCES LOCATION(id) ON DELETE CASCADE
)
GO

CREATE TABLE JOB_DETAIL (
	id INT IDENTITY PRIMARY KEY ,
	employee_id INT NOT NULL,
	department_id INT NOT NULL,
	job_id INT NOT NULL,
	fromDate DATE DEFAULT GETDATE(),
	toDate DATE,
	description NVARCHAR(1000),
	status NVARCHAR(100)			--onGoing, postponed, canceled

	FOREIGN KEY (employee_id) REFERENCES EMPLOYEE(id) ON DELETE CASCADE,
	FOREIGN KEY (job_id) REFERENCES JOB(id) ON DELETE CASCADE,
	FOREIGN KEY (department_id) REFERENCES DEPARTMENT(id) ON DELETE CASCADE,
)
GO

--END JOB


--GENERATE DATA

----EMPLOYEE
	INSERT INTO [EMPLOYEE] (name,gender,date_Of_Birth,date_joined,date_left,phone,email,img_path,base_pay,status)
	VALUES
	  ('Jordan Burgess', N'nữ','11/21/2004','01/26/2018','04/02/2020','0746791184','at.augue.id@protonmail.net','Len Sloan',6108429, N'Nhân viên chính thức'),
	  ('Wallace Rosales', N'nữ','10/11/2006','07/05/2019','10/17/2019','0014898495','maecenas.mi@aol.ca','Brynne Hart',8957443, N'Nhân viên chính thức'),
	  ('Sara Hutchinson', N'nữ','07/31/2008','12/21/2019','02/03/2019','0506696646','et.magnis.dis@icloud.couk','Rahim Roberts',7738075, N'Thử việc'),
	  ('George Stein','nam','03/01/2005','08/27/2018','07/14/2018','0371941234','orci.lobortis.augue@aol.ca','Shea Lawson',8525888, N'Đã nghỉ việc'),
	  ('Hop Burris', N'nữ','07/19/2005','06/14/2020','07/18/2018','0614832668','aliquet.vel@google.net','Mohammad Glover',6982771, N'Thử việc'),
	  ('Felix Beach', N'nữ','02/24/2011','10/11/2017','06/24/2019','0172434770','rhoncus.id.mollis@yahoo.edu','Ulric Thompson',6558671, N'Nhân viên chính thức'),
	  ('Teagan Byrd','nam','06/30/2006','01/29/2020','01/20/2016','0627977977','a.magna@yahoo.couk','Chloe Conrad',5070009, N'Thử việc'),
	  ('Lareina Wallace','nam','01/03/2004','10/31/2017','01/05/2019','0897179136','dui.fusce.aliquam@google.com','Libby Turner',6785789, N'Thử việc'),
	  ('Caldwell Cook', N'nữ','11/13/2007','05/17/2019','01/14/2017','0567983658','sit.amet@hotmail.com','Daniel Figueroa',7019827, N'Thử việc'),
	  ('Hashim Woodard', N'nữ','08/01/2005','10/29/2020','11/29/2019','0516466530','sed@protonmail.ca','Laura Sexton',8125969, N'Đã nghỉ việc');
	INSERT INTO [EMPLOYEE] (name,gender,date_Of_Birth,date_joined,date_left,phone,email,img_path,base_pay,status)
	VALUES
	  ('Lee Mcbride', N'nữ','08/30/2006','10/02/2018','12/29/2015','0605293619','orci@google.org','Evan Bolton',7973302, N'Đã nghỉ việc'),
	  ('Chancellor Watts', N'nữ','03/16/2009','01/01/2019','09/10/2020','0831376425','ultrices.posuere@protonmail.com','Wing Bailey',7551917, N'Nhân viên chính thức'),
	  ('Simon Hayes', N'nam','11/21/2006','12/19/2018','03/30/2020','0246356624','lorem@outlook.com','Graiden Bailey',9745272, N'Đã nghỉ việc'),
	  ('Cody Nixon', N'nam','10/11/2006','07/17/2020','03/04/2017','0188138677','ac@aol.couk','Lewis Wynn',8572305, N'Nhân viên chính thức'),
	  ('Lucas Klein', N'nam','01/19/2007','06/17/2020','08/15/2016','0033123591','egestas.rhoncus.proin@icloud.couk','Aristotle Guy',9281027, N'Thử việc'),
	  ('Angelica Walls', N'nam','05/20/2004','02/12/2018','11/09/2015','0022737308','nunc.quisque@aol.com','Marah Oliver',8786254, N'Nhân viên chính thức'),
	  ('Preston Carey', N'nữ','05/04/2004','08/21/2021','01/10/2020','0074317723','pellentesque@yahoo.edu','Edward Abbott',6038058, N'Nhân viên chính thức'),
	  ('Adrienne Velasquez', N'nam','12/08/2006','05/08/2018','04/05/2020','0659327200','viverra.maecenas@icloud.couk','Adria Michael',6927708, N'Đã nghỉ việc'),
	  ('Kyle Garner','nam','07/11/2010','08/20/2019','10/18/2019','0313518355','orci.sem@aol.com','Lucas O''donnell',6197214, N'Đã nghỉ việc'),
	  ('Hayes Torres','nam','07/04/2011','01/09/2018','05/09/2019','0226776397','mi.ac.mattis@google.com','Alec Underwood',6927990, N'Thử việc');

  UPDATE EMPLOYEE SET img_path = NULL
  UPDATE EMPLOYEE SET date_left = NULL
  DBCC CHECKIDENT (EMPLOYEE, RESEED, 0)

----ACCOUNT
	INSERT INTO ACCOUNT (username, employee_id, password) VALUES ('admin', 1, '123456')

----PERFORMANCE REVIEWS
	INSERT INTO [PERFORMANCE_REVIEWS] (employee_id,review_by,status,description)
	VALUES
	  (1,3,'good','mi tempor lorem, eget mollis lectus pede et risus. Quisque libero'),
	  (16,19,'bad','eu'),
	  (5,19,'good','iaculis enim, sit amet ornare lectus justo eu arcu. Morbi sit amet massa. Quisque porttitor eros'),
	  (11,13,'acceptable','lacinia orci, consectetuer euismod'),
	  (9,7,'bad','libero at auctor ullamcorper, nisl arcu iaculis enim, sit amet ornare lectus justo'),
	  (8,4,'bad','Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla magna, malesuada vel,'),
	  (8,4,'acceptable','tellus. Aenean egestas hendrerit'),
	  (11,12,'bad','sapien. Cras dolor dolor, tempus non, lacinia at, iaculis quis, pede. Praesent eu dui. Cum sociis natoque penatibus et'),
	  (7,9,'good','convallis in,'),
	  (17,17,'acceptable','Aenean eget metus. In nec orci. Donec nibh.');
	INSERT INTO [PERFORMANCE_REVIEWS] (employee_id,review_by,status,description)
	VALUES
	  (8,3,'acceptable','bibendum. Donec felis orci, adipiscing non, luctus sit amet, faucibus ut, nulla.'),
	  (9,19,'bad','at auctor ullamcorper, nisl arcu iaculis enim, sit amet ornare lectus justo eu arcu. Morbi'),
	  (17,1,'bad','et risus. Quisque libero'),
	  (6,16,'bad','molestie orci tincidunt adipiscing. Mauris molestie pharetra nibh. Aliquam ornare, libero at'),
	  (15,9,'good','metus. Aenean sed'),
	  (13,18,'acceptable','sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et arcu imperdiet ullamcorper. Duis at'),
	  (10,2,'acceptable','pede blandit congue. In scelerisque scelerisque dui. Suspendisse ac metus'),
	  (17,5,'good','placerat, augue. Sed molestie.'),
	  (11,17,'good','lobortis augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan sed, facilisis vitae, orci. Phasellus dapibus quam quis diam.'),
	  (12,12,'bad','eget metus. In nec orci. Donec nibh. Quisque nonummy ipsum');
	INSERT INTO [PERFORMANCE_REVIEWS] (employee_id,review_by,status,description)
	VALUES
	  (12,9,'bad','orci lacus vestibulum'),
	  (15,5,'bad','accumsan'),
	  (10,10,'good','eu sem. Pellentesque ut ipsum ac mi eleifend'),
	  (6,13,'good','pede. Praesent eu dui. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus'),
	  (2,7,'bad','Curabitur massa. Vestibulum accumsan neque et nunc. Quisque ornare tortor at risus. Nunc ac'),
	  (6,12,'bad','Mauris vestibulum, neque sed dictum eleifend, nunc risus'),
	  (17,9,'acceptable','Fusce dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc'),
	  (17,14,'bad','vel est'),
	  (4,5,'good','ullamcorper, velit in aliquet lobortis, nisi nibh lacinia orci, consectetuer'),
	  (14,4,'bad','a, dui. Cras pellentesque. Sed dictum. Proin eget odio. Aliquam vulputate ullamcorper magna. Sed eu eros. Nam');
  DELETE FROM PERFORMANCE_REVIEWS
  DELETE FROM EMPLOYEE

 ----TRAINING HISTORY
	INSERT INTO [TRAINING_HISTORY] (employee_id,status,description,fromDate,toDate)
	VALUES
	  (1,'acceptable','tellus justo sit amet nulla. Donec non justo.','11/04/2017','11/17/2018'),
	  (2,'good','tempus scelerisque, lorem ipsum sodales purus, in molestie tortor','03/04/2018','11/21/2018'),
	  (3,'good','commodo auctor velit. Aliquam nisl. Nulla eu neque','03/16/2018','07/04/2019'),
	  (4,'bad','Mauris ut quam vel sapien imperdiet ornare.','04/18/2018','08/18/2019'),
	  (5,'good','et','12/18/2017','02/28/2019'),
	  (6,'acceptable','elementum sem, vitae aliquam','10/18/2017','11/15/2018'),
	  (7,'bad','massa. Mauris vestibulum, neque sed dictum eleifend,','05/07/2018','11/01/2018'),
	  (8,'bad','luctus, ipsum leo elementum sem, vitae aliquam','01/15/2018','10/18/2018'),
	  (9,'acceptable','eget metus. In nec orci. Donec nibh. Quisque','02/09/2018','02/16/2019'),
	  (10,'acceptable','ornare egestas ligula. Nullam','04/07/2018','11/26/2018');

	INSERT INTO [TRAINING_HISTORY] (employee_id,status,description,fromDate,toDate)
	VALUES
	  (11,'good','ornare lectus justo eu arcu. Morbi sit amet','07/11/2018','09/15/2019'),
	  (12,'bad','Fusce feugiat. Lorem ipsum dolor sit amet,','05/01/2018','07/11/2019'),
	  (13,'acceptable','ut dolor dapibus','01/04/2018','06/21/2019'),
	  (14,'good','Mauris blandit enim consequat purus.','11/05/2017','07/26/2019'),
	  (15,'acceptable','elit. Nulla facilisi. Sed neque. Sed eget','03/22/2018','11/23/2018'),
	  (16,'acceptable','egestas a, scelerisque sed, sapien. Nunc pulvinar arcu','09/15/2018','02/01/2019'),
	  (17,'acceptable','Donec sollicitudin adipiscing','12/15/2017','11/09/2018'),
	  (18,'bad','egestas ligula. Nullam feugiat placerat velit. Quisque varius. Nam','06/09/2018','02/06/2019'),
	  (19,'good','Integer aliquam adipiscing lacus. Ut nec urna et','05/09/2018','09/30/2019'),
	  (20,'bad','inceptos','03/14/2018','03/07/2019');

----LEVEL
	INSERT INTO LEVEL VALUES ('fresher')
	INSERT INTO LEVEL VALUES ('junior')
	INSERT INTO LEVEL VALUES ('senior')

----SKILL
	INSERT INTO [SKILL] (name,description)
	VALUES
	  ('Macaulay Vega','eget, venenatis a, magna. Lorem ipsum dolor'),
	  ('Quyn Nichols','sed, sapien. Nunc pulvinar arcu et pede. Nunc'),
	  ('Brielle Dickerson','Donec consectetuer'),
	  ('Ciaran Galloway','dapibus ligula. Aliquam erat volutpat.'),
	  ('Yoshio Ochoa','dui lectus rutrum urna, nec luctus felis purus ac'),
	  ('Dorian Quinn','nisi a odio semper cursus.'),
	  ('Gisela Mcneil','ac mattis semper, dui lectus rutrum urna, nec'),
	  ('Cameron Jacobs','Integer vitae nibh. Donec est mauris, rhoncus id,'),
	  ('Hedwig Hickman','dui lectus rutrum urna, nec luctus'),
	  ('Briar Carver','faucibus ut,');
	INSERT INTO [SKILL] (name,description)
	VALUES
	  ('Cruz Allen','mattis. Cras eget'),
	  ('Briar Clemons','Nulla interdum. Curabitur dictum. Phasellus in felis.'),
	  ('Timothy Bonner','semper et, lacinia vitae, sodales'),
	  ('Nathan Juarez','dictum placerat, augue. Sed molestie.'),
	  ('Carly Mcfarland','sem egestas blandit.'),
	  ('Lucius Dunn','sed, est. Nunc laoreet lectus'),
	  ('Tanek Haynes','nascetur'),
	  ('Serena Stokes','fringilla ornare placerat, orci lacus vestibulum lorem, sit amet'),
	  ('Perry Mueller','Integer vitae nibh. Donec est mauris,'),
	  ('Jennifer Callahan','arcu. Vestibulum ante ipsum primis in faucibus orci');

----EMPLOYEE_SKILLS
	INSERT INTO [EMPLOYEE_SKILLS] (skill_id,level_id,employee_id,description)
	VALUES
	  (18,3,16,'ipsum dolor sit amet,'),
	  (3,2,1,'vitae, erat. Vivamus nisi. Mauris nulla. Integer urna. Vivamus molestie dapibus ligula. Aliquam erat'),
	  (4,3,8,'a neque. Nullam ut nisi a odio semper cursus. Integer mollis. Integer tincidunt aliquam arcu. Aliquam'),
	  (11,1,18,'In faucibus. Morbi vehicula. Pellentesque tincidunt tempus risus. Donec egestas. Duis ac'),
	  (17,1,14,'parturient montes, nascetur ridiculus mus. Proin vel arcu eu odio tristique pharetra. Quisque ac libero nec ligula consectetuer rhoncus. Nullam'),
	  (15,2,11,'eu nulla at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero est, congue a, aliquet'),
	  (10,3,8,'ipsum cursus vestibulum. Mauris magna. Duis dignissim tempor arcu. Vestibulum ut eros non enim commodo hendrerit.'),
	  (3,1,15,'est. Mauris eu turpis. Nulla aliquet. Proin velit. Sed malesuada augue ut lacus. Nulla tincidunt, neque'),
	  (6,2,14,'ultrices posuere cubilia Curae Donec tincidunt. Donec vitae erat vel pede blandit congue. In scelerisque scelerisque dui. Suspendisse ac metus'),
	  (6,2,6,'nec, imperdiet nec, leo. Morbi neque');
	INSERT INTO [EMPLOYEE_SKILLS] (skill_id,level_id,employee_id,description)
	VALUES
	  (10,1,4,'placerat velit. Quisque varius. Nam porttitor scelerisque neque. Nullam nisl. Maecenas malesuada fringilla est. Mauris eu turpis.'),
	  (10,2,19,'vulputate, posuere vulputate, lacus. Cras interdum. Nunc sollicitudin commodo ipsum. Suspendisse non leo. Vivamus'),
	  (9,3,11,'nec, malesuada ut, sem. Nulla interdum.'),
	  (14,2,18,'dui quis accumsan convallis, ante lectus convallis est, vitae sodales nisi'),
	  (9,3,14,'Nulla tempor augue ac ipsum. Phasellus vitae mauris sit amet lorem semper auctor. Mauris vel turpis. Aliquam adipiscing lobortis'),
	  (18,3,14,'Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend'),
	  (3,2,13,'orci luctus et ultrices posuere cubilia Curae Donec tincidunt. Donec vitae erat vel pede blandit'),
	  (2,2,17,'eros. Nam consequat dolor vitae dolor. Donec fringilla. Donec feugiat metus sit amet ante. Vivamus'),
	  (2,2,14,'porttitor tellus non magna. Nam ligula elit, pretium et, rutrum non, hendrerit id,'),
	  (8,3,14,'Aliquam gravida mauris ut mi. Duis risus odio, auctor vitae, aliquet nec, imperdiet nec, leo. Morbi neque tellus, imperdiet');

----SALARY
	INSERT INTO [SALARY] (employee_id,time,total)
	VALUES
	  (16,'06/23/2022',7920360),
	  (15,'09/20/2022',7169861),
	  (14,'04/25/2022',8101542),
	  (11,'11/21/2021',8383703),
	  (17,'04/08/2022',9265146),
	  (18,'12/21/2021',9967349),
	  (12,'02/04/2022',8032026),
	  (4,'06/22/2022',6230538),
	  (8,'06/01/2022',8518741),
	  (2,'06/08/2022',9974240);
	INSERT INTO [SALARY] (employee_id,time,total)
	VALUES
	  (15,'05/08/2022',9269567),
	  (19,'10/07/2021',8018929),
	  (7,'11/05/2021',9624059),
	  (19,'08/25/2022',8221142),
	  (10,'05/18/2022',9160093),
	  (5,'04/15/2022',6425055),
	  (5,'08/13/2022',9260564),
	  (19,'01/18/2022',7724784),
	  (9,'05/26/2022',5320170),
	  (17,'08/07/2022',9093083);
	INSERT INTO [SALARY] (employee_id,time,total)
	VALUES
	  (20,'07/11/2022',8941093),
	  (2,'05/12/2022',7562353),
	  (3,'12/05/2021',9524176),
	  (14,'09/11/2022',8979049),
	  (6,'10/25/2021',8189105),
	  (3,'12/27/2021',8215254),
	  (10,'10/10/2021',9013545),
	  (6,'08/19/2022',5800108),
	  (8,'08/20/2022',7954769),
	  (19,'12/21/2021',7899131);

	----BONUS_AND_FINES
	INSERT INTO [BONUS_AND_FINES] (salary_id,amount,type,reason)
	VALUES
	  (17,136896,'fines','ipsum leo elementum sem,'),
	  (22,189554,'bonus','orci. Ut sagittis lobortis mauris. Suspendisse'),
	  (25,174434,'fines','arcu iaculis enim, sit amet ornare lectus justo'),
	  (27,110569,'bonus','vulputate ullamcorper magna. Sed'),
	  (9,169775,'fines','non, cursus non,'),
	  (22,163802,'bonus','neque. In ornare sagittis felis. Donec tempor, est'),
	  (17,108172,'bonus','Nam consequat dolor vitae dolor.'),
	  (11,146937,'fines','nibh'),
	  (7,150794,'fines','ac metus vitae velit egestas'),
	  (10,115615,'fines','Etiam bibendum fermentum metus.');
	INSERT INTO [BONUS_AND_FINES] (salary_id,amount,type,reason)
	VALUES
	  (18,177851,'bonus','condimentum eget, volutpat'),
	  (15,124446,'fines','vulputate, nisi sem semper erat, in'),
	  (9,157767,'fines','porttitor tellus non magna. Nam ligula elit,'),
	  (14,147815,'bonus','Etiam bibendum fermentum metus. Aenean sed pede nec ante'),
	  (19,106118,'fines','luctus lobortis. Class aptent taciti sociosqu ad'),
	  (14,148373,'fines','eu,'),
	  (4,175478,'fines','Sed congue,'),
	  (8,127820,'bonus','Aenean massa. Integer vitae nibh.'),
	  (18,148019,'bonus','facilisis lorem tristique aliquet. Phasellus fermentum'),
	  (23,176004,'fines','nisi dictum augue malesuada malesuada. Integer id magna et');
	INSERT INTO [BONUS_AND_FINES] (salary_id,amount,type,reason)
	VALUES
	  (9,127510,'fines','litora torquent per conubia nostra, per'),
	  (6,198761,'fines','parturient montes, nascetur ridiculus mus.'),
	  (18,157689,'fines','interdum. Curabitur'),
	  (6,136257,'bonus','placerat. Cras dictum ultricies ligula. Nullam enim. Sed nulla ante,'),
	  (15,111115,'bonus','porttitor tellus non magna. Nam'),
	  (4,185141,'fines','dui. Cum sociis natoque penatibus et magnis dis'),
	  (7,129604,'bonus','bibendum fermentum metus. Aenean sed'),
	  (21,155679,'bonus','libero nec ligula consectetuer rhoncus. Nullam velit dui,'),
	  (16,173907,'bonus','dis parturient'),
	  (16,153688,'fines','elementum, dui');

----JOB
	INSERT INTO [JOB] (job_name, role, description)
	VALUES
	  ('Nascetur Ridiculus Industries','DESIGNER','Quisque libero'),
	  ('Auctor Quis Tristique Corp.','DESIGNER','Integer id'),
	  ('At Institute','TESTER','dui. Cras pellentesque. Sed dictum. Proin eget odio. Aliquam'),
	  ('Lorem Donec Limited','TESTER','eget lacus. Mauris non dui nec urna suscipit nonummy. Fusce'),
	  ('Cursus In LLC','PM','vel, mauris. Integer sem elit,'),
	  ('Lorem Lorem Luctus PC','TEST LEAD','Sed et libero. Proin mi. Aliquam gravida'),
	  ('A Limited','BA','pretium neque. Morbi quis urna. Nunc quis arcu vel quam'),
	  ('Proin Company','BA','eu, ultrices sit amet, risus. Donec nibh enim, gravida sit'),
	  ('Aenean Euismod Institute','PM','fermentum metus. Aenean sed pede nec ante blandit'),
	  ('Euismod In Dolor Corporation','DESIGNER','non massa non ante bibendum ullamcorper. Duis cursus, diam at');
	INSERT INTO [JOB] (job_name, role, description)
	VALUES
	  ('Est Mollis Non Industries','DEV','porttitor tellus non magna.'),
	  ('Id Foundation','DEV','felis ullamcorper viverra. Maecenas iaculis aliquet diam.'),
	  ('Nisi Nibh Lacinia Institute','TEST LEAD','lacus. Quisque imperdiet, erat nonummy ultricies'),
	  ('Auctor Mauris Limited','DESIGNER','fames ac turpis egestas.'),
	  ('In At Industries','DEV','sit amet, dapibus id, blandit at, nisi. Cum');

----LOCATION
	INSERT INTO [LOCATION] (address)
	VALUES
	  ('579-6805 Magna. St.'),
	  ('263-6172 Nunc Rd.'),
	  ('1415 Urna. St.'),
	  ('9000 Eu Road'),
	  ('483-9482 Diam St.'),
	  ('2020 Ut Ave'),
	  ('471-9019 Luctus St.'),
	  ('225-1852 Nibh. Ave'),
	  ('4936 Cursus Rd.'),
	  ('P.O. Box 339, 3118 In Street');

--DEPARTMENT

	INSERT INTO [DEPARTMENT] (location_id,name,address_detail)
	VALUES
	  (9,'Shimla','775-9643 Ipsum Rd.'),
	  (3,'Rangiora','2371 Inceptos St.'),
	  (9,'Tarnów','8896 Sed, Ave'),
	  (10,'Coevorden','912-4788 Porta Av.'),
	  (6,'Kitchener','Ap #363-6449 Ut St.'),
	  (3,'Alingsås','Ap #378-496 Magnis Rd.'),
	  (6,'Port Lincoln','P.O. Box 700, 2533 Iaculis St.'),
	  (8,'Ribeirão Preto','950-185 Bibendum Road'),
	  (10,'Gatchina','P.O. Box 882, 9119 Cras Street'),
	  (2,'Lidingo','607-3048 Lorem Street');

----JOB_DETAIL
	INSERT INTO [JOB_DETAIL] (employee_id,department_id,job_id,fromDate,toDate,description,status)
	VALUES
	  (16,6,1,'03/02/2021','04/20/2023','rhoncus id, mollis nec, cursus a, enim. Suspendisse aliquet, sem ut cursus luctus,','onGoing'),
	  (8,3,11,'11/15/2020','11/21/2022','lacinia vitae, sodales at, velit. Pellentesque ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi','canceled'),
	  (13,8,5,'01/17/2021','03/04/2023','Donec felis','canceled'),
	  (11,9,7,'10/10/2020','12/25/2022','mattis ornare, lectus ante dictum mi, ac','postponed'),
	  (3,4,2,'01/27/2021','10/07/2022','sodales elit erat vitae risus. Duis a mi','canceled'),
	  (17,5,6,'02/03/2021','01/07/2023','imperdiet ullamcorper. Duis','postponed'),
	  (18,6,5,'03/01/2021','01/16/2023','neque et nunc. Quisque ornare tortor at risus. Nunc','postponed'),
	  (5,9,4,'07/27/2021','04/22/2023','elit elit fermentum risus, at fringilla purus mauris','onGoing'),
	  (2,6,14,'01/29/2021','08/19/2023','diam nunc,','canceled'),
	  (11,7,8,'10/20/2020','05/12/2023','feugiat. Lorem ipsum dolor sit','postponed');
	INSERT INTO [JOB_DETAIL] (employee_id,department_id,job_id,fromDate,toDate,description,status)
	VALUES
	  (6,4,13,'04/25/2021','11/12/2022','mattis. Cras eget nisi dictum augue malesuada malesuada. Integer id magna et','canceled'),
	  (19,8,12,'05/30/2021','03/14/2023','mi lorem, vehicula et, rutrum','canceled'),
	  (4,6,10,'07/29/2021','03/25/2023','elit pede, malesuada vel, venenatis vel, faucibus id,','postponed'),
	  (4,7,3,'01/25/2021','06/07/2023','tincidunt pede ac urna. Ut tincidunt vehicula risus. Nulla eget metus','postponed'),
	  (14,1,15,'08/08/2021','06/27/2023','tincidunt nibh. Phasellus','postponed'),
	  (3,2,12,'11/10/2020','02/06/2023','nunc risus varius','postponed'),
	  (19,2,10,'12/14/2020','06/27/2023','faucibus ut, nulla. Cras eu tellus eu augue porttitor interdum. Sed auctor odio','canceled'),
	  (3,3,5,'12/05/2020','01/27/2023','mauris id sapien. Cras dolor dolor, tempus non,','onGoing'),
	  (13,7,6,'02/02/2021','09/04/2023','lorem lorem, luctus ut, pellentesque eget, dictum placerat,','onGoing'),
	  (7,5,3,'04/03/2021','02/28/2023','dolor elit, pellentesque a, facilisis non, bibendum sed, est. Nunc','canceled');
	INSERT INTO [JOB_DETAIL] (employee_id,department_id,job_id,fromDate,toDate,description,status)
	VALUES
	  (12,7,5,'09/20/2021','10/01/2023','a tortor. Nunc commodo','onGoing'),
	  (4,6,8,'09/14/2021','03/03/2023','lacus pede sagittis augue, eu tempor erat neque non quam. Pellentesque habitant morbi tristique senectus','onGoing'),
	  (9,8,3,'01/02/2021','09/11/2023','nec urna et arcu imperdiet ullamcorper. Duis at lacus.','canceled'),
	  (15,1,2,'12/09/2020','05/18/2023','risus a ultricies','onGoing'),
	  (16,3,5,'06/29/2021','07/11/2023','Integer sem elit,','onGoing'),
	  (12,8,11,'04/17/2021','10/20/2022','a purus. Duis elementum, dui quis accumsan','onGoing'),
	  (19,10,14,'01/29/2021','09/05/2023','urna justo faucibus lectus, a','postponed'),
	  (15,5,13,'06/05/2021','03/28/2023','elementum, lorem ut aliquam iaculis, lacus pede sagittis augue, eu tempor erat neque non','postponed'),
	  (13,6,15,'12/03/2020','08/07/2023','quis diam luctus lobortis.','postponed'),
	  (17,8,4,'06/27/2021','09/14/2023','pharetra','canceled');
GO
--END GENERATE


--STORE PROCEDURE

----LOGIN
CREATE PROC USP_Login
@UserName nvarchar(100), @PassWord nvarchar(100)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE username= @UserName COLLATE SQL_Latin1_General_CP1_CS_AS AND password = @PassWord COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO


--END STORE PROCEDURE