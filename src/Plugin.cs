using System;
using BepInEx;
using UnityEngine;
using SlugBase.Features;
using static SlugBase.Features.FeatureTypes;

namespace HydroxCat
{
    [BepInPlugin(MOD_ID, "[PRERELEASE] The Dummy", "0.0.0")]
    class Plugin : BaseUnityPlugin
    {
        private const string MOD_ID = "urufudoggo.hydrox";

        public static readonly PlayerFeature<string> 오마이갓 = PlayerString("hydroxide/오하이도");

        // Add hooks
        public void OnEnable()
        {
            On.RainWorld.OnModsInit += Extras.WrapInit(LoadResources);

            // Put your custom hooks here!
            On.Player.ctor += FeckYourInputs;
            On.Player.checkInput += MakeCharacterMoveButNotReally;
            On.PlayerGraphics.DrawSprites += DrawCursor;
        }

        // Load any resources, such as sprites or sounds
        private void LoadResources(RainWorld rainWorld)
        {
        }


        private void FeckYourInputs(On.Player.orig_ctor orig, Player self, AbstractCreature abstractCreature, World world)
        {
            throw new NotImplementedException();
        }


        private void MakeCharacterMoveButNotReally(On.Player.orig_checkInput orig, Player self)
        {
            throw new NotImplementedException();
        }


        private void DrawCursor(On.PlayerGraphics.orig_DrawSprites orig, PlayerGraphics self, RoomCamera.SpriteLeaser sLeaser, RoomCamera rCam, float timeStacker, Vector2 camPos)
        {
            throw new NotImplementedException();
        }
    }
}