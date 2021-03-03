#include <stdio.h>
#include <ctype.h>

int main()
{   
/*  변수 사용 
    int a, b, c, d;
    a = 1, b = 1, c = 1, d = 1;
    printf("%d %d %d %d\n", a++, ++b, c--, --d);
    printf("%d %d %d %d", a, b, c, d);
*/
/* 논리 연산자
    int a = 10, b = 20;
    if(a > 5 && a < 10){
        printf("YES");
    }
    else{
        printf("NO");
    }
*/
/* 분기문/반복문
    //while loop
    int a = 1, b = 10, result = 0;
    int idx;
    while (a <= b)    {
        result += a++;
        idx++
    }
    printf("%d %d", result, idx);
*/
/*
    //for loop
    int a, b, result_Odd = 0, result_Even = 0;
    printf("a부터 b까지의 홀수합과 짝수합\n");
    printf("a : "); scanf("%d", &a);
    printf("b : "); scanf("%d", &b);
    for(int i = a; i <= b; i++){
        if(i%2 == 0){ //짝수
            result_Even += i;
        }
        else{ //홀수
            result_Odd += i;
        }
    }
    printf("%d ~ %d 까지의 홀수합 = %d, 짝수합 = %d\n", a, b, result_Odd, result_Even);
*/
    //switch - case
    for(int i = 0; i < 10; i++){
        switch (i)
        {
            case 1:
                printf("One");
                break;
            case 2:
                printf("Two");
                break;
            case 3:
                printf("Three");
                break;
            case 4:
                printf("Four");
                break;
            case 5:
                printf("Five");
                break;
            case 6:
                printf("Six");
                break;
            case 7:
                printf("Seven");
                break;
            case 8:
                printf("Eight");
                break;
            case 9:
                printf("Nine");
                break;
            case 0:
                printf("Zero");
                break;
        }
        printf("\n");
    }
    return 0;
}