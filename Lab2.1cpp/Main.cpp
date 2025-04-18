// main.cpp
#include <iostream>
#include "DigitalRow.h"

int main() {
    std::string inputRow;
    std::cout << "Enter a row with digits: ";
    std::getline(std::cin, inputRow);

    DigitalRow digitalRow(inputRow);

    std::cout << "Row information: " << std::endl;
    std::cout << digitalRow.toString() << std::endl;

    std::cout << "Digits in the row: ";
    std::vector<int> digits = digitalRow.getDigits();
    for (int digit : digits) {
        std::cout << digit << " ";
    }
    std::cout << std::endl;

    std::cout << "Row length: " << digitalRow.calculateLength() << std::endl;
    std::cout << "Digital sum: " << digitalRow.calculateDigitalSum() << std::endl;

    return 0;
}
