/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.

Query the average population for all cities in CITY, rounded down to the nearest integer.
*/

select avg(population) from city;
SELECT FLOOR(AVG(population)) FROM city;