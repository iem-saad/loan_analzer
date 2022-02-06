import matplotlib.pyplot as mt
import matplotlib as matplot
import numpy as np
import pandas as pd



matplot.use('TkAgg')
if __name__ == '__main__':
    #plot a graph for average income of man and womens
    loan_data = pd.read_csv("train.csv")
    loan_data.dropna(inplace=True)
    # plot a graph for average income according to area
    loan_data = pd.read_csv("train.csv")
    loan_data.dropna(inplace=True)
    applicantIncome = loan_data['ApplicantIncome']
    loanAmount = loan_data['LoanAmount']
    genderIncomeMean = loan_data.groupby('Gender').ApplicantIncome.mean()
    genderIncomeMedian = loan_data.groupby('Gender').ApplicantIncome.median()
    genderLoanMean = loan_data.groupby('Gender').LoanAmount.mean()
    genderLoanMedian = loan_data.groupby('Gender').LoanAmount.median()
    genders = ['Male', 'Female']
    # multiple bar chart for Applicant income mean and median to check variantion.
    x = np.arange(len(genders))  # the label locations
    width = 0.35  # the width of the bars
    fig, ax = mt.subplots()
    rects1 = ax.bar(x - width / 2, genderIncomeMean, width, label='Mean')
    rects2 = ax.bar(x + width / 2, genderIncomeMedian, width, label='Median')
    ax.set_ylabel('Income')
    ax.set_title('Gender Income Mean and Median(Mean Affected By Outliers)')
    ax.set_xticks(x, genders)
    ax.legend()
    ax.bar_label(rects1, padding=2)
    ax.bar_label(rects2, padding=2)
    fig.tight_layout()

    # multiple bar chart for Applicant loan mean and median to check variantion.
    x = np.arange(len(genders))  # the label locations
    width = 0.35  # the width of the bars
    fig, ax = mt.subplots()
    rects1 = ax.bar(x - width / 2, genderLoanMean, width, label='Mean')
    rects2 = ax.bar(x + width / 2, genderLoanMedian, width, label='Median')
    ax.set_ylabel('Loan')
    ax.set_title('Gender Loan Mean and Median(less outliers as compared to income)')
    ax.set_xticks(x, genders)
    ax.legend()
    ax.bar_label(rects1, padding=2)
    ax.bar_label(rects2, padding=2)
    fig.tight_layout()
    mt.show(block=True)

