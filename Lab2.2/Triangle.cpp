#include "Triangle.h"
#include <cmath>
#include <sstream>

Triangle::Triangle() : Figure("Triangle") {
    x1 = 1.0; y1 = 1.0;
    x2 = 4.0; y2 = 1.0;
    x3 = 2.0; y3 = 5.0;
}

Triangle::Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    : Figure("Triangle"), x1(x1), y1(y1), x2(x2), y2(y2), x3(x3), y3(y3) {
}

Triangle::Triangle(const Triangle& other)
    : Figure(other), x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2), x3(other.x3), y3(other.y3) {
}

Triangle::~Triangle() {
}

double Triangle::getX1() const { return x1; }
double Triangle::getY1() const { return y1; }
double Triangle::getX2() const { return x2; }
double Triangle::getY2() const { return y2; }
double Triangle::getX3() const { return x3; }
double Triangle::getY3() const { return y3; }

double Triangle::distance(double x1, double y1, double x2, double y2) const {
    return std::sqrt(std::pow(x2 - x1, 2) + std::pow(y2 - y1, 2));
}

double Triangle::calculateArea() const {
    double a = distance(x1, y1, x2, y2);
    double b = distance(x2, y2, x3, y3);
    double c = distance(x3, y3, x1, y1);

    double s = (a + b + c) / 2.0;

    return std::sqrt(s * (s - a) * (s - b) * (s - c));
}

double Triangle::calculatePerimeter() const {
    double a = distance(x1, y1, x2, y2);
    double b = distance(x2, y2, x3, y3);
    double c = distance(x3, y3, x1, y1);

    return a + b + c;
}

std::string Triangle::toString() const {
    std::stringstream ss;
    ss << "Triangle: Vertices at (" << x1 << "," << y1 << "), ("
        << x2 << "," << y2 << "), (" << x3 << "," << y3 << ")";
    return ss.str();
}
