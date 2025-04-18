// DigitalRow.h
#pragma once
#include "Row.h"
#include <vector>

class DigitalRow : public Row {
public:
    DigitalRow();
    DigitalRow(const std::string& value);
    DigitalRow(const DigitalRow& other);
    ~DigitalRow() override;

    // Calculate digital sum of the row
    int calculateDigitalSum() const;

    // Get digits from the row
    std::vector<int> getDigits() const;

    // Override toString
    std::string toString() const override;
};
