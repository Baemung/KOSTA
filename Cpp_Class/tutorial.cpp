#include <iostream>
#include <math.h>

#define PI 3.14

using namespace std;

class Point{
private:
    int x;
    int y;
public:
    Point(int x, int y){
        this->x = x;
        this->y = y;;
    }
    void SetX(int x){
        this->x = x;;
    }
    void SetY(int y){
        this->y = y;;
    }
    int GetX(){
        return x;
    }
    int GetY(){
        return y;
    }
    Point MoveP(int n);
};

Point Point::MoveP(int n){
    Point tempP(x+n, y+n);
    return tempP;
}

class Rect: public Point{
private:
    Point p1;
    Point p2;
public:
    Rect(int x1, int y1, int x2, int y2): Point(x1, y1){
        this->p1 = Point(x1, y1);
        this->p2 = Point(x2, y2);
    }
    double dist(Point pt1, Point pt2);
};

double Rect::dist(Point pt1, Point pt2){
    return sqrt((pt1.x-pt2.x)*(pt1.x-pt2.x)+(pt1.y-pt2.y)*(pt1.y-pt2.y));
}

//Circle클래스 정의, 멤버 함수 구현
//멤버함수: 지름(diameter), 둘레(Clen), 면적(area)
class Circle: public Rect{
private: 
    double r;
public:
    Circle(Point pt1, Point pt2) : Rect(pt1,pt2){
        r = dist(pt1, pt2)/2;
    }
    double diameter();
    double Clen();
    double area();
};

double Circle::diameter(){
    return 2*r;
}

double Circle::Clen(){
    return 2*PI*r;
}

double Circle::area(){
    return PI*r*r;
}

int main(){
    Point p1,p2;
    cout<<"Point A : "; cin>>p1.x>>p1.y;
    cout<<"Point B : "; cin>>p2.x>>p2.y;
    Circle c(p1,p2);
    cout<<"지름 : "<<c.diameter()<<"\n둘레 : "<<c.Clen()<<"\n넓이 : "<<c.area()<<endl;
    return 0;
}