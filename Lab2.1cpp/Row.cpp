// Row.cpp
#include "Row.h"

Row::Row() : value("") {
}

Row::Row(const std::string& value) : value(value) {
}

Row::Row(const Row& other) : value(other.value) {
}

Row::~Row() {
}

std::string Row::getValue() const {
    return value;
}

int Row::calculateLength() const {
    return value.length();
}

std::string Row::toString() const {
    return "Row: " + value + ", Length: " + std::to_string(calculateLength());
}
