use std::io::{stdin, stdout, Write};
use colored::*;


#[macro_use]
//noinspection RsUnresolvedReference
extern crate colour;

fn main() {
    for i in 0..5 {
        let mut input = String::new();
        print!("Enter your answer: ");
        stdout().flush().unwrap();
        stdin().read_line(&mut input).unwrap();

        let answer = String::from("answer");
        let mut correct = false;

        if input.trim() == answer {
            green!("Correct");
            correct = true;
            let mut input = String::new();
            print!("\nPress enter to close ");
            stdout().flush().unwrap();
            stdin().read_line(&mut input).unwrap();

            break;
        }
        else{
            red!("Wrong answer!\n");
            correct = false;
        }
    }
}
