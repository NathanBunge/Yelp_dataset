-- a. Whenever a user provides a tip for a business, the “numTips” value for that business 
--    and the “tipCount” value for the user should be updated. 

CREATE FUNCTION updateTipCount() RETURNS trigger AS '
    BEGIN
        UPDATE Business
        SET numTips = numTips + 1
        WHERE Business.business_id = NEW.business_id;

        UPDATE Users
        SET tipCount = tipCount + 1
        WHERE Users.user_id = NEW.user_id;

        RETURN NEW;
    END;
' LANGUAGE plpgsql;

CREATE TRIGGER newTip
    AFTER INSERT ON Tip
    FOR EACH ROW
    EXECUTE FUNCTION updateTipCount();

/*      Test     */

-- make note of the tipCount value
SELECT tipCount FROM Users WHERE user_id='we_ONmXR0wP5-Ejx9AbIAA';

INSERT INTO Tip VALUES ('2022-04-21 14:33:46', 'we_ONmXR0wP5-Ejx9AbIAA', 'enzgrlkltK3PO-KGg1pkSQ', 'The hot dogs are lit! 🔥🔥🔥', 112);
SELECT tipCount FROM Users WHERE user_id='we_ONmXR0wP5-Ejx9AbIAA';
SELECT numTips FROM Business WHERE business_id='enzgrlkltK3PO-KGg1pkSQ';
-- cleanup test
DELETE FROM Tip WHERE business_id='enzgrlkltK3PO-KGg1pkSQ' AND user_id='we_ONmXR0wP5-Ejx9AbIAA' AND tipText='The hot dogs are lit! 🔥🔥🔥';
DROP TRIGGER newTip on Tip CASCADE;
DROP FUNCTION updateTipCount;


-- b. Similarly, when a customer checks-in a business, the “numCheckins” attribute value for that business should be updated.  
CREATE FUNCTION updateCheckins() RETURNS trigger AS '
    BEGIN
        UPDATE Business
        SET numCheckins = numCheckins + 1
        WHERE Business.business_id = NEW.business_id;

        RETURN NEW;
    END;
' LANGUAGE plpgsql;

CREATE TRIGGER newCheckin
    AFTER INSERT ON Checkins
    FOR EACH ROW
    EXECUTE FUNCTION updateCheckins();

/*      Test     */

-- make note of the numCheckins value
SELECT numCheckins FROM Business WHERE business_id='0AUdqRDyqxOB8TZ8HFettg';

INSERT INTO Checkins VALUES ('0AUdqRDyqxOB8TZ8HFettg', 2022, 12, 25, '01:50:10');
SELECT numCheckins FROM Business WHERE business_id='0AUdqRDyqxOB8TZ8HFettg';
-- cleanup test
DELETE FROM Checkins WHERE business_id='0AUdqRDyqxOB8TZ8HFettg' AND checkin_year=2022 AND checkin_month=12 AND checkin_day=25 AND checkin_time='01:50:10';
DROP TRIGGER newCheckin on Checkins CASCADE;
DROP FUNCTION updateCheckins;


-- c. When a user likes a tip, the “totalLikes” attribute value for the user who wrote that tip should be updated. 
CREATE FUNCTION updateTotalLikes() RETURNS trigger AS '
    BEGIN
        UPDATE Users
        SET totalLikes = totalLikes + NEW.likes
        WHERE Users.user_id = NEW.user_id;

        RETURN NEW;
    END;
' LANGUAGE plpgsql;

CREATE TRIGGER newLike
    AFTER UPDATE OF likes ON Tip
    FOR EACH ROW
    EXECUTE FUNCTION updateTotalLikes();

/*      Test     */

-- make note of the totalLikes value
SELECT totalLikes FROM Users WHERE user_id='we_ONmXR0wP5-Ejx9AbIAA';

UPDATE Tip
SET likes = 3
WHERE user_id='we_ONmXR0wP5-Ejx9AbIAA' AND tipText='Great zoo! Go early!!';

SELECT totalLikes FROM Users WHERE user_id='we_ONmXR0wP5-Ejx9AbIAA';
-- cleanup test
DROP TRIGGER newLike on Tip CASCADE;
DROP FUNCTION updateTotalLikes;