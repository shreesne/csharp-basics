SELECT 
    CapitalCity.Name AS CapitalCityName
FROM
    City AS CapitalCity
JOIN
    Country AS CapitalCountry ON CapitalCity.CountryCode = CapitalCountry.Code
JOIN
    Country AS YarenCountry ON YarenCountry.Region = CapitalCountry.Region
JOIN
    City AS YarenCity ON YarenCity.CountryCode = YarenCountry.Code
WHERE
    YarenCity.Name = 'Yaren';
  
