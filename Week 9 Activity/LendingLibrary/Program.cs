using LendingLibrary.Models;

//Create Objects

//textbooks
var textbook1 = new TextBook("Science 101", "J. Smith", 2003, "Science");
var textbook2 = new TextBook("Basics of Photography", "Elizabeth Doyle", 2012, "Photography");

//novels
var novel1 = new Novel("Vile Bodies", "Evelyn Waugh", 1930, "Satire");
var novel2 = new Novel("The Handmaid's Tale", "Margaret Atwood", 1985, "Science Fiction");

//albums
var album1 = new Album("A Moon Shaped Pool", "Radiohead", 11, 2016);
var album2 = new Album("Dear Annie", "Rejjie Snow", 20, 2018);

//audiobooks
var audiobook1 = new AudioBook("The Tales of Beatrix Potter - Remastered", "Beatrix Potter", "Vivien Leigh", 6, 2012);
var audiobook2 = new AudioBook("The War of the Worlds (2012 recording)", "H.G. Wells", "Maxwell Caulfield", 51, 2012);

var Library = new Library("Melissa's");

Library.AddTextBook(textbook1);
Library.AddTextBook(textbook2);
Library.AddNovel(novel1);
Library.AddNovel(novel2);
Library.AddAlbum(album1);
Library.AddAlbum(album2);
Library.AddAudiobook(audiobook1);
Library.AddAudiobook(audiobook2);


Library.LibraryMenu();