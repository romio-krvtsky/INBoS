#include <iostream>
#include <fstream>
#include <string>

#define SIZE 26
#define FIRST 'a'
#define KEY 3

using namespace std;

void caesar(string&);
void decaesar(string&);
void read_write(string, string, void (*func)(string&));


int main()
{
	read_write("input.txt", "output1.txt", caesar);
	read_write("output1.txt", "output2.txt", decaesar);

	return 0;
}

void caesar(string& s) {
	for (size_t i = 0; i < s.length(); i++)
	{
		bool isletter = (tolower(s[i]) >= FIRST) && (tolower(s[i]) < FIRST + SIZE);
		if (!isletter) continue;
		unsigned char x, y;
		bool up = 0;
		if (isupper(s[i])) {
			x = tolower(s[i]);
			up = 1;
		}
		else x = s[i];
		y = (x - FIRST + KEY) % SIZE;
		s[i] = y + FIRST;
		if (up) s[i] = toupper(s[i]);
	}
}

void decaesar(string& s) {
	for (size_t i = 0; i < s.length(); i++)
	{
		bool isletter = (tolower(s[i]) >= FIRST) && (tolower(s[i]) < FIRST + SIZE);
		if (!isletter) continue;
		unsigned char x, y;
		bool up = 0;
		if (isupper(s[i])) {
			x = tolower(s[i]);
			up = 1;
		}
		else x = s[i];
		y = (x - FIRST - KEY + SIZE) % SIZE;
		s[i] = y + FIRST;
		if (up) s[i] = toupper(s[i]);
	}
}

void read_write(string in, string out, void (*func)(string&)) {
	ifstream fin(in);
	ofstream fout(out);

	if (!fin)
	{
		cerr << in + " could not be opened for reading!" << endl;
		return;
	}

	if (!fout)
	{
		cerr << out + " could not be opened for writing!" << endl;
		return;
	}

	while (fin)
	{
		string strInput;
		getline(fin, strInput);
		func(strInput);
		fout << strInput << endl;
	}

	fin.close();
	fout.close();
}