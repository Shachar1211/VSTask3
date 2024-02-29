CREATE PROCEDURE spReadVacation
AS
BEGIN

    SELECT [id], [userId],[flatId], [startDate], [endDate]
    FROM VacationsTable;
END;
