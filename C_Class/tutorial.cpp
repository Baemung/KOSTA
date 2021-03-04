#include <stdio.h>
#include <string.h>
#include "MyHeader.h"

int main()
{   
/*  변수
    int a, b, c, d;
    a = 1, b = 1, c = 1, d = 1;
    printf("%d %d %d %d\n", a++, ++b, c--, --d);
    printf("%d %d %d %d", a, b, c, d);
*/
/*  논리 연산자
    int a = 10, b = 20;
    if(a > 5 && a < 10){
        printf("YES");
    }
    else{
        printf("NO");
    }
*/
/*  분기문/반복문
    //while loop
    int a = 1, b = 10, result = 0;
    int idx;
    while (a <= b)    {
        result += a++;
        idx++
    }
    printf("%d %d", result, idx);
*/
/*  for loop
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
/*  switch - case
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
*/
/*  함수
    int n; scanf("%d", &n); Fib(n);
    for(int i = 1; i <= n; i++){
        printf("%d\n", f[i]);
    }
*/
/*
    int i, j ,k; //후에 사용할 임시 변수들 선언
    char key; //입력받을 변수 선언
    while (1){
        printf("key 입력 : ");
        scanf(" %c", &key); //변수 입력 받음
        Func(key); //변수를 함수의 매개변수로 전달 
        if(key == 'Z'){ //Z를 누르면 반복 중단
            break;
        }
    }
*/
/*  배열
    int i = 0;
    char buffer[100];
    scanf("%s", buffer);
    while(buffer[i]){
        if(buffer[i] >= 'a' && buffer[i] <= 'z'){
            buffer[i] -= 32;
        }
        printf("%c", buffer[i]);
        i++;
    }
*/
/*  포인터
*/
    char buffer[100];
    int key;
    scanf("%s", buffer); scanf("%d", &key);
    printf("%c", buffer[key]);
    return 0;
}