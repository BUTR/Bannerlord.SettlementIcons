using HarmonyLib;

using System;

using TaleWorlds.Library;

namespace SettlementIcons.ViewModels
{
    public class NotificationVM : ViewModel
	{
        [DataSourceProperty]
        public bool IsPossibleNobleTroops
        {
            get => _isPossibleNobleTroops;
            set
            {
                if (_isPossibleNobleTroops != value)
                {
                    _isPossibleNobleTroops = value;
                    OnPropertyChangedWithValue(value, nameof(IsPossibleNobleTroops));
                }
            }
        }
        private bool _isPossibleNobleTroops;

        [DataSourceProperty]
        public bool Clay
        {
            get => _clay;
            set
            {
                if (_clay != value)
                {
                    _clay = value;
                    OnPropertyChangedWithValue(value, nameof(Clay));
                }
            }
        }
        private bool _clay;

        [DataSourceProperty]
        public bool Cow
        {
            get => _cow;
            set
            {
                if (_cow != value)
                {
                    _cow = value;
                    OnPropertyChangedWithValue(value, nameof(Cow));
                }
            }
        }
        private bool _cow;

        [DataSourceProperty]
        public bool Dates
        {
            get => _dates;
            set
            {
                if (_dates != value)
                {
                    _dates = value;
                    OnPropertyChangedWithValue(value, nameof(Dates));
                }
            }
        }
        private bool _dates;

        [DataSourceProperty]
        public bool Fish
        {
            get => _fish;
            set
            {
                if (_fish != value)
                {
                    _fish = value;
                    OnPropertyChangedWithValue(value, nameof(Fish));
                }
            }
        }
        private bool _fish;

        [DataSourceProperty]
        public bool Flax
        {
            get => _flax;
            set
            {
                if (_flax != value)
                {
                    _flax = value;
                    OnPropertyChangedWithValue(value, nameof(Flax));
                }
            }
        }
        private bool _flax;

        [DataSourceProperty]
        public bool Fur
        {
            get => _fur;
            set
            {
                if (_fur != value)
                {
                    _fur = value;
                    OnPropertyChangedWithValue(value, nameof(Fur));
                }
            }
        }
        private bool _fur;

        [DataSourceProperty]
        public bool Grain
        {
            get => _grain;
            set
            {
                if (_grain != value)
                {
                    _grain = value;
                    OnPropertyChangedWithValue(value, nameof(Grain));
                }
            }
        }
        private bool _grain;

        [DataSourceProperty]
        public bool Grapes
        {
            get => _grapes;
            set
            {
                if (_grapes != value)
                {
                    _grapes = value;
                    OnPropertyChangedWithValue(value, nameof(Grapes));
                }
            }
        }
        private bool _grapes;

        [DataSourceProperty]
        public bool Hardwood
        {
            get => _hardwood;
            set
            {
                if (_hardwood != value)
                {
                    _hardwood = value;
                    OnPropertyChangedWithValue(value, nameof(Hardwood));
                }
            }
        }
        private bool _hardwood;

        [DataSourceProperty]
        public bool Hide
        {
            get => _hide;
            set
            {
                if (_hide != value)
                {
                    _hide = value;
                    OnPropertyChangedWithValue(value, nameof(Hide));
                }
            }
        }
        private bool _hide;

        [DataSourceProperty]
        public bool Hog
        {
            get => _hog;
            set
            {
                if (_hog != value)
                {
                    _hog = value;
                    OnPropertyChangedWithValue(value, nameof(Hog));
                }
            }
        }
        private bool _hog;

        [DataSourceProperty]
        public bool AseraiHorse
        {
            get => _aseraiHorse;
            set
            {
                if (_aseraiHorse != value)
                {
                    _aseraiHorse = value;
                    OnPropertyChangedWithValue(value, nameof(AseraiHorse));
                }
            }
        }
        private bool _aseraiHorse;

        [DataSourceProperty]
        public bool BattanianWarmount
        {
            get => _battanianWarmount;
            set
            {
                if (_battanianWarmount != value)
                {
                    _battanianWarmount = value;
                    OnPropertyChangedWithValue(value, nameof(BattanianWarmount));
                }
            }
        }
        private bool _battanianWarmount;

        [DataSourceProperty]
        public bool SaddleHorse
        {
            get => _saddleHorse;
            set
            {
                if (_saddleHorse != value)
                {
                    _saddleHorse = value;
                    OnPropertyChangedWithValue(value, nameof(SaddleHorse));
                }
            }
        }
        private bool _saddleHorse;

        [DataSourceProperty]
        public bool SteppeHorse
        {
            get => _steppeHorse;
            set
            {
                if (_steppeHorse != value)
                {
                    _steppeHorse = value;
                    OnPropertyChangedWithValue(value, nameof(SteppeHorse));
                }
            }
        }
        private bool _steppeHorse;

        [DataSourceProperty]
        public bool IronOre
        {
            get => _ironOre;
            set
            {
                if (_ironOre != value)
                {
                    _ironOre = value;
                    OnPropertyChangedWithValue(value, nameof(IronOre));
                }
            }
        }
        private bool _ironOre;

        [DataSourceProperty]
        public bool Olives
        {
            get => _olives;
            set
            {
                if (_olives != value)
                {
                    _olives = value;
                    OnPropertyChangedWithValue(value, nameof(Olives));
                }
            }
        }
        private bool _olives;

        [DataSourceProperty]
        public bool Sheep
        {
            get => _sheep;
            set
            {
                if (_sheep != value)
                {
                    _sheep = value;
                    OnPropertyChangedWithValue(value, nameof(Sheep));
                }
            }
        }
        private bool _sheep;

        [DataSourceProperty]
        public bool RawSilk
        {
            get => _rawSilk;
            set
            {
                if (_rawSilk != value)
                {
                    _rawSilk = value;
                    OnPropertyChangedWithValue(value, nameof(RawSilk));
                }
            }
        }
        private bool _rawSilk;

        [DataSourceProperty]
        public bool Salt
        {
            get => _salt;
            set
            {
                if (_salt != value)
                {
                    _salt = value;
                    OnPropertyChangedWithValue(value, nameof(Salt));
                }
            }
        }
        private bool _salt;

        [DataSourceProperty]
        public bool SilverOre
        {
            get => _silverOre;
            set
            {
                if (_silverOre != value)
                {
                    _silverOre = value;
                    OnPropertyChangedWithValue(value, nameof(SilverOre));
                }
            }
        }
        private bool _silverOre;

        public int SortIndex { get; set; }

        public static NotificationVM FromPropertyName(string propertyName)
		{
			var notificationVM = new NotificationVM();
			AccessTools.Property(typeof(NotificationVM), propertyName)?.SetValue(notificationVM, true);

			if (propertyName == nameof(IsPossibleNobleTroops))
            {
                notificationVM.SortIndex = 1;
            }
			else if (Enum.IsDefined(typeof(ProductionType), propertyName))
            {
                notificationVM.SortIndex = 0;
            }
			else
            {
                notificationVM.SortIndex = 2;
            }

			return notificationVM;
		}
	}
}