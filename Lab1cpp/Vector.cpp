#include "Vector.h"
#include <iostream>
using namespace std;

Vector::Vector(double x, double y)
{
    if (x >= 0) this->x = x;
    else this->x = 0;
    if (y >= 0) this->y = y;
    else this->y = 0;
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