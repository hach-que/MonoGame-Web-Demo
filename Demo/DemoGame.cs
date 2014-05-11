using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    using Microsoft.Xna.Framework;

    public class DemoGame : Game
    {
        public DemoGame()
        {
            this.GraphicsDeviceManager = new GraphicsDeviceManager(this);
        }

        public GraphicsDeviceManager GraphicsDeviceManager { get; set; }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            this.GraphicsDevice.Clear(Color.Red);
        }
    }
}
