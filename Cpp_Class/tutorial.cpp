#include <iostream>
#include <math.h>

using namespace std;

class Point{
private:
public:
    int x;
    int y;
};

class Rect{
private:
public:
    Point p1;
    Point p2;
    int area();
    double dist(Point pt1, Point pt2);
};

int Rect::area(){
    return abs(p1.x-p2.x)*abs(p1.y-p2.y);
}

double Rect::dist(Point pt1, Point pt2){
    return sqrt((pt1.x-pt2.x)*(pt1.x-pt2.x)+(pt1.y-pt2.y)*(pt1.y-pt2.y));
}

class RectEx: public Rect{
    /*
    class Rect의 모든 내용이 class RectEx안에 있다라고 생각하면 됨.
    */
private:
   Point p3 = {p1.x, p2.y};
   Point p4 = {p2.x, p1.y};
public:
   double tLength();
};

double RectEx::tLength(){
    double sl1 = dist(p1,p3), sl2 = dist(p1,p4), sl3 = dist(p2,p3), sl4 = dist(p2,p4);
    return sl1+sl2+sl3+sl4;
}

int main(){
    RectEx r;

    cout<<fixed; 
    cout.precision(2);

    cout<<"Point A : "; cin>>r.p1.x>>r.p1.y;
    cout<<"Point B : "; cin>>r.p2.x>>r.p2.y;
    cout<<"Aria is "<<r.area()<<"\nDistance is "<<r.tLength()<<endl;

    return 0;
}