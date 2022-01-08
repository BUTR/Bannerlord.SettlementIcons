using Bannerlord.UIExtenderEx.Attributes;
using Bannerlord.UIExtenderEx.Prefabs2;

using System.Linq;
using System.Xml;

using TaleWorlds.Engine;
using TaleWorlds.ModuleManager;

namespace SettlementIcons.UIExtenderEx
{
    [PrefabExtension(
        movie:"SettlementNameplateItem",
        autoGenWidgetName:"SettlementNameplate",
        xpath:"descendant::SettlementNameplateItemWidget[@Id='SmallSizeNameplateWidget']/Children/MapEventVisualWidget")]
	public class SettlementIconsPrependPatch : PrefabExtensionInsertPatch
	{
        [PrefabExtensionXmlDocument]
        public XmlDocument GetPrefabExtension() => _document;

		public override InsertType Type => InsertType.Prepend;

		private readonly XmlDocument _document = new();

		public SettlementIconsPrependPatch()
		{
            // ReSharper disable once InconsistentNaming
			var SIRPresent = Utilities.GetModulesNames().Any(module => module == "SettlementIconRedesign" || module == "CBUPack");

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(ModuleHelper.GetModuleFullPath("SettlementIcons") + "GUI/PrefabExtensions/SISettlementNameplateItemPatch.xml");

            var tempXml = SIRPresent
                ? "<GridWidget Id=\"NotificationsGridWidget\" DataSource=\"{Notifications}\" WidthSizePolicy=\"CoverChildren\" HeightSizePolicy=\"Fixed\"" +
                  " SuggestedHeight=\"50\" PositionXOffset=\"-16\" PositionYOffset=\"-66\" HorizontalAlignment=\"Center\" DefaultCellWidth=\"20\" DefaultCellHeight=\"20\" ColumnCount=\"7\"" +
                  " LayoutImp=\"GridLayout\">"

                : "<GridWidget Id=\"NotificationsGridWidget\" DataSource=\"{Notifications}\" WidthSizePolicy=\"CoverChildren\" HeightSizePolicy=\"Fixed\"" +
                   " SuggestedHeight=\"50\" PositionXOffset=\"41\" PositionYOffset=\"-16\" DefaultCellWidth=\"20\" DefaultCellHeight=\"20\" ColumnCount=\"7\"" +
                   " LayoutImp=\"GridLayout\">";
            tempXml = tempXml + xmlDocument.InnerXml + "</GridWidget>";
            _document.LoadXml(tempXml);
		}
    }
}