import pandas as pd
def recon(Ailment_name,medicine):
	data=pd.read_csv("medicines1.txt",delim_whitespace="",header=None)
	ailment=data[0]
	med=data[1]
	for i in range(len(ailment)):
		if(Ailment_name==ailment[i]):
			if(medicine==med[i]):
				return "1"
	
	return "0"



