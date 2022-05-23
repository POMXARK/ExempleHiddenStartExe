import winsound

freq = 500  # Set Frequency To 500 Hertz
dur = 1000 # Set Duration To 1000 ms == 1
winsound.Beep(freq, dur)

""" python -m nuitka main.py --onefile"""