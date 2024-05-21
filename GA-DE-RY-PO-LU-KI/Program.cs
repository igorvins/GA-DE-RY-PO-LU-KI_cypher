
using System.Globalization;

string input = "ABCD";

//ENCODING -------------------------------------------------------------------------

//convert string in array:
char[] str = input.ToCharArray();

//define dict of encode:
Dictionary<char,char> pairs = new Dictionary<char, char>
{
    {'G','A'},{'g','a'},{'A','G'},{'a','g'},
    {'D','E'},{'d','e'},{'E','D'},{'e','d'},
    {'R','Y'},{'r','y'},{'Y','R'},{'y','r'},
    {'P','O'},{'p','o'},{'O','P'},{'o','p'},
    {'L','U'},{'l','u'},{'U','L'},{'u','l'},
    {'K','I'},{'k','i'},{'I','K'},{'i','k'}
};
//iterate through array to change letters:
char[] array_2 = new char[str.Length];
for (int i=0; i<str.Length; i++)
{
    char c = str[i]; 
    if (pairs.ContainsKey(c))
    {
        array_2[i] = pairs[c];
    }
    else 
    {
        array_2[i] = c;
    }
}
//convert the array into string again:
string enconded_phrase = new string(array_2);
Console.WriteLine(enconded_phrase);

//DECODING -------------------------------------------------------------------------

//convert string in array:
char[] str2 = enconded_phrase.ToCharArray();

//define dict of encode:
Dictionary<char, char> pairs2 = new Dictionary<char, char>
{
    {'G','A'},{'g','a'},{'A','G'},{'a','g'},
    {'D','E'},{'d','e'},{'E','D'},{'e','d'},
    {'R','Y'},{'r','y'},{'Y','R'},{'y','r'},
    {'P','O'},{'p','o'},{'O','P'},{'o','p'},
    {'L','U'},{'l','u'},{'U','L'},{'u','l'},
    {'K','I'},{'k','i'},{'I','K'},{'i','k'}
};
//iterate through array to change letters:
char[] array_4 = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    char c = str2[i];
    if (pairs.ContainsKey(c))
    {
        array_4[i] = pairs2[c];
    }
    else
    {
        array_4[i] = c;
    }
}
//convert the array into string again:
string decoded_phrase = new string(array_4);
Console.WriteLine(decoded_phrase);