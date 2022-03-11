#include <Windows.h>
#include <iostream>
#include "line.h"
#include "angle.h"
#include "triangle.h"
#include "circle.h"
#include "segments.h"

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	printf("Введите количество отрезков от 1 до %d: ", segments::getmaxn());//вызов статического метода
	segments sm1;
	sm1.vvod();
	sm1.totalvivod();
	return 0;
}