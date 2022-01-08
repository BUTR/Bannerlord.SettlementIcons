using Helpers;

using System;
using System.Collections.Generic;
using System.Linq;

using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;

namespace SettlementIcons
{
    internal class SettlementIconState
	{
        public bool IsPossibleNobleTroops { get; set; }

        public ProductionType VillageProductionType { get; set; }

        private readonly Dictionary<string, ProductionType> _productionTypeToEnum = new()
        {
            {"clay", ProductionType.Clay},
            {"cow", ProductionType.Cow},
            {"date_fruit", ProductionType.Dates},
            {"fish", ProductionType.Fish},
            {"flax", ProductionType.Flax},
            {"fur", ProductionType.Fur},
            {"grain", ProductionType.Grain},
            {"grape", ProductionType.Grapes},
            {"hardwood", ProductionType.Hardwood},
            {"hide", ProductionType.Hide}, //not sure if this actually exist
            {"hog", ProductionType.Hog},
            {"t2_aserai_horse", ProductionType.AseraiHorse},
            {"t2_battania_horse", ProductionType.BattanianWarmount},
            {"vlandia_horse", ProductionType.SaddleHorse},
            {"khuzait_horse", ProductionType.SteppeHorse},
            {"iron", ProductionType.IronOre},
            {"olives", ProductionType.Olives},
            {"cotton", ProductionType.RawSilk},
            {"salt", ProductionType.Salt},
            {"sheep", ProductionType.Sheep},
            {"silver", ProductionType.SilverOre}
        };

		public SettlementIconState(Settlement settlement)
        {
            IsPossibleNobleTroops = settlement.Notables.Where(x => x.IsNoble).Any();

            if (settlement.IsVillage && settlement.Village.VillageType != null)
			{
				//Debug.Print(settlement.Village.VillageType.PrimaryProduction.Name.ToString() + " | primaryProduction stringid: " + settlement.Village.VillageType.PrimaryProduction.StringId );
				try
				{
					VillageProductionType = _productionTypeToEnum[settlement.Village.VillageType.PrimaryProduction.StringId];
				}
				catch (Exception e)
				{
					Debug.Print("Production type not found: \"" + settlement.Village.VillageType.PrimaryProduction.StringId + "\" Error: " + e);
					VillageProductionType = ProductionType.None;
				}
			}
        }
    }
}