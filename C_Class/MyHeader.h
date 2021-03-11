#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int get_Fib(int a){
    int f[101];
    if(a <= 2){
        f[a] = 1;
    }
    else if(f[a] == 0){
        f[a] = get_Fib(a-1)+get_Fib(a-2);
    }
    return f[a];
}

void get_type(char k){
    if(k >= '0' && (int)(k) <= '9'){
        printf("숫자");
    }
    else if(k >= 'A' && (int)(k) <= 'Z'){
        printf("대문자");
    }
    else if(k >= 'a' && (int)(k) <= 'z'){
        printf("소문자");
    }
    else{
        printf("특수문자");
    }
    printf("\n");
}

int get_Min(int *arr, int n){
    int min_ = arr[0];
    for(int i = 1; i < n; i++){
        if(min_ > arr[i]){
            min_ = arr[i];
        }
    }
    return min_;
}

void swap(int *a, int *b){
    int temp = *a;
    *a = *b;
    *b = temp;
}

int* int_Sort(int *arr, int n){
    for(int i = 0; i < n-1; i++){
        for(int j = i+1; j < n; j++){
            if(*(arr+i) > *(arr+j)){
                swap(arr+i, arr+j); // swap(&arr[i], &arr[j])과 동일
            }
        }
    }
    return arr;
}

int get_GCD(int a, int b){
    int min_ = a > b ? b : a;
    int max_ = a > b ? a : b;
    while (min_ != 0)
    {
        int temp = max_;
         max_ = min_;
         min_ = temp % min_;
    }
    return max_;
}

int* get_CD(int a){
    int arr[100];
    int *ptr = arr;
    int idx = 0;
    for(int i = 1; i <= a; i++){
        if(a%i == 0){
            ptr[++idx] = i;
        }
    }
    ptr[0] = idx;
    return ptr;
}

void ASCII_Table(){
    int i, j;
    printf("\n\t\t\t\tASCII CODE TABLE\n");
    for(i = 0; i <= 4; i++){
        printf("-----------------");
    }
    printf("\n|   Dec   Hc   Char  |");
    for(i = 0; i < 3; i++){
        printf("  Dec    Hc   Char  |");
    }
    printf("\n");
    for(i = 0; i < 32; i++){
        for(j = 0; j <= 4; j++){
            printf("-----------------");
        }
        printf("\n|");
        for(j = i; j <= i+96; j += 32){
            if(j < 32 || j == 127){
                printf(" %4d   %3x    **   |", j, j);
            }
            else{
                printf(" %4d   %3x  %3c    |", j, j, j);
            }
        }
        printf("\n");
    }
    for(i = 0; i <= 4; i++){
        printf("-----------------");
    }
    printf("\n");
}


int* Prompt(const char *pt, int *ret){
    char buffer[254];
    printf("%s", pt);
    fgets(buffer, sizeof(buffer), stdin);
    *ret = atoi(buffer);
    return ret;
}

/*
    함수명 : int chrPos(const char *str, char chr);
    return type : int : 파라미터 chr의 위치, 없다면 -1.
    input : char *str : 대상 문자열.
            char chr  : 찾을 문자.
    기능 : str으로 전달된 문자열 중에서 chr 문자의 위치를 검색하여 해당 위치를 반환(zero base).
          검색되지 않으면, -1을 반환.
*/
int chrPos_v1(const char *str, char chr){
    int i, j, k;
    i = 0;
    while (*(str+i)){
        if(*(str+i++) == chr){
            return i-1;
        }
    }
    return -1;
}

int chrPos_v2(const char *str, char chr){
    int i, j, k;
    for(i = 0; *(str+i); i++){
        if(*(str+i) == chr){
            return i;
        }
    }
    return -1;
}

int* strPos(const char *str1, const char *str2, int *idx){
    int i, j, k, p;
    for(i = 0; i < strlen(str2); i++){
        *(idx+i) = chrPos_v1(str1, *(str2+i));
    }
    return idx;
}