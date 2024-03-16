# Eternal Quest Program Instructions

## About the Program
This Program allows users to make 3 types of goals, which are: Simple Goals, Eternal Goals,
and Checklist Goals. Each goal has a name, a description, a point value, and a
boolean to indicate if it has been accomplished. The program will allow the user to
add goals, view goals, and record goal events. When you record an event you will get 
the point value of the goal added to your score. If it is a checklist goal and you hit the bonus 
count you get bonus points as well. There is a reward shop that allows you to purchase reward items 
you create for completing your goals.



To achieve this functionality the progam is split into 8 classes and a txt file.

- `Program.cs` - Displays the Menu and allows the user to add, view, and record goals.
- `Goal.cs` - Base class for Goals
- `SimpleGoal.cs` - Inheirits from Goal class and morphs to support simple goals like checking if goal is accomplished
- `EternalGoal.cs` - Inheirits from Goal class and morphs to support eternal goals like not marking goals as complete
- `ChecklistGoal.cs` - Inheirits from Goal class and morphs to support checklist goals by adding bonus points when bonus count is hit
- `File.cs` - Allows you to save and load the data to a .txt file.
- `Pointshop.cs` - Displays a list of items you can buy, you inventory, and allows you to buy and redeem items.
- `Item.cs` - Stores item attributes like name, cost, shop quantity and inventory quantity.
- `Test.txt` - Save File that saves the score, goals, and items.




