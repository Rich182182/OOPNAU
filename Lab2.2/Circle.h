#pragma once
#include "Figure.h"
#include <string>

class Circle : public Figure {
protected:
    double radius;
    double centerX, centerY;

public:
    Circle();
    Circle(double centerX, double centerY, double radius);
    Circle(const Circle& other);

    ~Circle() override;

    double getRadius() const;
    double getCenterX() const;
    double getCenterY() const;

    double calculateArea() const override;
    double calculatePerimeter() const override;

    std::string toString() const override;
};
