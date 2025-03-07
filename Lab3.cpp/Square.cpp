#include "Square.h"
#include <iostream>
#include <string>

Square::Square() : x(0), y(0), side(1) {}

Square::Square(double x, double y, double side) : x(x), y(y), side(side) {}

Square::Square(const Square& other) : x(other.x), y(other.y), side(other.side) {}

Square::~Square() {
    std::cout << "Square object is being deleted" << std::endl;
}

double Square::GetArea() {
    return side * side;
}

double Square::GetPerimeter() {
    return 4 * side;
}

Square Square::operator+(const Square& other) {
    return Square(x, y, side + other.side);
}

Square Square::operator/(double value) {
    return Square(x, y, side / value);
}

std::string Square::ToString() {
    return "Square: Origin (" + std::to_string(x) + ", " + std::to_string(y) + "), Side = " + std::to_string(side);
}
