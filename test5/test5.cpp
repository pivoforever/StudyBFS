#include "pch.h"
#include <iostream>
#include <string>

using namespace std;

int a = 10;
double b = 20.5;
bool c = true;
char d = 'A';
string abc = "А это я учусь!!!";

double square(int a, int b, int c)
{
	return a*a+b*b+c*c;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	b = square(4, 5, 6);
	cout << "Переменная а:"<<a << endl;
	cout << b << endl;
	cout << c << endl;
	cout << d << endl;
	cout << abc<<endl;
    cout << "Hello World!\n"; 
}




