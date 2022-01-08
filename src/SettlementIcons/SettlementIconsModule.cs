using Bannerlord.UIExtenderEx;

using System;
using System.Windows.Forms;

using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.MountAndBlade;
using TaleWorlds.TwoDimension;

namespace SettlementIcons
{
    public class SubModule : MBSubModuleBase
	{
		private readonly UIExtender _uiExtender = new("SettlementIcons");
		protected override void OnSubModuleLoad()
		{
			base.OnSubModuleLoad();

            try //UIExtender Patches
			{
				_uiExtender.Register(typeof(SubModule).Assembly);
				_uiExtender.Enable();
			}
			catch (Exception exception)
			{
				MessageBox.Show("ESI Failed to apply UIExtender patches" + exception.Message);
			}
			try
			{
				var uiResourceDepot = UIResourceManager.UIResourceDepot;
				var resourceContext = UIResourceManager.ResourceContext;
				var spriteData = UIResourceManager.SpriteData;
				var yourSpriteData = new SpriteData("siSpriteData");
				yourSpriteData.Load(uiResourceDepot);
				spriteData.SpriteCategories["ui_custom_si"].Load(resourceContext, uiResourceDepot);
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Failed to load sprites " + ex2.Message);
			}
        }
	}
}