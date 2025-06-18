import serial
import time

PORT = 'COM3'
BAUD_RATE = 9600 # 9600 bits per second matches Serial.begin(9600); in joystickmouse arduino code

ser = serial.Serial(PORT, BAUD_RATE, timeout=1) # does the listening based on dataabove, waits one second before giving up
time.sleep(2) # add pause to collect data before refresh

print(f"Listening on PORT {PORT}...")

while True:
    try:
        line = ser.readline().decode('utf-8').strip() # reads one line of text from arduino such as "511,512\n" converts from bytes to string, removes unneeded whitespace
        with open("../joystick_data.txt", "w") as f:
            f.write(line)
            print(f"Joystick Data: {line}")
            
    except Exception as e:
        print("Error", e)
