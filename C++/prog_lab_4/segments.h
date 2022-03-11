#pragma once
#include "line.h"

class segments
{
	static const int MAXN = 100;
	int n;
	line* ptrline;
public:
	void vvod();
	void totalvivod();
	void vivod(int i);
	float totallength();
	float length(int i);
	static int getmaxn();
};