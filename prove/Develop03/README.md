# Scripture Memorization program Instructions

This program allows users to read scriptures from a correctly formatted .txt file
and allows them to select one or have one randomly selected to memorize by hiding
words every time they hit enter until the whole scripture is hidden.

To achieve this functionality the program is split into 4 classes and a txt file:

- `Program.cs` - Reads the scriptures.txt into a list of scriptures and presents a list of scripture references to select.
- `scripturest.txt` - Stores a list of scriptures each formatted on their own line.
- `Scripture.cs` - Takes the reference and scripture and splits them up into their different parts for other classes, hides and displays the scripture.
- `Reference.cs` - Stores the different parts of the reference and displays the reference.
- `Word.cs` - Takes a word and stores it and replaces all the characters with underscores when the word is hidden.
