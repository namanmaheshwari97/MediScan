from twilio.rest import TwilioRestClient
import reverse_geocoder as rg

def parseCoordinates(recvCoordinates):
    coordinatesList = recvCoordinates.split(",")
    lattitude = float(coordinatesList[0])
    longitude = float(coordinatesList[1])
    finalCoordinates = (lattitude,longitude)
    getLocation(finalCoordinates,recvCoordinates)

def getLocation(finalCoordinates,recvCoordinates):
    resultsDict = rg.search(finalCoordinates)
    resultsList = resultsDict[0]
    finalLocation = resultsList['name']+" "+resultsList['admin2']+" "+resultsList['admin1']+" "+resultsList['cc']
    sendMessage(finalLocation,recvCoordinates)

def sendMessage(finalLocation,recvCoordinates):
    contacts =["+919560265684", "+918860594765","+919790722563","+917358344371"]
    account_sid = "ACb921538e09be9fc6fa5bf292081cf889"
    auth_token = "7355f88e6809fa97fa3622503dd65e5a"

parseCoordinates("12.8290481,80.0479037")


