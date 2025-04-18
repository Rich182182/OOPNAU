// Row.h
#pragma once
#include <string>

class Row {
protected:
    std::string value;

public:
    Row();
    Row(const std::string& value);
    Row(const Row& other);
    virtual ~Row();

    // Getter for value
    std::string getValue() const;

    // Calculate length of the row
    virtual int calculateLength() const;

    // ToString method
    virtual std::string toString() const;
};
