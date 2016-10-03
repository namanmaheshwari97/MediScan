import sys
sys.path.insert(0,'sos_module/')
sys.path.insert(0,'homeRemedies_module/')
sys.path.insert(0,'oursuggestions_module/')
sys.path.insert(0,'recommender_module/')

import sosmessage as sm
import homeRemedies as hr
import ourSuggestions as oursug
import recommendationEngine as re

while True:
    recvString = raw_input("Enter the string :")
    parsedString = recvString.split(";")

    if parsedString[0] == "sos":
        sm.parseCoordinates(parsedString[1])
        break
    elif parsedString[0] == "home remedies":
        toSendHomeRemedies = getHomeRemedies(parsedString[1])
        print toSendHomeRemedies

    elif 
