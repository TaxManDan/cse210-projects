# Mindfulness Program Instructions

This program allows users to choose 1 of 3 mindfullness activity to participate in
to help them be more mindful and unwind from the fast-paced world. The opportunities
given to the users are a breathing activity, a reflecting activing and a listing activity. 
After the user chosen an activity it will display the activity's name and descripition and
will prompt the user for a duration and then will run the activity for the duration. After
the activity it will display the duration of the activity they completed and it will store
it in the log with the current date and time. They can view the log from the main menu. If
you want to reset the log you have to manually delete all the lines in the log.csv file. 

To achieve this functionality the program is split into 5 classes and a csv file:

- `Program.cs` - Displays the menu of activities for the user to chose from and loads from the log.
- `log.csv` - Stores a log of the activities the user has completed with the duration and current date and time.
- `Activity.cs` - Displays the common start and end messages as well as countdown and loading spinner. Also logs the activities to the log file.
- `BreathingActivity.cs` - Displays a breathe in and out cycle for the inputed duration.
- `ReflectingActivity.cs` - Selects a prompt for the user to reflect then asks questions to help guide the reflecting for the chosen duration.
-  `ListingActivity.cs` - Selects and displays a prompt for the user to list as many responses as possible in the chosen duration.
