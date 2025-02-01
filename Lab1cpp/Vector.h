#pragma once

class Vector
{
private:
    double x, y;

public:
    Vector(double x = 0, double y = 0);
    void printCoordinates();
    double magnitude();
    double angle();
    void printPolarCoordinates();
};

