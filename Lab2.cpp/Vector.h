#pragma once
class Vector {
private:
    double x;
    double y;

public:
    Vector();

    Vector(double x, double y);

    Vector(const Vector& other);

    ~Vector();


    double length() const;

    void getPolarCoordinates(double& radius, double& angle) const;

    void print() const;
};
