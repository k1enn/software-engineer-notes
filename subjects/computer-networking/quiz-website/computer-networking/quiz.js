
let quizData = [];

// Fetch quiz data from the JSON file
async function loadQuizData() {
    try {
        const response = await fetch('quizData.json');
        if (!response.ok) {
            throw new Error('Failed to load quiz data');
        }
        quizData = await response.json();
        initQuiz(); // Initialize the quiz after loading data
    } catch (error) {
        console.error('Error loading quiz data:', error);
    }
}

// Initialize the quiz when page loads
document.addEventListener("DOMContentLoaded", loadQuizData);


// DOM Elements
const questionElement = document.getElementById("question");
const choiceElements = Array.from(document.getElementsByClassName("choice-text"));
const questionCounterElement = document.getElementById("question-counter");
const prevButton = document.getElementById("prev-btn");
const nextButton = document.getElementById("next-btn");
const submitButton = document.getElementById("submit-btn");
const scoreDisplay = document.getElementById("score-display");
const scoreElement = document.getElementById("score");
const resultElement = document.getElementById("result");
const questionsMapElement = document.getElementById("questions-map");
const toggleMapButton = document.getElementById("toggle-map");
const questionNav = document.getElementById("question-nav");
const collapseMapButton = document.getElementById("collapse-map");
const showMapButton = document.getElementById("show-map-btn");

// Quiz state
let currentQuestionIndex = 0;
const userAnswers = Array(quizData.length).fill(null);
let quizSubmitted = false;
let mapVisible = true;

// Initialize the quiz
function initQuiz() {
    createQuestionsMap();
    showQuestion();
    updateButtons();
    submitButton.classList.remove("hide"); // Always show submit button
    setupMapToggle();
    
    // Add resize listener to maintain grid layout
    window.addEventListener('resize', ensureGridLayout);
}

// Ensure grid layout is maintained
function ensureGridLayout() {
    if (!questionsMapElement) return;
    
    // Force grid layout with proper sizing
    questionsMapElement.style.cssText = `
        display: grid !important;
        grid-template-columns: repeat(4, 1fr) !important;
        grid-auto-flow: row !important;
        grid-gap: 8px !important;
        width: 100% !important;
    `;
    
    // Ensure all buttons have proper width
    const questionBtns = document.querySelectorAll(".question-btn");
    questionBtns.forEach(btn => {
        btn.style.width = '100%';
    });
}

// Setup map toggle functionality
function setupMapToggle() {
    const mapOverlay = document.getElementById("map-overlay");
    const mapContainer = document.querySelector(".map-container");
    
    // Initialize map state
    if (window.innerWidth <= 768) {
        // On mobile, start with map collapsed
        mapContainer.classList.add("collapsed");
        showMapButton.classList.remove("hide");
    } else {
        // On desktop, start with map visible
        mapContainer.classList.remove("collapsed");
        showMapButton.classList.add("hide");
    }
    
    // Mobile toggle button (this will be hidden via CSS, but kept for backward compatibility)
    toggleMapButton.addEventListener("click", () => {
        toggleQuestionMap();
    });
    
    // Desktop collapse button
    collapseMapButton.addEventListener("click", () => {
        hideQuestionMap();
    });
    
    // Universal show map button
    showMapButton.addEventListener("click", () => {
        showQuestionMap();
    });
    
    // Close map when clicking on overlay
    if (mapOverlay) {
        mapOverlay.addEventListener("click", () => {
            hideQuestionMap();
        });
    }
    
    // Handle window resize
    window.addEventListener('resize', () => {
        if (window.innerWidth > 768) {
            // On desktop
            if (!mapContainer.classList.contains("collapsed")) {
                // If map is visible
                showMapButton.classList.add("hide");
            } else {
                showMapButton.classList.remove("hide");
            }
        } else {
            // On mobile
            if (questionNav.classList.contains("show")) {
                // If map is showing on mobile
                showMapButton.classList.add("hide");
            } else {
                showMapButton.classList.remove("hide");
            }
        }
    });
    
    // Helper function to show question map
    function showQuestionMap() {
        mapContainer.classList.remove("collapsed");
        
        // For mobile
        if (window.innerWidth <= 768) {
            questionNav.classList.add("show");
            if (mapOverlay) {
                mapOverlay.classList.add("show");
                
                // Add subtle animation when showing the map
                questionNav.style.opacity = "0";
                questionNav.style.transform = "scale(0.95)";
                
                // Force reflow
                void questionNav.offsetWidth;
                
                // Apply animation
                questionNav.style.transition = "opacity 0.3s ease, transform 0.3s ease";
                questionNav.style.opacity = "1";
                questionNav.style.transform = "scale(1)";
            }
            
            // Prevent body scrolling
            document.body.style.overflow = "hidden";
        }
        
        // Hide the show map button
        showMapButton.classList.add("hide");
    }
    
    // Helper function to hide question map
    function hideQuestionMap() {
        mapContainer.classList.add("collapsed");
        
        // For mobile view animation
        if (window.innerWidth <= 768) {
            // Fade out the map
            questionNav.style.opacity = "0";
            questionNav.style.transform = "scale(0.95)";
            
            // Wait for animation to complete
            setTimeout(() => {
                questionNav.classList.remove("show");
                if (mapOverlay) mapOverlay.classList.remove("show");
                
                // Reset styles
                questionNav.style.transition = "";
                questionNav.style.opacity = "";
                questionNav.style.transform = "";
            }, 200);
        } else {
            // For desktop, just hide immediately
            questionNav.classList.remove("show");
            if (mapOverlay) mapOverlay.classList.remove("show");
        }
        
        // Show the show map button
        showMapButton.classList.remove("hide");
        
        // Re-enable body scrolling
        document.body.style.overflow = "";
    }
    
    // Helper function to toggle question map
    function toggleQuestionMap() {
        if (mapContainer.classList.contains("collapsed")) {
            showQuestionMap();
        } else {
            hideQuestionMap();
        }
    }
}

