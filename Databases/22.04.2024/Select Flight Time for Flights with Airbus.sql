SELECT FLIGHT_TIME FROM FLIGHTS as f
WHERE f.AIRPLANE = ANY(SELECT CODE FROM AIRPLANES AS a WHERE a.TYPE LIKE 'Airbus%');