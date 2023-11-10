SELECT
    City.Name AS CityName
FROM
    City
JOIN
    Country ON City.CountryCode = Country.Code
WHERE
    Country.Capital = 'Luanda';