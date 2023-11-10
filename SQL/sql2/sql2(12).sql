SELECT
    CountryCode,
    COUNT(*) AS CityCount
FROM
    City
GROUP BY
    CountryCode
HAVING
    CityCount > 200
ORDER BY
    CityCount ASC;