// Helper function to toggle show map button visibility
function toggleShowMapButton() {
    const mapContainer = document.querySelector(".map-container");
    if (mapContainer.classList.contains("collapsed")) {
        showMapButton.classList.remove("hide");
    } else {
        showMapButton.classList.add("hide");
    }
}

// Create the questions navigation map
function createQuestionsMap() {
    // Clear existing buttons first to avoid duplicates
    questionsMapElement.innerHTML = '';
    
    // Force grid layout with proper sizing
    questionsMapElement.style.cssText = `
        display: grid !important;
        grid-template-columns: repeat(4, 1fr) !important;
        grid-auto-flow: row !important;
        grid-gap: 8px !important;
        width: 100% !important;
    `;
    
    // Create a button for each question
    for (let i = 0; i < quizData.length; i++) {
        const questionBtn = document.createElement("button");
        questionBtn.className = "btn btn-outline-primary question-btn";
        questionBtn.textContent = i + 1;
        questionBtn.setAttribute("data-index", i);
        questionBtn.setAttribute("aria-label", `Go to question ${i + 1}`);
        
        // Set explicit sizing to ensure proper grid layout
        questionBtn.style.cssText = "width: 100% !important; margin: 0 !important;";
        
        questionBtn.addEventListener("click", () => {
            navigateToQuestion(i);
        });
        
        questionsMapElement.appendChild(questionBtn);
    }
    
    // Update footer text
    const footerDiv = document.querySelector('.block_navigation .footer');
    if (footerDiv) {
        footerDiv.textContent = `Total: ${quizData.length} questions`;
    }
    
    // Ensure grid layout immediately
    setTimeout(ensureGridLayout, 0);
}

// Navigate to a specific question
function navigateToQuestion(index) {
    currentQuestionIndex = index;
    showQuestion();
    updateButtons();
    updateQuestionsMap();
}

// Update the active state in the questions map
function updateQuestionsMap() {
    const questionBtns = document.querySelectorAll(".question-btn");
    
    questionBtns.forEach((btn, index) => {
        // Remove all state classes first
        btn.classList.remove("active");
        
        // Mark answered questions
        const userAnswer = userAnswers[index];
        if (userAnswer && !quizSubmitted) {
            btn.classList.add("answered");
        }
        
        // Add active class to current question
        if (index === currentQuestionIndex) {
            btn.classList.add("active");
            
            // Scroll the question map to make current question visible
            setTimeout(() => {
                scrollQuestionMapToCurrentQuestion(btn);
            }, 100);
        }
        
        // If quiz is submitted, show correct/incorrect status
        if (quizSubmitted) {
            if (userAnswer) {
                const correctAnswer = quizData[index].answer;
                if (userAnswer === correctAnswer) {
                    btn.classList.remove("btn-outline-primary", "answered");
                    btn.classList.add("correct");
                } else {
                    btn.classList.remove("btn-outline-primary", "answered");
                    btn.classList.add("incorrect");
                }
            }
        }
    });
}

// Scroll question map to ensure current question is visible
function scrollQuestionMapToCurrentQuestion(btn) {
    const questionsMapContainer = document.getElementById("questions-map");
    if (!questionsMapContainer) return;
    
    const btnRect = btn.getBoundingClientRect();
    const containerRect = questionsMapContainer.getBoundingClientRect();
    
    // Check if button is not fully visible in the container
    if (btnRect.bottom > containerRect.bottom || btnRect.top < containerRect.top) {
        const scrollTop = btn.offsetTop - (questionsMapContainer.clientHeight / 2) + (btn.clientHeight / 2);
        questionsMapContainer.scrollTo({
            top: Math.max(0, scrollTop),
            behavior: 'smooth'
        });
    }
}

