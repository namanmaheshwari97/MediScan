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
port = 8101
s.bind((host,port))

s.listen(5)
print "Listening"
while True:
    c,addr = s.accept()
    recvString = c.recv(1024)
    parsedString = recvString.split(";")
    if parsedString[0] == "sos":
        sm.parseCoordinates(parsedString[1])  
        c.close()                               
        break
    
    elif parsedString[0] == "home remedies":
        toSendHomeRemedies = getHomeRemedies(parsedString[1])
        c.send(toSendHomeRemedies)              
    
    elif parsedString[0] == "check":
        toSendCheck = re.parseString(parsedString[0]+";"+parsedString[1])
        c.send(toSendCheck)
    
    elif parsedString[0] == "our suggestions"
       toSendMedicines = oursug.suggest(parsedString[1])
       c.send(toSendMedicines)
    
    elif parsedString[0] == "exit"
        print "Exiting and closing connections"
        c.close()
        break




