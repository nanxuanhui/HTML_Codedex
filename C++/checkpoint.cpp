#include <iostream>
#include <string>

int main() {
    std::string password;
    bool hasNumber = false;
    bool hasSpecial = false;

    std::cout << "===================\n";
    std::cout << "Password Checker 🔐\n";
    std::cout << "===================\n\n";

    std::cout << "Enter a password: ";
    std::cin >> password;

    // Check password length
    if (password.length() < 8) {
        std::cout << "❌ Password must be at least 8 characters." << std::endl;
        return 0;
    }

    // Check each character
    for (int i = 0; i < password.length(); i++) {

        // Check if character is a number
        if (password[i] >= '0' && password[i] <= '9') {
            hasNumber = true;
        }

        // Check if character is a special character
        if (password[i] == '!' ||
            password[i] == '@' ||
            password[i] == '#' ||
            password[i] == '%' ||
            password[i] == '^') {
            hasSpecial = true;
        }
    }

    // Final validation
    if (!hasNumber) {
        std::cout << "❌ Password must include a number." << std::endl;
    }
    else if (!hasSpecial) {
        std::cout << "❌ Password must include a special character." << std::endl;
    }
    else {
        std::cout << "✅ Valid password!" << std::endl;
    }

    return 0;
}