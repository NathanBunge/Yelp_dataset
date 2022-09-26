import json
import psycopg2
import getpass

# NOTE: This script assumes you've already created a database called milestone2 with the tables listed in TeamBeachHouse_RELATIONS_v2.sql

def connectDatabase():
    print("Connecting to Postgres Database. Please enter your login credentials.\nEx: postgres, root")
    username = input("Enter username: ")
    password = getpass.getpass(prompt='Enter password: ')

    # connect to yelpdb database on postgres server using psycopg2
    try:
        conn = psycopg2.connect(f"dbname='milestone2' user={username} host='localhost' password={password}")
    except:
        print('Unable to connect to the database!')
    cur = conn.cursor()

    return conn, cur

def cleanStr4SQL(s):
    return s.replace("'","`").replace("\n"," ")

def procRecurssion(data, outList):
    for a in data:
        if(type(data[a]) == dict):
            procRecurssion(data[a], outList)
        else:
            outList.append((a, data[a])) #Appends a tuple to the outList

def parseBusinessData(conn, cur):
    #read the JSON file
    with open('../YelpDataset/yelp_business.JSON','r') as f:  
        line = f.readline()

        #read each JSON abject and extract data
        while line:
            data = json.loads(line)

            # INSERT TO BUSINESS TABLE
            try:
                cur.execute("INSERT INTO Business (business_id, business_name, business_city, business_state, postal_code, latitude, longitude, business_address, numTips, numCheckins, is_open, stars)" + " VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s, %s, %s)", 
                    (( cleanStr4SQL(data['business_id']),cleanStr4SQL(data["name"]), cleanStr4SQL(data["city"]), cleanStr4SQL(data["state"]), cleanStr4SQL(data["postal_code"]), str(data["latitude"]),
                        str(data["longitude"]), cleanStr4SQL(data["address"]), str(0), str(0), str(data["is_open"]), str(data["stars"])) ))
            except Exception as e:
                print("Insert to business TABLE failed!", e)

            conn.commit() # commit the pending transaction to database

            # process business categories
            categories = data["categories"].split(', ')
            bus_id = data['business_id']
            
            for c in categories:
                try:
                    cur.execute("INSERT INTO Categories (category_name, business_id)" + " VALUES (%s, %s)", (c, bus_id) )              
                except Exception as e:
                    print("Insert to Categories TABLE failed!", e)
                conn.commit()

            attrList = []
            procRecurssion(data["attributes"], attrList)
            for a in attrList:
                try:
                    cur.execute("INSERT INTO Attributes (business_id, attr_name, attribute_value)" + " VALUES (%s, %s, %s)", (bus_id, a[0], a[1]) )              
                except Exception as e:
                    print("Insert to Attributes TABLE failed!", e)
                conn.commit()

            hourList = []
            procRecurssion(data["hours"], hourList)
            for h in hourList:
                temp = h[1].split('-') #Ex. "11:0-20:0" to "11:0" and "20:0"
                time_open = temp[0]
                time_close = temp[1]
                try:
                    cur.execute("INSERT INTO Hours (business_id, dayofweek, hours_close, hours_open)" + " VALUES (%s, %s, %s, %s)", 
                        (bus_id, h[0], time_close, time_open) )              
                except Exception as e:
                    print("Insert to Hours TABLE failed!",e)
                conn.commit()
            
            line = f.readline()
    f.close()
    print("Finished parsing business data!")

def parseUserData(conn, cur):
    with open('../YelpDataset/yelp_user.JSON','r') as f:  
        line = f.readline()
        
        # read each JSON abject and extract data
        while line:
            data = json.loads(line)
            # Fills Users table
            try:
                cur.execute("INSERT INTO Users (user_id, average_stars, cool, funny, useful, yelping_since, name, fans, tipCount, totalLikes)" + " VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s)", 
                    (( cleanStr4SQL(data['user_id']), str(data["average_stars"]), str(data["cool"]),
                    str(data["funny"]), str(data['useful']), str(data["yelping_since"]), cleanStr4SQL(data["name"]), str(data["fans"]), str(0), str(0))) )
            except Exception as e:
                print("Insert to Users TABLE failed!", e)

            conn.commit()


            # Fills has_friends table
            friends = data["friends"]
            user_id = data['user_id']

            for i in friends:
                try:
                    cur.execute("INSERT INTO Has_friends (user_id, friend_id)" + " VALUES (%s, %s)", (user_id, i) )              
                except Exception as e:
                    print("Insert to Has_friends TABLE failed!", e)
                conn.commit()

            line = f.readline()
    f.close()
    print("Finished parsing user data!")

def parseCheckinData(conn, cur):
    with open('../YelpDataset/yelp_checkin.JSON','r') as f:  
        line = f.readline()
        
        #read each JSON abject and extract data
        while line:
            data = json.loads(line)

            for d in data["date"].split(","):
                year = d[:4]
                month = d[5:7] #Offset by 1 because of -
                day = d[8:10]
                time = d[11:19]
                bus_id = data['business_id']
                
                try:
                    cur.execute("INSERT INTO Checkins (business_id, checkin_year, checkin_month, checkin_day, checkin_time)" + " VALUES (%s, %s, %s, %s, %s)", 
                        (str(bus_id), str(year), str(month), str(day), str(time) ))
                except Exception as e:
                    print("Insert to Checkins TABLE failed!", e)
            
            conn.commit() # commit the pending transaction to database
            line = f.readline()
    f.close()
    print("Finished parsing checkin data!")

def parseTipData(conn, cur):
    with open('../YelpDataset/yelp_tip.JSON','r') as f:  
        
        line = f.readline()
        
        while line:
            data = json.loads(line)

            # Fills Tip table
            try:
                cur.execute("INSERT INTO Tip (tipDate, user_id, business_id, tipText, likes)" + " VALUES (%s, %s, %s, %s, %s)", 
                    ( str(data["date"]), str(data["user_id"]), str(data["business_id"]), str(data["text"]), str(data["likes"]) ))
            except Exception as e:
                print("Insert to Tip TABLE failed!", e)

            conn.commit()
            line = f.readline()
    f.close()
    print("Finished parsing tip data!")

if __name__ == "__main__":
    conn, cur = connectDatabase()

    parseBusinessData(conn, cur)
    parseUserData(conn, cur)
    parseCheckinData(conn, cur)
    parseTipData(conn, cur)
    
    cur.close()
    conn.close()
