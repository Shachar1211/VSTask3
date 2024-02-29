CREATE PROCEDURE [dbo].[spInsertVacation]
    @userId VARCHAR (25),
    @flatId SMALLINT, 
    @startDate DATETIME,
    @endDate DATETIME
AS
BEGIN
    insert into VacationsTable (userId,flatId,startDate,endDate) values (@userId,@flatId,@startDate,@endDate)
END