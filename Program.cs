// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace Project_1 {
    class MainClass {

       
        public static void Main (string[] args) {
             List<char> Grid = new List<char>();
             for(int i=0; i<9; i++){
                 int val = i+49;
                 
                 Grid.Add(Convert.ToChar(val));
             }
             char turn = 'x';
            
        Console.WriteLine(" ");


while(true){

 displayGrid(Grid);
 Console.Write($"{turn}'s turn to choose a square (1-9): ");
 string inputChoice =Console.ReadLine();
Console.WriteLine(" ");
int change = int.Parse(inputChoice)-1;
if(Grid[change] == turn){
    Console.WriteLine("That isn't how you play!");
    break;
}
Grid[change] = turn;
if(turn =='x'){
    turn = 'O';
}
else{
    turn = 'x';
}
bool condition = false;
condition = checkGrid(Grid);
if(condition == true){
    Console.WriteLine("Thanks for playing!");
    break;
}

}
          

        }
        static void displayGrid(List<char> Grid){
            for(int i=0; i<9;i++){
                if(i==2||i==5){
                Console.WriteLine($"{Grid[i]}");
                if(i!=9){
                Console.WriteLine($"-+-+-");
                }
                }
                else{
                    if(i!=8){
Console.Write($"{Grid[i]}|");
                }else{
                    Console.WriteLine($"{Grid[i]}");  
                    Console.WriteLine(" ");
                }
                }
                
         }

    }
static bool checkGrid(List<char> Grid){
    // if(){}
    bool isGame = false;
    for(int i=0; i<9; i=i+3){
isGame = checkslots(Grid, i,(i+1),(i+2));
if(isGame==true){
return true;
}}

    for(int i = 0; i<3; i++){
isGame = checkslots(Grid, i,(i+3),(i+6));
if(isGame==true){
return true;

}}
isGame = checkslots(Grid, 0, 4, 8);
if(isGame==true){
return true;
}
isGame = checkslots(Grid, 2,4,6);
if(isGame==true){
return true;

}

return false;
}
static bool checkslots(List<char> Grid, int i, int j, int k){


if(Grid[i] == Grid[j] && Grid[i] == Grid[k]){
    return true;
    }
    else{
        return false;
    }
}


    }
         
}