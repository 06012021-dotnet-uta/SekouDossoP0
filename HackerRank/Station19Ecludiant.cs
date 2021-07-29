// Consider  and  to be two points on a 2D plane where  are the 
// respective minimum and maximum values of Northern Latitude 
// (LAT_N) and  are the respective minimum and maximum values 
// of Western Longitude (LONG_W) in STATION.

select convert(decimal(10,4),
               Sqrt(power((convert(decimal(10,4),max(lat_N))-
                           convert(decimal(10,4),min(lat_N))),2)
                   +power((convert(decimal(10,4),max(long_w))-                                                                convert(decimal(10,4),min(long_w))),2))) 
as eucliedeanDistance 
from station;


SELECT CAST(SQRT(SQUARE(MAX(LAT_N)-(MIN(LAT_N)))+SQUARE(MAX(LONG_W)-(MIN(LONG_W)))) 
            as decimal(20,4)) 
            FROM STATION


select 
ROUND(
    POWER(
        POWER(MAX(LONG_W)-MIN(LONG_W), 2) + 
        POWER(MAX(LAT_N)-MIN(LAT_N), 2)
        , 1/2 )
    , 4)
FROM STATION;
