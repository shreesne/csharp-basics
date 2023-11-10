SELECT
    CountryCode,
    AVG(Population) AS AveragePopulation
FROM
    City
WHERE
    CountryCode IN ('MOZ', 'VNM')
GROUP BY
    CountryCode;
