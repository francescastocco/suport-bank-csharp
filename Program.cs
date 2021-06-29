using System;
using System.IO;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines("./Transactions2014.csv");
            
            foreach (var line in file) {
                var cells = line.Split(",");
                
            }

            for(int i = 1; i < file.Length; i++) {
                var cells = file[i].Split(",");
                int amountFloat = int.Parse(cells[4]);

                var transaction = new Transaction(cells[0], amountInt, cells[3], cells[1], cells[2], i);


                cells.push(
                    new Transaction {}
                )
            }
          
        }

    }

}

