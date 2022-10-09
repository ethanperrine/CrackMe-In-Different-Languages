import os

try:
    import colorama
except ImportError:
    print("Colorama is not found\nPlease do \"pip install colorama\"!")
    input()
    os._exit(0)

colorama.init()

# these are the colors
red = colorama.Fore.RED
green = colorama.Fore.GREEN
blue = colorama.Fore.BLUE
# these are the colors

global correct_answer
correct_answer = "TestingKey"


def clear_console():
    if os.name == 'nt':
        os.system('cls')
    else:
        os.system('clear')

def question(questions_input):
    questions_input = input("Please enter the correct answer: ")
    total_tries = 4
    for each_try in range(total_tries):
        if questions_input == correct_answer:
            print(f"{green}Correct!")
            input()
            break
        else:
            print(f"{blue}You have {total_tries - each_try} tries left!")
            print(f"{red}Incorrect!")
            questions_input = input("Try again: ")

def main():
    try:
        clear_console()
        question(input)
        os._exit(0)
    except ValueError:
        print(f"{red}We Have a incorrect error!")
        os._exit(0)

if __name__ == "__main__":
    main()

