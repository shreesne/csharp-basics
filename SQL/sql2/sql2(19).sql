SELECT DISTINCT
    CountryLanguage.Language AS SpokenLanguage
FROM
    City
JOIN
    Country ON City.CountryCode = Country.Code
JOIN
    CountryLanguage ON Country.Code = CountryLanguage.CountryCode
WHERE
    City.Name = 'Riga';

