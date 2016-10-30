#include <iostream>

using namespace std;

const long long number = 600851475143L;

bool isPrime(long long x)
{
    if(x != 1 || x % 2 == 0)
    {
        for(long long i = 3; i <= x/2; i += 2)
        {
            if(x % i == 0)
            {
                return false;
            }
        }
    }
    else
    {
        return false;
    }

    return true;
}

int main()
{
    long long temp = number;
    long long largestPrime = 2;
    for(long long i = 1; i < number/2; i += 2)
    {
        if(number % i == 0)
        {
            if (isPrime(i))
            {
                if(i >= largestPrime)
                {
                    largestPrime = i;
                    cout << "Largest prime : " << largestPrime << "\n";
                }                
            }
        }
    }

    cout << "Largest prime : " << largestPrime << "\n";
    cout << "FINISHED" << endl;
    return 0;
}