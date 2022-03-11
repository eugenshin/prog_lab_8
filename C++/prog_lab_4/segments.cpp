#define _CRT_SECURE_NO_WARNINGS
#include "segments.h"
#include <iostream>

void segments::vvod()
{
	while ((scanf("%d", &n) < 1)||(n<1)||(n>MAXN)) {
		while (getchar() != '\n');
		printf("���������� �������� ������� �������.\n");
	}
	ptrline = new line[n];
	for (int i = 0; i < n; i++) {
		printf("������� ���������� ����� ������ � ����� ������� %d: ",i);
		ptrline[i].vvod();
	}
	return;
}

void segments::totalvivod()
{
	for (int i = 0; i < n; i++) {
		printf("������� %d:\n",i);
		ptrline[i].vivod();
		printf("\n");
	}
	return;
}

void segments::vivod(int i)
{
	if ((i >= 0) && (i < n)) {
		printf("������� %d:\n",i);
		ptrline[i].vivod();
		return;
	}
	printf("\n����� ������� ����� �������.");
	return;
}

float segments::totallength()
{
	float sum = 0;
	for (int i = 0; i < n; i++) {
		sum += ptrline[i].length();
	}
	return sum;
}

float segments::length(int i)
{
	if ((i >= 0) && (i < n))
		return ptrline[i].length();
	return -1;
}

int segments::getmaxn()
{
	return MAXN;
}