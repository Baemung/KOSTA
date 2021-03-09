#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <sys/uio.h>
#include "MyHeader.h"

#define NUM 2

int get_Min(int *arr, int n);
int* int_Sort(int *arr, int n);
int get_GCD(int a, int b);
int* get_CD(int a);
void ASCII_Table();
int* Prompt(const char *pt, int *ret);
int chrPos_v1(const char *str, char chr);
int chrPos_v2(const char *str, char chr);
int* strPos(const char *str1, const char *str2);

typedef struct{
    char name[20];
    int kor;
    int math;
    int eng;
    int rank;
    int mean;
    int sum;
} Score;

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
/*  아스키코드 테이블
    ASCII_Table();
*/
/*  표준 입출력
    char str1[30];
    char str2[10];

    fputs("Input the string of number : ", stdout);
    fgets(str2, sizeof(str2), stdin);
    strcat(str1, str2);
    printf("생성된 문자열 : %s", str1);
    printf("변환된 숫자열 : %d", atoi(str1));
*/
/*  문자열 처리 함수
    int a, b, *c;
    Prompt("A를 입력하세요. : ", &a);
    c = Prompt("B를 입력하세요. : ", &b);
    printf("A : %d\nB : %d\nC : %d\n", a, b, *c);
    if(&b == c){
        printf("same");
    }
    else{
        printf("not");
    }
*/
/*  포인터 매개변수로 주고 리턴받기
    scanf와 fgets의 차이 : scanf는 여러 타입의 자료형을 입력받음.
                        fgets은 문자열만 쭉 받아서 캐릭터 버퍼에 때려넣고 되돌려줌.
                        stdin은 특별한 케이스이고, 보통은 파일데이터를 입출력 한다.

    char str1[100];
    char str2[20];
    int idx[20];

    fputs("str1을 입력하세요 : ", stdout);
    fgets(str1, sizeof(str1), stdin);
    fputs("str2를 입력하세요 : ", stdout);
    fgets(str2, sizeof(str2), stdin);

    int* ch = strPos(str1, str2, idx);
    for(int i = 0; i < strlen(str2)-1; i++){
        printf("%c 의 위치 : %d\n", *(str2+i), *(ch+i));
    }
*/
/*  파일 입출력
    파일 입출력을 하기위해서는 데이터를 주고 받을 수 있는 스트림을 생성해야한다.
    FILE* fopen(const char* filename, const char* mode)
    FILE* : file manager; 성공시 파일 포인터 반환, 실패시 NULL 포인터 반환.
    mode : 파일 접근 모드 + 데이터 입,출력 모드
    r(read;읽기), w(write;쓰기, 기존 파일 내용 날려버림), a(append;추가, 기존 파일 뒤에 내용 추가)
    r+, w+, a+ (데이터 입출력 모드를 추가 지정 '+' 자리에는 t와 b가 올 수 있다.)
    t:텍스트 모드(디폴트), b:바이너리 모드
    CR(\r) : Cariage Return(커서를 가장 앞으로 리턴)
    LF(\n) : Line Feed(줄바꿈)

    파일 구조체
    - 데이터 입,출력 함수 호출
    - 위치 정보 참조
    - 파일의 끝 확인

    파일의 종결
    int fclose(FILE* stream) : 정상적으로 종류되면 0을 리턴 (꼭 해줘야 함)

    FILE *fa = fopen("test.txt", "wb");
    char buf1[20];
    char buf2[20];
    scanf("%s", buf1);
    fprintf(fa, "%s", buf1);
    fclose(fa);

    FILE *fr = fopen("test.txt", "rb");
    fscanf(fr, "%s", buf2);
    printf("%s", buf2);
    fclose(fr);
*/
/*  파일 구조체로 성적입력받고 파일에 저장, 파일에서 성적읽어서 출력
*/
    FILE *fw = fopen("score.txt", "wb");
    Score *s = (Score*)malloc(sizeof(Score)*NUM);
    int i, j, k;

    printf("성적을 입력합니다.\n");
    for (i=0; i < NUM; i++){
        printf("이름을 입력하세요 : "); scanf("%s", s[i].name);
        printf("국어성적을 입력하세요 : "); scanf("%d", &s[i].kor);
        printf("수학성적을 입력하세요 : "); scanf("%d", &s[i].math);
        printf("영어성적을 입력하세요 : "); scanf("%d", &s[i].eng); 
        printf("\n");
        s[i].sum = s[i].kor+s[i].math+s[i].eng;
        s[i].mean = s[i].sum/3;
    }

    char temp_name[20];
    int temp_kor;
    int temp_math;
    int temp_eng;
    int temp_sum;
    int temp_mean;
    for(i = 0; i < NUM-1; i++){   
       for(j = i; j < NUM; j++){   
            if(s[i].sum < s[j].sum){
                strcpy (temp_name, s[j].name);
                temp_kor = s[j].kor;
                temp_math = s[j].math;
                temp_eng = s[j].eng;
                temp_sum = s[j].sum;
                temp_mean = s[j].mean;

                strcpy (s[j].name, s[i].name);
                s[j].kor = s[i].kor;
                s[j].math = s[i].math;
                s[j].eng = s[i].eng;
                s[j].sum = s[i].sum;
                s[j].mean = s[i].mean;

                strcpy (s[i].name, temp_name);
                s[i].kor = temp_kor;
                s[i].math = temp_math;
                s[i].eng = temp_eng;
                s[i].sum = temp_sum;
                s[i].mean = temp_mean;
            }
        }   
    }

    for (i = 0; i < NUM; i++){
        s[i].rank = i+1;
        fprintf(fw, "%s %d %d %d %d %d %d\r\n", s[i].name, s[i].kor, s[i].math, s[i].eng, s[i].sum, s[i].mean, s[i].rank);
    }
    fclose(fw);

    char name[20];
    int kor, math, eng, sum, mean, rank;
    FILE *fr = fopen("score.txt", "rb");
    printf(" 이름   국어 수학 영어 총점 평균 등수\n");
    for(i = 0; i < NUM; i++){
        fscanf(fr,"%s %d %d %d %d %d %d\r\n", name, &kor, &math, &eng, &sum, &mean, &rank);
        printf("%s   %d   %d   %d  %d   %d   %d\n", name, kor, math, eng, sum, mean, rank);
    }
    fclose(fr);
    return 0;
}