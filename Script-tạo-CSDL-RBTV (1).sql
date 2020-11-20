create database QuanLiThueVaBanNha
go 
use QuanLiThueVaBanNha
go 
create table Branch(
	Br_ID smallint,
	Br_Street nvarchar(50),
	Br_District nvarchar(50),
	Br_CityOrProvince nvarchar(50),
	Br_PhoneNumber varchar(10) unique,
	Br_FaxNumber varchar(10),
	Br_StartDate date not null,
	Br_EndDate date,
	primary key(Br_ID)
);
go

create table Employee(
	Em_ID int,
	Em_Name nvarchar(50),
	Em_PhoneNumber varchar(10) unique,
	Em_Address nvarchar(50),
	Em_Gender varchar(1) check(Em_Gender='M' or Em_Gender='F'),
	Em_Salary money,
	Em_DateOfBirth date check(DATEDIFF(year,Em_DateOfBirth, getdate()) >= 18),
	Em_Branch smallint,
	primary key(Em_ID)
);
go
create table TypeOfApartment(
	Type_ID smallint,
	Type_Name nvarchar(30),
	primary key(Type_ID)
);
go
--

create table Customer(
	Cus_ID int,
	Cus_Name nvarchar(50),
	Cus_Address nvarchar(50),
	Cus_PhoneNumber varchar(10) unique,
	Cus_Criteria nvarchar(20),
	Cus_TypeApart smallint,
	Cus_TypeCustomer varchar(1)  check(Cus_TypeCustomer='B' or Cus_TypeCustomer='R'),
	Cus_BranchMange smallint,
	primary key(Cus_ID,Cus_TypeCustomer)
);
go
create table LandLord(
	Lan_ID int,
	Lan_Name nvarchar(50),
	Lan_Address nvarchar(50),
	Lan_PhoneNumber varchar(10) unique,
	primary key(Lan_ID)
);
go
create table ApartmentForSale(
	Aps_ID varchar(10),
	APS_Street nvarchar(50),
	Aps_District nvarchar(50),
	Aps_CityOrProvince nvarchar(50),
	Aps_LandLord int,
	Aps_TypeApart smallint,
	Aps_NumberOfRooms smallint check(Aps_NumberOfRooms >= 1),
	Aps_DateSubmitted date,
	Aps_DateExpiration date,
	Aps_Status varchar(1) check(Aps_Status ='S' or Aps_Status = 'N'),
	Aps_ViewNumber int check(Aps_ViewNumber > 0),
	Aps_Price money check(Aps_Price > 0),
	Aps_RequirementOfLandLord nvarchar(50),
	Aps_CusID int,
	Aps_CusType varchar,
	Aps_ContractID smallint ,
	Aps_EmployeeContract int,
	Aps_Branch smallint,
	primary key(Aps_ID)
);
go
alter table ApartmentForSale add constraint check_dateSale check(DATEDIFF(day,Aps_DateSubmitted, Aps_DateExpiration) > 0);
go
create table DemandOfCustomer(
	De_CusID int,
	De_CusType varchar(1),
	De_ApTypeID smallint,
	primary key(De_CusID,De_CusType,De_ApTypeID)
);
go
create table RentInformation (
	Rent_CustomerID int,
	Rent_CustomerType varchar(1),
	Rent_Apartment varchar(10),
	Rent_Contract smallint,
	Rent_EmployeeContract int,
	primary key(Rent_CustomerID,Rent_CustomerType,Rent_Contract)
);
go

create table ContractRent(
	Con_ID smallint,
	Con_StartDateRant date,
	Con_EndDateRent date,
	primary key(Con_ID)
);
go
alter table ContractRent add constraint check_dateContractRent check(DATEDIFF(day,Con_StartDateRant, Con_EndDateRent) > 0);
go
create table HouseViewChecklist(
	HouseView_Date date,
	HouseView_CusID int,
	HouseView_CusType varchar(1),
	HouseView_ApartID varchar(10),
	HouseView_CommentOfCustomer nvarchar(100),
	primary key(HouseView_Date,HouseView_CusID,HouseView_ApartID)
);
go
create table ApartmentForRent(
	Apr_ID varchar(10),
	Apr_Street nvarchar(50),
	Apr_LandLord int,
	Apr_TypeApart smallint,
	Apr_District nvarchar(50),
	Apr_City nvarchar(50),
	Apr_NumberOfRooms smallint check(Apr_NumberOfRooms >= 1),
	Apr_DateSubmitted date,
	Apr_DateExpiration date,
	Apr_Status varchar(1) check(Apr_Status ='E' or Apr_Status = 'F'),
	Apr_ViewNumber int check(Apr_ViewNumber > 0),
	Apr_MonthRent money check(Apr_MonthRent > 0),
	Apr_Branch smallint,
	primary key(Apr_ID)
);
go
alter table ApartmentForRent add constraint check_dateRent check(DATEDIFF(day,Apr_DateSubmitted, Apr_DateExpiration) > 0);
go
create table HistoryBranch_Apartment(
	HisB_Branch smallint,
	HisB_Apartment varchar(10),
	HisB_StartDate date,
	HisB_EndDate date,
	primary key(HisB_Branch,HisB_Apartment,HisB_StartDate)
)
alter table HistoryBranch_Apartment add constraint checkDateHistoryBrAp
check(DATEDIFF(day,HisB_StartDate, HisB_EndDate) > 0);
go

