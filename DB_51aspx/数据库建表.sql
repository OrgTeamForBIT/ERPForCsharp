use HYMIS
--用户权限表
create table HY_Security
(
   s_ID int identity(1,1) primary key, -- 主键
   s_QID int not null,
   s_QName varchar(20) not null --权限
)

select Count(*)as con from HY_user
select * from HY_BomInfo

--仓库表
create table HY_Warehouse
(
   c_ID int identity(1,1) primary key, -- 主键
   c_ckName varchar(20) not null --仓库名
)
--供应商表
create table HY_Supplier
(
    s_ID int identity(1,1) primary key, --主键
    s_gyName varchar(50) not null, --供应商名称
    s_jName varchar(10), --公司简称
    s_Area varchar(50) not null, --地区
    s_cpName varchar(250) not null --供应产品
)

--供应商物料价格信息表

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

--请购信息表
create table HY_RequisitionInfo
(
   r_ID int identity(1,1) primary key,
   r_DID varchar(100) not null, --请购单号
   r_Department varchar(20) not null, --请购部门
   r_Person varchar(10) not null, --请购人
   r_Name varchar(50) not null, --品名
   r_Supplier varchar(100) not null, --供应商
   r_Origin varchar(10), --地区
   r_QDate datetime not null, --请购时间
   r_XDate datetime not null, --需要时间
   r_Specifications varchar(200) not null, --规格 
   r_Units varchar(2) not null, --单位
   r_Amount int not null, --数量
   r_Uses varchar(200) not null, --用途
   r_Notes varchar(500), --备注
   r_Hot varchar(100 )--热处理
)

Update set HY_RequisitionInfo r_State='已确认' where r_DID
insert into HY_ProcurementInfo(c_DID,c_Department,c_Person,c_Name,c_Supplier,c_Origin,c_QDate,c_XDate,c_Specifications,c_Units,c_Uses,c_Notes,c_Hot,c_Amount) select REPLACE(r_DID,'QG','CG'),r_Department,r_Person,r_Name,r_Supplier,r_Origin,r_QDate,r_XDate,r_Specifications,r_Units,r_Uses,r_Notes,r_Hot,r_Amount from HY_RequisitionInfo WHERE r_DID='QG-16122009113737'  
select * from HY_ProcurementInfo where c_DID='CG-16122009113737'
select distinct c_DID from HY_ProcurementInfo  order by c_ID desc
select distinct r_DID from HY_RequisitionInfo where r_DID like 'QG%'
select REPLACE(r_DID,'QG','CG'),r_Department,r_Person,r_Name,r_Supplier,r_Origin,r_QDate,r_XDate,r_Specifications,r_Units,r_Uses,r_Notes,r_Hot,r_Amount from HY_RequisitionInfo WHERE r_DID='QG-16122009113737'
--采购信息表

create table HY_ProcurementInfo
(
   c_ID int identity(1,1) primary key,
   c_DID varchar(100) not null, --采购单号
   c_Department varchar(20) not null, --采购部门
   c_Person varchar(10) not null, --申请人
   c_Name varchar(50) not null, --品名
   c_Supplier varchar(100) not null, --供应商
   c_Origin varchar(10), --地区
   c_QDate datetime not null, --采购时间
   c_XDate datetime not null, --需要时间
   c_Specifications varchar(200) not null, --规格 
   c_Units varchar(2) not null, --单位
   c_Amount int not null, --数量
   c_Uses varchar(200) not null, --用途
   c_Notes varchar(500), --备注
   c_Hot varchar(100 )--热处理
)

--BOM物料信息表

create table HY_BomInfo
(
   b_ID int identity(1,1) primary key,
   b_SKID varchar(100) not null, --受控编号
   b_CID varchar(100) not null, --厂内编号
   b_CustomerID varchar(100) not null, --客户编号
   b_No varchar(10) not null, --工程数
   b_Material varchar(20) not null, --材质
   b_BomSize varchar(10), --用料尺寸
   b_Notes varchar(100), --工作内容
   b_Height varchar(10) not null, --闭合高度
   b_Tonnage varchar(10) not null, --冲床吨位
   b_Name varchar(20) not null, --模具名称
   b_SPerson varchar(10) not null, --设计人
   b_Proofreading varchar(10),--校对人
   b_Audit varchar(10),--审核人
   b_SDate datetime not null, --设计时间
   b_XDate datetime , --校对时间
   b_HDate datetime  --核对时间
)
use HYMIS
Delete HY_BomInfo.*,HY_BomDetails.* from 
Select HY_BomInfo.b_SKID,HY_BomInfo.b_CID,HY_BomInfo.b_CustomerID,HY_BomInfo.b_SPerson,HY_BomInfo.b_SDate,HY_BomDetails.d_PID,HY_BomDetails.d_PName,HY_BomDetails.d_Model,HY_BomDetails.d_Specifications,HY_BomDetails.d_Amount,HY_BomDetails.d_Heat,HY_BomDetails.d_Notes from HY_BomInfo INNER JOIN HY_BomDetails on HY_BomInfo.b_SKID='B-7012010164146'
Update HY_BomDetails set
--BOM物料明细表

