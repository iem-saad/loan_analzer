import pandas as pd # data processing, CSV file I/O (e.g. pd.read_csv).
import tkinter as tk
from pandastable import Table

loan_data = pd.read_csv("./train.csv")

class SummarStat(tk.Frame):
    def __init__(self, parent=None):
        self.parent = parent
        tk.Frame.__init__(self)
        self.main = self.master
        self.main.geometry('800x600+200+100')
        self.main.title('Summary Statistics.')
        f = tk.Frame(self.main)
        f.pack(fill=tk.BOTH,expand=1)
        df = pd.DataFrame(loan_data).describe(include='all')
        new_col= ['Occurances', 'Unique', 'Top', 'Frequency','Mean', 'Std Dev','Min Val' ,'25% Of Data', '50% Of Data', '75% Of Data', 'Max Val']
        df.insert(loc=0, column='Attribute', value=new_col)
        self.table = pt = Table(f, dataframe=df,
                                showtoolbar=True, showstatusbar=True)
        pt.show()
        return
summary = SummarStat()
summary.mainloop()