// Display the current question and choices
function showQuestion() {
    const currentQuestion = quizData[currentQuestionIndex];
    questionElement.innerText = `${currentQuestionIndex + 1}. ${currentQuestion.question}`;
    
    choiceElements.forEach(choiceElement => {
        const choiceLetter = choiceElement.dataset.choice;
        choiceElement.innerText = currentQuestion.choices[choiceLetter];
        
        // Remove previous selection classes
        choiceElement.parentElement.classList.remove("correct", "incorrect", "selected");
        
        // Highlight previously selected answer
        if (userAnswers[currentQuestionIndex] === choiceLetter) {
            choiceElement.parentElement.classList.add("selected");
        }
        
        // Show correct/incorrect in submitted state
        if (quizSubmitted) {
            const isCorrect = choiceLetter === currentQuestion.answer;
            const isSelected = userAnswers[currentQuestionIndex] === choiceLetter;
            
            if (isSelected) {
                if (isCorrect) {
                    choiceElement.parentElement.classList.add("correct");
                } else {
                    choiceElement.parentElement.classList.add("incorrect");
                }
            } else if (isCorrect) {
                choiceElement.parentElement.classList.add("correct");
            }
        }
    });
    
    questionCounterElement.innerText = `Question ${currentQuestionIndex + 1}/${quizData.length}`;
    updateQuestionsMap();
}

// Update button states
function updateButtons() {
    prevButton.disabled = currentQuestionIndex === 0;
    nextButton.disabled = currentQuestionIndex === quizData.length - 1;
}

// Handle choice selection
choiceElements.forEach(choice => {
    choice.addEventListener("click", e => {
        if (quizSubmitted) return; // Don't allow changes after submission
        
        const selectedChoice = e.target;
        const selectedAnswer = selectedChoice.dataset.choice;
        
        // Save user's answer
        userAnswers[currentQuestionIndex] = selectedAnswer;
        
        // Clear previous selections
        choiceElements.forEach(c => c.parentElement.classList.remove("selected"));
        
        // Highlight current selection
        selectedChoice.parentElement.classList.add("selected");
        
        // Update the questions map to show answered questions
        updateQuestionsMap();
    });
});

// Navigate to previous question
prevButton.addEventListener("click", () => {
    if (currentQuestionIndex > 0) {
        currentQuestionIndex--;
        showQuestion();
        updateButtons();
    }
});

// Navigate to next question
nextButton.addEventListener("click", () => {
    if (currentQuestionIndex < quizData.length - 1) {
        currentQuestionIndex++;
        showQuestion();
        updateButtons();
    }
});

// Submit the quiz
submitButton.addEventListener("click", () => {
    // Check if user has attempted any questions
    const answeredCount = userAnswers.filter(answer => answer !== null).length;
    
    if (answeredCount === 0) {
        alert("Please answer at least one question before submitting.");
        return;
    }
    
    if (!quizSubmitted && !confirm("Are you sure you want to submit the quiz? You won't be able to change your answers afterwards.")) {
        return;
    }
    
    quizSubmitted = true;
    
    let score = 0;
    
    // Calculate score
    quizData.forEach((question, index) => {
        if (userAnswers[index] === question.answer) {
            score++;
        }
    });
    
    // Display score
    scoreElement.innerText = score;
    scoreDisplay.classList.remove("hide");
    
    // Show result message
    const percentage = (score / quizData.length) * 100;
    let resultMessage = "";
    
    if (percentage >= 90) {
        resultMessage = "Xuất sắc, bạn hiểu hầu hết tất cả nội dung trong đây";
    } else if (percentage >= 70) {
        resultMessage = "Làm tốt lắm, bạn có nền tảng khá vững chắc";
    } else if (percentage >= 50) {
        resultMessage = "Ổn á, bạn hiểu được cơ bản";
    } else {
        resultMessage = "Cố gắng lên nha, bạn sẽ giỏi hơn khi tiếp tục học tập";
    }
    
    resultElement.innerText = resultMessage;
    resultElement.classList.remove("hide");
    
    // Update button styling
    submitButton.disabled = true;
    submitButton.innerText = "Quiz Submitted";
    
    // Show correct and incorrect answers
    showCorrectAnswers();
    
    // Update the questions map to show correct/incorrect
    updateQuestionsMap();
});

// Show correct answers after submission
function showCorrectAnswers() {
    const currentQuestion = quizData[currentQuestionIndex];
    
    choiceElements.forEach(choiceElement => {
        const choiceLetter = choiceElement.dataset.choice;
        const isCorrect = choiceLetter === currentQuestion.answer;
        const isSelected = userAnswers[currentQuestionIndex] === choiceLetter;
        
        choiceElement.parentElement.classList.remove("correct", "incorrect");
        
        if (isSelected) {
            if (isCorrect) {
                choiceElement.parentElement.classList.add("correct");
            } else {
                choiceElement.parentElement.classList.add("incorrect");
            }
        } else if (isCorrect) {
            choiceElement.parentElement.classList.add("correct");
        }
    });
}

// Update showCorrectAnswers to be called on navigation after submission
prevButton.addEventListener("click", () => {
    if (quizSubmitted) {
        showCorrectAnswers();
    }
});

nextButton.addEventListener("click", () => {
    if (quizSubmitted) {
        showCorrectAnswers();
    }
});

// Handle orientation change for mobile devices
window.addEventListener('orientationchange', function() {
    setTimeout(function() {
        if (window.innerWidth > 768) {
            questionNav.style.display = 'block';
        } else {
            questionNav.style.display = 'none';
        }
    }, 200);
});

// Initialize the quiz when page loads
document.addEventListener("DOMContentLoaded", initQuiz); 