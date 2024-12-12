// 1. Validate "Mã sinh viên": Ensure length is exactly 10 characters
function validateStudentId() {
  const studentId = document.getElementById('studentId').value;
  const studentIdError = document.getElementById('studentIdError');
  
  if (studentId.length !== 10) {
    studentIdError.textContent = 'Mã sinh viên gồm 10 ký tự';
    studentIdError.style.color = 'red';
    return false;
  } else {
    studentIdError.textContent = ''; // Clear error message
  }
  
  return true;
}

// 2. Validate "Họ và tên": Ensure it's not empty and has max length of 30
function validateFullName() {
  const fullName = document.getElementById('fullName').value.trim();
  const fullNameError = document.getElementById('fullNameError');
  
  if (fullName === '') {
    fullNameError.textContent = 'Họ tên không rỗng';
    fullNameError.style.color = 'red';
    return false;
  }
  
  if (fullName.length > 30) {
    fullNameError.textContent = 'Họ tên không được dài quá 30 ký tự';
    fullNameError.style.color = 'red';
    return false;
  } else {
    fullNameError.textContent = ''; // Clear error message
  }
  
  return true;
}

// 3. Validate "Tuổi": Ensure age is 18 or more
function validateAge() {
  const age = document.getElementById('age').value;
  const ageError = document.getElementById('ageError');
  
  if (age < 18) {
    ageError.textContent = 'Tuổi phải từ 18 trở lên';
    ageError.style.color = 'red';
    return false;
  } else {
    ageError.textContent = ''; // Clear error message
  }
  
  return true;
}

// 4. Display "Sở trường" based on "Chuyên ngành" selection
function updateStrength() {
  const major = document.getElementById('major').value;
  const strengthInput = document.getElementById('strength');
  
  switch (major) {
    case 'Hệ thống':
      strengthInput.value = 'Phân tích & Thiết kế';
      break;
    case 'Phần mềm':
      strengthInput.value = 'Lập trình';
      break;
    case 'Mạng':
      strengthInput.value = 'Quản lý mạng';
      break;
    default:
      strengthInput.value = '';
  }
}

// Main validation function that runs all checks
function validateForm() {
  const isStudentIdValid = validateStudentId();
  const isFullNameValid = validateFullName();
  const isAgeValid = validateAge();
  
  // If any validation fails, stop the form submission
  if (!isStudentIdValid || !isFullNameValid || !isAgeValid) {
    document.getElementById('finalError').textContent = 'Bạn phải nhập lại cho đúng';
    document.getElementById('finalError').style.color = 'blue';
    return false;
  } else {
    document.getElementById('finalError').textContent = ''; // Clear final error message
  }
  
  return true;
}

// Attach event listeners
document.getElementById('major').addEventListener('change', updateStrength);
document.querySelector('form').addEventListener('submit', function(event) {
  if (!validateForm()) {
    event.preventDefault(); // Stop form submission if validation fails
  }
});
