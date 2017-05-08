CREATE PROCEDURE [dbo].[InSeriesReprint1] 

(
@PartTypeID int,
@RotationNbrStart varchar(4) =NULL,
@RotationNbrEnd varchar(4) =NULL,
@RackNbr varchar(3) =NULL,
@RackID varchar(10) =NULL
)
AS

SET NOCOUNT ON;

Select
	IP.PartTypeID,
	IP.SlotNbr, 
	IP.RotationNbr,
	IP.RackNbr, 
	IP.RackID,
	IP.LabelPrinted, 
	IP.PrintDate, 
	IP.VerifyDate
FROM
	tblincomingparts IP
WHERE
	(IP.PartTypeID = @PartTypeID) and
	(IP.PartTypeID >= 12) and
	(IP.RotationNbr >= @RotationNbrStart) and 
	(IP.RotationNbr <= @RotationNbrEnd) and
	(IP.RackNbr = @RackNbr) AND
	(IP.RackID = @RackID) AND
	(IP.RotationNbr != 'SHOP') AND 
	(IP.RotationNbr != '0000') And 
	(IP.PrintDate >= DATEADD(dd, DATEDIFF(dd, 0, GETDATE()), 0)) AND 
	(IP.PrintDate < DATEADD(dd, DATEDIFF(dd, 0, GETDATE()) + 2, 0))

ORDER BY
	RotationNbr ASC