SELECT
    City.Name AS CityName,
    CountryLanguage.Language AS SpokenLanguage,
    city.population as citypopulaton
FROM
    City

JOIN
    CountryLanguage ON City.CountryCode = CountryLanguage.CountryCode
WHERE
    City.Population BETWEEN 400 AND 500;
