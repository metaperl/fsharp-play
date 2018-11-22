let greetPerson name age = 
    sprintf "Hello %s. You are %d years old." name age


let greeting = greetPerson "Fred" 25


let countWords (s:string) =
    let wordList = s.Split(' ')
    let numberOfWords = wordList.Length
    printfn "%s has %d words in it" s numberOfWords

countWords "My name is dot net"

let drive petrol distance =
    if distance = "far" then 1000
    elif distance = "medium" then 250
    else 50

drive "medium"

let file = @"C:\Users\Owner\Downloads\adsgrid.txt"

let x = System.IO.File.ReadLines file