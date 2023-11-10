SELECT countrycode, COUNT(*) AS city_count
FROM city
WHERE countrycode IN ('MOZ', 'VNM')
GROUP BY countrycode;