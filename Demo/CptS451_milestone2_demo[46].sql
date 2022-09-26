

--1.
SELECT COUNT(*) 
FROM  Business;
SELECT COUNT(*) 
FROM  Users;
SELECT COUNT(*) 
FROM  Tip;
SELECT COUNT(*) 
FROM  Has_friends;
SELECT COUNT(*) 
FROM  Checkins;
SELECT COUNT(*) 
FROM  Categories;
SELECT COUNT(*) 
FROM  Attributes;
SELECT COUNT(*) 
FROM  Hours;



--2. Run the following queries on your business table, checkin table and review table. Make sure to change the attribute names based on your schema. 

SELECT postal_code, COUNT(distinct C.category_name)
FROM Business as B, Categories as C
WHERE B.business_id = C.business_id
GROUP BY postal_code
HAVING count(distinct C.category_name)>300
ORDER BY postal_code;

SELECT postal_code, COUNT(distinct A.attr_name)
FROM Business as B, Attributes as A
WHERE B.business_id = A.business_id
AND attribute_value <> 'False'
GROUP BY postal_code
HAVING count(distinct A.attr_name) = 30;


SELECT Users.user_id, count(friend_id)
FROM Users, Has_friends
WHERE Users.user_id = Has_friends.user_id AND 
      Users.user_id = 'NxtYkOpXHSy7LWRKJf3z0w'
GROUP BY Users.user_id;


--3. Run the following queries on your business table, checkin table and tips table. Make sure to change the attribute names based on your schema. 


SELECT business_id, business_name, business_city, numTips, numCheckins
FROM Business 
WHERE business_id ='K8M3OeFCcAnxuxtTc0BQrQ';

SELECT user_id, name, tipCount, totalLikes
FROM Users
WHERE user_id = 'NxtYkOpXHSy7LWRKJf3z0w';

-----------

SELECT COUNT(*) 
FROM Checkins
WHERE business_id ='K8M3OeFCcAnxuxtTc0BQrQ';

SELECT count(*)
FROM Tip
WHERE  business_id = 'K8M3OeFCcAnxuxtTc0BQrQ';


--4. 
--Type the following statements. Make sure to change the attribute names based on your schema. 

SELECT business_id, business_name, business_city, numCheckins, numTips
FROM Business
WHERE business_id ='hDD6-yk1yuuRIvfdtHsISg';

-- GO BACK
INSERT INTO Checkins (business_id, checkindate)
VALUES ('hDD6-yk1yuuRIvfdtHsISg','2022-03-31 10:45:07');


--5.
--Type the following statements. Make sure to change the attribute names based on your schema.  

-- same as the above query in part4
SELECT business_id, business_name, business_city, numCheckins, numTips
FROM Business 
WHERE business_id ='hDD6-yk1yuuRIvfdtHsISg';

SELECT user_id, name, tipCount, totalLikes
FROM Users
WHERE user_id = '3z1EttCePzDn9OZbudD5VA';


INSERT INTO Tip (user_id, business_id, tipDate, tipText,likes)  
VALUES ('3z1EttCePzDn9OZbudD5VA','hDD6-yk1yuuRIvfdtHsISg', '2022-03-31 13:00','EVERYTHING IS AWESOME',0);

UPDATE Tip 
SET likes = likes+1
WHERE user_id = '3z1EttCePzDn9OZbudD5VA' AND 
      business_id = 'hDD6-yk1yuuRIvfdtHsISg' AND 
      tipDate ='2022-03-31 13:00';

      