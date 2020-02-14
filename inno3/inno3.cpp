// inno3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
#include <fstream>

using namespace std;

const int maxReb = 100;
const int maxVert = 100;
const int maxLength = 100;

void printD();

int n, m, q, p;
int Reb[maxReb + 1][3];
bool Dinam[maxLength + 1][maxVert + 1];
ifstream input("input.txt");

int main()
{
	input >> n >> m >> q >> p;
	for (int i = 1; i <= m; i++)
	{
		input >> Reb[i][0] >> Reb[i][1] >> Reb[i][2];
	}
	for (int i = 1; i <= m; i++)
	{
		for (int j = 0; j < 3; j++)
			cout << Reb[i][j] << "\t";
		cout << endl;
	}
	cout << endl;
	for (int i = 0; i <= maxLength; i++)
	{
		for (int j = 0; j <= maxVert; j++)
			Dinam[i][j] = false;
	}
	Dinam[0][1] = true;
	for (int j = 2; j <= n; j++)
	{
		for (int i = 1; i <= q; i++)
			for (int k = 1; k <= m; k++)
				if ((Reb[k][1] == j) && (i - Reb[k][2] >= 0) && (Dinam[i - Reb[k][2]][Reb[k][0]] == true)) Dinam[i][j] = true;
	}
	printD();
	return 0;
}

void printD()
{
	for (int i = 0; i <= q; i++)
	{
		for (int j = 1; j <= n; j++)
			cout << Dinam[i][j] << "\t";
		cout << endl;
	}
}
