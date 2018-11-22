using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TRUCO
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        enum EstadoJogo { MENU, PLAYGAME, HELP, ABOUT }
        EstadoJogo estadoJogo;
        Botao botaoHELP, botaoPLAY, botaoCREDITS, botaoEXIT, botaoMENU;
        TextoNaTela help, about0, about1, about2, about3;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region TEXTURAS
        Texture2D Unselected, MouseOver, Selected;
        Texture2D varTexture, varPablito, varLogo;
        Texture2D logoPUC1, logoPUC2;
        Texture2D Void;
        Texture2D mousecursor;
        Texture2D MainMenuFundo, AboutFundo, HelpFundo, PlainFundo;

        Texture2D texMENU1, texMENU2, texPLAY1, texPLAY2, texCREDITS1, texCREDITS2, texHELP1, texHELP2, texEXIT1, texEXIT2;
        Texture2D varMENU, varPLAY, varCREDITS, varHELP, varEXIT;
        Texture2D logoMaze, varCarta, versoCartaTex, frenteCartaTex;
        //Texture2D[] listaCartas;
        List<Texture2D> listaCartas = new List<Texture2D>();
        Texture2D carta1Text, carta2Text, carta3Text, carta4Text, carta5Text, carta6Text, carta7Text, carta8Text, carta9Text, carta10Text,
            carta11Text, carta12Text, carta13Text, carta14Text, carta15Text, carta16Text, carta17Text, carta18Text, carta19Text, carta20Text,
            carta21Text, carta22Text, carta23Text, carta24Text, carta25Text, carta26Text, carta27Text, carta28Text, carta29Text, carta30Text,
            carta31Text, carta32Text, carta33Text, carta34Text, carta35Text, carta36Text, carta37Text, carta38Text, carta39Text, carta40Text;
        #endregion

        MouseState meuMouse, meuMouseAnterior;
        Vector2 mousePosicao;
        Rectangle texRect1, texRect2, texRect3, sprRect;
        SpriteFont fonteHead, fonteTitulo, fonteTexto;
        int spriteX = 0; //TODO: ANIMACAO DE TEXTURAS
        int spriteY = 0; //TODO: ANIMACAO DE TEXTURAS
        int alturaTela, larguraTela; //TODO: REDIMENSIONAMENTO
        int cursorX, cursorY;

        Tabuleiro tabuleiro;
        int tempoPausaInteracao;
        Carta carta1;
        Carta carta2;
        int pontos;



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = false;
            //graphics.ToggleFullScreen();
            cursorX = 15;
            cursorY = 20;


            carta1 = null;
            carta2 = null;

            pontos = 0;


            base.Initialize();
        }

        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);
            #region TEXTURAS E FONTES CARREGADAS
            //Unselected = Content.Load<Texture2D>("Unselected");
            //MouseOver = Content.Load<Texture2D>("MouseOver");
            //Selected = Content.Load<Texture2D>("Selected");
            MainMenuFundo = Content.Load<Texture2D>("MENU_ART/Tela_Fundo");
            AboutFundo = Content.Load<Texture2D>("MENU_ART/Tela_About");
            HelpFundo = Content.Load<Texture2D>("MENU_ART/Tela_Help");
            PlainFundo = Content.Load<Texture2D>("MENU_ART/Tela_Fundo");
            //logoPUC1 = Content.Load<Texture2D>("logoPUC");
            //logoPUC2 = Content.Load<Texture2D>("logoPUC2");
            //Void = Content.Load<Texture2D>("Void");
            mousecursor = Content.Load<Texture2D>("cursor");
            texMENU1 = Content.Load<Texture2D>("MENU_ART/botaoMENU1");
            texMENU2 = Content.Load<Texture2D>("MENU_ART/botaoMENU2");
            texCREDITS1 = Content.Load<Texture2D>("MENU_ART/botaoCREDITS1");
            texCREDITS2 = Content.Load<Texture2D>("MENU_ART/botaoCREDITS2");
            texEXIT1 = Content.Load<Texture2D>("MENU_ART/botaoEXIT1");
            texEXIT2 = Content.Load<Texture2D>("MENU_ART/botaoEXIT2");
            texPLAY1 = Content.Load<Texture2D>("MENU_ART/botaoPLAY1");
            texPLAY2 = Content.Load<Texture2D>("MENU_ART/botaoPLAY2");
            texHELP1 = Content.Load<Texture2D>("MENU_ART/botaoHELP1");
            texHELP2 = Content.Load<Texture2D>("MENU_ART/botaoHELP2");
            //logoMaze = Content.Load<Texture2D>("Maze");
            //versoCartaTex = Content.Load<Texture2D>("VersoCarta");
            //frenteCartaTex = Content.Load<Texture2D>("FrenteCarta");

            carta1Text = Content.Load<Texture2D>("CARTAS_ART/Azul_1");
            listaCartas.Add(carta1Text);
            carta2Text = Content.Load<Texture2D>("CARTAS_ART/Azul_2");
            listaCartas.Add(carta2Text);
            carta3Text = Content.Load<Texture2D>("CARTAS_ART/Azul_3");
            listaCartas.Add(carta3Text);
            carta4Text = Content.Load<Texture2D>("CARTAS_ART/Azul_4");
            listaCartas.Add(carta4Text);
            carta5Text = Content.Load<Texture2D>("CARTAS_ART/Azul_5");
            listaCartas.Add(carta5Text);
            carta6Text = Content.Load<Texture2D>("CARTAS_ART/Azul_6");
            listaCartas.Add(carta6Text);
            carta7Text = Content.Load<Texture2D>("CARTAS_ART/Azul_7");
            listaCartas.Add(carta7Text);
            carta8Text = Content.Load<Texture2D>("CARTAS_ART/Azul_8");
            listaCartas.Add(carta8Text);
            carta9Text = Content.Load<Texture2D>("CARTAS_ART/Azul_9");
            listaCartas.Add(carta9Text);
            carta10Text = Content.Load<Texture2D>("CARTAS_ART/Azul_10");
            listaCartas.Add(carta10Text);

            carta11Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_1");
            listaCartas.Add(carta11Text);
            carta12Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_2");
            listaCartas.Add(carta12Text);
            carta13Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_3");
            listaCartas.Add(carta13Text);
            carta14Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_4");
            listaCartas.Add(carta14Text);
            carta15Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_5");
            listaCartas.Add(carta15Text);
            carta16Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_6");
            listaCartas.Add(carta16Text);
            carta17Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_7");
            listaCartas.Add(carta17Text);
            carta18Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_8");
            listaCartas.Add(carta18Text);
            carta19Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_9");
            listaCartas.Add(carta19Text);
            carta20Text = Content.Load<Texture2D>("CARTAS_ART/Laranja_10");
            listaCartas.Add(carta20Text);

            carta21Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_1");
            listaCartas.Add(carta21Text);
            carta22Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_2");
            listaCartas.Add(carta22Text);
            carta23Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_3");
            listaCartas.Add(carta23Text);
            carta24Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_4");
            listaCartas.Add(carta24Text);
            carta25Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_5");
            listaCartas.Add(carta25Text);
            carta26Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_6");
            listaCartas.Add(carta26Text);
            carta27Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_7");
            listaCartas.Add(carta27Text);
            carta28Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_8");
            listaCartas.Add(carta28Text);
            carta29Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_9");
            listaCartas.Add(carta29Text);
            carta30Text = Content.Load<Texture2D>("CARTAS_ART/Roxo_10");
            listaCartas.Add(carta30Text);

            carta31Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_1");
            listaCartas.Add(carta31Text);
            carta32Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_2");
            listaCartas.Add(carta32Text);
            carta33Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_3");
            listaCartas.Add(carta33Text);
            carta34Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_4");
            listaCartas.Add(carta34Text);
            carta35Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_5");
            listaCartas.Add(carta35Text);
            carta36Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_6");
            listaCartas.Add(carta36Text);
            carta37Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_7");
            listaCartas.Add(carta37Text);
            carta38Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_8");
            listaCartas.Add(carta38Text);
            carta39Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_9");
            listaCartas.Add(carta39Text);
            carta40Text = Content.Load<Texture2D>("CARTAS_ART/Cinza_10");
            listaCartas.Add(carta40Text);


            fonteHead = Content.Load<SpriteFont>("fonteHead");
            fonteTitulo = Content.Load<SpriteFont>("fonteTitulo");
            fonteTexto = Content.Load<SpriteFont>("fonteTexto");
            #endregion
            #region BOTOES CARREGADOS
            botaoPLAY = new Botao("", new Vector2(250, 180));
            botaoHELP = new Botao("", new Vector2(250, 230));
            botaoCREDITS = new Botao("", new Vector2(250, 280));
            botaoEXIT = new Botao("", new Vector2(250, 330));
            botaoMENU = new Botao("", new Vector2(250, 420));
            #endregion
            #region TEXTO CARREGADO
            help = new TextoNaTela("HELP//", "ME", "Estas sao as regras do TRUCO", "\nEh isso :)");
            about0 = new TextoNaTela("ABOUT//", "ME", "", "");
            about1 = new TextoNaTela("ABOUT//", "ME", "name_\nalias_\norganization_\nemail_\ninstituition_\ndiscipline/year_\nidentification_", "Thiago Rosene\nThefiant\nMasterpiece / MP North\nth.rosene@hotmail.com\nPUC SP\nLPG3 - Jogos Digitais 2018\nRA00170606");
            about2 = new TextoNaTela("ABOUT//", "ME", "name_\nalias_\norganization_\nemail_\ninstituition_\ndiscipline/year_\nidentification_", "Pablo Felicetti Goncalves\nJorge do Tapete\nPipe Cat\npablofelicetti@gmail.com\nPUC SP\nLPG3 - Jogos Digitais 2018\nRA00171779");
            about3 = new TextoNaTela("ABOUT//", "ME", "\n\n\n\ninstituition_\ndiscipline/year_\n", "\n\n\n\nPUC SP\nLPG3 - Jogos Digitais 2018\n");
            #endregion

            alturaTela = GraphicsDevice.Viewport.Bounds.Height; //TODO: REDIMENSIONAMENTO
            larguraTela = GraphicsDevice.Viewport.Bounds.Width; //TODO: REDIMENSIONAMENTO

            tabuleiro = FabricarTabuleiros.Truco(listaCartas);
            estadoJogo = EstadoJogo.MENU;
            meuMouse = Mouse.GetState();
            meuMouseAnterior = meuMouse;

        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            //SAIR

            meuMouseAnterior = meuMouse;
            meuMouse = Mouse.GetState();
            //if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
            //Condição se a ultima ação do mouse for o clique e soltura

            mousePosicao = new Vector2(meuMouse.X, meuMouse.Y);
            if (meuMouse.LeftButton == ButtonState.Pressed)
            {
                cursorX = 12;
                cursorY = 18;
            }
            else
            {
                cursorX = 15;
                cursorY = 20;
            }
            //ESTADOS DO MOUSE

            varTexture = Unselected;
            //varPablito = perfilPablito1;
            varLogo = Void;
            varPLAY = texPLAY1;
            varHELP = texHELP1;
            varCREDITS = texCREDITS1;
            varMENU = texMENU1;
            varEXIT = texEXIT1;
            varCarta = versoCartaTex;

            //VARIAVEIS DE TEXTURA PARA INTERACAO DO MOUSE

            texRect1 = new Rectangle(50, 75, 200, 300);
            texRect2 = new Rectangle(90, 115, 200, 300);
            texRect3 = new Rectangle(70, 95, 200, 300);
            sprRect = new Rectangle(spriteX, spriteY, 300, 450); // TODO: ANIMACAO DE TEXTURA

            switch (estadoJogo)
            {
                #region Menu
                case EstadoJogo.MENU:
                    {
                        #region BOTAO PLAY
                        if (mousePosicao.X >= 250 && mousePosicao.X <= 250 + 300 && mousePosicao.Y >= 180 && mousePosicao.Y <= 180 + 50)
                        {
                            //colide com primeiro botao
                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varPLAY = texPLAY2;
                            }
                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                estadoJogo = EstadoJogo.PLAYGAME;
                            }
                        }


                        #endregion
                        #region BOTAO HELP
                        else if (mousePosicao.X >= 250 && mousePosicao.X <= 250 + 300 && mousePosicao.Y >= 230 && mousePosicao.Y <= 230 + 50)
                        {
                            //colide com segundo botao
                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varHELP = texHELP2;
                            }
                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                estadoJogo = EstadoJogo.HELP;
                            }

                        }
                        #endregion
                        #region BOTAO CREDITS
                        else if (mousePosicao.X >= 250 && mousePosicao.X <= 250 + 300 && mousePosicao.Y >= 280 && mousePosicao.Y <= 280 + 50)
                        {
                            //colide com terceiro botao

                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varCREDITS = texCREDITS2;
                            }
                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                estadoJogo = EstadoJogo.ABOUT;
                            }
                        }
                        #endregion
                        #region BOTAO SAIR
                        else if (mousePosicao.X >= 250 && mousePosicao.X <= 250 + 300 && mousePosicao.Y >= 330 && mousePosicao.Y <= 330 + 50)
                        {
                            //colide com quarto botao
                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varEXIT = texEXIT2;
                            }
                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                Exit();
                            }

                        }
                        #endregion
                        break;
                    }
                #endregion
                #region About
                case EstadoJogo.ABOUT:
                    {
                        #region FOTO PERFIL CLIQUE
                        if (mousePosicao.X >= 50 && mousePosicao.X <= 50 + 200 && mousePosicao.Y >= 75 && mousePosicao.Y <= 75 + 300)
                        {
                            texRect1 = new Rectangle(47, 72, 210, 310);
                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varTexture = Selected;
                                texRect1 = new Rectangle(50, 75, 197, 295);
                            }
                            else
                            {
                                varTexture = MouseOver;
                            }
                        }
                        #endregion
                        #region FOTO PERFIL CLIQUE 2
                        if ((mousePosicao.X >= 70 && mousePosicao.X <= 70 + 200 && mousePosicao.Y >= 376 && mousePosicao.Y <= 95 + 300)
                            || (mousePosicao.X > 200 + 50 && mousePosicao.X < 200 + 70 && mousePosicao.Y > 95 && mousePosicao.Y <= 95 + 300))
                        {
                            texRect3 = new Rectangle(67, 92, 210, 310);
                            varTexture = Void;
                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                //varPablito = perfilPablito3;
                                texRect3 = new Rectangle(70, 95, 197, 295);

                            }
                            else
                            {
                                //varPablito = perfilPablito1;
                            }
                        }
                        #endregion
                        #region LOGO PUC CLIQUE
                        else if ((mousePosicao.X > 90 && mousePosicao.X < 90 + 200 && mousePosicao.Y > 300 + 95 && mousePosicao.Y <= 115 + 300)
                            || (mousePosicao.X > 200 + 70 && mousePosicao.X < 200 + 90 && mousePosicao.Y > 115 && mousePosicao.Y <= 300 + 115))
                        {
                            varLogo = logoPUC1;
                            texRect2 = new Rectangle(87, 103, 210, 310);
                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varLogo = logoPUC2;
                                texRect2 = new Rectangle(90, 115, 197, 295);
                            }
                        }
                        #endregion
                        #region BOTAO MENU
                        else if (mousePosicao.X >= 250 && mousePosicao.X <= 250 + 300 && mousePosicao.Y >= 420 && mousePosicao.Y <= 420 + 50)
                        {
                            //colide com botao

                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varMENU = texMENU2;
                            }
                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                estadoJogo = EstadoJogo.MENU;
                            }

                        }
                        #endregion
                        #region IMAGEM NULA
                        else
                        {
                            varLogo = Void;
                        }
                        #endregion
                        break;
                    }
                #endregion
                #region Help
                case EstadoJogo.HELP:
                    {
                        #region BOTAO MENU
                        if (mousePosicao.X >= 250 && mousePosicao.X <= 250 + 300 && mousePosicao.Y >= 420 && mousePosicao.Y <= 420 + 50)
                        {
                            //colide com botao

                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varMENU = texMENU2;
                            }
                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                estadoJogo = EstadoJogo.MENU;
                            }
                        }
                        #endregion
                        break;
                    }
                #endregion
                #region PlayGame
                case EstadoJogo.PLAYGAME:
                    {


                        if (tempoPausaInteracao == 0)
                        {

                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                int linha = (int)meuMouse.Y / (110 + 14);
                                int coluna = (int)meuMouse.X / (65 + 14);
                                Carta carta = tabuleiro.GetCarta(linha, coluna);
                                if (carta != null)
                                {
                                    if (carta.Coberta)
                                    {
                                        carta.Coberta = false;

                                        if (carta1 == null)
                                        {
                                            carta1 = carta;
                                        }
                                        else
                                        {
                                            carta2 = carta;
                                            tempoPausaInteracao = 30;
                                        }
                                    }
                                }
                            }
                        }

                        if (tempoPausaInteracao == 0)
                        {
                            //Se peguei as duas cartas
                            if (carta1 != null && carta2 != null)
                            {
                                //Compare as cartas
                                if (carta1.Igual(carta2))
                                {
                                    pontos++;
                                    // TODO animação produto
                                }

                                else
                                {
                                    carta1.Coberta = true;
                                    carta2.Coberta = true;
                                }
                                //devolva 
                                carta1 = null;
                                carta2 = null;
                            }
                        }


                        if (tempoPausaInteracao > 0)
                        {
                            tempoPausaInteracao--;
                        }


                        if (mousePosicao.X >= 250 && mousePosicao.X <= 250 + 300 && mousePosicao.Y >= 420 && mousePosicao.Y <= 420 + 50)
                        {

                            //TODO interação com cartas, virar cartas, 
                            //colide com botao Menu

                            if (meuMouse.LeftButton == ButtonState.Pressed)
                            {
                                varMENU = texMENU2;
                            }
                            if (meuMouse.LeftButton == ButtonState.Released && meuMouseAnterior.LeftButton == ButtonState.Pressed)
                            {
                                estadoJogo = EstadoJogo.MENU;
                            }
                        }
                        break;
                    }
                    #endregion
            }
            base.Update(gameTime);
        }



        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();

            switch (estadoJogo)
            {
                case EstadoJogo.MENU:
                    {
                        spriteBatch.Draw(PlainFundo, new Rectangle(0, 0, 800, 480), Color.White);
                        DrawObjetos.Botao(botaoPLAY, spriteBatch, varPLAY, fonteTexto);
                        DrawObjetos.Botao(botaoHELP, spriteBatch, varHELP, fonteTexto);
                        DrawObjetos.Botao(botaoCREDITS, spriteBatch, varCREDITS, fonteTexto);
                        DrawObjetos.Botao(botaoEXIT, spriteBatch, varEXIT, fonteTexto);
                        break;
                    }
                case EstadoJogo.ABOUT:
                    {
                        spriteBatch.Draw(AboutFundo, new Rectangle(0, 0, 800, 480), Color.White);
                        /*spriteBatch.Draw(Unselected, texRect1, sprRect, Color.White);
                        spriteBatch.Draw(logoPUC1, texRect2, sprRect, Color.Gray);
                        spriteBatch.Draw(varPablito, texRect3, sprRect, Color.White);
                        spriteBatch.Draw(varTexture, texRect1, sprRect, Color.White);
                        spriteBatch.Draw(varLogo, texRect2, sprRect, Color.White);

                        if (varTexture == MouseOver || varTexture == Selected)
                        {
                            DrawObjetos.TextoNaTela2(about1, spriteBatch, fonteHead, fonteTitulo, fonteTexto);
                        }
                        else if (varTexture == Void)
                        {
                            DrawObjetos.TextoNaTela2(about2, spriteBatch, fonteHead, fonteTitulo, fonteTexto);
                        }
                        else if (varLogo == logoPUC1 || varLogo == logoPUC2)
                        {
                            DrawObjetos.TextoNaTela2(about3, spriteBatch, fonteHead, fonteTitulo, fonteTexto);
                        }
                        else
                        {
                            DrawObjetos.TextoNaTela2(about0, spriteBatch, fonteHead, fonteTitulo, fonteTexto);
                        }*/
                        DrawObjetos.Botao(botaoMENU, spriteBatch, varMENU, fonteTexto);
                        
                        break;
                    }
                case EstadoJogo.HELP:
                    {
                        spriteBatch.Draw(HelpFundo, new Rectangle(0, 0, 800, 480), Color.White);
                        DrawObjetos.TextoNaTela(help, spriteBatch, fonteHead, fonteTitulo, fonteTexto);
                        DrawObjetos.Botao(botaoMENU, spriteBatch, varMENU, fonteTexto);
                        break;
                    }
                case EstadoJogo.PLAYGAME:
                    {
                        //DrawObjetos.Tabuleiro(tabuleiro, spriteBatch, versoCartaTex, listaCartas, fonteTexto);
                        DrawObjetos.Botao(botaoMENU, spriteBatch, varMENU, fonteTexto);
                        break;
                    }
            }
            spriteBatch.Draw(mousecursor, new Rectangle(meuMouse.X, meuMouse.Y, cursorX, cursorY), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
