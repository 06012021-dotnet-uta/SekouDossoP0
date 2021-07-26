select distinct City
from STATION
-- where City not like '[aeiou]%';
where City like '[QWRTPSDFGHJKLZXCVBNMY]%' ;