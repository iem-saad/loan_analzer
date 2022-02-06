import matplotlib.pyplot as mt
import matplotlib as matplot
import numpy as np
import pandas as pd

#plot a histogram
loan_data = pd.read_csv("train.csv")
matplot.use('TkAgg')
loan_data.dropna(inplace=True)
mt.figure()
mt.title('Histogram Showing Frequency of Applicant Income')
mt.xlabel('Applicant Income')
mt.ylabel('Frequency')
applicantIncome = loan_data['ApplicantIncome']
mt.hist(applicantIncome, bins=50)
# box wisker plot showing outliers in data.
mt.figure()
mt.title('Wisker Plot Showing Outliers in Applicant Income')
loan_data.boxplot(column = 'ApplicantIncome')

mt.show(block=True)

