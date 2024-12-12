function validateInput(id, message) {
    const inputElement = document.getElementById(id);
    const value = inputElement.value.trim();
    let messageElement = inputElement.nextElementSibling;

    
    if (!messageElement || messageElement.className !== "error-message") {
        messageElement = document.createElement("div");
        messageElement.className = "error-message text-danger";
        inputElement.parentNode.appendChild(messageElement);
    }

    // Kiểm tra xem ô nhập liệu có rỗng không
    if (value === "") {
        messageElement.textContent = message; 
        return false;
    } else {
        messageElement.textContent = ""; 
        return true;
    }
}

// Hàm kiểm tra số điện thoại
function validatePhone() {
    const phoneElement = document.getElementById("phone");
    const value = phoneElement.value.trim();
    let messageElement = phoneElement.nextElementSibling;

    
    if (!messageElement || messageElement.className !== "error-message") {
        messageElement = document.createElement("div");
        messageElement.className = "error-message text-danger";
        phoneElement.parentNode.appendChild(messageElement);
    }

    // Kiểm tra số điện thoại có ít nhất 10 ký số
    if (value.length < 10) {
        messageElement.textContent = "Số điện thoại phải có ít nhất 10 ký số.";
        return false;
    } else {
        messageElement.textContent = ""; 
        return true;
    }
}

// Hàm kiểm tra tất cả thông tin và xử lý sự kiện submit
function validateForm(event) {
    event.preventDefault(); // Ngăn không cho form tự động submit

 
    const isNameValid = validateInput("name", "Tên không được để trống.");
    const isAddressValid = validateInput("address", "Địa chỉ không được để trống.");
    const isCityValid = validateInput("city", "Tỉnh / Thành phố không được để trống.");
    const isDistrictValid = validateInput("district", "Quận / Huyện không được để trống.");
    const isWardValid = validateInput("ward", "Phường / Xã không được để trống.");
    const isPhoneValid = validatePhone();

    // Kiểm tra nếu tất cả đều hợp lệ
    if (isNameValid && isAddressValid && isCityValid && isDistrictValid && isWardValid && isPhoneValid) {
    }
}

document.getElementById("btnSubmit").addEventListener("click", validateForm);
