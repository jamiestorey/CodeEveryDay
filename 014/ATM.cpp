#include "ATM.h"
#include "ChangePrograms.h"
#include "Colourful.h"

Colourful Colourz;
ChangePrograms atmChangeP;
CONST static string CURRENCYZ = "jelly beans";


ATM::ATM()
{
	balance = 250;
}


ATM::~ATM()
{
}

void ATM::DisplayAtmWelcome()
{

	Colourz.setcolor(31);	cout << "Welcome to the ATM, select an action below:\n";
	Colourz.setcolor(3);	cout << "[1]---> Check Balance " << endl;
	Colourz.setcolor(4);	cout << "[2]---> Deposit " << CURRENCYZ << endl;
	Colourz.setcolor(5);	cout << "[3]---> Withdraw " << CURRENCYZ << endl;
	Colourz.setcolor(6);	cout << "[0]---> Change Program " << endl;

	cin >> userInput;
	switch (userInput)
	{
	case 1:
		Colourz.setcolor(197);	 cout << " Your balance is " << GetBalance() << " "
			<< CURRENCYZ << "\n" << endl;
		DisplayAtmWelcome();
		break;
	case 2:
		Colourz.setcolor(101);
		DepositMoney();
		break;
	case 3:
		Colourz.setcolor(201);
		WithdrawMoney();
		break;
	case 0:
		atmChangeP.SiwtchProgram();
	}

}

void ATM::DepositMoney()
{
	cout << "Enter the amount of " << CURRENCYZ << " that you'd like to desposit:" << endl;
	cin >> userDeposit;
	balance += userDeposit;
	DisplayAtmWelcome();

}
void ATM::WithdrawMoney()
{
	cout << "Enter the amount of " << CURRENCYZ << " that you'd like to withdraw:" << endl;
	cin >> userWithdraw;
	balance -= userWithdraw;
	DisplayAtmWelcome();
}

int ATM::GetBalance()
{
	return balance;
}
