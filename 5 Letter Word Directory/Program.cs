        string a = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/a.txt");
        string b = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/b.txt");
        string c = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/c.txt");
        string d = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/d.txt");
        string e = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/e.txt");
        string f = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/f.txt");
        string g = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/g.txt");
        string h = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/h.txt");
        string i = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/i.txt");
        string j = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/j.txt");
        string k = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/k.txt");
        string l = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/l.txt");
        string m = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/m.txt");
        string n = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/n.txt");
        string o = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/o.txt");
        string p = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/p.txt");
        string q = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/q.txt");
        string r = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/r.txt");
        string s = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/s.txt");
        string t = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/t.txt");
        string u = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/u.txt");
        string v = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/v.txt");
        string w = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/w.txt");
        string x = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/x.txt");
        string y = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/y.txt");
        string z = System.IO.File.ReadAllText(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/z.txt");


        Console.WriteLine("Enter the first letter of the word.");
        string userLetter = "";
        userLetter = Console.ReadLine()!;
        
        //userLetterFile = (@/Users/melissamcfadzien/Desktop/C#/5-letter words/z.txt)

        // Console.WriteLine($"5 letter words begining with {userLetter}:");
        // foreach(var word in userLetter)
        //     //Console.WriteLine(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/{'userLetter'}.txt");
        //     Console.WriteLine(@"/Users/melissamcfadzien/Desktop/C#/5-letter words/{userLetter}.txt", userLetter);
    

            switch(userLetter)
            {
                case "a":
                Console.WriteLine("5 letter words beggining with 'A'");
                Console.WriteLine("Contents of a.txt = {0}", a);
                break;
        
                case "b":
                Console.WriteLine("5 letter words beggining with 'B'");
                Console.WriteLine("Contents of b.txt = {0}", b);
                break;

                case "c":
                Console.WriteLine("5 letter words beggining with 'C'");
                Console.WriteLine("Contents of c.txt = {0}", c);
                break;

                case "d":
                Console.WriteLine("5 letter words beggining with 'D'");
                Console.WriteLine("Contents of d.txt = {0}", d);
                break;

                case "e":
                Console.WriteLine("5 letter words beggining with 'E'");
                Console.WriteLine("Contents of e.txt = {0}", e);
                break;

                case "f":
                Console.WriteLine("5 letter words beggining with 'F'");
                Console.WriteLine("Contents of f.txt = {0}", f);
                break;

                case "g":
                Console.WriteLine("5 letter words beggining with 'G'");
                Console.WriteLine("Contents of g.txt = {0}", g);
                break;

                case "h":
                Console.WriteLine("5 letter words beggining with 'H'");
                Console.WriteLine("Contents of h.txt = {0}", h);
                break;

                case "i":
                Console.WriteLine("5 letter words beggining with 'I'");
                Console.WriteLine("Contents of i.txt = {0}", i);
                break;
                
                case "j":
                Console.WriteLine("5 letter words beggining with 'J'");
                Console.WriteLine("Contents of j.txt = {0}", j);
                break;
                
                case "k":
                Console.WriteLine("5 letter words beggining with 'K'");
                Console.WriteLine("Contents of k.txt = {0}", k);
                break;                
                
                case "l":
                Console.WriteLine("5 letter words beggining with 'L'");
                Console.WriteLine("Contents of l.txt = {0}", l);
                break;                
                
                case "m":
                Console.WriteLine("5 letter words beggining with 'M'");
                Console.WriteLine("Contents of m.txt = {0}", m);
                break;                
                
                case "n":
                Console.WriteLine("5 letter words beggining with 'N'");
                Console.WriteLine("Contents of n.txt = {0}", n);
                break;                
                
                case "o":
                Console.WriteLine("5 letter words beggining with 'O'");
                Console.WriteLine("Contents of o.txt = {0}", o);
                break;                
                
                case "p":
                Console.WriteLine("5 letter words beggining with 'P'");
                Console.WriteLine("Contents of p.txt = {0}", p);
                break;                
                
                case "q":
                Console.WriteLine("5 letter words beggining with 'Q'");
                Console.WriteLine("Contents of q.txt = {0}", q);
                break;
                                
                case "r":
                Console.WriteLine("5 letter words beggining with 'R'");
                Console.WriteLine("Contents of r.txt = {0}", r);
                break;                
                
                case "s":
                Console.WriteLine("5 letter words beggining with 'S'");
                Console.WriteLine("Contents of s.txt = {0}", s);
                break;                
                
                case "t":
                Console.WriteLine("5 letter words beggining with 'T'");
                Console.WriteLine("Contents of t.txt = {0}", t);
                break;                
                
                case "u":
                Console.WriteLine("5 letter words beggining with 'U'");
                Console.WriteLine("Contents of u.txt = {0}", u);
                break;                
                
                case "v":
                Console.WriteLine("5 letter words beggining with 'V'");
                Console.WriteLine("Contents of v.txt = {0}", v);
                break;                
                
                case "w":
                Console.WriteLine("5 letter words beggining with 'W'");
                Console.WriteLine("Contents of w.txt = {0}", w);
                break;                
                
                case "x":
                Console.WriteLine("5 letter words beggining with 'X'");
                Console.WriteLine("Contents of x.txt = {0}", x);
                break;                
                
                case "y":
                Console.WriteLine("5 letter words beggining with 'Y'");
                Console.WriteLine("Contents of y.txt = {0}", y);
                break;                
                
                case "z":
                Console.WriteLine("5 letter words beggining with 'Z'");
                Console.WriteLine("Contents of z.txt = {0}", z);
                break;

                default:
                Console.WriteLine("Please enter a letter of the alphabet in lowercase");
                break;
            }
    
        

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

        
        // Display the file contents by using a foreach loop.
        //Console.WriteLine("a.txt = ");
        //foreach (word in lines)
        //{
            // Use a tab to indent each line of the file.
        //    Console.WriteLine("\t" + line);
        //}



        // Display the file contents to the console. Variable text is a string.
       // Console.WriteLine($"Five letter words that start with {userLetter} = {0}", @"/Users/melissamcfadzien/Desktop/C#/5-letter words/{userLetter}.txt");