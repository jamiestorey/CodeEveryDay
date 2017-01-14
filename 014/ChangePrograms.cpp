#include "ChangePrograms.h"
#include "Colourful.h"
#include "ATM.h"
#include "OddEven.h"

using namespace std;
ATM atm;
OddEven oddeven;


ChangePrograms::ChangePrograms()
{
}


ChangePrograms::~ChangePrograms()
{
}

void ChangePrograms::SiwtchProgram()
{
	Colourful Colours;
	Colours.setcolor(31);	cout << "To switch programs, enter the value of the program and hit enter:\n";
	Colours.setcolor(2);	cout << "[1]---> ATM Machine\n";
	Colours.setcolor(3);	cout << "[2]---> Odd & Even Numbers\n";
	Colours.setcolor(5);	cout << "[3]---> Colourful :D\n";
	Colours.setcolor(4);	cout << "[0]---> EXIT" << endl;

	cin >> inputSelectedProgram;

	switch (inputSelectedProgram)
	{
		//switch to ATM
	case 1:
		Colours.setcolor(2);
		atm.DisplayAtmWelcome();
		break;
		//switch to OddEven
	case 2:
		oddeven.DisplayOddEvenInfo();
		break;

		//switch to colourful loop
	case 3:
		Colours.setcolor(5);
		Colours.LoopColours();
		break;
	}
}
