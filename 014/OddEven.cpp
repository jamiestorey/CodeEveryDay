#include "OddEven.h"
#include "Colourful.h"
#include "ChangePrograms.h"

using namespace std;

Colourful Colors;
string userInputBegin;
ChangePrograms cp;


OddEven::OddEven()
{
}


OddEven::~OddEven()
{
}


void OddEven::DisplayOddEvenInfo()
{
	Colors.setcolor(17);	cout << "Welcome to the Odd Even Program" << endl;
	Colors.setcolor(18);	cout << "Enter in a number that is not 0 and then..." << endl;
	Colors.setcolor(19);	cout << "...I will tell you if it is odd or even and..." << endl;
	Colors.setcolor(21);	cout << "I'll explain why it's either odd or even!" << endl;
	Colors.setcolor(22);	cout << "Enter \"start\" to beign :D" << endl;

	cin >> userInputBegin;


	if (userInputBegin == "exit" || userInputBegin == "Exit")
	{
		exit(0);
	}
	else
	{
		Colors.setcolor(23);	cout << "Enter a number:";
		cin >> userInputOddEven;

		while (userInputOddEven != 0)
		{
			if (userInputOddEven % 2 == 0)
			{
				Colors.setcolor(24); cout << userInputOddEven << " is even because it can be diveded by 2 and returns a whole number :D" << endl;
			}
			else
			{
				Colors.setcolor(24); cout << userInputOddEven << " is odd because I said so!" << endl;
			}

			Colors.setcolor(23);	cout << "Enter another number:";
			cin >> userInputOddEven;
		}

		if (userInputOddEven == 0)
		{
			cout << "\n\n" << endl;
			Colors.setcolor(3);
			cp.SiwtchProgram();
		}
	}
}
