# Windows Application for Artificial Fixation Points

This is my take with a Windows application written in C# using WinForms that implements a technique called "Bionic Reading", it creates artificial fixation points by emphasizing the first few letters of words using bold string. This technique is aimed at reducing eye strain while improving reading speed and comprehension which I thought was pretty cool.

# Description

The program takes text as input and processes it to create artificial fixation points by emphasizing the first few letters of each word. This is achieved by wrapping the first few letters of a word in <b> and </b> HTML tags. The emphasized text is then displayed in a RichTextBox control.

# Images 

![image1](https://github.com/jgaspar10/Bold-string-enhanced-reading/assets/61797706/f75b5651-24c7-411b-9b82-a5eca199ac1b)
![image2](https://github.com/jgaspar10/Bold-string-enhanced-reading/assets/61797706/9ef6048a-e463-4790-8c80-a1121ca5bfa6)
![image3](https://github.com/jgaspar10/Bold-string-enhanced-reading/assets/61797706/677fd9ba-57c5-4805-a075-98eb67c68451)
![boldstring-gif](https://github.com/jgaspar10/Bold-string-enhanced-reading/assets/61797706/52639ce0-5f12-407f-9056-9c4bdcbf0a5d)


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

- .NET Framework 4.7.2
- Windows Forms
- Guna.UI

# Contributing

Contributions are welcome! If you have any suggestions or improvements for this application, feel free to open an issue or submit a pull request.
