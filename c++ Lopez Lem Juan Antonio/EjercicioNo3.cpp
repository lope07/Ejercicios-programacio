#include <iostream>
#include <vector>
using namespace std;
int main() {
    int size;
   cout << "Escriba el tamanio del vector: ";
   cin >> size;
   vector<int> vec(size);
   
    for (int i = 0; i < size; ++i) {
        cout << "Digite el valor para la posicion " << i + 1 << ": ";
        cin >> vec[i];
        vec[i] = max((vec[i] % 2 == 0) ? vec[i] + 1 : vec[i] - 2, 0);
    }
    
    cout << "\nMuestra datos originales y mejora:\n";
    for (int i = 0; i < size; ++i) {
        cout << "Dato en la posicion " << i + 1 << ": " << vec[i] << endl;
    }
    return 0;
}

