from sklearn.preprocessing import StandardScaler
import matplotlib.pyplot as plt
import matplotlib as matplot
import numpy as np # linear algebra
import pandas as pd # data processing, CSV file I/O (e.g. pd.read_csv).
import seaborn as sns
from tkinter import *


loan_data = pd.read_csv("./train.csv")

matplot.use('TkAgg')
# simple bar chart showing how many men and women are in dataset
plt.figure()
plt.title('Gender Count Pie Chart')
plt.xlabel('Pie Chart Showing how many men and women are in dataset')
loan_data['Gender'].value_counts().plot(kind="pie")

# # simple bar chart for loan.
plt.figure()
plt.title('Loan Status Bar Plot')
plt.xlabel('Y represent People who got loan and N for who didnot. (No Gender Separation)')
plt.ylabel('Loan Status Count')
loan_data['Loan_Status'].value_counts().plot.bar(color=['green', 'red'], edgecolor='blue')

# multiple bar chart between gender and loan.
plt.figure()
GenderAndLoan = pd.crosstab(loan_data['Gender'], loan_data['Loan_Status'])
GenderAndLoan.index.name = "Multiple Bar Chart Showing out of dataset how many men and women got loan."
GenderAndLoan.plot(kind="bar")
plt.show(block=True)
