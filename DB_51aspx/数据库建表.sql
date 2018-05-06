use HYMIS
--�û�Ȩ�ޱ�
create table HY_Security
(
   s_ID int identity(1,1) primary key, -- ����
   s_QID int not null,
   s_QName varchar(20) not null --Ȩ��
)

select Count(*)as con from HY_user
select * from HY_BomInfo

--�ֿ��
create table HY_Warehouse
(
   c_ID int identity(1,1) primary key, -- ����
   c_ckName varchar(20) not null --�ֿ���
)
--��Ӧ�̱�
create table HY_Supplier
(
    s_ID int identity(1,1) primary key, --����
    s_gyName varchar(50) not null, --��Ӧ������
    s_jName varchar(10), --��˾���
    s_Area varchar(50) not null, --����
    s_cpName varchar(250) not null --��Ӧ��Ʒ
)

--��Ӧ�����ϼ۸���Ϣ��

create table HY_SupplierPrice
(
   p_ID int identity(1,1) primary key,
   p_DID varchar(100) not null,
   p_PID varchar(100) not null,
   p_gyName varchar(50) not null,
   p_Date datetime default(getdate()),
   p_PName varchar(50) not null,
   p_Price int not null,
   p_rPerson varchar(10) not null,
   p_SM varchar(100)
)

--�빺��Ϣ��
create table HY_RequisitionInfo
(
   r_ID int identity(1,1) primary key,
   r_DID varchar(100) not null, --�빺����
   r_Department varchar(20) not null, --�빺����
   r_Person varchar(10) not null, --�빺��
   r_Name varchar(50) not null, --Ʒ��
   r_Supplier varchar(100) not null, --��Ӧ��
   r_Origin varchar(10), --����
   r_QDate datetime not null, --�빺ʱ��
   r_XDate datetime not null, --��Ҫʱ��
   r_Specifications varchar(200) not null, --��� 
   r_Units varchar(2) not null, --��λ
   r_Amount int not null, --����
   r_Uses varchar(200) not null, --��;
   r_Notes varchar(500), --��ע
   r_Hot varchar(100 )--�ȴ���
)

Update set HY_RequisitionInfo r_State='��ȷ��' where r_DID
insert into HY_ProcurementInfo(c_DID,c_Department,c_Person,c_Name,c_Supplier,c_Origin,c_QDate,c_XDate,c_Specifications,c_Units,c_Uses,c_Notes,c_Hot,c_Amount) select REPLACE(r_DID,'QG','CG'),r_Department,r_Person,r_Name,r_Supplier,r_Origin,r_QDate,r_XDate,r_Specifications,r_Units,r_Uses,r_Notes,r_Hot,r_Amount from HY_RequisitionInfo WHERE r_DID='QG-16122009113737'  
select * from HY_ProcurementInfo where c_DID='CG-16122009113737'
select distinct c_DID from HY_ProcurementInfo  order by c_ID desc
select distinct r_DID from HY_RequisitionInfo where r_DID like 'QG%'
select REPLACE(r_DID,'QG','CG'),r_Department,r_Person,r_Name,r_Supplier,r_Origin,r_QDate,r_XDate,r_Specifications,r_Units,r_Uses,r_Notes,r_Hot,r_Amount from HY_RequisitionInfo WHERE r_DID='QG-16122009113737'
--�ɹ���Ϣ��

create table HY_ProcurementInfo
(
   c_ID int identity(1,1) primary key,
   c_DID varchar(100) not null, --�ɹ�����
   c_Department varchar(20) not null, --�ɹ�����
   c_Person varchar(10) not null, --������
   c_Name varchar(50) not null, --Ʒ��
   c_Supplier varchar(100) not null, --��Ӧ��
   c_Origin varchar(10), --����
   c_QDate datetime not null, --�ɹ�ʱ��
   c_XDate datetime not null, --��Ҫʱ��
   c_Specifications varchar(200) not null, --��� 
   c_Units varchar(2) not null, --��λ
   c_Amount int not null, --����
   c_Uses varchar(200) not null, --��;
   c_Notes varchar(500), --��ע
   c_Hot varchar(100 )--�ȴ���
)

--BOM������Ϣ��

