using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lane> lanes = new List<Lane>();

            lanes.Add(new Lane(0, false, ConsoleColor.White, false, false, 0f, ' ', Utils.colorsCars.ToList()));
            lanes.Add(new Lane(1, true, ConsoleColor.Blue, false, true, 0.9f, Utils.charLogs, Utils.colorsLogs.ToList()));
            lanes.Add(new Lane(2, true, ConsoleColor.Blue, false, true, 0.8f, Utils.charLogs, Utils.colorsLogs.ToList()));
            lanes.Add(new Lane(3, true, ConsoleColor.Blue, false, true, 0.8f, Utils.charLogs, Utils.colorsLogs.ToList()));
            lanes.Add(new Lane(4, true, ConsoleColor.Blue, false, true, 0.7f, Utils.charLogs, Utils.colorsLogs.ToList()));
            lanes.Add(new Lane(5, true, ConsoleColor.Blue, false, true, 0.7f, Utils.charLogs, Utils.colorsLogs.ToList()));
            lanes.Add(new Lane(6, false, ConsoleColor.White, false, false, 0f, ' ', Utils.colorsCars.ToList()));
            lanes.Add(new Lane(7, false, ConsoleColor.Black, true, false, 0.06f, Utils.charCars, Utils.colorsCars.ToList()));
            lanes.Add(new Lane(8, false, ConsoleColor.Black, true, false, 0.05f, Utils.charCars, Utils.colorsCars.ToList()));
            lanes.Add(new Lane(9, false, ConsoleColor.Black, true, false, 0.04f, Utils.charCars, Utils.colorsCars.ToList()));
            lanes.Add(new Lane(10, false, ConsoleColor.Black, true, false, 0.04f, Utils.charCars, Utils.colorsCars.ToList()));
            lanes.Add(new Lane(11, false, ConsoleColor.Black, true, false, 0.03f, Utils.charCars, Utils.colorsCars.ToList()));
            lanes.Add(new Lane(12, false, ConsoleColor.White, false, false, 0f, ' ', Utils.colorsCars.ToList()));

            Player player = new Player();

            while (true)
            {
                //inputs
                
                Utils.GAME_STATE gameState = Utils.GAME_STATE.RUNNING;
                Vector2Int inputDir = Utils.Input();
                gameState = player.Update(inputDir, lanes);

                //lógica
                if (gameState == Utils.GAME_STATE.WIN)
                {
                    Console.WriteLine("Congratulations! Has ganado!");
                    break;
                }
                else if (gameState == Utils.GAME_STATE.LOOSE)
                {
                    Console.WriteLine("Game Over! Has perdido!");
                    break;
                }
                //Mapa dibujado
                foreach (Lane lane in lanes)
                {
                    lane.Update();
                    lane.Draw();
                }

                player.Draw();
                TimeManager.NextFrame();
            }

            Console.WriteLine("Escribe algo para cerrar el programa:");
            string nombre = Console.ReadLine();
        }

    }
    
}
