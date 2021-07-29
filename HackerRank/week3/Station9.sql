-- Query the list of CITY names starting with vowels (i.e., a, e, i, o, or u) 
-- from STATION. Your result cannot contain duplicates.
select distinct city 
from STATION 
where city like '[aeiuo]%';

-- Query the list of CITY names from STATION that do 
-- not start with vowels. Your result cannot contain duplicates.
select distinct City
from STATION
-- where City not like '[^aeiou]%';
where City like '[QWRTPSDFGHJKLZXCVBNMY]%' ;

-- Query the list of CITY names from STATION that do not 
-- end with vowels. Your result cannot contain duplicates.
select distinct city 
from STATION
where city like '%[^aeiuo]';

-- Query the list of CITY names from STATION that do not start 
-- with vowels and do not end with vowels. Your result cannot 
-- contain duplicates.
select distinct city 
from STATION
where city like '[^aeuio]%' and city like '%[^aeuoi]';

