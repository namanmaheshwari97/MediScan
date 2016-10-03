import pandas as pd

def parseString(recvString):
    parsedString = recvString.split(";")
    recvAilment = parsedString[0]
    recvMedicine = parsedString[1]
    return getRecommendation(recvAilment,recvMedicine)

def getRecommendation(recvAilment,recvMedicine):
        data=pd.read_csv("medicines_database.txt",delim_whitespace="",header=None)
	ailment=data[0]
	medicine=data[1]
        for i in range(len(ailment)):
            if recvAilment == ailment[i]:
                if recvMedicine == medicine[i]:
                    return "1"
        return "0"



