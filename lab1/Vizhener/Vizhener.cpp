#include <iostream>
#include <fstream>
#include <string>

#define SIZE 26
#define FIRST 'a'
#define KEY "lemon"

using namespace std;

void vizhener(string&, string);
void devizhener(string&, string);
void read_write(string, string, void (*func)(string&, string));

int main()
{
	read_write("input.txt", "output1.txt", vizhener);
	read_write("output1.txt", "output2.txt", devizhener);

	return 0;
}

void vizhener(string& s, string key) {
	for (size_t i = 0, j = 0; i < s.length(); i++)
	{
		bool isletter = (tolower(s[i]) >= FIRST) && (tolower(s[i]) < FIRST + SIZE);
		if (!isletter) continue;

		unsigned char x, y, k;
		bool up = 0;

		if (isupper(s[i])) {
			x = tolower(s[i]);
			up = 1;
		}
		else x = s[i];

		k = tolower(key[j % key.length()]) - FIRST;
		j++;
		y = (x - FIRST + k) % SIZE;
		s[i] = y + FIRST;

		if (up) s[i] = toupper(s[i]);
	}
}

void devizhener(string& s, string key) {
	for (size_t i = 0, j = 0; i < s.length(); i++)
	{
		bool isletter = (tolower(s[i]) >= FIRST) && (tolower(s[i]) < FIRST + SIZE);
		if (!isletter) continue;

		unsigned char x, y, k;
		bool up = 0;

		if (isupper(s[i])) {
			x = tolower(s[i]);
			up = 1;
		}
		else x = s[i];

		k = tolower(key[j % key.length()]) - FIRST;
		j++;
		y = (x - FIRST - k + SIZE) % SIZE;
		s[i] = y + FIRST;

		if (up) s[i] = toupper(s[i]);
	}
}

void read_write(string in, string out, void (*func)(string&, string)) {
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
		func(strInput, KEY);
		fout << strInput << endl;
	}

	fin.close();
	fout.close();
}