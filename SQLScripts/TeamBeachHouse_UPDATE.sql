-- Calculate numCheckins
UPDATE Business
SET numCheckins = (SELECT COUNT(business_id) FROM Checkins WHERE Checkins.business_id = Business.business_id)
WHERE Business.business_id IN (SELECT Checkins.business_id FROM Checkins);

-- Calculate numTips
UPDATE Business
SET numTips = (SELECT COUNT(business_id) FROM Tip WHERE Tip.business_id = Business.business_id)
WHERE Business.business_id IN (SELECT Tip.business_id FROM Tip);

-- Calculate totalLikes
UPDATE Users
SET totalLikes = (SELECT SUM(likes) FROM Tip WHERE Tip.user_id = Users.user_id)
WHERE Users.user_id IN (SELECT Tip.user_id FROM Tip);

-- Calculate tipCount
UPDATE Users
SET tipCount = (SELECT COUNT(user_id) FROM Tip WHERE Tip.user_id = Users.user_id)
WHERE Users.user_id IN (SELECT Tip.user_id FROM Tip);