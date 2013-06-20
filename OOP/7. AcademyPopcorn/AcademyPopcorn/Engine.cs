﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Engine
    {
        private int threadSleep;
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<GameObject> staticObjects;
        protected Racket playerRacket;

        public Engine(IRenderer renderer, IUserInterface userInterface, int threadSleep)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
            this.threadSleep = threadSleep;
        }

        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Racket)
                {
                    AddRacket(obj);

                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        private void AddRacket(GameObject obj)
        {
            //TODO: we should remove the previous racket from this.allObjects

            if (obj is ShootingRacket)
            {

                this.playerRacket = obj as ShootingRacket;

                allObjects.RemoveAll(x => x is Racket);
                staticObjects.RemoveAll(x => x is Racket);

                this.AddStaticObject(obj);
            }
            else
            {
                this.playerRacket = obj as Racket;

                allObjects.RemoveAll(x => x is Racket);
                staticObjects.RemoveAll(x => x is Racket);

                this.AddStaticObject(obj);
            }
        }


        

        public virtual void MovePlayerRacketLeft()
        {
            this.playerRacket.MoveLeft();
        }

        public virtual void MovePlayerRacketRight()
        {
            this.playerRacket.MoveRight();
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(threadSleep);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }
    }
}