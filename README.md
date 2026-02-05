# Chemical Elements Quiz

## Overview
Chemical Elements Quiz is a Blazor WebAssembly application designed to help users practice the names of chemical elements.
The app loads element data from a JSON file and generates a quiz where each question must be answered within 10 seconds.
After completing the quiz, users receive a final score along with a detailed summary of correct and incorrect answers.
The project demonstrates component‑based UI, state management, data loading, and interactive logic in Blazor.

## Technologies
- .NET 8.0
- C# 12
- Blazor WebAssembly

## How to Run

### 1. Clone the repository:
```bash
git clone https://github.com/krzysztof-lech/chemical-elements-quiz.git
```
### 2. Navigate to the project folder:
```bash
   cd chemical-elements-quiz
```

### 3. Run the application:
```bash
   dotnet watch run
```
### 4. The application will automatically open in your default browser

## Features

- 10‑second timer per question with a visual progress indicator  
- Final score calculation and display  
- Detailed summary of correct and incorrect answers  
- Option to retake the quiz  
- Polish character normalization for answer validation  