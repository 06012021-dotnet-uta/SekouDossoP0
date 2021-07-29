/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.

Given the CITY and COUNTRY tables, query the names of all cities where the CONTINENT is 'Africa'.

Note: CITY.CountryCode and COUNTRY.Code are matching key columns.
*/

select CITY.name
from CITY, COUNTRY
where CITY.CountryCode = COUNTRY.Code
      and COUNTRY.continent = 'Africa';