# Unit + Arduino Joystick Control

This project uses an Ardion kit joystick to control a cube in the unity game engine.


## How to run

### 1) Build Your Arduino Uno R3 year 2024
1. Take your joystick Module and attatch the rubber grip
2. Connect wire from GND on joystick to GND on your UNO R3 Controller Board (the main Arduino board)
3. Connect +5v to 5v on your Arduino Board
4. Connect VRx to A0
5. Connect Vry to A1
6. Connect SW to 2 on the board also known as D2
7. Connect Arduino Board to computer using USB CABLE

### 2) Running Arduino Sketch
1. Download Arduino IDE 2.3.6 if not done already (it does not run automatically in Unity sadly)
2. Open Arduino IDE > file > open > find joystickmouse.ino found in this project
3. Select your board and port:
    - Tools > Board > Arduino Uno
    - Tools > Port > COMX (note: the joystick_relay.py file has 'COM3' hardcoded so change if needed)
4. Click the upload button
5. Open Serial Monitor to check that it is working. (9600 baud also hardcoded in joystick_relay.py change if needed)
6. Once you have checked that the Serial Monitor is responding with values as you move the joystick you need to exit out of the Serial Monitor by clicking on the x next to it in the terminal area. The code won't work if this is running in the background while you try to run your code.
7. Keep the program running while you try to play the game.

### 3) Run joystick_relay.py
1. Open JOYSTICKCUBE folder in VS Code
2. In joystick_relay.py file, make sure the PORT and baud are correct for your Arduino setup if not already done so
3. In terminal, cd to joystick_relay.py
4. in terminal paste python joystick_relay.py and run
5. You should see many pairs of numbers displaying in your terminal in vs code keep running until you want to finish your cube game.

### 4) Run Unity
1. Open Unity 6
2. Open folder to JoyStickCube
3. click the play button to run your game
4. Both the python and Arduino Sketch must be working before you will be able to move your cube