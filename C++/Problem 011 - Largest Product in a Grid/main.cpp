#include <iostream>
#include <fstream>
#include <sstream>
#include <iterator>
#include <vector>
#include <string>

using namespace std;
vector<vector<string> > tokens;
vector<vector<int> > ival (20, vector<int>(20));

void read_inputfile()
{
	fstream inputfile;
	inputfile.open("inputfile");

	if (inputfile.is_open())
	{
		// File found 

		string line;
		while (getline(inputfile, line))
		{
			istringstream iss(line);
			tokens.push_back({ istream_iterator<string>{iss},
				istream_iterator<string>{} });
		}

		inputfile.close();

		for (int x = 0; x < tokens.size(); ++x)
		{
			for (int y = 0; y < tokens[x].size(); ++y)
			{
				ival[x][y] = stoi(tokens[x][y]);
			}
		}
	}
	else
	{
		cout << "Loading input file failed ... " << endl;
		///return;
	}
}

int highest_val = 0;

int main()
{
	read_inputfile();

	int val = 0;

	for (int x = 0; x < ival.size(); ++x)
	{
		for (int y = 0; y < ival[x].size(); ++y)
		{
			
			// Left
			if (x - 3 > 0)
			{
				val = ival[x - 3][y] * ival[x - 2][y] * ival[x - 1][y] * ival[x][y];
				if (val > highest_val) highest_val = val;
			}
			// Right
			if (x + 3 < ival.size())
			{
				val = ival[x + 3][y] * ival[x + 2][y] * ival[x + 1][y] * ival[x][y];
				if (val > highest_val) highest_val = val;
			}
			// Up
			if (y - 3 > 0)
			{
				val = ival[x][y - 3] * ival[x][y - 2] * ival[x][y - 1] * ival[x][y];
				if (val > highest_val) highest_val = val;
			}
			// Down
			if (y + 3 < ival[x].size())
			{
				val = ival[x][y + 3] * ival[x][y + 2] * ival[x][y + 1] * ival[x][y];
				if (val > highest_val) highest_val = val;
			}

			// DUpLeft
			if (x - 3 > 0 && y - 3 > 0)
			{
				val = ival[x][y] * ival[x - 1][y - 1] * ival[x - 2][y - 2] * ival[x - 3][y - 3];
				if (val > highest_val) highest_val = val;
			}
			// DDownLeft
			if (x - 3 > 0 && y + 3 < ival[x].size())
			{
				val = ival[x][y] * ival[x - 1][y + 1] * ival[x - 2][y + 2] * ival[x - 3][y + 3];
				if (val > highest_val) highest_val = val;
			}
			// DUpRight
			if (x + 3 < ival.size() && y - 3 > 0)
			{
				val = ival[x][y] * ival[x + 1][y - 1] * ival[x + 2][y - 2] * ival[x + 3][y - 3];
				if (val > highest_val) highest_val = val;
			}
			// DDownRight
			if (x + 3 < ival.size() && y + 3 < ival[x].size())
			{
				val = ival[x][y] * ival[x + 1][y + 1] * ival[x + 2][y + 2] * ival[x + 3][y + 3];
				if (val > highest_val) highest_val = val;
			}
		}
	}

	return 0;
}