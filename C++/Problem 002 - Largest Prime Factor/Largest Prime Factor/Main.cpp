#include <iostream>

using namespace std;

int main()
{
	long long number = 600851475143L;
    //int number = 360;
    long long temp = number;
    long long largestPrime = 2;

    do{
        if (temp % largestPrime == 0)
        {
            temp = temp / largestPrime;
        }
        else
        {
            if (temp != 1)
            {
                int count = 0;
                // Find next prime
                for (long long i = number; count == 0; i--)
                {
					if(temp % 2 == 0)
					{
						continue;
					}
                    for (int k = 2; k < i; k += 2)
                    {
                        if (i % k == 0)
                        {
                            break;
                        }
                        else if (k + 1 == i)
                        { 
                            largestPrime = i;
							cout << "Largest prime : " << largestPrime << "\n";
							return 0;
                            count++;
                        }
                    }

                }
                count = 0;
            }
        }
    }while(temp > 2);
            
	cout << "Largest prime : " << largestPrime << "\n";

	return 0;
}