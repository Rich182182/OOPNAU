#include "Vector.h"
#include <iostream>
using namespace std;

Vector::Vector(double x, double y)
{
    this->x = x;
    this->y = y;
}

void Vector::printCoordinates() {
    cout << "Coordinates: (" << x << ", " << y << ")"<< endl;
}

double Vector::magnitude() {
    return sqrt(x * x + y * y);
}

double Vector::angle() {
    return atan2(y, x);
}
void Vector::printPolarCoordinates() {
    cout << "PolarCoordinates: " << magnitude() << angle() << endl;
}