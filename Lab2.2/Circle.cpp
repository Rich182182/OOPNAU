#include "Circle.h"
#include <cmath>
#include <sstream>

const double PI = 3.14159265358979323846;

Circle::Circle() : Figure("Circle"), centerX(0), centerY(0), radius(1) {
}

Circle::Circle(double centerX, double centerY, double radius)
    : Figure("Circle"), centerX(centerX), centerY(centerY) {
    // Ensure radius is positive
    this->radius = (radius > 0) ? radius : 1.0;
}

Circle::Circle(const Circle& other)
    : Figure(other), centerX(other.centerX), centerY(other.centerY), radius(other.radius) {
}

Circle::~Circle() {
}

double Circle::getRadius() const { return radius; }
double Circle::getCenterX() const { return centerX; }
double Circle::getCenterY() const { return centerY; }

double Circle::calculateArea() const {
    return PI * radius * radius;
}

double Circle::calculatePerimeter() const {
    return 2 * PI * radius;
}

std::string Circle::toString() const {
    std::stringstream ss;
    ss << "Circle: Center at (" << centerX << "," << centerY << "), Radius = " << radius;
    return ss.str();
}
