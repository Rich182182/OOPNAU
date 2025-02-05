#include "Vector.h"
#include <iostream>
#include<string>
using namespace std;

Vector::Vector(double x, double y)
{
    this->x = x;
    this->y = y;
}

string Vector::printCoordinates() {
    return ("Coordinates: (" + std::to_string(x) + ", " + to_string(y) + ")");
}
double Vector::magnitude() {
    return sqrt(x * x + y * y);
}

double Vector::angle() {
    return atan2(y, x);
}
string Vector::printPolarCoordinates() {
    return "PolarCoordinates: " + to_string(magnitude()) + ", " + to_string(angle());
}