import sys
import socket
sys.path.insert(0,'sos_module/')
sys.path.insert(0,'homeRemedies_module/')
sys.path.insert(0,'oursuggestions_module/')
sys.path.insert(0,'recommender_module/')

import sosmessage as sm
import homeRemedies as hr
import ourSuggestions as oursug
import recommendationEngine as re



s = socket.socket()
host = "10.4.59.36"
port = 8137
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
        toSendCheck = re.parseString(parsedString[1]+";"+parsedString[2])
        toSendCheck = toSendCheck + "\n"
        c.send(toSendCheck)
    
    elif parsedString[0] == "our suggestions":
       toSendMedicines = oursug.suggest(parsedString[1])
       c.send(toSendMedicines)
    
    elif parsedString[0] == "exit":
        print "Exiting and closing connections"
        c.close()
        break




