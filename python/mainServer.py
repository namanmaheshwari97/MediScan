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
port = 8092
s.bind((host,port))

s.listen(5)
print "Listening"
while True:
    c,addr = s.accept()
    print "Connected"
    print c.recv(1024)
    print "Sent"
    #c.send("Got it bro")
    c.close()
    break
print "exiting"

