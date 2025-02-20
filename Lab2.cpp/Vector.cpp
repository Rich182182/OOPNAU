#include "Vector.h"
#include <cmath>
#include <iostream>

Vector::Vector() : x(0), y(0) {}

Vector::Vector(double x, double y) : x(x), y(y) {}

Vector::Vector(const Vector& other) : x(other.x), y(other.y) {}

Vector::~Vector() {
    std::cout << "Vector object is being deleted" << std::endl;
}

double Vector::length() const {
    return std::sqrt(x * x + y * y);
}

void Vector::getPolarCoordinates(double& radius, double& angle) const {
    radius = length();
    angle = std::atan2(y, x);
}
void Vector::print() const {
    std::cout << "Vector: (" << x << ", " << y << ")" << std::endl;
}