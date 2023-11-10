SELECT
    City.Name AS CityName,
    CountryLanguage.Language AS SpokenLanguage,
    City.Population AS cityPopulation
FROM
    City

JOIN
    CountryLanguage ON City.CountryCode = CountryLanguage.CountryCode
WHERE
    City.Population BETWEEN 500 AND 600;
