from twilio.rest import TwilioRestClient
import reverse_geocoder as rg

def parseCoordinates(recvCoordinates):
    coordinatesList = recvCoordinates.split(",")
    lattitude = float(coordinatesList[0])
    longitude = float(coordinatesList[1])
    finalCoordinates = (lattitude,longitude)
    print "Split Coordinates"
    getLocation(finalCoordinates,recvCoordinates)


def getLocation(finalCoordinates,recvCoordinates):
    resultsDict = rg.search(finalCoordinates)
    resultsList = resultsDict[0]
    finalLocation = resultsList['name']+" "+resultsList['admin2']+" "+resultsList['admin1']+" "+resultsList['cc']
    print "Got location"
    sendMessage(finalLocation,recvCoordinates)

def sendMessage(finalLocation,recvCoordinates):
    contacts =["+919560265684", "+918860594765","+919790722563","+917358344371"]
    account_sid = "ACb921538e09be9fc6fa5bf292081cf889"
    auth_token = "7355f88e6809fa97fa3622503dd65e5a"
    client=TwilioRestClient(account_sid, auth_token)
    for nums in contacts:
        print "Sending to "+nums
        message = client.messages.create(to=nums, from_="+15103442597",body="Your friend is in an emergency!!\nName - Arpit Joshi\nLocation - "+finalLocation)
        message = client.messages.create(to=nums, from_="+15103442597",body="http://www.google.com/maps/place/"+recvCoordinates)
    print "Sent messages"


