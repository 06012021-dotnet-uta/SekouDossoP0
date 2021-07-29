/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
Query the Western Longitude (LONG_W)where the smallest Northern Latitude (LAT_N) in STATION is greater than 38.7780. Round your answer to 4 decimal places.
*/


select top 1 CAST(LONG_W as DECIMAL(10,4))
from station
where LAT_N > 38.7780
order by LAT_N;