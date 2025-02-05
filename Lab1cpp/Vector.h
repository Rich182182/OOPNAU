#pragma once
#include<string>
using namespace std;
class Vector
{
private:
    double x, y;

public:
    Vector(double x = 0, double y = 0);
    string printCoordinates();
    double magnitude();
    double angle();
    string printPolarCoordinates();
};

