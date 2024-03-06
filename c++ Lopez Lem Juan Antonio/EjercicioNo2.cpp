#include<iostream>
using namespace std;
int main(){
int vector [5]={1,2,3,4,5};
double total=0;
double promedio=0;
double porcentaje25=0;

for (int i=0;i<5;i++){
     total+=vector [i];
}
promedio=total/5;
porcentaje25=total/4;
cout<<"total: "<<total<<endl;
cout<<"promedio: "<<promedio<<endl;
cout<<"porcentaje 25: "<<porcentaje25<<endl;

return 0;
}
