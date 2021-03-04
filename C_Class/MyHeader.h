#include <stdio.h>
int f[101];

int Fib(int a){
    if(a <= 2){
        f[a] = 1;
    }
    else if(f[a] == 0){
        f[a] = Fib(a-1)+Fib(a-2);
    }
    return f[a];
}

void Func(char k){
    if(k >= '0' && int(k) <= '9'){
        printf("숫자");
    }
    else if(k >= 'A' && int(k) <= 'Z'){
        printf("대문자");
    }
    else if(k >= 'a' && int(k) <= 'z'){
        printf("소문자");
    }
    else{
        printf("특수문자");
    }
    printf("\n");
}