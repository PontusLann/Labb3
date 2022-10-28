namespace ClassLibrary1
{
    public class WordList : Word
    {
        private List<Word> words = new List<Word>();

        public string Name { get; }

        public static string[] _language;

        public string[] Languages => _language;

        static string localAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        static string pathToLabb3Folder = Path.Combine(localAppDataFolder, "Labb3");

        public WordList(string name, string[] languages)
        {
            Name = name;
            _language = languages;

        }

        public static string[] GetLists()
        {
            var filesInFolder = Directory.GetFiles(pathToLabb3Folder);

            List<string> fileName = new List<string>();

            for (int i = 0; i < filesInFolder.Length; i++)
            {
                string[] FilePath = new string[6];
                FilePath = filesInFolder[i].Split("\\");

                if (filesInFolder[i].EndsWith(".dat"))
                {
                    fileName.Add(FilePath[6].Substring(0, FilePath[6].Length - 4));
                }
            }

            string[] ofn = new string[fileName.Count];
            fileName.CopyTo(ofn);
            return ofn;

        }


        public static WordList LoadList(string name)
        {

            List<string> rowsInFiles = new List<string>();

            string currentFile = Path.Combine(pathToLabb3Folder, name + ".dat");


            using (var wordReader = new StreamReader(currentFile))
            {
                string[] langugageInFile = wordReader.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                WordList newList = new WordList(name, langugageInFile);

                while (!wordReader.EndOfStream)
                {
                    string lines = wordReader.ReadLine();
                    rowsInFiles = lines.Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
                    newList.Add(rowsInFiles.ToArray());
                }

                return newList;

            }
        }

        public void Save()
        {
            string currentFile = Path.Combine(localAppDataFolder, "Labb3", $"{Name}.dat");

            using (StreamWriter sw = new StreamWriter(currentFile))
            {
                sw.WriteLine(string.Join(';', Languages));

                foreach (Word words in words)
                {
                    sw.WriteLine(string.Join(";", words.Translations));
                }
            }
        }

        public void Add(params string[] translations)
        {

            if (translations.Length != Languages.Length)
            {
                throw new Exception("added words must match languages");
            }
            else
            {
                words.Add(new Word(translations));
            }

        }

        public bool Remove(int translation, string word)
        {

            string currentFile = Path.Combine(localAppDataFolder, "Labb3", $"{Name}.dat");

            string wordToLower = word.ToLower();

            for (int i = 0; i < words.Count; i++)
            {

                if (this.words[i].Translations[translation].Equals(wordToLower))
                {
                    List<string> removeTextInFile = File.ReadAllLines(currentFile).ToList();

                    removeTextInFile.RemoveAt(i + 1);
                    File.WriteAllLines(currentFile, removeTextInFile);

                    words.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }

        public int Count()
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            string currentFile = Path.Combine(localAppDataFolder, "Labb3", $"{Name}.dat");

            var sortContent = words.OrderBy(sort => sort.Translations[sortByTranslation]);

            foreach (var words in sortContent)
            {
                showTranslations(words.Translations);
            }

        }

        public Word GetWordToPractice()
        {
            Random rand = new Random();
            int fromLanguage = rand.Next(Languages.Length);
            int toLanguage = rand.Next(Languages.Length);
            int randomWord = rand.Next(words.Count);

            while (fromLanguage == toLanguage)
            {
                toLanguage = rand.Next(Languages.Length);
            }

            Word practiceWords = new Word(fromLanguage, toLanguage, words[randomWord].Translations[fromLanguage], words[randomWord].Translations[toLanguage]);

            return practiceWords;
        }

    }


}





