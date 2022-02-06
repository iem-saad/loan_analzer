import matplotlib.pyplot as mt
import matplotlib as matplot
import numpy as np
import pandas as pd



matplot.use('TkAgg')
if __name__ == '__main__':
    #plot a graph for average income according to area
    loan_data = pd.read_csv("train.csv")
    loan_data.dropna(inplace=True)
    applicantIncome = loan_data['ApplicantIncome']
    loanAmount = loan_data['LoanAmount']
    areaIncomeMean = loan_data.groupby('Property_Area').ApplicantIncome.mean()
    areaIncomeMedian = loan_data.groupby('Property_Area').ApplicantIncome.median()
    areaLoanMean = loan_data.groupby('Property_Area').LoanAmount.mean()
    areaLoanMedian = loan_data.groupby('Property_Area').LoanAmount.median()
    areas = ['Rural', 'Sami urban', 'Urban']
    # multiple bar chart for Applicant income mean and median to check variantion.
    x = np.arange(len(areas))  # the label locations
    width = 0.35  # the width of the bars
    fig, ax = mt.subplots()
    rects1 = ax.bar(x - width / 2, areaIncomeMean, width, label='Mean')
    rects2 = ax.bar(x + width / 2, areaIncomeMedian, width, label='Median')
    ax.set_ylabel('Income')
    ax.set_title('Area Income Mean and Median(Mean Affected By Outliers)')
    ax.set_xticks(x, areas)
    ax.legend()
    ax.bar_label(rects1, padding=2)
    ax.bar_label(rects2, padding=2)
    fig.tight_layout()

    # multiple bar chart for Applicant loan mean and median to check variantion.
    x = np.arange(len(areas))  # the label locations
    width = 0.35  # the width of the bars
    fig, ax = mt.subplots()
    rects1 = ax.bar(x - width / 2, areaLoanMean, width, label='Mean')
    rects2 = ax.bar(x + width / 2, areaLoanMedian, width, label='Median')
    ax.set_ylabel('Loan')
    ax.set_title('Area Loan Mean and Median(less outliers as compared to income)')
    ax.set_xticks(x, areas)
    ax.legend()
    ax.bar_label(rects1, padding=2)
    ax.bar_label(rects2, padding=2)
    fig.tight_layout()
    mt.show(block=True)