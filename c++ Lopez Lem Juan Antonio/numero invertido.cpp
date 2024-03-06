#include <iostream>
using namespace std;

int main() {
    int num, a = 0, b;
    cout << "Digite un numero: ";
    cin >> num;

    while (num != 0) {
        b = num % 10;
        a = a * 10 + b;
        num /= 10;
    }

   
    if (a < 10) {
        cout << "El numero invertido es: 0" << a << endl;
    } else {
        cout << "El numero invertido es: " << a << endl;
    }

    return 0;
}

