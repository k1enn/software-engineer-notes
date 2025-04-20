# Network Quiz Application

This is a web-based quiz application focused on network concepts and technologies. The application loads questions from a predefined set, allows users to navigate through questions, select answers, and receive a score at the end.

## Features

- Interactive quiz interface
- Navigation between questions
- Scoring system
- Visual feedback for correct and incorrect answers
- Responsive design

## How to Use

1. Open `index.html` in your web browser
2. Click "Start Quiz" to begin
3. Read each question and select the answer you believe is correct
4. Use the "Previous" and "Next" buttons to navigate between questions
5. Click "Submit" on the last question to see your score
6. After submission, you can review correct and incorrect answers by navigating through the questions

## Files

- `index.html`: The main entry point of the application
- `quiz.html`: The quiz interface
- `style.css`: Styles for the application
- `quiz.js`: JavaScript code that handles the quiz logic
- `resources/quiz_01.txt`: Source file containing the quiz questions

## Adding More Questions

To add more questions to the quiz, edit the `quizData` array in `quiz.js`. Each question should follow this format:

```javascript
{
    question: "Your question text here",
    choices: {
        a: "First choice",
        b: "Second choice",
        c: "Third choice",
        d: "Fourth choice"
    },
    answer: "a" // The correct answer (a, b, c, or d)
}
```

## Extracting Questions from Text File

The application includes an `extract_questions.js` Node.js script that can help extract questions from the text file format. To use it:

1. Make sure you have Node.js installed
2. Run `node extract_questions.js`
3. The script will output JSON that can be copied into the `quizData` array in `quiz.js` 