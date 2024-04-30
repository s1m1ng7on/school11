SELECT DISTINCT AGENCY, BOOKING_DATE FROM BOOKINGS AS b
WHERE BOOKING_DATE <= ALL(SELECT BOOKING_DATE FROM BOOKINGS WHERE AGENCY = b.AGENCY);