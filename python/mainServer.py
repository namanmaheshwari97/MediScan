
import sys
import socket
sys.path.insert(0,'sos_module/')
sys.path.insert(0,'homeRemedies_module/')
sys.path.insert(0,'oursuggestions_module/')
sys.path.insert(0,'recommender_module/')

import sosmessage as sm
import homeRemedies as hr
import adv_suggestion as advsug
import recommendationEngine as re




s = socket.socket()
host = "10.4.59.49"                         #CHANGE THIS IP ADDRESS TO THE PC'S IP ADDRESS
port = 8151                                 #CHANGE THE PORT TO ANYONE AFTER 8080
s.bind((host,port))
s.listen(5)
print "Listening"



while True:
    print "Loop started"
    c,addr = s.accept()
    print "Connected"
    recvString = c.recv(1024)
    parsedString = recvString.split(";")
    if parsedString[0] == "sos":
        print parsedString[1]
        sm.parseCoordinates(parsedString[1])                            
        c.close()                               
        break
    
    elif parsedString[0] == "home remedies":
        print "home remedies called"
        ailment = parsedString[1]
        ailment = ailment[:-1]
        toSendHomeRemedies = hr.getHomeRemedies(ailment)
        toSendHomeRemedies = toSendHomeRemedies + "\n"
        c.send(toSendHomeRemedies)
    
    elif parsedString[0] == "check":
        print parsedString[1]+" "+parsedString[2]
        toSendCheck = re.parseString(parsedString[1]+";"+parsedString[2])
        toSendCheck = toSendCheck + "\n"
        print toSendCheck
        c.send(toSendCheck)
    
    elif parsedString[0] == "our suggestions":
       ailment = parsedString[1]
       ailment = ailment[:-1]
       print ailment
       toSendMedicines = oursug.advanceSuggestion(ailment)
       toSendMedicines = toSendMedicines + "\n"
       c.send(toSendMedicines)
    
    elif parsedString[0] == "exit":
        print "Exiting and closing connections"
        c.close()
        break