create table HY_BomDetails
(
   d_ID int identity(1,1) primary key,
   d_SKID varchar(100) not null, --所属BOM单号
   d_CID varchar(100) not null, --厂内编号
   d_PID varchar(100) not null,--品号
   d_PName varchar(50) not null, --品名
   d_Model varchar(50) not null, --材料型号
   d_Specifications varchar(200) not null, --材料规格 
   d_Amount varchar(10) not null, --数量
   d_Heat varchar(30) not null, --热处理
   d_Notes varchar(200) not null, --备注
   d_SPerson varchar(10)  --设计人

)
--请购信息表
create table HY_RequisitionInfo
(
   r_ID int identity(1,1) primary key,
   r_DID varchar(100) not null, --请购单号
   r_NameID varchar(100) not null, --品号
   r_Department varchar(20) not null, --请购部门
   r_Person varchar(10) not null, --请购人
   r_Name varchar(50) not null, --品名
   r_Supplier varchar(100) not null, --供应商
   r_Origin varchar(100), --型号
   r_QDate datetime not null, --请购时间
   r_XDate datetime not null, --需要时间
   r_Specifications varchar(200) not null, --规格 
   r_Units varchar(2) not null, --单位
   r_Amount int not null, --数量
   r_Uses varchar(200) not null, --用途
   r_Notes varchar(500), --备注
   r_Hot varchar(100 )--热处理
)
use HYMIS 
update HY_RequisitionInfo set r_DID= ,r_NameID=,r_Department=,r_Person=,r_Name=,r_Supplier=,r_Origin=,r_QDate=,r_XDate=,r_Specifications=,r_Units=,r_Amount,r_Uses=,r_Notes,r_Hot=
select r_DID,max(r_ID),max(r_QDate),max(r_Person) from HY_RequisitionInfo group by r_DID
select distinct r_DID,r_State from HY_RequisitionInfo
--BOM单抛请购单
insert into HY_RequisitionInfo(r_DID,r_NameID,r_Name,r_Person,r_Origin,r_Specifications,r_Amount,r_Hot,r_Notes) select REPLACE(d_SKID,'B','QG'),d_PID,d_PName,d_SPerson,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes from HY_BomDetails WHERE d_SKID='B-12122009142724'

insert into HY_RequisitionInfo(r_DID,r_NameID,r_Person,r_Origin,r_Specifications,r_Amount,r_Hot,r_Notes) select REPLACE(d_SKID,'B','QG'),d_PID,d_SPerson,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes from HY_BomDetails WHERE d_SKID='B-12122009142724'

select * from HY_RequisitionInfo

select HY_BomInfo.*,HY_BomDetails.* from HY_BomInfo inner join HY_BomDetails on HY_BomInfo.b_SKID=HY_BomDetails.d_SKID and HY_BomDetails.d_SKID=@d_SKID
select  * from HY_BomInfo where b_ID=5
insert into HY_Supplier(s_gyName,s_jName,s_Area,s_cpName) values('深圳普联科技','TP','深圳','路由器，交换机')
select s_gyName,s_jName,s_Area,s_Name,s_Tel,s_cpName from HY_Supplier

insert into HY_user(h_UserName,h_yUserPwd,h_Status) values('卓越','123456','')

insert into HY_BomDetails(d_SKID,d_CID,d_PID,d_PName,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes,d_SPerson) values(d_SKID,d_CID,d_PID,d_PName,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes,d_SPerson)

delete from HY_Department where d_ID=1

select * from HY_CPClass order by c_ID desc

--产品分类

