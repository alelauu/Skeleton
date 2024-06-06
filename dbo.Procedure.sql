CREATE PROCEDURE sproc_tblSupplier_FilterByAddressId
	--parameter to store the supplier id we are looking for
	@SupplierId int
AS
    -- select all fields from the table where the supplier id matches the parameter data
	SELECT * FROM tblSupplier WHERE SupplierId = @SupplierId

RETURN 0
