#include <iostream>

using namespace std;

static long total = 0;
static long limit = 4000000;

static void nextFib(long x, long y)
{
    x += y;
            
    cout << "\n" << y;
    if (x > limit) return;
    else
    {
        if (x % 2 == 0) total += x;
        nextFib(y, x);
    }
}

int main()
{
	nextFib(1, 2);

    cout << "\nDONE : " << total + 2; // Add 2 because the nextFib skips the first 2 that's entered
    return 0;
}