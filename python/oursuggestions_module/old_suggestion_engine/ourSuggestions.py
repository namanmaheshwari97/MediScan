import pandas as pd
def suggest(recvAilment):
	data=pd.read_csv("oursuggestions_module/suggested_medicines_database.txt",delim_whitespace="",header=None)
	ailment=data[0]
	firstMedicine=data[1]
	secondMedicine=data[2]
	for i in range(len(ailment)):
		if(recvAilment==ailment[i]):
			finalMedicineString = firstMedicine[i]+";"+secondMedicine[i]
			return finalMedicineString


