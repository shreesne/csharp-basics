SELECT
    Name AS CityName,
    Population
FROM
    City
WHERE
    Population < 200 OR Population > 9500000;

