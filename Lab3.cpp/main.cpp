#include <iostream>
#include "Square.h"

int main() {
    std::cout << "Enter square origin and side length (x y side): ";
    double x, y, side;
    std::cin >> x >> y >> side;

    Square square1(x, y, side);
    Square square2(square1);
    Square square3(2, 2, 6);

    Square square4 = square2 + square3;

    std::cout << "Square1:" << std::endl;
    std::cout << square1.ToString() << std::endl;
    std::cout << "Square2:" << std::endl;
    std::cout << square2.ToString() << std::endl;
    std::cout << "Square3:" << std::endl;
    std::cout << square3.ToString() << std::endl;
    std::cout << "Square4:" << std::endl;
    std::cout << square4.ToString() << std::endl;

    return 0;
}
