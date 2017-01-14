#include <string>
#include <iostream>
#include "Windows.h"
#include "ChangePrograms.h"
#include "Colourful.h"
#include "ATM.h"


using namespace std;

Colourful Colours;
ChangePrograms changeP;

int main()
{
	
	Colours.setcolor(7); cout << 
    "\t\tWelcome to my collection of C++ Programs!\t\t\t\n\n";
    
    cout << "Testing" << endl;

	changeP.SiwtchProgram();


	return 0;
}