create table HY_CPClass
(
   c_ID int identity(1,1) primary key,
   c_Class varchar(50) not null -- 产品类别名

)

inser into HY_CPClass(c_Class) values('')
delete from HY_CPClass where c_ID=1
USE HYMIS
--产品入库单
create table HY_Storage
(
   s_ID int identity(1,1) primary key,
   s_DID varchar(100) not null, --单号
   s_CID varchar(100) , --厂内编号
   s_Person varchar(10) not null, --入库人
   s_Class varchar(50) not null,--产品类别（大类）
   s_Warehouse varchar(20) not null, --仓库
   s_XDate datetime , --入库时间
   s_DDate datetime , --到货时间
   s_PID varchar(100) not null, --品号
   s_Pname varchar(100) not null, --品名
   s_Specifications varchar(200) not null, --规格
   s_Amount int not null, --数量
   s_Price int not null, --单价
   s_Notes varchar(200)  --备注
)

---库存数据统计表
Create table HY_StorageStatistics
(
   s_ID int identity(1,1) primary key,
   s_DID varchar(100) not null, --单号
   s_CID varchar(100) , --厂内编号
   s_PID varchar(100) not null, --品号
   s_Class varchar(50) not null,--产品类别（大类）
   s_Amount int not null, --数量
   s_Price int not null, --单价
)

use HYMIS
Update set HY_Storage s_DID='"+ hystormodel.S_DID+"',s_CID='"+hystormodel.S_CID+"',s_Person='" + hystormodel.S_Person + "',s_Class='" + hystormodel.S_Class + "',s_Warehouse='" + hystormodel.S_Warehouse + "',s_XDate='" + hystormodel.S_XDate + "',s_DDate='" + hystormodel.S_DDate + "',s_Pname='" + hystormodel.S_Pname + "',s_Specifications='" + hystormodel.S_Specifications + "',s_Amount='" + hystormodel.S_Amount + "',s_Price='" + hystormodel.S_Price + "',s_Notes,'" + hystormodel.S_Notes + "' where  s_PID='" + hystormodel.S_PID + "'
values(,,,,,)
select sum(s_Price) as PR,sum(s_Amount) as AM from HY_Storage where s_PID='PH-4012010113624'
select s_ID,s_PID,s_Pname,s_Specifications,s_Price,s_Class,s_Warehouse from HY_Storage where s_PID like 'PH%' order by s_ID desc
SELECT * from HY_Storage order by 
--领料单
create table HY_Receiving
(
   r_ID int identity(1,1) primary key,
   r_DID varchar(100) not null, --领料单号
   r_Person varchar(10) not null, --领料人
   r_Class varchar(50) not null,--料件类别（大类）
   r_Warehouse varchar(20) not null, --所在仓库
   r_LDate datetime , --领料日期
   r_PID varchar(100) not null, --物料品号
   r_Pname varchar(100) not null, --品名
   r_Specifications varchar(200) not null, --物料规格
   r_Amount int not null, --领取数量
   r_Price int not null, --物料单价
   r_Notes varchar(200)  --领料备注
)
use HYMIS

update HY_Receiving set r_DID='" + hyreqmodel.R_DID + "',r_Person='" + hyreqmodel.R_Person + "',r_Class='" + hyreqmodel.R_Class + "',r_Warehouse='" + hyreqmodel.R_Warehouse + "',r_LDate='" + hyreqmodel.R_LDate + "',r_Pname='" + hyreqmodel.R_Pname + "',r_Specifications='" + hyreqmodel.R_Specifications + "',r_Amount='" + hyreqmodel.R_Amount + "',r_Price='" + hyreqmodel.R_Price + "',r_Notes='" + hyreqmodel.R_Notes + "' where r_PID='" + hyreqmodel.R_PID + "'
values(,,,,,,,,,,)