create table HistoryEmployee_Apartment(
	HisE_Employee int,
	HisE_Apartment varchar(10),
	HisE_StartDate date,
	HisE_EndDate date,
	primary key(HisE_Employee,HisE_Apartment,HisE_StartDate)
);
go
alter table HistoryEmployee_Apartment add constraint check_dateHistoryEmAp
check(DATEDIFF(day,HisE_StartDate, HisE_EndDate) > 0);


alter table RentInformation add constraint FK_RentInfor_Employee foreign key(Rent_EmployeeContract) references Employee(Em_ID)
alter table RentInformation add constraint FK_RentInfor_ContractRent foreign key(Rent_Contract) references ContractRent(Con_ID)
alter table RentInformation add constraint FK_RentInfor_ApartmentRent  foreign key(Rent_Apartment) references ApartmentForRent(Apr_ID)
alter table RentInformation add constraint FK_RentInfor_Customer foreign key(Rent_CustomerID,Rent_CustomerType) references Customer(Cus_ID,Cus_TypeCustomer)

alter table DemandOfCustomer add constraint FK_DemandOfCustomer_TypeApartment foreign key(De_ApTypeID) references TypeOfApartment(Type_ID)
alter table DemandOfCustomer add constraint FK_DemandOfCustome_Customer foreign key(De_CusID,De_CusType) references Customer(Cus_ID,Cus_TypeCustomer)

alter table ApartmentForSale add constraint FK_ApartmentSale_LandLord foreign key(Aps_LandLord) references LandLord(Lan_ID)
alter table ApartmentForSale add constraint FK_ApartmentSale_TypeApart foreign key(Aps_TypeApart) references TypeOfApartment(Type_ID)
alter table ApartmentForSale add constraint FK_ApartmentSale_Customer foreign key(Aps_CusID,Aps_CusType) references Customer(Cus_ID,Cus_TypeCustomer)
alter table ApartmentForSale add constraint FK_ApartmentSale_Employee foreign key(Aps_EmployeeContract) references Employee(Em_ID)
alter table ApartmentForSale add constraint FK_ApartmentSale_Branch foreign key(Aps_Branch) references Branch(Br_ID)

alter table ApartmentForRent add constraint FK_ApartmentRent_LandLord foreign key(Apr_LandLord) references LandLord(Lan_ID)
alter table ApartmentForRent add constraint FK_ApartmentRent_TypeApart foreign key(Apr_TypeApart) references TypeOfApartment(Type_ID)
alter table ApartmentForRent add constraint FK_ApartmentRent_Branch foreign key(Apr_Branch) references Branch(Br_ID)

alter table Employee add constraint FK_Employee_Branch foreign key(Em_Branch) references Branch(Br_ID)

alter table HistoryBranch_Apartment add constraint FK_HisBranchApart_Branch foreign key(HisB_Branch) references Branch(Br_ID)

alter table HistoryEmployee_Apartment add constraint FK_HisEmployeeApart_Branch foreign key(HisE_Employee) references Employee(Em_ID)

alter table HouseViewChecklist add constraint FK_HouseView_Customer foreign key(HouseView_CusID,HouseView_CusType) references Customer(Cus_ID,Cus_TypeCustomer)

go
-------------- CÀI ĐẶT RÀNG BUỘC TOÀN VẸN ----------------
--trigger 
-- ID apartment phai nam trong bang ApartmentForSale hoac bang ApartmentForRent
-- HouseView_CusID phai co trong bang Buyer hoac Renter
create trigger trig_addHistoryViewList on HouseViewCheckList
for insert, update 
as
begin
	if (exists (select i.HouseView_CusID
					from inserted i
					 where i.HouseView_ApartID not in (select apr.Apr_ID from ApartmentForRent apr)
						and i.HouseView_ApartID not in (select aps.Aps_ID from ApartmentForSale aps)))
	begin
		raiserror('ID Apartment không co trong bang ApartmentForRent hoac ApartmentForSale',16,1)
		rollback;
	end
	if (exists (select i.HouseView_CusID
					from inserted i
					 where (i.HouseView_CusType = 'B' and i.HouseView_ApartID in (select apr.Apr_ID from ApartmentForRent apr))
						or (i.HouseView_CusType = 'R' and i.HouseView_ApartID  in (select aps.Aps_ID from ApartmentForSale aps))))
	begin
		raiserror(N'Loại khách hàng và loại nhà (để bán hay mua) không tương thích',16,1)
		rollback;
	end
