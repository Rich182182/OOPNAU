#include "Figure.h"

Figure::Figure() : name("Unknown Figure") {
}

Figure::Figure(const std::string& name) : name(name) {
}

Figure::Figure(const Figure& other) : name(other.name) {
}

Figure::~Figure() {
}

std::string Figure::getName() const {
    return name;
}

double Figure::calculateArea() const {
    return 0.0;
}

double Figure::calculatePerimeter() const {
    return 0.0;
}

std::string Figure::toString() const {
    return "Figure: " + name;
}
