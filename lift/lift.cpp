// lift.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
#include <algorithm>
#include <fstream>

int floors_walked(int previous, int current);
int optimize_floor();
void reconstruct_path(int lastfloor, int stops_to_go);

const int NFLOORS = 110; /* высота здания в этажах */
const int MAX_RIDERS = 50; /* вместимость лифта */
int stops[MAX_RIDERS]; /* кто на каком этаже выходит */
int nriders; /* количество пассажиров */
int nstops; /* число разрешенных остановок */
int m[NFLOORS + 1][MAX_RIDERS]; /* таблица стоимости */
int p[NFLOORS + 1][MAX_RIDERS]; /* таблица родительских
элементов */

using namespace std;


int main()
{
	ifstream fInput;
	fInput.open("input.txt");
	fInput>> nriders;
	fInput >> nstops;
	for (int i = 1; i <= nriders; i++)
	{
		fInput >> stops[i];
	}
	int lastfloor=optimize_floor();
	reconstruct_path(lastfloor, nstops);
	fInput.close();
}

int floors_walked(int previous, int current)
{
int nsteps = 0; /* общее пройденное расстояние */
int i; /* счетчик */
for (i = 1; i <= nriders; i++)
	if ((stops[i] > previous) && (stops[i] <= current))
		nsteps += min(stops[i] - previous, current -
			stops[i]);
	return(nsteps);
}

int optimize_floor()
{
int i, j, k; /* счетчики */
int cost; /* стоимость */
int laststop; /* последняя остановка лифта */
for (i = 0; i <= NFLOORS; i++)
{
	m[i][0] = floors_walked(0,INT_MAX);
	p[i][0] = -1;
}
for (j = 1; j <= nstops; j++)
for (i = 0; i <= NFLOORS; i++)
	{
		m[i][j] = INT_MAX;
		for (k = 0; k <= i; k++) {
			cost = m[k][j - 1] - floors_walked(k, INT_MAX) +
				floors_walked(k, i) + floors_walked(i, INT_MAX);
			if (cost < m[i][j]) {
				m[i][j] = cost;
				p[i][j] = k;
			}
		}
	}
	laststop = 0;
	for (i = 1; i <= NFLOORS; i++)
	if (m[i][nstops] < m[laststop][nstops])
		laststop = i;
	return(laststop);
}

void reconstruct_path(int lastfloor, int stops_to_go)
{
	if (stops_to_go > 1)
		reconstruct_path(p[lastfloor][stops_to_go], stops_to_go - 1);
	cout << lastfloor << endl;
}

