#pragma once
#include <string>

class Figure {
protected:
    std::string name;

public:
    Figure();
    Figure(const std::string& name);
    Figure(const Figure& other);

    virtual ~Figure();

    std::string getName() const;

    virtual double calculateArea() const;
    virtual double calculatePerimeter() const;

    virtual std::string toString() const;
};

