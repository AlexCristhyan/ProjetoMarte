using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Helper
{
    public class Helper
    {

        public string MoveResult(string directions, string positionStart)
        {
            List<char> moves = new List<char>();

            moves.AddRange(directions);

            var positionsStart = positionStart.Split(' ');
            var x = Convert.ToInt32(positionsStart[0]);
            var y = Convert.ToInt32(positionsStart[1]);
            var directionInit = positionsStart[2];

            for (int i = 0; i < moves.Count; i++)
            {
                if (moves.ElementAt(i).ToString() == "M")
                {
                    switch (directionInit)
                    {
                        case "N":
                            y++;
                            break;
                        case "W":
                            x--;
                            break;
                        case "S":
                            y--;
                            break;
                        case "E":
                            x++;
                            break;
                        default:
                            break;
                    }
                }
                else if (moves.ElementAt(i).ToString() == "L")
                {
                    switch (directionInit)
                    {
                        case "N":
                            directionInit = "W";
                            break;
                        case "W":
                            directionInit = "S";
                            break;
                        case "S":
                            directionInit = "E";
                            break;
                        case "E":
                            directionInit = "N";
                            break;
                        default:
                            break;
                    }

                }
                else if (moves.ElementAt(i).ToString() == "R")
                {
                    switch (directionInit)
                    {
                        case "N":
                            directionInit = "E";
                            break;
                        case "W":
                            directionInit = "N";
                            break;
                        case "S":
                            directionInit = "W";
                            break;
                        case "E":
                            directionInit = "S";
                            break;
                        default:
                            break;
                    }

                }
            }

            string result = string.Concat(x, ' ', y, ' ', directionInit);

            return result;
        }
    }
}