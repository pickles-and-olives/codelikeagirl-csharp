namespace LendingLibrary.Models
{
    public class Library
    {   
        public string? Name { get; set; }
         public List<Novel> Novels{ get; set; }
         public List<TextBook> TextBooks{ get; set; }
         public List<Album> Albums{ get; set; }
         public List<AudioBook> AudioBooks{ get; set; }
         public List<Media> AllMedia{ get; set; }
        
        public Library(string name)
        {   Name = name;
            Novels = new List<Novel>();
            TextBooks = new List<TextBook>();
            Albums = new List<Album>();
            AudioBooks = new List<AudioBook>();
            AllMedia = new List<Media>();
        }

        public void listTextBooks()
        {
            Console.WriteLine("Textbooks available:");
            foreach(var TextBook in TextBooks)
            {
                TextBook.getTextBook();
            }
        }

        public void listNovels()
        {
            Console.WriteLine("Novels available:");
            foreach(var Novel in Novels)
            {
                Novel.getNovel();
            }
        }

        public void listAlbums()
        {
            Console.WriteLine("Albums available:");
            foreach(var Album in Albums)
            {
                Album.getAlbum();
            }
        }

        public void listAudioBooks()
        {
            Console.WriteLine("Audiobooks available:");
            foreach(var AudioBook in AudioBooks)
            {
                AudioBook.getAudioBook();
            }
        }
        public void listAllMedia()
        {
            Console.WriteLine("Here is a full list of what we have available:");
            Console.WriteLine("Textbooks:");
            foreach(var TextBook in TextBooks)
            {
                TextBook.getTextBook();
            }
            Console.WriteLine("");
            Console.WriteLine("Novels:");
            foreach(var Novel in Novels)
            {
                Novel.getNovel();
            }
            Console.WriteLine("");
            Console.WriteLine("Albums:");
            foreach(var Album in Albums)
            {
                Album.getAlbum();
            }
            Console.WriteLine("");
            Console.WriteLine("Audiobooks:");
            foreach(var AudioBook in AudioBooks)
            {
                AudioBook.getAudioBook();
            }
        }

        public void AddTextBook(TextBook textbook)
        {
            TextBooks.Add(textbook);
        }
        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }
        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }
         public void AddAudiobook(AudioBook audioBook)
        {
            AudioBooks.Add(audioBook);
        }       



    public void LibraryMenu()  
    {     
    while(true)
    {   Console.WriteLine("");
        Console.WriteLine($"Welcome to {Name} lending library!");
        Console.WriteLine("");
        Console.WriteLine("If you are looking for a particular type of media please select from the options below,");
        Console.WriteLine("or if you wish to view the full list please enter 'All'.");
        Console.WriteLine("To view available textbooks please enter 'Textbooks'");
        Console.WriteLine("To view available novels please enter 'Novels'");
        Console.WriteLine("To view available albums please enter 'Albums'");
        Console.WriteLine("To view available audiobooks please enter 'Audiobooks'");
        Console.WriteLine("To exit the program enter 'X'");

    var userInput = Console.ReadLine()!.ToLower().Trim();

    if(userInput == "x")
    {
        break;
    }
    if(userInput == "all")
    {
    listAllMedia();
    }
    if(userInput == "textbooks")
    {
    listTextBooks();
    }
    if(userInput == "novels")
    {
    listNovels();
    }
    if(userInput == "albums")
    {
    listAlbums();
    }
    if(userInput == "audiobooks")
    {
    listAudioBooks();
    }

    }
    }
    }
    }



 

