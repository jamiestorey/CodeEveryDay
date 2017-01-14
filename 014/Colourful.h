#pragma once
#include <string>
#include <iostream>
#include "Windows.h"
class Colourful
{
public:
	Colourful();
	~Colourful();

	void setcolor(unsigned short color)
	{
		HANDLE hcon = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hcon, color);
	}

	void LoopColours();
	void TimeInput();

};