create table HY_BomInfo
(
   b_ID int identity(1,1) primary key,
   b_SKID varchar(100) not null, --�ܿر��
   b_CID varchar(100) not null, --���ڱ��
   b_CustomerID varchar(100) not null, --�ͻ����
   b_No varchar(10) not null, --������
   b_Material varchar(20) not null, --����
   b_BomSize varchar(10), --���ϳߴ�
   b_Notes varchar(100), --��������
   b_Height varchar(10) not null, --�պϸ߶�
   b_Tonnage varchar(10) not null, --�崲��λ
   b_Name varchar(20) not null, --ģ������
   b_SPerson varchar(10) not null, --�����
   b_Proofreading varchar(10),--У����
   b_Audit varchar(10),--�����
   b_SDate datetime not null, --���ʱ��
   b_XDate datetime , --У��ʱ��
   b_HDate datetime  --�˶�ʱ��
)
use HYMIS
Delete HY_BomInfo.*,HY_BomDetails.* from 
Select HY_BomInfo.b_SKID,HY_BomInfo.b_CID,HY_BomInfo.b_CustomerID,HY_BomInfo.b_SPerson,HY_BomInfo.b_SDate,HY_BomDetails.d_PID,HY_BomDetails.d_PName,HY_BomDetails.d_Model,HY_BomDetails.d_Specifications,HY_BomDetails.d_Amount,HY_BomDetails.d_Heat,HY_BomDetails.d_Notes from HY_BomInfo INNER JOIN HY_BomDetails on HY_BomInfo.b_SKID='B-7012010164146'
Update HY_BomDetails set
--BOM������ϸ��

create table HY_BomDetails
(
   d_ID int identity(1,1) primary key,
   d_SKID varchar(100) not null, --����BOM����
   d_CID varchar(100) not null, --���ڱ��
   d_PID varchar(100) not null,--Ʒ��
   d_PName varchar(50) not null, --Ʒ��
   d_Model varchar(50) not null, --�����ͺ�
   d_Specifications varchar(200) not null, --���Ϲ�� 
   d_Amount varchar(10) not null, --����
   d_Heat varchar(30) not null, --�ȴ���
   d_Notes varchar(200) not null, --��ע
   d_SPerson varchar(10)  --�����

)
--�빺��Ϣ��
create table HY_RequisitionInfo
(
   r_ID int identity(1,1) primary key,
   r_DID varchar(100) not null, --�빺����
   r_NameID varchar(100) not null, --Ʒ��
   r_Department varchar(20) not null, --�빺����
   r_Person varchar(10) not null, --�빺��
   r_Name varchar(50) not null, --Ʒ��
   r_Supplier varchar(100) not null, --��Ӧ��
   r_Origin varchar(100), --�ͺ�
   r_QDate datetime not null, --�빺ʱ��
   r_XDate datetime not null, --��Ҫʱ��
   r_Specifications varchar(200) not null, --��� 
   r_Units varchar(2) not null, --��λ
   r_Amount int not null, --����
   r_Uses varchar(200) not null, --��;
   r_Notes varchar(500), --��ע
   r_Hot varchar(100 )--�ȴ���
)
use HYMIS 
update HY_RequisitionInfo set r_DID= ,r_NameID=,r_Department=,r_Person=,r_Name=,r_Supplier=,r_Origin=,r_QDate=,r_XDate=,r_Specifications=,r_Units=,r_Amount,r_Uses=,r_Notes,r_Hot=
select r_DID,max(r_ID),max(r_QDate),max(r_Person) from HY_RequisitionInfo group by r_DID
select distinct r_DID,r_State from HY_RequisitionInfo
--BOM�����빺��
insert into HY_RequisitionInfo(r_DID,r_NameID,r_Name,r_Person,r_Origin,r_Specifications,r_Amount,r_Hot,r_Notes) select REPLACE(d_SKID,'B','QG'),d_PID,d_PName,d_SPerson,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes from HY_BomDetails WHERE d_SKID='B-12122009142724'

insert into HY_RequisitionInfo(r_DID,r_NameID,r_Person,r_Origin,r_Specifications,r_Amount,r_Hot,r_Notes) select REPLACE(d_SKID,'B','QG'),d_PID,d_SPerson,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes from HY_BomDetails WHERE d_SKID='B-12122009142724'

select * from HY_RequisitionInfo

select HY_BomInfo.*,HY_BomDetails.* from HY_BomInfo inner join HY_BomDetails on HY_BomInfo.b_SKID=HY_BomDetails.d_SKID and HY_BomDetails.d_SKID=@d_SKID
select  * from HY_BomInfo where b_ID=5
insert into HY_Supplier(s_gyName,s_jName,s_Area,s_cpName) values('���������Ƽ�','TP','����','·������������')
select s_gyName,s_jName,s_Area,s_Name,s_Tel,s_cpName from HY_Supplier

insert into HY_user(h_UserName,h_yUserPwd,h_Status) values('׿Խ','123456','')

insert into HY_BomDetails(d_SKID,d_CID,d_PID,d_PName,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes,d_SPerson) values(d_SKID,d_CID,d_PID,d_PName,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes,d_SPerson)

delete from HY_Department where d_ID=1

