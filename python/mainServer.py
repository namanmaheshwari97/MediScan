
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
port = 8081
s.bind((host,port))

s.listen(5)
s.settimeout(300.0)

while True:
    c,addr = s.accept()
    print "Connected"
    c.send("Got it bro")
    c.close()
    break