insert into HY_Receiving(r_DID,r_Person,r_Class,r_Warehouse,r_LDate,r_PID,r_Pname,r_Specifications,r_Amount,r_Price,r_Notes) values()
select * from HY_Receiving where r_DID='' like '%a%' order by s_ID desc
--产品入库单操作日志
create table HY_StorageLog
(
   s_ID int identity(1,1) primary key,
   s_DID varchar(100) not null, --单号
   s_CID varchar(100) , --厂内编号
   s_Person varchar(10) not null, --入库人
   s_Class varchar(50) not null,--产品类别（大类）
   s_Warehouse varchar(20) not null, --仓库
   s_XDate datetime , --入库时间
   s_DDate datetime , --到货时间
   s_PID varchar(100) not null, --品号
   s_Pname varchar(100) not null, --品名
   s_Specifications varchar(200) not null, --规格
   s_Amount int not null, --数量
   s_Price int not null, --单价
   s_Notes varchar(200)  --备注
)
update HY_StorageLog set s_Amount=s_Amount-1
select * from HY_StorageLog where s_DID='CK-201222009083343'
select s_ID,s_PID,s_Pname,sum(s_Amount) as s_KCAmount from HY_Storage group by s_ID,s_PID,s_Pname having  sum(s_Amount)=1
select s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes from HY_Storage where s_ID=1
insert into HY_Storage(s_DID,s_CID,s_Person,s_Class,s_Warehouse,s_XDate,s_PID,s_Pname,s_Specifications,s_Amount,s_Price,s_Notes) values()
select s_PID,sum(s_Amount) as s_KCAmount,s_Pname from HY_Storage group by s_PID,s_Pname having sum(s_Amount)<40
--生产指令排程表
create table HY_ProductionPlanning
(
   p_ID int identity(1,1) primary key,
   p_DID varchar(100) not null, --销售单号
   p_KID varchar(100) , --客户番号
   p_CID varchar(100) , --厂内编号
   p_Engineering varchar(10) not null, --工程数
   p_Design varchar(10) not null, --设计担当
   p_YKDate datetime , --营业确认开始时间
   p_YWDate datetime , --营业确认完成时间
   p_SKDate datetime , --设计开始时间
   p_SWDate datetime , --设计完成时间
   p_STKDate datetime , --审图开始时间
   p_STWDate datetime , --审图完成时间
   p_CLKDate datetime , --材料要求到货时间
   p_CLWDate datetime , --材料实际到货时间
   p_CNCKDate datetime , --CNC加工开始时间
   p_CNCWDate datetime , --CNC加工完成时间
   p_JJKDate datetime , --机加工开始时间
   p_JJWDate datetime , --机加工完成时间
   p_HKDate datetime , --热处理开始时间
   p_HWDate datetime , --热处理完成时间
   p_MKDate datetime , --磨加工开始时间
   p_MWDate datetime , --磨加工完成时间
   p_XKDate datetime , --线切割开始时间
   p_XWDate datetime , --线切割完成时间
   p_ZLKDate datetime , --组立开始时间
   p_ZLWDate datetime , --组立完成时间
   p_SZKDate datetime , --试作开始时间
   p_SZWDate datetime , --试作完成时间
   p_XJWDate datetime , --型检完成时间
   p_OKWDate datetime , --OK样提交完成时间
   p_YDWDate datetime  --模具移交完成时间

)

insert into HY_ProductionPlanning(p_DID,p_KID,p_CID,p_Engineering,p_Design) values('','','','','')
select * from HY_ProductionPlanning where p_DID='1111111111111'
update HY_ProductionPlanning set p_YKDate='',p_YWDate='' where p_DID=''

--客户信息表
create table HY_CustomerInfo
(
   c_ID int identity(1,1) primary key,
   c_Name varchar(100) not null, --客户名称
   c_FID varchar(100) not null --客户番号
)
use HYMIS
select * from HY_CustomerInfo order by c_ID desc
insert into HY_CustomerInfo(c_Name,c_FID) values('','')
delete from HY_CustomerInfo where c_ID=''
update HY_CustomerInfo set c_Name='cvcvc',c_FID='ddd' where c_ID='3'

--客户订单信息表
create table HY_CustomerOrder
(
   o_ID int identity(1,1) primary key,
   o_DID varchar(100) not null,--销售单号
   o_Name varchar(100) not null, --客户名称
   o_FID varchar(100) not null, --客户番号
   o_CPName varchar(100) not null, --产品名称
   o_Person varchar(10) not null, --录单人
   o_RDate datetime , --录单时间
   o_Notes varchar(300) --备注   
)
select o_ID,o_DID, from HY_CustomerOrder order by o_ID desc
insert into HY_CustomerOrder(o_Name,o_FID,o_CPName,o_Person,o_RDate,o_Notes) values('','','','','','')

select h_ID,h_UserName,h_yUserPwd,h_Permissions,h_Status,h_Department from HY_user

update HY_user set h_Department='CNC' where h_ID='5'