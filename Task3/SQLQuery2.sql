ALTER PROCEDURE [dbo].[spInsertFlat]
    @city NVARCHAR(30),
    @address NVARCHAR (30),
    @price FLOAT(53), 
    @numOfRooms SMALLINT

AS
BEGIN
    insert into FlatsTable (city,[address],price,numOfRooms) values (@city,@address,@price,@numOfRooms)
END
