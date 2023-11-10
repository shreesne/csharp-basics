SELECT
    City.Name AS CityName
FROM
    City
WHERE
    City.CountryCode = (
        SELECT
            CountryCode
        FROM
            City
        WHERE
            Population = 122199
    )
    AND
    City.Population != 122199;

