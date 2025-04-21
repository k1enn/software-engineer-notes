/**
 * This script can be used to extract questions and answers from the quiz_01.txt file
 * and convert them to the format used by the quiz.js file.
 * 
 * Usage: 
 * 1. Run this script with Node.js: node extract_questions.js
 * 2. Copy the output and paste it into the quizData array in quiz.js
 */

const fs = require('fs');

// Function to extract questions and answers from the file
function extractQuestionsAndAnswers(filePath) {
    try {
        // Read the file
        const data = fs.readFileSync(filePath, 'utf8');
        
        // Split by question numbers (1., 2., etc.)
        const questionBlocks = data.split(/\d+\./).filter(block => block.trim() !== '');
        
        const questions = [];
        
        questionBlocks.forEach((block, index) => {
            // Clean up the block and split into lines
            const lines = block.trim().split('\n').filter(line => line.trim() !== '');
            
            // First line is the question
            const question = lines[0].trim();
            
            // Extract choices
            const choices = {
                a: '',
                b: '',
                c: '',
                d: ''
            };
            
            let currentChoice = '';
            
            for (let i = 1; i < lines.length; i++) {
                const line = lines[i].trim();
                
                // Check if this is a choice indicator (a., b., etc.)
                if (line === 'a.' || line === 'b.' || line === 'c.' || line === 'd.') {
                    currentChoice = line.charAt(0);
                } else if (currentChoice) {
                    // This is the choice text
                    choices[currentChoice] = line;
                    currentChoice = ''; // Reset for next choice
                }
            }
            
            // For simplicity, we'll assume the first choice ('a') is the correct answer
            // In a real scenario, you would need the actual answers
            const answer = 'a'; // Placeholder
            
            questions.push({
                question,
                choices,
                answer
            });
        });
        
        return questions;
    } catch (err) {
        console.error('Error reading file:', err);
        return [];
    }
}

// Example usage
const filePath = './resources/quiz_01.txt';
const questions = extractQuestionsAndAnswers(filePath);

// Output formatted for quiz.js
console.log(JSON.stringify(questions, null, 4)); 