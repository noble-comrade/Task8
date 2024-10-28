string pathToRead = "C:\\Users\\prdb\\Desktop\\someProject123\\file.txt";
string pathToWrite = "C:\\Users\\prdb\\Desktop\\someProject123\\answer.txt";
int result = 0;

StreamReader reader = new StreamReader(pathToRead);
StreamWriter writer = new StreamWriter(pathToWrite);

string[] phrase = reader.ReadLine().Split(" ");

if (phrase[1] == "+") result = Convert.ToInt32(phrase[0]) + Convert.ToInt32(phrase[2]);
if (phrase[1] == "-") result = Convert.ToInt32(phrase[0]) - Convert.ToInt32(phrase[2]);
if (phrase[1] == "*") result = Convert.ToInt32(phrase[0]) * Convert.ToInt32(phrase[2]);
if (phrase[1] == "/") result = Convert.ToInt32(phrase[0]) / Convert.ToInt32(phrase[2]);

writer.WriteLine(Convert.ToString(result));
Console.WriteLine(result);