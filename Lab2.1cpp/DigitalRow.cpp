// DigitalRow.cpp
#include "DigitalRow.h"
#include <cctype>

DigitalRow::DigitalRow() : Row() {
}

DigitalRow::DigitalRow(const std::string& value) : Row(value) {
}

DigitalRow::DigitalRow(const DigitalRow& other) : Row(other) {
}

DigitalRow::~DigitalRow() {
}

int DigitalRow::calculateDigitalSum() const {
    int sum = 0;
    for (char c : value) {
        if (std::isdigit(c)) {
            sum += (c - '0');
        }
    }
    return sum;
}

std::vector<int> DigitalRow::getDigits() const {
    std::vector<int> digits;
    for (char c : value) {
        if (std::isdigit(c)) {
            digits.push_back(c - '0');
        }
    }
    return digits;
}

std::string DigitalRow::toString() const {
    return "Digital" + Row::toString() + ", Digital Sum: " + std::to_string(calculateDigitalSum());
}
