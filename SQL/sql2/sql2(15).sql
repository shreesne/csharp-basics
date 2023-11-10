SELECT
    City.Name AS CityName
FROM
    City
where 
 City.CountryCode = (
SELECT CountryCode
        FROM City
        WHERE Population = 122199);
