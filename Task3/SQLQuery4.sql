CREATE PROCEDURE spReadFlats
AS
BEGIN

    SELECT [id], [address],[city], [price], [numOfRooms]
    FROM FlatsTable;
END;