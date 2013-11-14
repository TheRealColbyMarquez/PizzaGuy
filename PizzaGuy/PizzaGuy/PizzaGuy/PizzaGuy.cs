using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PizzaGuy;

namespace PizzaGuy
{
    class PizzaGuy : Sprite
    {
        public PizzaGuy(
            Vector2 location,
            Texture2D texture,
            Rectangle initialFrame,
            Vector2 velocity) :

            base(location, texture, initialFrame, velocity)
        {

        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyboard = Keyboard.GetState();
            if (keyboard.IsKeyDown(Keys.Right))
            {
                Velocity = new Vector2(100, 0);

            }

            if (keyboard.IsKeyDown(Keys.Down))
            {
                velocity = new Vector2(0, 100);
            }

            if (keyboard.IsKeyDown(Keys.Up))
            {
                velocity = new Vector2(0, -100);
            }

            if (keyboard.IsKeyDown(Keys.Left))
            {
                velocity = new Vector2(-100, 0);
            }

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

    }
}