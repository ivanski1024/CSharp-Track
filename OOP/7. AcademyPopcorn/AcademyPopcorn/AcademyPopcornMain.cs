using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 7;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            //==============THE BLOCKS================
            for (int i = startCol; i < endCol; i++)
            {
                if (i == 7)
                {
                    ExploadingBlock exploadingBlock = new ExploadingBlock(new MatrixCoords(startRow, i));
                    engine.AddObject(exploadingBlock);
                }
                else if (i == endCol - 5)
                {
                    GiftBlock giftBlock = new GiftBlock(new MatrixCoords(startRow, i));
                    engine.AddObject(giftBlock);
                }
                else
                {
                    Block currBlock = new Block(new MatrixCoords(startRow, i));
                    engine.AddObject(currBlock);
                }
            }
            //========================================


            //==============GIFT TEST================
            //engine.AddObject(new Gift(new MatrixCoords(5, WorldCols / 2)));

            //engine.AddObject(new UnpassableBlock(new MatrixCoords(WorldRows - 3, endCol - 5)));
            //=======================================


            //==============THE BALL==================
            UnstoppableBall unstoppable = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            MeteoriteBall meteorit = new MeteoriteBall(new MatrixCoords(WorldRows / 2, WorldCols - 1), new MatrixCoords(-1, -1));


            engine.AddObject(unstoppable);
            engine.AddObject(meteorit);
            //========================================

            //==============THE RACKET================
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
            //========================================

            //==============THE WALLS=================
            for (int row = 0; row < WorldRows - 1; row++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, 0)));
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1)));
            }
            for (int col = 1; col < WorldCols - 1; col++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(0, col)));
            }
            //========================================


            //=============TRAIL TEST================
            //char[,] trailObjectBody = { {'*'} };
            //engine.AddObject(new TrailObject(new MatrixCoords(10, 10), trailObjectBody, 5));
            //=======================================


            //=============EXPLOSION BLOCK===========
            engine.AddObject(new ExploadingBlock(new MatrixCoords(8, WorldCols - 2)));
            //=======================================



            //==============BULLET TEST==============
            //engine.AddObject(new Bullet(new MatrixCoords(WorldRows - 1, WorldCols / 2)));

            //engine.AddObject(new UnpassableBlock(new MatrixCoords(5, WorldCols / 2)));

        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine_ShootingRacket gameEngine = new Engine_ShootingRacket(renderer, keyboard, 100);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };
            
            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
