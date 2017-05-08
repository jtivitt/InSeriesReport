CREATE PROCEDURE [dbo].[InSeriesReprint1] 
--Any information that can be input and searched for using report screen needs a parameter
@PartType int,
@AssemblyLine int,
@RotationNbrStart nvarchar(4),
@RotationNbrEnd nvarchar(4),
@RackNbr int,
@SlotNbr int,
@LabelPrinted datetime,
@PrintDate datetime,
@VerifyDate datetime,
@RackID int

AS
BEGIN
SET NOCOUNT ON;
--Any variables that will be referenced in this function
DECLARE @PartLabel nvarchar(50);

Select *
	--@RotationNbrStart = IP.RotationNbr,
	--@RotationNbrEnd = IP.RotationNbr
	--@RackNbr = IP.RackNbr, 
	--@SlotNbr = IP.SlotNbr, 
	--@LabelPrinted = IP.LabelPrinted, 
	--@PrintDate = IP.PrintDate, 
	--@VerifyDate = IP.VerifyDate, 
	--@RackID = IP.RackID

FROM tblincomingparts IP
WHERE 
	(IP.PartTypeID = @PartType) and
	(IP.RotationNbr >= @RotationNbrStart) and 
	(IP.RotationNbr <= @RotationNbrEnd) and
	(IP.RotationNbr != 'SHOP') AND 
	(IP.RotationNbr != '0000') And 
	(IP.PrintDate >= DATEADD(dd, DATEDIFF(dd, 0, GETDATE()), 0)) AND 
	(IP.PrintDate < DATEADD(dd, DATEDIFF(dd, 0, GETDATE()) + 2, 0))
ORDER BY RotationNbr ASC;


 
Select @PartLabel = PT.PartType
From tblPartType PT
Where PT.PartTypeID = @PartType
print @PartLabel

END