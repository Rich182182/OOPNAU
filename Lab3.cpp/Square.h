#pragma once
#include <string>

class Square {
public:
    const double x;
    const double y;
    const double side;

    Square();
    Square(double x, double y, double side = 5);
    Square(const Square& other);
    ~Square();

    double GetArea();
    double GetPerimeter();
    double GetPerimeter(double x);
    Square operator+(const Square& other);
    Square operator/(double value);
    std::string ToString();
};

