#include <iostream>
#include <vector>
#include <iomanip>
#include "Triangle.h"
#include "Circle.h"

void displayFigureInfo(const Figure& figure) {
    std::cout << "\n--- Figure Information ---" << std::endl;
    std::cout << figure.toString() << std::endl;
    std::cout << "Area: " << figure.calculateArea() << std::endl;
    std::cout << "Perimeter: " << figure.calculatePerimeter() << std::endl;
    std::cout << "-------------------------\n" << std::endl;
}

int main() {
    std::cout << "Creating a triangle..." << std::endl;
    std::cout << "Enter triangle coordinates (x1 y1 x2 y2 x3 y3): ";
    double x1, y1, x2, y2, x3, y3;
    std::cin >> x1 >> y1 >> x2 >> y2 >> x3 >> y3;

    Triangle triangle(x1, y1, x2, y2, x3, y3);

    std::cout << "\nCreating a circle..." << std::endl;
    std::cout << "Enter circle center and radius (centerX centerY radius): ";
    double centerX, centerY, radius;
    std::cin >> centerX >> centerY >> radius;

    Circle circle(centerX, centerY, radius);

    displayFigureInfo(triangle);
    displayFigureInfo(circle);

    return 0;
}