end
go
-- ID apartment phai nam trong bang ApartmentForSale hoac bang ApartmentForRent
create trigger trig_addHistoryApartmentBranch on HistoryBranch_Apartment
for insert, update 
as
begin
	if (exists (select *
					from inserted i
					 where i.HisB_Apartment not in (select apr.Apr_ID from ApartmentForRent apr)
						and i.HisB_Apartment not in (select aps.Aps_ID from ApartmentForSale aps)))
	begin
		raiserror('HisB_Apartment phai co trong bang ApartmentForRent hoac ApartmentForSale',16,1)
		rollback;
	end
end
go
-- ID apartment phai nam trong bang ApartmentForSale hoac bang ApartmentForRent
create trigger trig_addHistoryApartmentEmployee on HistoryEmployee_Apartment
for insert, update 
as
begin
	if (exists (select *
					from inserted i
					 where i.HisE_Apartment not in (select apr.Apr_ID from ApartmentForRent apr)
						and i.HisE_Apartment not in (select aps.Aps_ID from ApartmentForSale aps)))
	begin
		raiserror('HisE_Apartment phai co trong bang ApartmentForRent hoac ApartmentForSale',16,1)
		rollback;
	end
end
go

-- kiem tra du lieu hop le
create trigger trig_checkValidApartmentSale on ApartmentForSale
for insert , update
as
begin
	
	if(exists (select *	
					from inserted i
					where not (i.Aps_ContractID is null and i.Aps_Status = 'N' and 
					i.Aps_CusID is null and i.Aps_CusType is null and i.Aps_EmployeeContract is null)
					or (i.Aps_ContractID is not null and i.Aps_Status = 'S' and 
					i.Aps_CusID is not null and i.Aps_CusType is not null and i.Aps_EmployeeContract is not null)
					))
	begin
		raiserror(N'dữ liệu ở các cột Aps_ContractID,Aps_CusID,Aps_CusType,Aps_EmployeeContract cung khac null 
		va Aps_Status = S hoac cung bang null va Aps_Status = N' , 16,1);
		rollback;
	end
	if(exists (select *	
					from inserted i
					where  i.Aps_CusType = 'R' 
					))
	begin
		raiserror(N'Khách hàng mua nhà phải có thuộc tính Custype = B', 16,1);
		rollback;
	end
end
go

create trigger trg_checkValidRentInformation on RentInformation
for insert , update
as
begin
	if(exists (select *	
					from inserted i
					where  i.Rent_CustomerType != 'R' 
					))
	begin
		raiserror(N'Khách hàng thue nhà phải có thuộc tính Custype = R', 16,1);
		rollback;
	end
end
go
----------------------------------------------------------------
--Không cho phép xóa 1 chi nhánh
create trigger Trig_DeleteBranch on Branch
FOR DELETE
AS
BEGIN
	IF (exists (SELECT b.* FROM Branch b, Deleted d WHERE b.Br_ID = d.Br_ID))
	BEGIN
		raiserror( N'Không cho phép xóa chi nhánh,chỉ cập nhật lại EndDate',16,1);
		ROLLBACK TRAN;
	END
END 
GO


--1 căn hộ chỉ 1 nhân viên phụ trách tại 1 thời điểm
create trigger trig_HisEmAp ON HistoryEmployee_Apartment
FOR INSERT
AS
BEGIN
	IF (exists(
				SELECT * 
				FROM HistoryEmployee_Apartment his join INSERTED i 
				 on his.HisE_Apartment = i.HisE_Apartment and his.HisE_Employee != i.HisE_Employee
				where ((his.HisE_StartDate <= i.HisE_StartDate and (i.HisE_EndDate is null 
																	or his.HisE_EndDate >= i.HisE_StartDate 
																	))
				or (i.HisE_EndDate >= his.HisE_StartDate and (his.HisE_EndDate is null or i.HisE_EndDate <= his.HisE_EndDate))
				)))
		begin
			raiserror( N'Mỗi căn hộ tại một thời điểm chỉ một nhân viên phụ trách',16,1)
			ROLLBACK ;
		end
END
go

--1 căn hộ thuộc 1 chi nhánh quản lí
create trigger trig_HistoryBrAp ON HistoryBranch_Apartment
FOR INSERT
AS
BEGIN
	IF (exists(
				SELECT * 
				FROM HistoryBranch_Apartment his join INSERTED i 
				on his.HisB_Apartment = i.HisB_Apartment
				and his.HisB_Branch = i.HisB_Branch
				and his.HisB_StartDate != i.HisB_StartDate
				where  ((his.HisB_StartDate <= i.HisB_StartDate and (his.HisB_EndDate is null 
																	or his.HisB_EndDate >= i.HisB_StartDate 
																	))
				or (i.HisB_EndDate >= his.HisB_StartDate and (his.HisB_EndDate is null or i.HisB_EndDate <= his.HisB_EndDate))
				)))
		begin
			RAISERROR(N'Mỗi căn hộ tại một thời điểm chỉ thuộc một chi nhánh',16,1)
			ROLLBACK ;
		end
END
GO
--khi thay đổi nhân viên phụ trách, không cho phép Xóa nhân viên
create trigger Trig_DeleteEmployee on HistoryEmployee_Apartment
FOR DELETE
AS
BEGIN
	IF (exists (SELECT e.*
				FROM HistoryEmployee_Apartment e, Deleted d 
				WHERE e.HisE_Employee = d.HisE_Employee))
	BEGIN
		RAISERROR(N'Không cho phép xóa nhân viên, chỉ cập nhật lại EndDate',16,1)
		ROLLBACK TRAN;
	END
END 
GO

-- mỗi nhà cho thuê có mã khác với mã của nhà bán
create trigger trig_AddApartmentSale on ApartmentForSale
for insert 
as
begin
	if (exists (select * 
					from ApartmentForRent apr, inserted i
					where apr.Apr_ID = i.Aps_ID))
	begin
		RAISERROR(N'ID nha de ban phai khac ID nha cho thue',16,1)
		rollback;
	end
end
go

create trigger trig_AddApartmentRent on ApartmentForRent
for insert 
as
begin
	if (exists (select * 
					from ApartmentForSale aps, inserted i
					where aps.Aps_ID = i.Apr_ID))
	begin
		raiserror(N'ID nha cho thue phai khac ID nha de ban',16,1)
		rollback;
	end
end

go
---------------------------------------------------------------------
go
--Moi nhan viên chỉ được phụ trách căn hộ do cùng chi nhánh với nhân viên 
create trigger addHistoryEmAp on HistoryEmployee_Apartment
for insert
as
begin
	if(exists (select * 
					from inserted i, Employee em
					where i.HisE_Employee = em.Em_ID 
					and em.Em_Branch not in (select apr.Apr_Branch from ApartmentForRent apr 
												where apr.Apr_ID = i.HisE_Apartment)
						and  em.Em_Branch not in (select aps.Aps_Branch from ApartmentForSale aps 
												where aps.Aps_ID = i.HisE_Apartment)			
												))
	begin
		raiserror(N'Moi nhan vien chi duoc phu trach can ho cung chi nhanh quan li',16,1)
		rollback;
	end 

end
go


---------------  TẠO DỮ LIỆU MẪU -----------------------------------

insert into ContractRent values(1,'2/10/2005','10/20/2006')
insert into ContractRent values(2,'3/22/2007','5/26/2007')
insert into ContractRent values(3,'2/10/2002','10/20/2006')
insert into ContractRent values(4,'2/12/2018','10/20/2019')
insert into ContractRent values(5,'2/10/2017','10/20/2020')
insert into ContractRent values(6,'2/10/2015','10/20/2016')
go
insert into LandLord values(1,N'Phạm Văn An',N'Q5 TpHCM','0986513211')
insert into LandLord values(2,N'Phạm Văn Bình',N'Thủ Đức - TpHCM','0986513222')
insert into LandLord values(3,N'Nguyễn Đức Chiến',N'Q1 - TpHCM','0986513233')
insert into LandLord values(4,N'Lê Duy',N'Dĩ An- Bình Dương','0986513244')
insert into LandLord values(5,N'Trịnh Đông',N'Sóc Trăng','0986513255')
insert into LandLord values(6,N'Tài Em',N'Tây Ninh','0986513266')
insert into LandLord values(7,N'Lê khải',N'Đà Nẵng','0986513277')
insert into LandLord values(8,N'Nguyễn hùng',N'Gia Lai','0986513288')
insert into LandLord values(9,N'Phạm văn Long',N'Kiên Giang','0986513299')
insert into LandLord values(10,N'Lê Bình Minh',N'Cà mau','0986513210')
go
insert into TypeOfApartment values(1,N'Biệt thự')
insert into TypeOfApartment values(2,N'Nhà Cấp 1')
insert into TypeOfApartment values(3,N'Nhà Cấp 2')
insert into TypeOfApartment values(4,N'Nhà Cấp 3')
insert into TypeOfApartment values(5,N'Nhà Cấp 4')
insert into TypeOfApartment values(6,N'Nhà Tranh')
go
insert into Branch values(1,N'Nguyễn Văn Cừ',N'Quận 5',N'TpHCM','0986514679','012345678','3/25/2015',null)
insert into Branch values(2,N'Chu Văn An',N'Thủ Đức',N'TpHCM','0986514145','012345524','3/25/2015',null)
insert into Branch values(3,N'Chương Dương',N'Quận 1',N'TpHCM','0986514254','0123456524','3/25/2015',null)
insert into Branch values(4,N'Cao Bá Quát',N'Quận 9',N'TpHCM','0987358264','012345023','3/25/2015',null)
insert into Branch values(5,N'Đề Thám',N'Quận 2',N'TpHCM','0986514674','012345254','3/25/2015','6/23/2020')
insert into Branch values(6,N'Lê Thị Riêng',N'Quận 3',N'TpHCM','0986514672','012345678','3/25/2015',null)
insert into Branch values(7,N'Lê Văn Hưu',N'Quận 4',N'TpHCM','098651462','012345142','3/25/2015',null)
insert into Branch values(8,N'	Mạc Đĩnh Chi',N'Quận 5',N'TpHCM','098651464','012345644','3/25/2015',null)
insert into Branch values(9,N'Nguyễn Bỉnh Khiêm',N'Quận 6',N'TpHCM','0986514634','012345047','3/25/2015',null)
insert into Branch values(10,N'Nguyễn Cảnh Chân',N'Quận 7',N'TpHCM','098651447','0123451414','3/25/2015',null)
insert into Branch values(11,N'Võ Thị Sáu',N'Quận 8',N'TpHCM','098651474','012345652','3/25/2015',null)
go
insert into Employee values(1,N'Tân','098765124',N'Đà Nẵng','M',123.3,'6/5/1995',1)
insert into Employee values(2,N'An','0987654321',N'TP Hồ Chí Minh','F',123.3,'6/5/1995',3)
insert into Employee values(3,N'Bình','0987654146',N'Tây Ninh','M',123.3,'6/5/1995',3)
insert into Employee values(4,N'Chiến','0987654236',N'An Giang','F',123.3,'6/5/1995',2)
insert into Employee values(5,N'Đông','098765151',N'Cà Mau','M',123.3,'6/5/1995',4)
insert into Employee values(6,N'Dũng','098765148',N'Sóc Trăng','F',123.3,'6/5/1995',5)
insert into Employee values(7,N'Em','098765478',N'Kiên Giang','M',100.3,'6/5/1995',5)
insert into Employee values(8,N'Giang','0987654987',N'Đồng Nai','F',143.3,'6/5/1995',6)
insert into Employee values(9,N'Khánh','0987654654',N'Đồng Tháp','M',115.6,'6/5/1995',7)
insert into Employee values(10,N'Hồng','0987654478',N'Quảng Bình','F',223.3,'6/5/1995',6)
insert into Employee values(11,N'Long','0987654965',N'Quảng Trị','M',173.3,'6/5/1995',8)
insert into Employee values(12,N'Mai','0987654149',N'Huế','M',173.3,'6/5/1995',9)
insert into Employee values(13,N'Nhung','0987654958',N'Hà Tĩnh','F',453.3,'6/5/1990',10)
insert into Employee values(14,N'Phong','0987652591',N'Bình Phước','M',125.3,'6/5/1980',11)
insert into Employee values(15,N'Quang','0987644365',N'Hà Nội','M',300.3,'6/5/1985',11)
insert into Employee values(16,N'TRọng','0941654365',N'Hà Nội','M',351.3,'6/5/2000',10)

go
insert into Customer values(1,N'Lan',N'Quảng Bình','0986513116',N'có sân vườn',1,'R',5)
insert into Customer values(2,N'Trinh',N'Quảng Nam','0986513226',N'mái bằng',5,'B',10)
insert into Customer values(3,N'Chiến',N'TP HCM','0986513336',N'mái ngói',2,'R',6)
insert into Customer values(4,N'Thái',N'Bình Dương','0986513446',N'có 2 tầng',1,'R',2)
insert into Customer values(5,N'Huy',N'Tây Ninh','0986513556',N'nhà gần chợ',4,'B',11)
insert into Customer values(6,N'Hoàng',N'Cà Mau','0986513666',N'gần sông',6,'B',8)
insert into Customer values(7,N'Thảo',N'Bình Dương','0986513776',N'có sân tennis',1,'R',6)
insert into Customer values(8,N'Hùng',N'An Giang','0986513886',N'ven biển',2,'B',3)
insert into Customer values(9,N'Linh',N'Cà Mau','0986513996',N'gần công viên',4,'R',9)
insert into Customer values(10,N'Tú',N'Bình Phước','0981113106',N'an ninh tốt',2,'B',2)
insert into Customer values(11,N'Hải',N'Quảng Bình','0986513196',N'an ninh tốt',3,'R',10)
insert into Customer values(12,N'Loan',N'Sóc Trăng','0986513126',N'có sân vườn',4,'B',8)
insert into Customer values(13,N'Tú',N'Sóc Trăng','0986513135',N'mái bằng',3,'R',4)
insert into Customer values(14,N'Oanh',N'Bình Dương','0986513344',N'có 2 tầng',1,'R',2)
insert into Customer values(15,N'Dũng',N'Tây Ninh','0986513455',N'nhà gần chợ',4,'B',11)
insert into Customer values(16,N'Trung',N'Cà Mau','0986513566',N'gần sông',6,'B',8)
insert into Customer values(17,N'Nam',N'Bình Dương','0986513677',N'có sân tennis',1,'R',6)
insert into Customer values(18,N'Khuy',N'An Giang','0986513788',N'ven biển',2,'B',3)
insert into Customer values(19,N'Trúc',N'Cà Mau','0986513899',N'gần công viên',4,'R',9)
insert into Customer values(20,N'Tài',N'Bình Phước','0986513910',N'an ninh tốt',2,'B',2)
insert into Customer values(21,N'Giang',N'Quảng Bình','0986513120',N'an ninh tốt',3,'B',10)
insert into Customer values(22,N'Lan',N'Sóc Trăng','0986513530',N'có sân vườn',4,'R',8)
insert into Customer values(23,N'Hồng',N'Sóc Trăng','0986513440',N'mái bằng',3,'R',4)
go

insert into ApartmentForSale values('AS01',N'Chương Dương',N'Thủ Đức',N'Tp HCM',5,1,10,'10/20/2017','01/01/2018','N',200,220000.0,null,null, null, null, null,11)
insert into ApartmentForSale values('AS02',N'Ngô Quyền',N'Quận 5',N'Tp HCM',10,2,5,'10/20/2018','1/1/2019','N',220,450000.0,null,null,null,null,null,1)
insert into ApartmentForSale values('AS03',N'Đinh Tiên Hoàng',N'Quận 1',N'Tp HCM',6,5,3,'12/27/2019','1/1/2020','N',100,1000000.0,'Chi ban cho khach nam',null,null,null,null,5)
insert into ApartmentForSale values('AS04',N'Nguyễn Công Hoan',N'Dĩ An',N'Bình Dương',7,4,2,'11/21/2015','1/1/2016','N',150,782000.0,'Chi ban cho khach nu',null,null,null,null,7)
insert into ApartmentForSale values('AS05',N'Cao Bá',N'Thủ Đức',N'Tp HCM',3,3,4,'10/20/2017','1/1/2018','N',176,553000.0,'Khong lam on',null,null,null,null,1)
insert into ApartmentForSale values('AS06',N'Bùi Thị Xuân',N'Quận 9',N'Tp HCM',8,6,2,'10/20/2018','1/1/2019','N',332,632000.0,'Khong tra gop',null,null,null,null,6)
insert into ApartmentForSale values('AS07',N'Cao Bá Nhạ',N'Bình Tân',N'Tp HCM',9,1,20,'10/20/2019','1/1/2020','N',142,475000.0,'Khong tra gop',null,null,null,null,4)
insert into ApartmentForSale values('AS08',N'Công Xã Paris',N'Quận 2',N'Tp HCM',4,2,6,'1/2/2020','10/10/2020','N',457,800000.0,'Khong tra gop',null,null,null,null,3)
insert into ApartmentForSale values('AS09',N'Công Xã Paris',N'Quận 2',N'Tp HCM',4,2,6,'10/20/2019','1/1/2020','N',457,758000.0,'Khong tra gop',null,null,null,null,3)

go

insert into ApartmentForRent values('AR1',N'Lương Văn Can',5,3,N'Dĩ An',N'Bình Dương',5,'3/4/2020','10/10/2020','E',250,1000.0,6)
insert into ApartmentForRent values('AR2',N'Lê Quý Ðôn',6,4,N'Dĩ An',N'Bình Dương ',2,'3/4/2020','10/10/2020','F',100,1000.0,1)
insert into ApartmentForRent values('AR3',N'Hoa Sứ',7,5,N'Thủ Đức',N'TP HCM',3,'3/4/2020','10/10/2020','F',150,1000.0,10)
insert into ApartmentForRent values('AR4',N'Hồ Xuân Hương',8,6,N'Quận 1',N'TP HCM',6,'3/4/2020','10/10/2020','F',22,1000.0,7)
insert into ApartmentForRent values('AR5',N'Cầu Him Lam',9,2,N'Quận 2',N'TP HCM',2,'3/4/2020','10/10/2020','E',99,1000.0,2)
insert into ApartmentForRent values('AR6',N'Tân Hương',10,3,N'Quận 3',N'TP HCM',2,'3/4/2020','10/10/2020','F',245,1000.0,3)
insert into ApartmentForRent values('AR7',N'Lạc Long Quân',1,4,N'Quận 4',N'TP HCM',3,'3/4/2020','10/10/2020','E',124,1000.0,4)
insert into ApartmentForRent values('AR8',N'Lê Văn Thọ',2,5,N'Quận 5',N'TP HCM',4,'3/4/2020','10/10/2020','F',145,1000.0,2)
insert into ApartmentForRent values('AR9',N'Võ Thị Sáu',3,2,N'Quận 6',N'TP HCM',4,'10/10/2019','1/1/2020','F',145,1000.0,2)


go 
insert into DemandOfCustomer values(1,'R',2)
insert into DemandOfCustomer values(2,'B',4)
insert into DemandOfCustomer values(3,'R',3)
insert into DemandOfCustomer values(4,'R',2)
insert into DemandOfCustomer values(5,'B',5)
insert into DemandOfCustomer values(6,'B',6)
insert into DemandOfCustomer values(7,'R',4)
insert into DemandOfCustomer values(8,'B',5)
insert into DemandOfCustomer values(9,'R',6)
insert into DemandOfCustomer values(10,'B',5)
insert into DemandOfCustomer values(11,'R',1)
insert into DemandOfCustomer values(1,'R',4)
insert into DemandOfCustomer values(2,'B',5)
insert into DemandOfCustomer values(3,'R',2)
insert into DemandOfCustomer values(9,'R',3)
insert into DemandOfCustomer values(10,'B',3)
GO

insert into HouseViewChecklist values('2/3/2020',5,'B','AS06',N'Nhà đẹp')
insert into HouseViewChecklist values('3/3/2020',7,'R','AR5',N'Nhà rộng')	
insert into HouseViewChecklist values('4/3/2020',8,'B','AS07',N'Nhà xấu')	
insert into HouseViewChecklist values('5/3/2020',9,'R','AR1',N'Nhà đẹp')	
insert into HouseViewChecklist values('6/3/2020',10,'B','AS02',N'Nhà đẹp')	
insert into HouseViewChecklist values('7/3/2020',11,'R','AR6',N'Nhà đẹp')	
insert into HouseViewChecklist values('8/3/2020',12,'B','AS03',N'Nhà đẹp')	
insert into HouseViewChecklist values('9/3/2020',13,'R','AR7',N'Nhà đẹp')	
insert into HouseViewChecklist values('10/3/2020',4,'R','AR8',N'Nhà đẹp')	
go 

insert into RentInformation values(1,'R','AR1',1,13)
insert into RentInformation values(3,'R','AR4',3,9) 
insert into RentInformation values(3,'R','AR5',4,3)
insert into RentInformation values(7,'R','AR8',3,4 )
insert into RentInformation values(7,'R','AR7',6,5)
insert into RentInformation values(11,'R','AR1',5,1)
insert into RentInformation values(17,'R','AR2',1,1)
go


insert into HistoryBranch_Apartment values(1,'AS01','5/5/2015','3/3/2016')
insert into HistoryBranch_Apartment values(1,'AS02','3/3/2016',null)
insert into HistoryBranch_Apartment values(5,'AS03','2/2/2017',null)
insert into HistoryBranch_Apartment values(11,'AR4','2/2/2017',null)
insert into HistoryBranch_Apartment values(8,'AR5','2/2/2017',null)
insert into HistoryBranch_Apartment values(9,'AR6','2/2/2017',null)
insert into HistoryBranch_Apartment values(4,'AR7','2/2/2017',null)
insert into HistoryBranch_Apartment values(3,'AR8','2/2/2017',null)
go


insert into HistoryEmployee_Apartment values(14,'AS01','2/2/2015','2/2/2016')
insert into HistoryEmployee_Apartment values(14,'AS01','2/2/2016',null)
insert into HistoryEmployee_Apartment values(1,'AR2','2/2/2015',null)
insert into HistoryEmployee_Apartment values(6,'AS03','2/2/2015',null)
insert into HistoryEmployee_Apartment values(9,'AR4','2/2/2015',null)
insert into HistoryEmployee_Apartment values(1,'AS05','2/2/2015',null)
insert into HistoryEmployee_Apartment values(2,'AR6','2/2/2015',null)
insert into HistoryEmployee_Apartment values(5,'AS07','2/2/2015',null)
insert into HistoryEmployee_Apartment values(3,'AS08','2/2/2015','2/2/2016')
insert into HistoryEmployee_Apartment values(3,'AS08','2/2/2016',null)
go
--Thêm nhân viên
create proc Add_Customer @id int,@name nvarchar(50),@dc nvarchar(50),@phone varchar(10),@yc nvarchar(20),@loainha smallint,
						@loai_cus varchar(1),
						@branch smallint
as
BEGIN
	INSERT INTO Customer(Cus_ID,Cus_Name,Cus_Address,Cus_PhoneNumber,Cus_Criteria,Cus_TypeApart,Cus_TypeCustomer,Cus_BranchMange)
	VALUES (@id, @name, @dc, @phone, @yc,@loainha,@loai_cus,@branch)
END
GO 
--exec Add_Customer 50,'ds','ds','ds','ds',1,'B',10
--Tìm kiếm nhân viên

create proc Find_Customer
	@id int, @name nvarchar(50), @adr nvarchar(50)
AS
BEGIN
	--  0 đk -> select all
	IF (@id = 0 and @name is null and @adr is null)
		SELECT * FROM Employee

	-- Tìm theo đk phòng ban
	IF (@id != 0 and @name is null and @adr is null)
		BEGIN
			SELECT c.*
			FROM Customer c
			where c.Cus_ID = @id
			RETURN;
		END

	-- Tìm theo ca làm việc
	IF (@id = 0 and @name is not null and @adr is null)
		BEGIN
			SELECT c.*
			FROM Customer c
			where c.Cus_Name = @name
			RETURN;
		END

	-- Tìm theo giới tính
	IF (@id = 0 and @name is null and @adr IS NOT null)
		BEGIN
			SELECT c.*
			FROM Customer c
			WHERE c.Cus_Address = @adr 
			RETURN;
		END
	-- Tìm theo: phòng ban và ca 
	IF (@id != 0 and @name is not null and @adr is null)
		BEGIN
			SELECT c.*
			FROM Customer c
			where c.Cus_ID = @id and c.Cus_Name = @name
		END

	-- Tìm theo: phòng ban và  giới tính
	IF (@id!= 0 and @name is null and @adr IS NOT null)
		BEGIN
			SELECT c.*
			FROM Customer c
			where c.Cus_ID=@id and c.Cus_Address = @adr
			RETURN;
		END

	-- Tìm theo:  ca và giới tính
	IF (@id = 0 and @name is not null and @adr IS NOT null)
		BEGIN
			SELECT c.*
			FROM Customer c
			where c.Cus_Name = @name and c.Cus_Address = @adr
			RETURN;
		END

	-- tìm đủ 3 đk
	IF (@id!= 0 and @name is not null and @adr IS NOT null)
		BEGIN
			SELECT c.*
			FROM Customer c
			where c.Cus_Name = @name and c.Cus_Address = @adr and c.Cus_ID = @id
			
		END
END
GO
--exec Find_Customer 10,N'Nam',N'Quang'
--thông tin nhân viên

create proc Infor_Employee @id int 
as
begin
	select e.*
	from Employee e
	where e.Em_ID = @id
end
go
--thông tin nhân viên thuộc 1 chi nhánh
create proc Employee_Branch @id int
as
begin 
select e.Em_ID,e.Em_Name,e.Em_Address,e.Em_PhoneNumber,e.Em_Salary
from Employee e,Branch b
where e.Em_Branch = b.Br_ID and b.Br_ID = @id
end
--thông tin căn hộ thuộc 1 chi nhánh
create proc Apr_Branch @id int
as
begin 
select ar.Apr_ID,ar.Apr_City,ar.Apr_MonthRent
from ApartmentForRent ar
where ar.Apr_Branch = @id
end
go

create proc Aps_Branch @id int
as
begin 
select aps.Aps_ID,aps.Aps_CityOrProvince,aps.Aps_Price
from ApartmentForSale aps
where aps.Aps_Branch = @id
end
-- Branch- Employee
go
create proc Branch_Employee @id int
as
begin 
select b.Br_ID,b.Br_CityOrProvince,b.Br_PhoneNumber
from Branch b,Employee e
where e.Em_Branch = b.Br_ID and e.Em_ID = @id
end
go
--NHân viên đang phụ trách  văn hộ nào
create proc Apar_Em @id int
as
begin
	select hea.HisE_Apartment,hea.HisE_Employee,hea.HisE_StartDate
	from HistoryEmployee_Apartment hea
	where hea.HisE_Employee = @id and hea.HisE_EndDate is null
end
go
--thông tin chủ hộ
create proc TT_LandLord @name nvarchar(50)
as
begin
	select lan.Lan_ID,lan.Lan_Address,lan.Lan_PhoneNumber
	from LandLord lan
	where lan.Lan_Name = @name
end
go
--Liệt kê nhà chủ hộ
create proc apr_LandLord @name nvarchar(50)
as
begin
select apr.Apr_ID, apr.Apr_City,apr.Apr_MonthRent
from ApartmentForRent apr,LandLord lan 
where apr.Apr_LandLord = lan.Lan_ID
	and lan.Lan_Name = @name
end
go
create proc aps_LandLord @name nvarchar(50)
as
begin
select aps.Aps_ID, aps.Aps_CityOrProvince,aps.Aps_Price
from ApartmentForSale aps,LandLord lan 
where aps.Aps_LandLord = lan.Lan_ID
	and lan.Lan_Name = @name
end