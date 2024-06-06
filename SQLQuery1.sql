USE [p2651576]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblSupplier_FilterByAddressId]
		@SupplierId = 1

SELECT	@return_value as 'Return Value'

GO
