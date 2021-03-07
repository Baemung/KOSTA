#include <stdio.h>
#include <string.h>
#include "MyHeader.h"

int get_Min(int *arr, int n);
int* int_Sort(int *arr, int n);
int get_GCD(int a, int b);
int* get_CD(int a);
void ASCII_Table();

typedef struct{
    char name[20];
    char phone[20];
    int age;
} person;

typedef union{
    int d1;
    double d2;
    char d3;
} u_data;

typedef enum{
    mon, tue, wed, thu, fri, sat, sun
} week;

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
/*  인덱싱
    char buffer[100];
    int key;
    scanf("%s", buffer); scanf("%d", &key);
    printf("%c", buffer[key]);
*/
/*  포인터
    arr 자체를 변화시키지 않고 ex) arr++ or arr+1 은 X
    arr의 위치를 컨트롤할 수 있는 *pArr를 pArr = arr로 배열의 주소를 받아서 pArr를 더하거나 빼거나 하는것을 추천

    int a;
    int *Pa = &a;
    void *vp;
    int arr[5] = {0,1,2,3,4};
    int *pArr;
    pArr = arr;

    printf("a = %08x\n", &a);
    printf("*Pa = %08x\n\n", Pa);

    a = 1000;
    printf("a = %d = %08x\n", a, &a);
    printf("*Pa = %d = %08x\n\n", *Pa, Pa);
    
    a++;
    printf("a = %d = %08x\n", a, &a);
    printf("*Pa = %d = %08x\n\n", *Pa, Pa);
    
    vp = Pa++;
    printf("a = %d = %08x\n", a, &a);
    printf("*Pa = %d = %08x\n", *Pa, Pa);
    printf("*vp= %08x\n\n", vp);
    for(int i = 0; i < 5; i++){
        printf("%d\n", pArr[i]);
    }
*/ 
/*  포인터 매개변수
    int n;
    printf("배열 사이즈 입력 : ");
    scanf("%d", &n);

    int *arr, i;
    for(i = 0; i < n; i++){
        printf("%d번째 값 (%d/%d) : ", i+1, i+1, n);
        scanf("%d", &arr[i]);
    }
    printf("배열의 최솟값 : %d\n\n", get_Min(arr, n));

    arr = int_Sort(arr, n);
    printf("정렬 후 배열\n");
    for(i = 0; i < n; i++){
        printf("%d번째 값 (%d/%d) : %d\n", i+1, i+1, n, arr[i]);
    }

    int a, b;
    printf("최대 공약수를 구할 두 수를 입력하세요 : ");
    scanf("%d %d", &a, &b);
    int gcd = get_GCD(a, b);
    printf("%d와 %d의 최대공약수는 %d\n", a, b, gcd);
    printf("최대공약수 %d의 약수는 ", gcd);
    int *cd = get_CD(gcd);
    for(int i = 1; i <= *cd; i++){
        printf("%d ", *(cd+i));
    }    
*/
/*  포인터 배열
    int a = 10, b = 20, c = 30;
    int *arr[10] = {&a, &b, &c};
    const char *str[10] = {
        "abc", 
        "abc", 
        "abc"
    };
*/
/*  함수 포인터/void 포인터
    //함수 포인터
    int (*fget_Min)(int *arr, int n);
    int *(*fint_Sort)(int *arr, int n);
    fget_Min = get_Min;
    fint_Sort = int_Sort;

    //void 포인터
    int n1 = 10;
    float n2 = 3.5f;
    char c = 'a';
    void *ptr;
    ptr = &n1; //n1의 메모리 주소를 void 포인터 ptr에 저장
    printf("%d\n", *(int *)ptr); //void 포인터를 int 포인터로 변환한 뒤 역참조
    ptr = &n2; //n2의 메모리 주소를 void 포인터 ptr에 저장
    printf("%f\n", *(float *)ptr); // void 포인터를 float 포인터로 변환한 뒤 역참조
    ptr = &c; //c의 메모리 주소를 void 포인터 ptr에 저장
    printf("%c\n", *(char *)ptr); //void 포인터를 char 포인터로 변환한 뒤 역참조
*/
/*  구조체 : 독립적인 데이터 공간, 구조체 배열, 구조체 포인터

    struct person p[5] = {};
    for(int i = 0; i < 5; i++){
        printf("name : %s\n", p[i].name);
        printf("phone : %s\n", p[i].phone);
        printf("age : %d\n\n", p[i].age);
    }

    person pm = {"qoansrb", "01023328874", 29};
    person *pMan;
    pMan = &pm;
    //구조체 변수
    printf("name : %s\n", pm.name);
    printf("phone : %s\n", pm.phone);
    printf("age : %d\n\n", pm.age);
    //구조체 포인터1
    printf("name : %s\n", (*pMan).name);
    printf("phone : %s\n", (*pMan).phone);
    printf("age : %d\n\n", (*pMan).age);
    //구조체 포인터2
    printf("name : %s\n", pMan->name);
    printf("phone : %s\n", pMan->phone);
    printf("age : %d\n\n", pMan->age);
*/
/*  공용체(유니언) : 메모리 공간 공유

    union data;
*/
/*  열거형

    week w;
*/  
    ASCII_Table();
    return 0;
}
