/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
Given the CITY and COUNTRY tables, query the names of all the continents (COUNTRY.Continent) and their respective average city populations (CITY.Population) rounded down to the nearest integer.
Note: CITY.CountryCode and COUNTRY.Code are matching key columns.
*/
select COUNTRY.Continent, avg(CITY.Population)
from COUNTRY
join CITY
    on CITY.CountryCode = COUNTRY.Code
group by COUNTRY.Continent;