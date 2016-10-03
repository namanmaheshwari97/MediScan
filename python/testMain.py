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
        print "SOS Activated"
        sm.parseCoordinates(parsedString[1])
        break

    elif parsedString[0] == "home remedies":
        print "Home remedies activated"
        toSendHomeRemedies = hr.getHomeRemedies(parsedString[1])
        print toSendHomeRemedies

    elif parsedString[0] == "check":
        print "Check activated"
        toSendCheck = re.parseString(parsedString[1]+";"+parsedString[2])
        print toSendCheck

    elif parsedString[0] == "our suggestions":
        print "Oursuggestions activated"
        toSendMedicines = oursug.suggest(parsedString[1])
        print toSendMedicines


    elif parsedString[0] == "exit":
        print "Exiting"
        break
