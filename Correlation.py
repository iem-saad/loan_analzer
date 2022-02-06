import matplotlib.pyplot as mt
import matplotlib as matplot
import numpy as np
import pandas as pd
import scipy as sp
import seaborn as sb
from sklearn.linear_model import LinearRegression



matplot.use('TkAgg')
if __name__ == '__main__':
    loan_data = pd.read_csv("train.csv")
    loan_data.dropna(inplace=True)

    # Triangular heat map for correlation
    matrix = loan_data.corr()
    mt.figure()
    mt.title('Triangular Heatmap Showing Correlation')
    mask = np.triu(np.ones_like(matrix.corr(), dtype=bool))
    cmap = sb.diverging_palette(230, 20, as_cmap=True)
    sb.heatmap(matrix, vmax=1.0, mask=mask, cmap=cmap, square=True, annot=True)

    # heat map for finding correlation
    matrix = loan_data.corr()
    mt.figure()
    mt.title('Heatmap Showing Correlation')
    cmap = sb.diverging_palette(230, 20, as_cmap=True)
    sb.heatmap(matrix, vmax=1.0, cmap=cmap, square=True, annot=True)

    mt.show(block=True)

    # corss-checking coorelation of applicant income and loan amount
    applicantIncome = loan_data['ApplicantIncome']
    loanAmount = loan_data['LoanAmount']
    arr1 = np.array(applicantIncome).reshape((-1, 1))
    arr2 = np.array(loanAmount)
    cor = np.corrcoef(applicantIncome, loanAmount)
    print(cor[0, 1])