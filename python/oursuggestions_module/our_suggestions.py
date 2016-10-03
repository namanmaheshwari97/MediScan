import pandas as pd
def suggest(Ailment_name):
	data=pd.read_csv("suggested_medicines.txt",delim_whitespace="",header=None)
	ailment=data[0]
	med1=data[1]
	med2=data[2]
	for i in range(len(ailment)):
		if(Ailment_name==ailment[i]):
			meds = med1[i]+";"+med2[i]
			return  meds


