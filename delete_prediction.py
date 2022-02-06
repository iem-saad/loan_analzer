import pandas as pd

if __name__ == '__main__':
    test_loan_data = pd.read_csv("test.csv")
    test_loan_data['LoanAmount'] = ''
    test_loan_data.to_csv('test.csv', index=False)