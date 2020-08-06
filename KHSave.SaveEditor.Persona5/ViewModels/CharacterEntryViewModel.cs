﻿using KHSave.Attributes;
using KHSave.LibPersona5.Models;
using KHSave.LibPersona5.Types;
using KHSave.SaveEditor.Common.Models;
using KHSave.SaveEditor.Persona5.Interfaces;
using System.Linq;
using System.Windows;
using Xe.Tools.Wpf.Models;

namespace KHSave.SaveEditor.Persona5.ViewModels
{
    public class CharacterEntryViewModel : GenericListModel<PersonaViewModel>
    {
        private readonly Characters _id;
        private readonly Character _character;
        private readonly IEquipmentList _equipmentList;

        public CharacterEntryViewModel(Character character, int index, IPersonaList personaList, ISkillList skillList, IEquipmentList equipmentList) :
            base(character.Persona.Select(x => new PersonaViewModel(x, personaList, skillList)))
        {
            _id = (Characters)index;
            _character = character;
            _equipmentList = equipmentList;
        }

        public Visibility EntryVisible => IsItemSelected ? Visibility.Visible : Visibility.Collapsed;
        public Visibility EntryNotVisible => !IsItemSelected ? Visibility.Visible : Visibility.Collapsed;

        public string Name => InfoAttribute.GetInfo(_id);
        
        public KhEnumListModel<EnumIconTypeModel<Equipment>, Equipment> EquipmentList =>
            _equipmentList.EquipmentList;

        public int Experience
        {
            get => _character.Experience;
            set => _character.Experience = value;
        }

        public int CurrentHp
        {
            get => _character.CurrentHp;
            set => _character.CurrentHp = value;
        }

        public int CurrentMp
        {
            get => _character.CurrentMp;
            set => _character.CurrentMp = value;
        }

        public Equipment MeleeWeapon
        {
            get => _character.MeleeWeapon;
            set
            {
                _character.MeleeWeapon = value;
                OnPropertyChanged(nameof(MeleeWeapon));
                OnPropertyChanged(nameof(MeleeWeaponId));
            }
        }

        public ushort MeleeWeaponId
        {
            get => (ushort)_character.MeleeWeapon;
            set
            {
                _character.MeleeWeapon = (Equipment)value;
                OnPropertyChanged(nameof(MeleeWeapon));
                OnPropertyChanged(nameof(MeleeWeaponId));
            }
        }

        public Equipment RangeWeapon
        {
            get => _character.RangeWeapon;
            set
            {
                _character.RangeWeapon = value;
                OnPropertyChanged(nameof(RangeWeapon));
                OnPropertyChanged(nameof(RangeWeaponId));
            }
        }

        public ushort RangeWeaponId
        {
            get => (ushort)_character.RangeWeapon;
            set
            {
                _character.RangeWeapon = (Equipment)value;
                OnPropertyChanged(nameof(RangeWeapon));
                OnPropertyChanged(nameof(RangeWeaponId));
            }
        }

        public Equipment Protector
        {
            get => _character.Protector;
            set
            {
                _character.Protector = value;
                OnPropertyChanged(nameof(Protector));
                OnPropertyChanged(nameof(ProtectorId));
            }
        }

        public ushort ProtectorId
        {
            get => (ushort)_character.Protector;
            set
            {
                _character.Protector = (Equipment)value;
                OnPropertyChanged(nameof(Protector));
                OnPropertyChanged(nameof(ProtectorId));
            }
        }

        public Equipment Accessory
        {
            get => _character.Accessory;
            set
            {
                _character.Accessory = value;
                OnPropertyChanged(nameof(Accessory));
                OnPropertyChanged(nameof(AccessoryId));
            }
        }

        public ushort AccessoryId
        {
            get => (ushort)_character.Accessory;
            set
            {
                _character.Accessory = (Equipment)value;
                OnPropertyChanged(nameof(Accessory));
                OnPropertyChanged(nameof(AccessoryId));
            }
        }

        public Equipment Outfit
        {
            get => _character.Outfit;
            set
            {
                _character.Outfit = value;
                OnPropertyChanged(nameof(Outfit));
                OnPropertyChanged(nameof(OutfitId));
            }
        }

        public ushort OutfitId
        {
            get => (ushort)_character.Outfit;
            set
            {
                _character.Outfit = (Equipment)value;
                OnPropertyChanged(nameof(Outfit));
                OnPropertyChanged(nameof(OutfitId));
            }
        }

        protected override void OnSelectedItem(PersonaViewModel item)
        {
            base.OnSelectedItem(item);
            OnPropertyChanged(nameof(EntryVisible));
            OnPropertyChanged(nameof(EntryNotVisible));
        }
    }
}