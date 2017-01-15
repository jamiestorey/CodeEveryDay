from tkinter import *

from tkinter import messagebox

import time

TOP = Tk()
TOP.geometry("500x500")

x = 1


def helloCallBack():
    msg = messagebox.showinfo("Hello Python", "Hello World")
    coord = 5, 11, 110, 400
    for i in range(0, 151, 1):
        arc = C.create_arc(coord, start=1, extent=300, fill="yellow")
        C.pack()


B = Button(TOP, text="Hello", command=helloCallBack)
B.place(x=50, y=50)

C = Canvas(TOP, bg="blue", height=300, width=300)


def shape():
    coord = 10, 50, 240, 210
    arc = C.create_arc(coord, start=0, extent=120, fill="red")
    C.pack()
             
e = Entry(TOP)
e.pack()
b = Button(TOP, text='shape', command=shape)
b.pack()

TOP.mainloop()
