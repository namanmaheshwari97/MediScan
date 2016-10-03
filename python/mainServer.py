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
        #CALL SOS FUNCTION
        
        c.close()
        break
    elif parsedString[0] == "home remedies":
        #CALL HOME REMEDIES AND RETURN HR
    elif parsedString[0] == "check":
        #CALL RECOMMENDER MODULE RETURN 1 OR 0
    elif parsedString[0] == "our suggestions"
        #CALL OUR SUGGESTIONS MODULE RETURN STRING OF 2 MEDICINES ; SEPARATED
    elif parsedString[0] == "exit"
        #FINAL EXIT FUNCTION
        print "Exiting and closing connections"
        c.close()
        break




