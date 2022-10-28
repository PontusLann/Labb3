using ClassLibrary1;
using System.Text;


string localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

string pathToLabb3Folder = Path.Combine(localAppDataFolder, "Labb3");





void Alternatives()
{
    Console.WriteLine("-lists");
    Console.WriteLine("-new <list name> <language 1> <language 2> .. <langauge n>");
    Console.WriteLine("-add <list name>");
    Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
    Console.WriteLine("-words <listname> <sortByLanguage>");
    Console.WriteLine("-count <listname>");
    Console.WriteLine("-practice <listname>");
}

string input = string.Empty;

do
{

    Console.WriteLine();
    Console.WriteLine("Here are your alternatives! If you wish to exit simply write an empty string!");
    Console.WriteLine();
    Alternatives();
    Console.WriteLine();

    input = Console.ReadLine().ToLower();
    string[] inputToArray = input.Split(" ");

    if (input != string.Empty)
    {
        Console.Clear();
    }

    switch (inputToArray[0])
    {
        case "-lists":
            Console.WriteLine("Here are the existing files:");
            foreach (var list in WordList.GetLists())
            {
                Console.WriteLine(list);
            }
            break;
        case "-new":
            if (inputToArray.Length >= 4)
            {
                string currentPathNew = Path.Combine(pathToLabb3Folder, inputToArray[1]);

                if (!File.Exists(currentPathNew))
                {

                    using (FileStream fs = File.Create(currentPathNew + ".dat"))
                    {
                        byte[] buffer = new UTF8Encoding(true).GetBytes($"{string.Join(";", inputToArray.Skip(2))}");
                        fs.Write(buffer, 0, buffer.Length);
                    }
                    Console.WriteLine("Which words do you want to add to your new list?");
                    add();
                }
                else
                {
                    Console.WriteLine("File \"{0}\" already exists.", currentPathNew);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            break;
        case "-add":


            void add()
            {
                string currentPathAdd = Path.Combine(pathToLabb3Folder, inputToArray[1]);
                Console.Clear();
                WordList addWord = WordList.LoadList(currentPathAdd);
                int stringCountInInputArray = 0;
                int addedWords = 0;
                string addWords = string.Empty;
                List<string> lists = new List<string>();
                for (int i = 0; i < addWord.Languages.Length; i++)
                {
                    stringCountInInputArray++;
                    Console.WriteLine($"add word in current language {addWord.Languages[i]}");
                    addWords = Console.ReadLine();
                    lists.Add(addWords);
                    addedWords++;
                }

                if (addWords != string.Empty)
                {

                    addWord.Add(lists.ToArray());
                    addWord.Save();
                    Console.WriteLine($"You have succesfully added words to the file");
                    Thread.Sleep(1000);
                    add();
                }
                else
                {
                    Console.WriteLine("You have exited add mode");
                }

            }
            if (inputToArray.Length == 2)
            {
                try
                {

                    add();
                }
                catch
                {
                    Console.WriteLine("File does not exist!");
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }



            break;
        case "-remove":

            if (inputToArray.Length >= 4)
            {
                string currentPathRemove = Path.Combine(pathToLabb3Folder, inputToArray[1]);

                try
                {
                    WordList removeWord = WordList.LoadList(currentPathRemove);
                    int currentLanguage = 0;

                    for (int i = 0; i < removeWord.Languages.Length; i++)
                    {
                        if (inputToArray[2] == removeWord.Languages[i])
                        {
                            currentLanguage = i;
                        }
                    }

                    for (int j = 3; j < inputToArray.Length; j++)
                    {
                        if (removeWord.Remove(currentLanguage, inputToArray[j]))
                        {
                            Console.WriteLine($"Your words {inputToArray[j]} have been removed");
                            removeWord.Save();
                        }
                        else
                        {
                            Console.WriteLine($"{inputToArray[j]} does not exist in this list");
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("File does not exist.", currentPathRemove);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            break;
        case "-words":

            if (inputToArray.Length == 2 || inputToArray.Length == 3)
            {
                string currentPathWords = Path.Combine(pathToLabb3Folder, inputToArray[1]);

                try
                {
                    WordList sortList = WordList.LoadList(currentPathWords);

                    int currentLanguage = 0;

                    if (inputToArray.Length == 2)
                    {
                        currentLanguage = 0;
                    }
                    else
                    {

                        for (int i = 0; i < sortList.Languages.Length; i++)
                        {
                            if (inputToArray[2] != sortList.Languages[i])
                            {
                                currentLanguage = i;
                            }
                        }
                    }

                    Console.WriteLine(string.Join("\t", sortList.Languages));

                    sortList.List(currentLanguage, translations => Console.WriteLine(string.Join("\t", translations)));
                }
                catch
                {
                    Console.WriteLine("File does not exist.", currentPathWords);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            break;
        case "-count":

            if (inputToArray.Length == 2)
            {
                string currentPathCount = Path.Combine(pathToLabb3Folder, inputToArray[1]);
                try
                {
                    WordList countList = WordList.LoadList(currentPathCount);

                    Console.WriteLine($"{currentPathCount}.dat contains {countList.Count()} words");
                }
                catch
                {
                    Console.WriteLine("File does not exist.", currentPathCount);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
            break;
        case "-practice":

            if (inputToArray.Length == 2)
            {
                string currentPathPractice = Path.Combine(pathToLabb3Folder, inputToArray[1]);

                try
                {
                    WordList getListToPractice = WordList.LoadList(currentPathPractice);
                    int correctCount = 0;
                    float guessed = 0;
                    float percentage = 0.0f;
                    string userInput = string.Empty;
                    Console.WriteLine("Welcome to practice mode!");
                    Console.WriteLine("To exit practice mode simply write an empty string");
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"number of guesses: {guessed}");
                        Word practice = getListToPractice.GetWordToPractice();
                        Console.WriteLine($"Translate {practice} to {getListToPractice.Languages[practice.ToLanguage]}");
                        userInput = Console.ReadLine().Trim().ToLower();

                        if (userInput == practice.Translations[1])
                        {
                            Console.WriteLine("Eureccca!");
                            correctCount++;
                            guessed++;
                            Thread.Sleep(800);
                        }

                        if (userInput != practice.Translations[1] && userInput != string.Empty)
                        {
                            Console.WriteLine("Wrong!");
                            guessed++;
                            Thread.Sleep(800);
                        }

                    } while (userInput != String.Empty);
                    Console.Clear();
                    percentage = correctCount / guessed;
                    Console.WriteLine("You have ended practice mode!");
                    Console.WriteLine($"You had {percentage * 100:f0}% correct answers");

                }
                catch
                {
                    Console.WriteLine("File does not exist.", currentPathPractice);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }


            break;

        default:
            if (input == string.Empty)
            {
                Console.WriteLine("See you later!");
            }
            else
            {

                Console.WriteLine("Something went wrong try again!");
            }
            Console.WriteLine();
            break;
    }
} while (input != string.Empty);