select * from HY_CPClass order by c_ID desc

--��Ʒ����

create table HY_CPClass
(
   c_ID int identity(1,1) primary key,
   c_Class varchar(50) not null -- ��Ʒ�����

)

inser into HY_CPClass(c_Class) values('')
delete from HY_CPClass where c_ID=1
USE HYMIS
--��Ʒ��ⵥ
create table HY_Storage
(
   s_ID int identity(1,1) primary key,
   s_DID varchar(100) not null, --����
   s_CID varchar(100) , --���ڱ��
   s_Person varchar(10) not null, --�����
   s_Class varchar(50) not null,--��Ʒ��𣨴��ࣩ
   s_Warehouse varchar(20) not null, --�ֿ�
   s_XDate datetime , --���ʱ��
   s_DDate datetime , --����ʱ��
   s_PID varchar(100) not null, --Ʒ��
   s_Pname varchar(100) not null, --Ʒ��
   s_Specifications varchar(200) not null, --���
   s_Amount int not null, --����
   s_Price int not null, --����
   s_Notes varchar(200)  --��ע
)

---�������ͳ�Ʊ�
Create table HY_StorageStatistics
(
   s_ID int identity(1,1) primary key,
   s_DID varchar(100) not null, --����
   s_CID varchar(100) , --���ڱ��
   s_PID varchar(100) not null, --Ʒ��
   s_Class varchar(50) not null,--��Ʒ��𣨴��ࣩ
   s_Amount int not null, --����
   s_Price int not null, --����
)

use HYMIS
Update set HY_Storage s_DID='"+ hystormodel.S_DID+"',s_CID='"+hystormodel.S_CID+"',s_Person='" + hystormodel.S_Person + "',s_Class='" + hystormodel.S_Class + "',s_Warehouse='" + hystormodel.S_Warehouse + "',s_XDate='" + hystormodel.S_XDate + "',s_DDate='" + hystormodel.S_DDate + "',s_Pname='" + hystormodel.S_Pname + "',s_Specifications='" + hystormodel.S_Specifications + "',s_Amount='" + hystormodel.S_Amount + "',s_Price='" + hystormodel.S_Price + "',s_Notes,'" + hystormodel.S_Notes + "' where  s_PID='" + hystormodel.S_PID + "'
values(,,,,,)
select sum(s_Price) as PR,sum(s_Amount) as AM from HY_Storage where s_PID='PH-4012010113624'
select s_ID,s_PID,s_Pname,s_Specifications,s_Price,s_Class,s_Warehouse from HY_Storage where s_PID like 'PH%' order by s_ID desc
SELECT * from HY_Storage order by 
--���ϵ�
create table HY_Receiving
(
   r_ID int identity(1,1) primary key,
   r_DID varchar(100) not null, --���ϵ���
   r_Person varchar(10) not null, --������
   r_Class varchar(50) not null,--�ϼ���𣨴��ࣩ
   r_Warehouse varchar(20) not null, --���ڲֿ�
   r_LDate datetime , --��������
   r_PID varchar(100) not null, --����Ʒ��
   r_Pname varchar(100) not null, --Ʒ��
   r_Specifications varchar(200) not null, --���Ϲ��
   r_Amount int not null, --��ȡ����
   r_Price int not null, --���ϵ���
   r_Notes varchar(200)  --���ϱ�ע
)
use HYMIS

update HY_Receiving set r_DID='" + hyreqmodel.R_DID + "',r_Person='" + hyreqmodel.R_Person + "',r_Class='" + hyreqmodel.R_Class + "',r_Warehouse='" + hyreqmodel.R_Warehouse + "',r_LDate='" + hyreqmodel.R_LDate + "',r_Pname='" + hyreqmodel.R_Pname + "',r_Specifications='" + hyreqmodel.R_Specifications + "',r_Amount='" + hyreqmodel.R_Amount + "',r_Price='" + hyreqmodel.R_Price + "',r_Notes='" + hyreqmodel.R_Notes + "' where r_PID='" + hyreqmodel.R_PID + "'
values(,,,,,,,,,,)

