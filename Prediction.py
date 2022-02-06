import matplotlib.pyplot as mt
import matplotlib as matplot
import numpy as np
import pandas as pd
import scipy as sp
import seaborn as sb
import sklearn.linear_model as skl
# from sklearn.linear_model import LinearRegression
import sklearn.neighbors
import sklearn.neighbors
import sklearn.tree
import sklearn.utils
import sklearn.utils._typedefs
import sklearn.utils._weight_vector
import sklearn.neighbors._partition_nodes
import sklearn.neighbors._quad_tree
import sklearn.tree._utils

matplot.use('TkAgg')
if __name__ == '__main__':
    loan_data = pd.read_csv("train.csv")
    test_loan_data = pd.read_csv("test.csv")
    loan_data.dropna(inplace=True)
    applicantIncome = loan_data['ApplicantIncome']
    loanAmount = loan_data['LoanAmount']
    arr1 = np.array(applicantIncome).reshape((-1, 1))
    arr2 = np.array(loanAmount)
    mt.scatter(arr1, arr2)
    reg = skl.LinearRegression().fit(arr1, arr2)
    r_sq = reg.score(arr1, arr2)

    testapplicantIncome = test_loan_data['ApplicantIncome']
    test_std_data = np.array(testapplicantIncome).reshape((-1, 1))
    test_loan_res = reg.predict(test_std_data)
    test_loan_data['LoanAmount'] = test_loan_res
    test_loan_data.to_csv('test.csv', index=False)

    # formula for prediction
    # pre = reg.intercept_ + reg.coef_*xy

    values = [reg.coef_ * i + reg.intercept_ for i in arr1]
    mt.title('Sactter Graph to Study the Relation of Correlated Attributes')
    mt.ylabel('Loan Amount')
    mt.xlabel('Income Amount')
    mt.plot(arr1,values, 'b')
    mt.show(block=True)

