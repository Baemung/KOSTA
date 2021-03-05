#include <stdio.h>

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
            if(arr[i] > arr[j]){
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