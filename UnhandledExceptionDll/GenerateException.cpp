#include "GenerateException.h"

void DivideZero()
{
    int a = 1 - 1;
    double b = 1 / a;
}

void AccessViolation()
{
    int* p = 0;
    *p = 1;
}
