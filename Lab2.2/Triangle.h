#pragma once
#include "Figure.h"
#include <string>

class Triangle : public Figure {
protected:
    double x1, y1, x2, y2, x3, y3;

public:
    Triangle();
    Triangle(double x1, double y1, double x2, double y2, double x3, double y3);
    Triangle(const Triangle& other);

    ~Triangle() override;

    double getX1() const;
    double getY1() const;
    double getX2() const;
    double getY2() const;
    double getX3() const;
    double getY3() const;

    double calculateArea() const override;
    double calculatePerimeter() const override;

    std::string toString() const override;

private:
    double distance(double x1, double y1, double x2, double y2) const;
};
