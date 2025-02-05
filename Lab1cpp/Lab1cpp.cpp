#include "Vector.h"
#include <iostream>
using namespace std;

int main()
{
    std::cout << "Add Coordinates x and y:" << std::endl;
    double x, y;
    std::cin >> x >> y;
    Vector v(x, y);
    cout<<v.printCoordinates()<<endl;
    cout<<v.printPolarCoordinates()<<endl;
    return 0;
}