insert into HY_Receiving(r_DID,r_Person,r_Class,r_Warehouse,r_LDate,r_PID,r_Pname,r_Specifications,r_Amount,r_Price,r_Notes) values()
select * from HY_Receiving where r_DID='' like '%a%' order by s_ID desc
--��Ʒ��ⵥ������־
create table HY_StorageLog
(
   s_ID int identity(1,1) primary key,
   s_DID varchar(100) not null, --����
   s_CID varchar(100) , --���ڱ��
   s_Person varchar(10) not null, --�����
   s_Class varchar(50) not null,--��Ʒ��𣨴��ࣩ
   s_Warehouse varchar(20) not null, --�ֿ�
   s_XDate datetime , --���ʱ��
   s_DDate datetime , --����ʱ��
   s_PID varchar(100) not null, --Ʒ��
   s_Pname varchar(100) not null, --Ʒ��
   s_Specifications varchar(200) not null, --���
   s_Amount int not null, --����
   s_Price int not null, --����
   s_Notes varchar(200)  --��ע
)
update HY_StorageLog set s_Amount=s_Amount-1
select * from HY_StorageLog where s_DID='CK-201222009083343'
select s_ID,s_PID,s_Pname,sum(s_Amount) as s_KCAmount from HY_Storage group by s_ID,s_PID,s_Pname having  sum(s_Amount)=1
select s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes from HY_Storage where s_ID=1
insert into HY_Storage(s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes) values()
select s_PID,sum(s_Amount) as s_KCAmount,s_Pname from HY_Storage group by s_PID,s_Pname having sum(s_Amount)<40
--����ָ���ų̱�
create table HY_ProductionPlanning
(
   p_ID int identity(1,1) primary key,
   p_DID varchar(100) not null, --���۵���
   p_KID varchar(100) , --�ͻ�����
   p_CID varchar(100) , --���ڱ��
   p_Engineering varchar(10) not null, --������
   p_Design varchar(10) not null, --��Ƶ���
   p_YKDate datetime , --Ӫҵȷ�Ͽ�ʼʱ��
   p_YWDate datetime , --Ӫҵȷ�����ʱ��
   p_SKDate datetime , --��ƿ�ʼʱ��
   p_SWDate datetime , --������ʱ��
   p_STKDate datetime , --��ͼ��ʼʱ��
   p_STWDate datetime , --��ͼ���ʱ��
   p_CLKDate datetime , --����Ҫ�󵽻�ʱ��
   p_CLWDate datetime , --����ʵ�ʵ���ʱ��
   p_CNCKDate datetime , --CNC�ӹ���ʼʱ��
   p_CNCWDate datetime , --CNC�ӹ����ʱ��
   p_JJKDate datetime , --���ӹ���ʼʱ��
   p_JJWDate datetime , --���ӹ����ʱ��
   p_HKDate datetime , --�ȴ���ʼʱ��
   p_HWDate datetime , --�ȴ������ʱ��
   p_MKDate datetime , --ĥ�ӹ���ʼʱ��
   p_MWDate datetime , --ĥ�ӹ����ʱ��
   p_XKDate datetime , --���иʼʱ��
   p_XWDate datetime , --���и����ʱ��
   p_ZLKDate datetime , --������ʼʱ��
   p_ZLWDate datetime , --�������ʱ��
   p_SZKDate datetime , --������ʼʱ��
   p_SZWDate datetime , --�������ʱ��
   p_XJWDate datetime , --�ͼ����ʱ��
   p_OKWDate datetime , --OK���ύ���ʱ��
   p_YDWDate datetime  --ģ���ƽ����ʱ��

)

insert into HY_ProductionPlanning(p_DID,p_KID,p_CID,p_Engineering,p_Design) values('','','','','')
select * from HY_ProductionPlanning where p_DID='1111111111111'
update HY_ProductionPlanning set p_YKDate='',p_YWDate='' where p_DID=''

--�ͻ���Ϣ��
create table HY_CustomerInfo
(
   c_ID int identity(1,1) primary key,
   c_Name varchar(100) not null, --�ͻ�����
   c_FID varchar(100) not null --�ͻ�����
)
use HYMIS
select * from HY_CustomerInfo order by c_ID desc
insert into HY_CustomerInfo(c_Name,c_FID) values('','')
delete from HY_CustomerInfo where c_ID=''
update HY_CustomerInfo set c_Name='cvcvc',c_FID='ddd' where c_ID='3'

--�ͻ�������Ϣ��
create table HY_CustomerOrder
(
   o_ID int identity(1,1) primary key,
   o_DID varchar(100) not null,--���۵���
   o_Name varchar(100) not null, --�ͻ�����
   o_FID varchar(100) not null, --�ͻ�����
   o_CPName varchar(100) not null, --��Ʒ����
   o_Person varchar(10) not null, --¼����
   o_RDate datetime , --¼��ʱ��
   o_Notes varchar(300) --��ע   
)
select o_ID,o_DID, from HY_CustomerOrder order by o_ID desc
insert into HY_CustomerOrder(o_Name,o_FID,o_CPName,o_Person,o_RDate,o_Notes) values('','','','','','')

select h_ID,h_UserName,h_yUserPwd,h_Permissions,h_Status,h_Department from HY_user

update HY_user set h_Department='CNC' where h_ID='5'