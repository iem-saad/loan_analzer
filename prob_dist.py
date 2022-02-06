import matplotlib.pyplot as plt
import matplotlib as matplot
import numpy as np # linear algebra
import pandas as pd # data processing, CSV file I/O (e.g. pd.read_csv).
import seaborn as sns

#used binomial dist
matplot.use('TkAgg')
loan_data = pd.read_csv("./train.csv")
loan_data.dropna(inplace=True)
count_y = loan_data["Loan_Status"].value_counts()[0]
count_n = loan_data["Loan_Status"].value_counts()[1]
size = loan_data["Loan_Status"].count()
prob_of_y = count_y/size
prob_of_n = count_n/size

# Normal Distribution  Graph for Success (Approval Of Loan)
plt.figure()
x=np.random.binomial(n=count_y, p=prob_of_y, size=size)
plt.title("Graph Showing Binomial Dist For Approval Of Loan")
plt.ylabel("Probability")
plt.xlabel("Tries")
sns.distplot(x, hist=True, kde=False)

# Normal Distribution  Graph for Success (Rejection Of Loan)
plt.figure()
x=np.random.binomial(n=count_n, p=prob_of_n, size=size)
plt.title("Graph Showing Binomial Dist For Rejection Of Loan")
plt.ylabel("Probability")
plt.xlabel("Tries")
sns.distplot(x, hist=True, kde=False)

plt.show(block=True)
