import pandas as pd
def advanceSuggestion(recvAilment):
    data = pd.read_csv("adv_sug.txt",delim_whitespace="",header=None)
    ailment = data[0]
    firstMed = data[1]
    secMed = data[2]
    medoneConsumedCounter = data[3]
    medtwoConsumedCounter = data[4]
    for i in range(len(ailment)):
        if recvAilment == ailment[i]:
            if medoneConsumedCounter[i]>medtwoConsumedCounter[i]:
                finalMedicineString = firstMed[i]+";"+secMed[i]
            else:
                finalMedicineString = secMed[i]+";"+firstMed[i]
            return finalMedicineString


