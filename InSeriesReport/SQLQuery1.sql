USE [InSeries]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[InSeriesReprint1]
		@RotationNbrEnd = N'7950',
		@RotationNbrStart = N'7927',
		@PartType = 12,
		@AssemblyLine = 3

SELECT	@return_value as 'Return Value'

GO
