using Bannerlord.UIExtenderEx.Attributes;
using Bannerlord.UIExtenderEx.ViewModels;

using HarmonyLib;

using SandBox.ViewModelCollection.Nameplate;

using SettlementIcons.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;

using TaleWorlds.Library;
using TaleWorlds.ObjectSystem;

namespace SettlementIcons.UIExtenderEx
{
    [ViewModelMixin]
    internal sealed class SettlementNameplateVMMixin : BaseViewModelMixin<SettlementNameplateVM>
    {
        public static Dictionary<MBGUID, SettlementIconState> States { get; set; } = new();

        static SettlementNameplateVMMixin()
        {
            var harmony = new Harmony("settlementicons.settlementnameplatevm.mixin");

            harmony.Patch(
                AccessTools.Method(typeof(SettlementNameplateVM), nameof(SettlementNameplateVM.RefreshDynamicProperties)),
                postfix: new HarmonyMethod(AccessTools.Method(typeof(SettlementNameplateVMMixin), nameof(RefreshDynamicPropertiesPostfix)), 300));
        }

        private static void RefreshDynamicPropertiesPostfix(SettlementNameplateVM __instance)
        {
            if (!__instance.Settlement.IsHideout && States.ContainsKey(__instance.Settlement.Id))
            {
                var settlementIconState = States[__instance.Settlement.Id];
                if (__instance.GetPropertyValue(nameof(SIMixin)) is WeakReference<SettlementNameplateVMMixin> weakReference && weakReference.TryGetTarget(out var mixin))
                {
                    mixin.IsPossibleNobleTroops = settlementIconState.IsPossibleNobleTroops;
                    mixin.VillageProductionType = settlementIconState.VillageProductionType;
                }
            }
        }

        [DataSourceProperty]
        public WeakReference<SettlementNameplateVMMixin> SIMixin => new(this);

        [DataSourceProperty]
        public bool IsPossibleNobleTroops
        {
            get => _isPossibleNobleTroops;
            set
            {
                if (value != _isPossibleNobleTroops)
                {
                    _isPossibleNobleTroops = value;
                    InsertOrRemoveNotification(nameof(IsPossibleNobleTroops), value);
                }
            }
        }

        [DataSourceProperty]
        public ProductionType VillageProductionType
        {
            get => _villageProductionType;
            set
            {
                if (value != _villageProductionType && value != ProductionType.None)
                {
                    _villageProductionType = value;
                    InsertOrRemoveNotification(_villageProductionType.ToString(), true);
                }
            }
        }

        [DataSourceProperty]
        public MBBindingList<NotificationVM> Notifications
        {
            get => _notifications;
            set
            {
                if (value != _notifications)
                {
                    _notifications = value;
                    ViewModel?.OnPropertyChangedWithValue(value, nameof(Notifications));
                    //ViewModel?.OnPropertyChanged(nameof(Notifications));
                }
            }
        }

        private NotificationComparer NotificationsComparer { get; } = new();

        private bool _isPossibleNobleTroops;

        private ProductionType _villageProductionType;

        private MBBindingList<NotificationVM> _notifications = new();

        public SettlementNameplateVMMixin(SettlementNameplateVM vm) : base(vm)
        {
            if (!vm.Settlement.IsHideout)
            {
                var value = new SettlementIconState(vm.Settlement);
                if (States.ContainsKey(vm.Settlement.Id))
                {
                    States.Remove(vm.Settlement.Id);
                }
                States.Add(vm.Settlement.Id, value);
            }
        }

        private void InsertOrRemoveNotification(string propertyName, bool insert)
        {
            if (insert)
            {
                Notifications.Add(NotificationVM.FromPropertyName(propertyName));
                Notifications.Sort(NotificationsComparer);
            }
            else
            {
                var notificationVM = Notifications.SingleOrDefault(n => AccessTools.Property(typeof(NotificationVM), propertyName)?.GetValue(n) as bool? == true);
                if (notificationVM != null)
                {
                    Notifications.Remove(notificationVM);
                }
            }
        }

        private class NotificationComparer : IComparer<NotificationVM>
        {
            public int Compare(NotificationVM left, NotificationVM right) => left.SortIndex.CompareTo(right.SortIndex);
        }
    }
}