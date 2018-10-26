using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ClassesPrivate;

namespace PROJ1_RA00195406
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont Arial12;

        Botao botaoTruco;
        Botao botaoSair;
        Botao botaoSalvarJogo;

        Texture2D BotaoTruco;
        Texture2D BotaoSair;
        Texture2D BotaoSalvarJogo;




        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

       protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

       protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            botaoSair = new Botao("Sair", new Vector2(370, 370));
            botaoSalvarJogo = new Botao("Salvar Jogo", new Vector2(370 , 300));
            botaoTruco = new Botao("Sair", new Vector2(370, 250));

            BotaoTruco = Content.Load<Texture2D>("Botao");
            BotaoSair = Content.Load<Texture2D>("Botao");
            BotaoSalvarJogo = Content.Load<Texture2D>("Botao");

            Arial12 = Content.Load<SpriteFont>("Arial12");
            // TODO: use this.Content to load your game content here
        }

       
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            


            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
