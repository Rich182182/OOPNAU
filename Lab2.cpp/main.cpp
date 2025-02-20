#include "Vector.h"
#include <iostream>

int main() {
    double x, y;
    std::cout << "Enter vector endpoint coordinates (x y): ";
    std::cin >> x >> y;

    Vector vector(x, y);
    vector.print();

    std::cout << "Vector length: " << vector.length() << std::endl;

    double radius, angle;
    vector.getPolarCoordinates(radius, angle);
    std::cout << "Polar coordinates: Radius = " << radius << ", Angle = " << angle << " radians" << std::endl;

    return 0;
}
