#include <iostream>

int main()
{
	int sum = 0;
    int sqrSum = 0;
    for (int i = 1; i <= 100; i++)
    {
        sum += i * i;
        sqrSum += i;
    }
            
    int difference = (sqrSum*sqrSum) - sum;
	std::cout << "Sum : " << sum << "\nSqrSum : " << sqrSum << "\nDifference : " << difference << std::endl;
	return 0;
}