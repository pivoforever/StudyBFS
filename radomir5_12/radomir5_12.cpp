// radomir5_12.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"

#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
using namespace std;


int main()
{
	ifstream fin;
	fin.open("INPUT.txt");
	if (!fin)
	{
		cout << "File no found";
		exit(1);
	}
	int n, k;
	fin >> n >> k;

	int* read = new int[2*n + 1];
	for (int i = 1; i <= 2 * n; i++)
	{
		fin >> read[i];
	}
	int **graph = new int*[n + 1];
	/*for (int i = 2; i <= n; i += 2)
	{
		graph[i] = new int[(i / 2) - i];
		for (int j = 1; j <= i/2; i++)
			graph[i][j] = read[i] - read[j*2 - 1];

	}
	for (int i = 3; i <= n; i += 2)
	{
		graph[i] = new int[2];
		graph[i][1] = 0;
	}
	cout << graph[4][1];*/
	return 0;
}