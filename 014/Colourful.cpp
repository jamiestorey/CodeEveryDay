#include "Colourful.h"
#include "ChangePrograms.h"


using namespace std;

Colourful::Colourful()
{

}


Colourful::~Colourful()
{
}

void Colourful::LoopColours()
{
	int input = 1;
	int sleepy = 0;
	setcolor(88);  cout << "Enter how long to loop through colours or type EXIT to quit.\n";
	setcolor(11); cout << "Once the loop starts, you'll have to wait for it to finish or close the program to exit!";
	cout << endl;

	cin >> input;
	if (input == 0)
	{
		exit(0);
	}
	else
	{
		setcolor(55);  cout << "Type how fast the loop will be in milliseconds:" << endl;
		cin >> sleepy;

		for (int i = 0; i < input; i++)
		{
			Sleep(sleepy);
			/*setcolor(i);  cout << "\t" << "i = " << i;
			setcolor(i + 1);  cout << "\t";
			setcolor(i * 5);  cout << "\t";
			setcolor(i + 7);  cout << "\t";*/

			setcolor(i);		cout << "\t" << "i = " << i;
			setcolor(i + 1);	cout << "\t";
			setcolor(i * 5);	cout << "\t";
			setcolor(i - 2);	cout << "\t" << "X_x";
			setcolor(11 * i);	cout << "\t" << "x_X";
		}
		setcolor(2);
		cout << "\n" << endl;

		ChangePrograms Switchy;
		Switchy.SiwtchProgram();
	}
}