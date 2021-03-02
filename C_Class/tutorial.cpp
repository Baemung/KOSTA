#include <stdio.h>

int main()
{
    printf("Hello KOSTA!");
    printf("\t%s\n", "코스타");
    printf("%-8d%-8d%d\n", 123, 456, 789);
    printf("%-.5f\t%-.5f\t%-.5f\n", 123.123, 456.456, 789.789);
    int a;
    double b;
    printf("%lu %lu", sizeof(a), sizeof(b));
}