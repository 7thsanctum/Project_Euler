// Multiples of 3 and 5.cpp : Defines the entry point for the console application.
//
# include <iostream>

using  namespace std;

int main()
{
	int total = 0;
    for (int i = 0; i < 1000; i++) 
		if (i % 3 == 0 || i % 5 == 0) total += i;

	cout << "Total : " << total << "\n";
	
	return 0;
}

