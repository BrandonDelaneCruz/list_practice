using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    public abstract class Dice
    {
        public string Name { get; set; }
        public int NumberOfDice { get; set; } = 1;
        public List<int> NumbersRolled { get; set; }
        public int SumRolledNumber { get; set; }
    }

    public class D4 : Dice
    {
        public D4(int numberOfDiceSelected)
        {
            Name = "4 Sided Dice";
            NumberOfDice = numberOfDiceSelected; 
            NumbersRolled = DiceHelper.RollDice(4, NumberOfDice);
            SumRolledNumber = NumbersRolled.Sum();
        }
    }

    public class D6 : Dice
    {
        public D6(int numberOfDiceSelected)
        {
            Name = "6 Sided Dice";
            NumberOfDice = numberOfDiceSelected;
            NumbersRolled = DiceHelper.RollDice(6, NumberOfDice);
            SumRolledNumber = NumbersRolled.Sum();
        }
    }

    public class D8 : Dice
    {
        public D8(int numberOfDiceSelected)
        {
            Name = "8 Sided Dice";
            NumberOfDice = numberOfDiceSelected;
            NumbersRolled = DiceHelper.RollDice(8, NumberOfDice);
            SumRolledNumber = NumbersRolled.Sum();
        }
    }

    public class D10 : Dice
    {
        public D10(int numberOfDiceSelected)
        {
            Name = "10 Sided Dice";
            NumberOfDice = numberOfDiceSelected;
            NumbersRolled = DiceHelper.RollDice(10, NumberOfDice);
            SumRolledNumber = NumbersRolled.Sum();
        }
    }

    public class D12 : Dice
    {
        public D12(int numberOfDiceSelected)
        {
            Name = "12 Sided Dice";
            NumberOfDice = numberOfDiceSelected;
            NumbersRolled = DiceHelper.RollDice(12, NumberOfDice);
            SumRolledNumber = NumbersRolled.Sum();
        }
    }

    public class D20 : Dice
    {
        public D20(int numberOfDiceSelected)
        {
            Name = "20 Sided Dice";
            NumberOfDice = numberOfDiceSelected;
            NumbersRolled = DiceHelper.RollDice(20, NumberOfDice);
            SumRolledNumber = NumbersRolled.Sum();
        }
    }

    public class D100 : Dice
    {
        public D100(int numberOfDiceSelected)
        {
            Name = "100 Sided Dice";
            NumberOfDice = numberOfDiceSelected;
            NumbersRolled = DiceHelper.RollDice(100, NumberOfDice);
            SumRolledNumber = NumbersRolled.Sum();
        }
    }

    
}
