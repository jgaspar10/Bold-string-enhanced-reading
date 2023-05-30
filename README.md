# Windows Application for Artificial Fixation Points

This is my take with a Windows application written in C# using WinForms that implements a technique called "Bionic Reading", it creates artificial fixation points by emphasizing the first few letters of words using bold string. This technique is aimed at reducing eye strain while improving reading speed and comprehension which I thought was pretty cool.

# Description

The program takes text as input and processes it to create artificial fixation points by emphasizing the first few letters of each word. This is achieved by wrapping the first few letters of a word in <b> and </b> HTML tags. The emphasized text is then displayed in a RichTextBox control.

# Usage
- Enter or paste the text into the input area of the application.
- Click the "Transform" button to generate the emphasized text.
- The emphasized text will be displayed in the output area of the application.
Note: The program considers the first three letters of each word for emphasis if the word has more than 3 letters. Words with fewer than three letters will be displayed with emphasis only on the first letter.

# Installation

### To run this application locally, follow these steps:

- Clone this repository to your local machine using the following command:
- git clone 
- https://github.com/jgaspar10/Bold-string-enhanced-reading.git
- Open the solution file (BoldStrings.sln) in Visual Studio.
- Build the solution to restore dependencies and compile the program.
- Press F5 or click the "Start" button in Visual Studio to run the application.

# Dependencies

## This application was developed using the following:

.NET Framework 4.7.2
Windows Forms
Guna.UI

# Contributing

Contributions are welcome! If you have any suggestions or improvements for this application, feel free to open an issue or submit a pull request.
