using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class MoveController : ApiController
    {

        DataAccess objds;

        public MoveController()
        {
            objds = new DataAccess();
        }

        public IHttpActionResult PostMove(Move move)
        {

            Helper.Helper help = new Helper.Helper();
            string resultA = help.MoveResult(move.DirectionsMoveA, move.PositionStartA);
            string resultB = help.MoveResult(move.DirectionsMoveB, move.PositionStartB);

            var moveMongo = new MoveMongo
            {
                Date = DateTime.Now,
                DirectionsMoveA = move.DirectionsMoveA,
                PositionStartA = move.PositionStartA,
                DirectionsMoveB = move.DirectionsMoveB,
                PositionStartB = move.PositionStartB,
                ResultA = resultA,
                ResultB = resultB,
                SizeOfArea = move.SizeOfArea
            };

            objds.Create(moveMongo);

            string dataResult = string.Concat("A posição final da Sonda A é : ", resultA," e a posição da Sonda B é: ", resultB);

           return CreatedAtRoute("DefaultApi", new { date = moveMongo.Date }, dataResult);
        }

    }
}
