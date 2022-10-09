import strutils
import std/terminal

var answer = "answer"
var counter: int = 0

for i in 1..5:
    stdout.write("Please input the answer: ")
    var consoleInput: string = readLine(stdin);
    stdout.flushFile()

    if consoleInput == answer:
        stdout.styledWriteLine(fgGreen, "Correct!")
        consoleInput = readLine(stdin);
        echo "Press enter to exit"
        break
    else:
        let math: int = 5 - counter
        stdout.styledWriteLine(fgRed, "Incorrect!, You have " & intToStr(math) & " tries left")
        stdout.write("\nPress enter to continue")
        consoleInput = readLine(stdin);
        counter += 1
    eraseScreen() #puts cursor at down
    setCursorPos(0, 0)